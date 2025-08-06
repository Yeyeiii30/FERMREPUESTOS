using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace FRMREPUESTOSMS
{
    public partial class FormVenta : Form
    {
        private SqlConnection conexion = new SqlConnection("Server=YEISON-POLANCO\\SQLEXPRESS;Database=RepuestosMSP;Trusted_Connection=True;");
        SqlConnection con = new SqlConnection("Server=YEISON-POLANCO\\SQLEXPRESS;Database=RepuestosMSP;Trusted_Connection=True;");
        SqlCommand comando;
        SqlDataAdapter adaptador;
        DataTable tabla;

        int idVentaSeleccionada = -1;

        public FormVenta()
        {
            InitializeComponent();
            CargarVentas();
            CargarClientes();
        }

        private void CargarVentas()
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                    conexion.Open();

                string consulta = @"
            SELECT V.IdVenta, V.Fecha, C.Nombre AS Cliente, V.Total
            FROM Venta V
            INNER JOIN Cliente C ON V.IdCliente = C.IdCliente";

                comando = new SqlCommand(consulta, conexion);
                adaptador = new SqlDataAdapter(comando);
                tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvVentas.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ventas: " + ex.Message);
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                    conexion.Close();
            }
        }


        private void CargarClientes()
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                    conexion.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT IdCliente, Nombre FROM Cliente", conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbClientes.DataSource = dt;
                cmbClientes.DisplayMember = "Nombre";
                cmbClientes.ValueMember = "IdCliente";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                    conexion.Close();
            }
        }

        private bool ValidarCampos()
        {
            errorProvider1.Clear();
            bool valido = true;

            if (cmbClientes.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbClientes, "Seleccione un cliente");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtTotal.Text))
            {
                errorProvider1.SetError(txtTotal, "Ingrese el total");
                valido = false;
            }
            else
            {
                if (!decimal.TryParse(txtTotal.Text, out _))
                {
                    errorProvider1.SetError(txtTotal, "Total inválido");
                    valido = false;
                }
            }

            return valido;
        }

        private void Limpiar()
        {
            cmbClientes.SelectedIndex = -1;
            txtTotal.Clear();
            errorProvider1.Clear();
            idVentaSeleccionada = -1;
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                conexion.Open();
                comando = new SqlCommand("INSERT INTO Venta (IdCliente, Total) VALUES (@idCliente, @total)", conexion);
                comando.Parameters.AddWithValue("@idCliente", cmbClientes.SelectedValue);
                comando.Parameters.AddWithValue("@total", Convert.ToDecimal(txtTotal.Text));
                comando.ExecuteNonQuery();
                MessageBox.Show("Venta agregada correctamente.");
                CargarVentas();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar venta: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnEliminarItem_Click(object sender, EventArgs e)
        {
            if (idVentaSeleccionada == -1)
            {
                MessageBox.Show("Seleccione una venta para eliminar.");
                return;
            }

            var resultado = MessageBox.Show("¿Seguro que desea eliminar esta venta?", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.No) return;

            try
            {
                conexion.Open();
                comando = new SqlCommand("DELETE FROM Venta WHERE IdVenta=@idVenta", conexion);
                comando.Parameters.AddWithValue("@idVenta", idVentaSeleccionada);
                comando.ExecuteNonQuery();
                MessageBox.Show("Venta eliminada correctamente.");
                CargarVentas();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar venta: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos() || dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Complete todos los campos y agregue al menos un repuesto.");
                return;
            }

            SqlTransaction transaccion = null;

            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();

                SqlCommand cmdVenta = new SqlCommand(
                    "INSERT INTO Venta (IdCliente, Total) VALUES (@idCliente, @total); SELECT SCOPE_IDENTITY();",
                    conexion, transaccion
                );

                cmdVenta.Parameters.AddWithValue("@idCliente", cmbClientes.SelectedValue);
                cmdVenta.Parameters.AddWithValue("@total", Convert.ToDecimal(txtTotal.Text));

                int idVenta = Convert.ToInt32(cmdVenta.ExecuteScalar());

                foreach (DataGridViewRow fila in dgvDetalles.Rows)
                {
                    if (fila.IsNewRow) continue;

                    int idRepuesto = Convert.ToInt32(fila.Cells["IdRepuesto"].Value);
                    int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                    decimal precioUnitario = Convert.ToDecimal(fila.Cells["PrecioUnitario"].Value);

                    SqlCommand cmdDetalle = new SqlCommand(
                        "INSERT INTO DetalleVenta (IdVenta, IdRepuesto, Cantidad, PrecioUnitario) " +
                        "VALUES (@idVenta, @idRepuesto, @cantidad, @precioUnitario)",
                        conexion, transaccion
                    );

                    cmdDetalle.Parameters.AddWithValue("@idVenta", idVenta);
                    cmdDetalle.Parameters.AddWithValue("@idRepuesto", idRepuesto);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", cantidad);
                    cmdDetalle.Parameters.AddWithValue("@precioUnitario", precioUnitario);

                    cmdDetalle.ExecuteNonQuery();
                }

                transaccion.Commit();
                MessageBox.Show("Venta registrada correctamente.");
                CargarVentas(); // Si tienes este método
                Limpiar();      // Si tienes este método
            }
            catch (Exception ex)
            {
                transaccion?.Rollback();
                MessageBox.Show("Error al registrar la venta: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idVentaSeleccionada = Convert.ToInt32(dgvVentas.Rows[e.RowIndex].Cells["IdVenta"].Value);
                cmbClientes.Text = dgvVentas.Rows[e.RowIndex].Cells["Cliente"].Value.ToString();
                txtTotal.Text = dgvVentas.Rows[e.RowIndex].Cells["Total"].Value.ToString();
            }
        }

        private void CargarRepuestos()
        {
            SqlConnection con = new SqlConnection("Server=YEISON-POLANCO\\SQLEXPRESS;Database=RepuestosMSP;Trusted_Connection=True;");

            {
                conexion.Open();

                string query = "SELECT IdRepuesto, Nombre FROM Repuesto";
                SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbRepuestos.DataSource = dt;
                cmbRepuestos.DisplayMember = "Nombre";   
                cmbRepuestos.ValueMember = "IdRepuesto";   
            }
        }


        private void FormVenta_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarRepuestos();
        }
    }
}

