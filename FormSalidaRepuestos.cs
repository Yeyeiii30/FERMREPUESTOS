using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FRMREPUESTOSMS
{
    public partial class FormSalidaRepuesto : Form
    {
        private SqlConnection conexion = new SqlConnection("Server=YEISON-POLANCO\\SQLEXPRESS;Database=RepuestosMSP;Trusted_Connection=True;");

        SqlConnection con = new SqlConnection();
        SqlCommand comando;
        SqlDataAdapter adaptador;
        DataTable tabla;

        int idSalidaSeleccionada = -1;

        public FormSalidaRepuesto()
        {
            InitializeComponent();
            CargarSalidas();
            CargarRepuestos();
        }

        private void CargarSalidas()
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                    conexion.Open();

                string consulta = @"SELECT IdCategoria, Nombre FROM Categoria";

                comando = new SqlCommand(consulta, conexion);
                adaptador = new SqlDataAdapter(comando);
                tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvSalidas.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar salidas: " + ex.Message);
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                    conexion.Close();
            }
        }


        private void CargarRepuestos()
        {
            try
            {
                conexion.Open();
                comando = new SqlCommand("SELECT IdCategoria, Nombre FROM Categoria", conexion);
                adaptador = new SqlDataAdapter(comando);
                DataTable repuestos = new DataTable();
                adaptador.Fill(repuestos);

                cmbRepuesto.DataSource = repuestos;
                cmbRepuesto.DisplayMember = "Nombre";
                cmbRepuesto.ValueMember = "IdCategoria";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Categoria: " + ex.Message);
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

            if (cmbRepuesto.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbRepuesto, "Seleccione un repuesto");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtPieza.Text))
            {
                errorProvider1.SetError(txtPieza, "Ingrese el nombre de la pieza");
                valido = false;
            }

            if (!dtpFechaSalida.Checked)
            {
                errorProvider1.SetError(dtpFechaSalida, "Seleccione la fecha de salida");
                valido = false;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                errorProvider1.SetError(txtCantidad, "Cantidad inválida");
                valido = false;
            }

            if (!int.TryParse(txtExistencia.Text, out int existencia) || existencia < 0)
            {
                errorProvider1.SetError(txtExistencia, "Existencia inválida");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtDestino.Text))
            {
                errorProvider1.SetError(txtDestino, "Ingrese el destino");
                valido = false;
            }

            return valido;
        }

        private void Limpiar()
        {
            cmbRepuesto.SelectedIndex = -1;
            txtPieza.Clear();
            dtpFechaSalida.Value = DateTime.Now;
            txtCantidad.Clear();
            txtExistencia.Clear();
            txtDestino.Clear();
            txtObservacion.Clear();
            errorProvider1.Clear();
            idSalidaSeleccionada = -1;
        }

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                conexion.Open();
                comando = new SqlCommand(@"INSERT INTO SalidaRepuesto 
                    (IdRepuesto, Pieza, FechaSalida, Cantidad, Existencia, Destino, Observacion) 
                    VALUES (@IdRepuesto, @Pieza, @FechaSalida, @Cantidad, @Existencia, @Destino, @Observacion)", conexion);

                comando.Parameters.AddWithValue("@IdRepuesto", cmbRepuesto.SelectedValue);
                comando.Parameters.AddWithValue("@Pieza", txtPieza.Text.Trim());
                comando.Parameters.AddWithValue("@FechaSalida", dtpFechaSalida.Value);
                comando.Parameters.AddWithValue("@Cantidad", int.Parse(txtCantidad.Text));
                comando.Parameters.AddWithValue("@Existencia", int.Parse(txtExistencia.Text));
                comando.Parameters.AddWithValue("@Destino", txtDestino.Text.Trim());
                comando.Parameters.AddWithValue("@Observacion", txtObservacion.Text.Trim());

                comando.ExecuteNonQuery();

                MessageBox.Show("Salida agregada correctamente.");
                CargarSalidas();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar salida: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            if (idSalidaSeleccionada == -1)
            {
                MessageBox.Show("Seleccione una salida para editar.");
                return;
            }

            if (!ValidarCampos()) return;

            try
            {
                conexion.Open();
                comando = new SqlCommand(@"UPDATE SalidaRepuesto SET 
                    IdRepuesto = @IdRepuesto, Pieza = @Pieza, FechaSalida = @FechaSalida, 
                    Cantidad = @Cantidad, Existencia = @Existencia, Destino = @Destino, Observacion = @Observacion
                    WHERE IdSalida = @IdSalida", conexion);

                comando.Parameters.AddWithValue("@IdRepuesto", cmbRepuesto.SelectedValue);
                comando.Parameters.AddWithValue("@Pieza", txtPieza.Text.Trim());
                comando.Parameters.AddWithValue("@FechaSalida", dtpFechaSalida.Value);
                comando.Parameters.AddWithValue("@Cantidad", int.Parse(txtCantidad.Text));
                comando.Parameters.AddWithValue("@Existencia", int.Parse(txtExistencia.Text));
                comando.Parameters.AddWithValue("@Destino", txtDestino.Text.Trim());
                comando.Parameters.AddWithValue("@Observacion", txtObservacion.Text.Trim());
                comando.Parameters.AddWithValue("@IdSalida", idSalidaSeleccionada);

                comando.ExecuteNonQuery();

                MessageBox.Show("Salida actualizada correctamente.");
                CargarSalidas();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar salida: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            if (idSalidaSeleccionada == -1)
            {
                MessageBox.Show("Seleccione una salida para eliminar.");
                return;
            }

            var resultado = MessageBox.Show("¿Seguro que desea eliminar esta salida?", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.No) return;

            try
            {
                conexion.Open();
                comando = new SqlCommand("DELETE FROM SalidaRepuesto WHERE IdSalida = @IdSalida", conexion);
                comando.Parameters.AddWithValue("@IdSalida", idSalidaSeleccionada);
                comando.ExecuteNonQuery();

                MessageBox.Show("Salida eliminada correctamente.");
                CargarSalidas();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar salida: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvSalidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvSalidas.Rows[e.RowIndex];
                idSalidaSeleccionada = Convert.ToInt32(fila.Cells["IdSalida"].Value);
                cmbRepuesto.SelectedValue = fila.Cells["IdRepuesto"].Value;
                txtPieza.Text = fila.Cells["Pieza"].Value.ToString();
                dtpFechaSalida.Value = Convert.ToDateTime(fila.Cells["FechaSalida"].Value);
                txtCantidad.Text = fila.Cells["Cantidad"].Value.ToString();
                txtExistencia.Text = fila.Cells["Existencia"].Value.ToString();
                txtDestino.Text = fila.Cells["Destino"].Value.ToString();
                txtObservacion.Text = fila.Cells["Observacion"].Value.ToString();
            }
        }
    }
}
