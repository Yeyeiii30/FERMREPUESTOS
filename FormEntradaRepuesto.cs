using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FRMREPUESTOSMS
{
    public partial class FormEntradaRepuesto : Form
    {
        SqlConnection conexion = new SqlConnection("Server=YEISON-POLANCO\\SQLEXPRESS;Database=RepuestosMSP;Trusted_Connection=True;");
        SqlCommand comando;
        SqlDataAdapter adaptador;
        DataTable tabla;

        public FormEntradaRepuesto()
        {
            InitializeComponent();
            CargarComboRepuestos();
            MostrarEntradas();
        }

        private void CargarComboRepuestos()
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                    conexion.Open();

                adaptador = new SqlDataAdapter("SELECT IdCategoria, Nombre FROM Categoria", conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                cmbRepuesto.DataSource = dt;
                cmbRepuesto.DisplayMember = "Nombre";
                cmbRepuesto.ValueMember = "IdCategoria";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Categoria: " + ex.Message);
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                    conexion.Close();
            }
        }

        private void MostrarEntradas()
        {
            try
            {
                tabla = new DataTable();
                conexion.Open();
                adaptador = new SqlDataAdapter("SELECT * FROM EntradaRepuesto", conexion);
                adaptador.Fill(tabla);
                dgvEntradas.DataSource = tabla;
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar entradas: " + ex.Message);
            }
        }

        private bool Validar()
        {
            errorProvider1.Clear();
            bool valido = true;

            if (cmbRepuesto.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbRepuesto, "Seleccione un repuesto");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtPieza.Text))
            {
                errorProvider1.SetError(txtPieza, "Ingrese la pieza");
                valido = false;
            }

            if (!int.TryParse(txtCantidad.Text, out int cant) || cant <= 0)
            {
                errorProvider1.SetError(txtCantidad, "Ingrese una cantidad válida");
                valido = false;
            }

            if (!int.TryParse(txtExistencia.Text, out int exist) || exist < 0)
            {
                errorProvider1.SetError(txtExistencia, "Ingrese existencia válida");
                valido = false;
            }

            return valido;
        }

        private void LimpiarCampos()
        {
            cmbRepuesto.SelectedIndex = -1;
            txtPieza.Clear();
            dtpFechaLlegada.Value = DateTime.Today;
            txtCantidad.Clear();
            txtExistencia.Clear();
            txtObservacion.Clear();
            errorProvider1.Clear();
        }

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            if (!Validar()) return;

            try
            {
                conexion.Open();
                comando = new SqlCommand("INSERT INTO EntradaRepuesto (IdRepuesto, Pieza, FechaLlegada, Cantidad, Existencia, Observacion) " +
                                         "VALUES (@IdRepuesto, @Pieza, @FechaLlegada, @Cantidad, @Existencia, @Observacion)", conexion);

                comando.Parameters.AddWithValue("@IdRepuesto", cmbRepuesto.SelectedValue);
                comando.Parameters.AddWithValue("@Pieza", txtPieza.Text.Trim());
                comando.Parameters.AddWithValue("@FechaLlegada", dtpFechaLlegada.Value);
                comando.Parameters.AddWithValue("@Cantidad", int.Parse(txtCantidad.Text));
                comando.Parameters.AddWithValue("@Existencia", int.Parse(txtExistencia.Text));
                comando.Parameters.AddWithValue("@Observacion", txtObservacion.Text.Trim());

                comando.ExecuteNonQuery();
                conexion.Close();

                MessageBox.Show("Entrada agregada correctamente.");
                MostrarEntradas();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar entrada: " + ex.Message);
            }
        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            if (dgvEntradas.CurrentRow == null || !Validar()) return;

            int idEntrada = Convert.ToInt32(dgvEntradas.CurrentRow.Cells["IdEntrada"].Value);

            try
            {
                conexion.Open();
                comando = new SqlCommand("UPDATE EntradaRepuesto SET IdRepuesto=@IdRepuesto, Pieza=@Pieza, FechaLlegada=@FechaLlegada, " +
                                         "Cantidad=@Cantidad, Existencia=@Existencia, Observacion=@Observacion WHERE IdEntrada=@IdEntrada", conexion);

                comando.Parameters.AddWithValue("@IdRepuesto", cmbRepuesto.SelectedValue);
                comando.Parameters.AddWithValue("@Pieza", txtPieza.Text.Trim());
                comando.Parameters.AddWithValue("@FechaLlegada", dtpFechaLlegada.Value);
                comando.Parameters.AddWithValue("@Cantidad", int.Parse(txtCantidad.Text));
                comando.Parameters.AddWithValue("@Existencia", int.Parse(txtExistencia.Text));
                comando.Parameters.AddWithValue("@Observacion", txtObservacion.Text.Trim());
                comando.Parameters.AddWithValue("@IdEntrada", idEntrada);

                comando.ExecuteNonQuery();
                conexion.Close();

                MessageBox.Show("Entrada actualizada correctamente.");
                MostrarEntradas();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar entrada: " + ex.Message);
            }
        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvEntradas.CurrentRow == null) return;

            int idEntrada = Convert.ToInt32(dgvEntradas.CurrentRow.Cells["IdEntrada"].Value);

            if (MessageBox.Show("¿Está seguro que desea eliminar esta entrada?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    conexion.Open();
                    comando = new SqlCommand("DELETE FROM EntradaRepuesto WHERE IdEntrada=@IdEntrada", conexion);
                    comando.Parameters.AddWithValue("@IdEntrada", idEntrada);
                    comando.ExecuteNonQuery();
                    conexion.Close();

                    MessageBox.Show("Entrada eliminada correctamente.");
                    MostrarEntradas();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar entrada: " + ex.Message);
                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvEntradas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvEntradas.CurrentRow != null)
            {
                cmbRepuesto.SelectedValue = dgvEntradas.CurrentRow.Cells["IdRepuesto"].Value;
                txtPieza.Text = dgvEntradas.CurrentRow.Cells["Pieza"].Value.ToString();
                dtpFechaLlegada.Value = Convert.ToDateTime(dgvEntradas.CurrentRow.Cells["FechaLlegada"].Value);
                txtCantidad.Text = dgvEntradas.CurrentRow.Cells["Cantidad"].Value.ToString();
                txtExistencia.Text = dgvEntradas.CurrentRow.Cells["Existencia"].Value.ToString();
                txtObservacion.Text = dgvEntradas.CurrentRow.Cells["Observacion"].Value.ToString();
            }
        }
    }
}

