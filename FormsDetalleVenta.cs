using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FRMREPUESTOSMS
{
    public partial class FormDetalleVenta : Form
    {
        SqlConnection conexion = new SqlConnection(@"server=.; database=RepuestosMSP; integrated security=true");
        SqlCommand comando;
        SqlDataAdapter adaptador;
        DataTable tabla;

        int idDetalleSeleccionado = -1;

        public FormDetalleVenta()
        {
            InitializeComponent();
            CargarDetalles();
            CargarVentas();
            CargarRepuestos();
        }

        private void CargarDetalles()
        {
            try
            {
                conexion.Open();
                string consulta = @"
                    SELECT IdDetalle, IdVenta, IdRepuesto, Cantidad, PrecioUnitario
                    FROM DetalleVenta";
                comando = new SqlCommand(consulta, conexion);
                adaptador = new SqlDataAdapter(comando);
                tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvDetalles.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalles: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void CargarVentas()
        {
            try
            {
                conexion.Open();
                comando = new SqlCommand("SELECT IdVenta FROM Venta", conexion);
                adaptador = new SqlDataAdapter(comando);
                DataTable ventas = new DataTable();
                adaptador.Fill(ventas);

                cmbVenta.DataSource = ventas;
                cmbVenta.DisplayMember = "IdVenta";
                cmbVenta.ValueMember = "IdVenta";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ventas: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void CargarRepuestos()
        {
            try
            {
                conexion.Open();
                comando = new SqlCommand("SELECT IdRepuesto, Nombre FROM Repuesto", conexion);
                adaptador = new SqlDataAdapter(comando);
                DataTable repuestos = new DataTable();
                adaptador.Fill(repuestos);

                cmbRepuesto.DataSource = repuestos;
                cmbRepuesto.DisplayMember = "Nombre";
                cmbRepuesto.ValueMember = "IdRepuesto";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar repuestos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private bool ValidarCampos()
        {
            errorProvider1.Clear();
            bool valido = true;

            if (cmbVenta.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbVenta, "Seleccione una venta");
                valido = false;
            }

            if (cmbRepuesto.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbRepuesto, "Seleccione un repuesto");
                valido = false;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                errorProvider1.SetError(txtCantidad, "Cantidad inválida");
                valido = false;
            }

            if (!decimal.TryParse(txtPrecioUnitario.Text, out decimal precio) || precio <= 0)
            {
                errorProvider1.SetError(txtPrecioUnitario, "Precio inválido");
                valido = false;
            }

            return valido;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                conexion.Open();
                comando = new SqlCommand(@"INSERT INTO DetalleVenta 
                    (IdVenta, IdRepuesto, Cantidad, PrecioUnitario) 
                    VALUES (@IdVenta, @IdRepuesto, @Cantidad, @PrecioUnitario)", conexion);

                comando.Parameters.AddWithValue("@IdVenta", cmbVenta.SelectedValue);
                comando.Parameters.AddWithValue("@IdRepuesto", cmbRepuesto.SelectedValue);
                comando.Parameters.AddWithValue("@Cantidad", int.Parse(txtCantidad.Text));
                comando.Parameters.AddWithValue("@PrecioUnitario", decimal.Parse(txtPrecioUnitario.Text));

                comando.ExecuteNonQuery();

                MessageBox.Show("Detalle agregado correctamente.");
                CargarDetalles();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar detalle: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (idDetalleSeleccionado == -1)
            {
                MessageBox.Show("Seleccione un detalle para editar.");
                return;
            }

            if (!ValidarCampos()) return;

            try
            {
                conexion.Open();
                comando = new SqlCommand(@"UPDATE DetalleVenta SET 
                    IdVenta = @IdVenta, IdRepuesto = @IdRepuesto, Cantidad = @Cantidad, PrecioUnitario = @PrecioUnitario
                    WHERE IdDetalle = @IdDetalle", conexion);

                comando.Parameters.AddWithValue("@IdVenta", cmbVenta.SelectedValue);
                comando.Parameters.AddWithValue("@IdRepuesto", cmbRepuesto.SelectedValue);
                comando.Parameters.AddWithValue("@Cantidad", int.Parse(txtCantidad.Text));
                comando.Parameters.AddWithValue("@PrecioUnitario", decimal.Parse(txtPrecioUnitario.Text));
                comando.Parameters.AddWithValue("@IdDetalle", idDetalleSeleccionado);

                comando.ExecuteNonQuery();

                MessageBox.Show("Detalle actualizado correctamente.");
                CargarDetalles();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar detalle: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (idDetalleSeleccionado == -1)
            {
                MessageBox.Show("Seleccione un detalle para eliminar.");
                return;
            }

            var resultado = MessageBox.Show("¿Seguro que desea eliminar este detalle?", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.No) return;

            try
            {
                conexion.Open();
                comando = new SqlCommand("DELETE FROM DetalleVenta WHERE IdDetalle = @IdDetalle", conexion);
                comando.Parameters.AddWithValue("@IdDetalle", idDetalleSeleccionado);
                comando.ExecuteNonQuery();

                MessageBox.Show("Detalle eliminado correctamente.");
                CargarDetalles();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar detalle: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            cmbVenta.SelectedIndex = -1;
            cmbRepuesto.SelectedIndex = -1;
            txtCantidad.Clear();
            txtPrecioUnitario.Clear();
            errorProvider1.Clear();
            idDetalleSeleccionado = -1;
        }

        private void dgvDetalles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvDetalles.Rows[e.RowIndex];
                idDetalleSeleccionado = Convert.ToInt32(fila.Cells["IdDetalle"].Value);
                cmbVenta.SelectedValue = fila.Cells["IdVenta"].Value;
                cmbRepuesto.SelectedValue = fila.Cells["IdRepuesto"].Value;
                txtCantidad.Text = fila.Cells["Cantidad"].Value.ToString();
                txtPrecioUnitario.Text = fila.Cells["PrecioUnitario"].Value.ToString();
            }
        }

        private void BtnAceptar_Click_1(object sender, EventArgs e)
        {
            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Agregue al menos un detalle.");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
