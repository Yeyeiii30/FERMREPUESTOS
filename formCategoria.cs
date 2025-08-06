using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FRMREPUESTOSMS
{
    public partial class FormCategoria : Form
    {
        SqlConnection con = new SqlConnection("Server=YEISON-POLANCO\\SQLEXPRESS;Database=RepuestosMSP;Trusted_Connection=True;");
        private int idCategoriaSeleccionado;

        public FormCategoria()
        {
            InitializeComponent();
            CargarCategorias();
            dgvCategorias.AutoGenerateColumns = true;
            dgvCategorias.CellClick += dgvCategorias_CellContentClick;
        }

        private void CargarCategorias()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT IdCategoria, Nombre FROM Categoria", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCategorias.DataSource = dt;

                if (dgvCategorias.Columns.Contains("IdCategoria"))
                    dgvCategorias.Columns["IdCategoria"].Visible = true;

                dgvCategorias.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
        }





        private void LimpiarCampos()
        {
            txtNombreCategoria.Clear();
            errorProvider1.Clear();
            txtNombre.Focus();
            dgvCategorias.ClearSelection();
        }

        private bool Validar()
        {
            bool ok = true;
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtNombreCategoria.Text))
            {
                errorProvider1.SetError(txtNombreCategoria, "Ingrese un nombre");
                ok = false;
            }

            return ok;
        }

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            if (Validar())
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Categoria (Nombre) VALUES (@Nombre)", con);
                    cmd.Parameters.AddWithValue("@Nombre", txtNombreCategoria.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Categoría agregada correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }

                CargarCategorias();
                LimpiarCampos();
            }
        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvCategorias.SelectedRows[0].Cells["IdCategoria"].Value);
                string nuevoNombre = txtNombre.Text.Trim();

                if (!string.IsNullOrEmpty(nuevoNombre))
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Categoria SET Nombre = @Nombre WHERE IdCategoria = @Id", con);
                        cmd.Parameters.AddWithValue("@Nombre", nuevoNombre);
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Categoría actualizada correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar: " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }

                    CargarCategorias();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Ingrese un nombre para la categoría.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar.");
            }
        }



        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvCategorias.SelectedRows[0].Cells["IdCategoria"].Value);

                DialogResult r = MessageBox.Show("¿Seguro que desea eliminar?", "Confirmar", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Categoria WHERE IdCategoria = @Id", con);
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Eliminado correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }

                    CargarCategorias();
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
            }
        }




        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
                LimpiarCampos();
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvCategorias.Rows[e.RowIndex];
                txtNombreCategoria.Text = fila.Cells["Nombre"].Value.ToString();
            }
        }
    }
}
