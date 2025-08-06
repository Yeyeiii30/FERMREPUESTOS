using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FRMREPUESTOSMS
{
    public partial class FormProveedor : Form
    {
        SqlConnection conexion = new SqlConnection("Server=YEISON-POLANCO\\SQLEXPRESS;Database=RepuestosMSP;Trusted_Connection=True;");
        SqlCommand comando;
        SqlDataAdapter adaptador;
        DataTable tabla;

        int idProveedorSeleccionado = -1;

        public FormProveedor()
        {
            InitializeComponent();
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                    conexion.Open();

                comando = new SqlCommand("SELECT * FROM Proveedor", conexion);
                adaptador = new SqlDataAdapter(comando);
                tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvProveedores.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message);
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                    conexion.Close();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                conexion.Open();
                comando = new SqlCommand("INSERT INTO Proveedor(Nombre, Telefono, Direccion, Correo) VALUES(@nombre, @telefono, @direccion, @correo)", conexion);
                comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                comando.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                comando.Parameters.AddWithValue("@correo", txtCorreo.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Proveedor agregado correctamente.");
                CargarProveedores();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar proveedor: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();
            errorProvider1.Clear();
            idProveedorSeleccionado = -1;
        }

        private bool ValidarCampos()
        {
            errorProvider1.Clear();
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese el nombre del proveedor.");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                errorProvider1.SetError(txtTelefono, "Ingrese el teléfono.");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                errorProvider1.SetError(txtDireccion, "Ingrese la dirección.");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                errorProvider1.SetError(txtCorreo, "Ingrese el correo.");
                esValido = false;
            }

            return esValido;
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (idProveedorSeleccionado == -1)
            {
                MessageBox.Show("Selecciona un proveedor para editar.");
                return;
            }

            if (!ValidarCampos()) return;

            try
            {
                conexion.Open();
                comando = new SqlCommand("UPDATE Proveedor SET Nombre=@nombre, Telefono=@telefono, Direccion=@direccion, Correo=@correo WHERE Id=@id", conexion);
                comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                comando.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                comando.Parameters.AddWithValue("@correo", txtCorreo.Text);
                comando.Parameters.AddWithValue("@id", idProveedorSeleccionado);
                comando.ExecuteNonQuery();
                MessageBox.Show("Proveedor actualizado correctamente.");
                CargarProveedores();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar proveedor: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (idProveedorSeleccionado == -1)
            {
                MessageBox.Show("Selecciona un proveedor para eliminar.");
                return;
            }

            DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este proveedor?", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;

            try
            {
                conexion.Open();
                comando = new SqlCommand("DELETE FROM Proveedor WHERE Id=@id", conexion);
                comando.Parameters.AddWithValue("@id", idProveedorSeleccionado);
                comando.ExecuteNonQuery();
                MessageBox.Show("Proveedor eliminado correctamente.");
                CargarProveedores();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar proveedor: " + ex.Message);
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

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idProveedorSeleccionado = Convert.ToInt32(dgvProveedores.Rows[e.RowIndex].Cells["IdProveedor"].Value);
                txtNombre.Text = dgvProveedores.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtTelefono.Text = dgvProveedores.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
                txtDireccion.Text = dgvProveedores.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
                txtCorreo.Text = dgvProveedores.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
            }
        }
    }
}
