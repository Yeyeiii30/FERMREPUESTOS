using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FRMREPUESTOSMS
{
    public partial class FormCliente : Form
    {
        SqlConnection conexion = new SqlConnection("Server=YEISON-POLANCO\\SQLEXPRESS;Database=RepuestosMSP;Trusted_Connection=True;");
        SqlCommand comando;
        SqlDataAdapter adaptador;
        DataTable tabla;

        int idClienteSeleccionado = -1;

        public FormCliente()
        {
            InitializeComponent();
            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                    conexion.Open();

                comando = new SqlCommand("SELECT * FROM Cliente", conexion);
                adaptador = new SqlDataAdapter(comando);
                tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvClientes.DataSource = tabla;
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

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese el nombre del cliente.");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                errorProvider1.SetError(txtTelefono, "Ingrese el teléfono.");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                errorProvider1.SetError(txtDireccion, "Ingrese la dirección.");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                errorProvider1.SetError(txtCorreo, "Ingrese el correo.");
                valido = false;
            }

            return valido;
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();
            errorProvider1.Clear();
            idClienteSeleccionado = -1;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                conexion.Open();
                comando = new SqlCommand("INSERT INTO Cliente (Nombre, Telefono, Direccion, Email) VALUES (@nombre, @telefono, @direccion, @correo)", conexion);
                comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                comando.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                comando.Parameters.AddWithValue("@correo", txtCorreo.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente agregado correctamente.");
                CargarClientes();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar cliente: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (idClienteSeleccionado == -1)
            {
                MessageBox.Show("Seleccione un cliente para editar.");
                return;
            }

            if (!ValidarCampos()) return;

            try
            {
                conexion.Open();
                comando = new SqlCommand("UPDATE Cliente SET Nombre=@nombre, Telefono=@telefono, Direccion=@direccion, Email=@correo WHERE IdCliente=@id", conexion);
                comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                comando.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                comando.Parameters.AddWithValue("@correo", txtCorreo.Text);
                comando.Parameters.AddWithValue("@id", idClienteSeleccionado);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente actualizado correctamente.");
                CargarClientes();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar cliente: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (idClienteSeleccionado == -1)
            {
                MessageBox.Show("Seleccione un cliente para eliminar.");
                return;
            }

            var resultado = MessageBox.Show("¿Seguro que desea eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.No) return;

            try
            {
                conexion.Open();
                comando = new SqlCommand("DELETE FROM Cliente WHERE IdCliente=@id", conexion);
                comando.Parameters.AddWithValue("@id", idClienteSeleccionado);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente eliminado correctamente.");
                CargarClientes();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar cliente: " + ex.Message);
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

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idClienteSeleccionado = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells["IdCliente"].Value);
                txtNombre.Text = dgvClientes.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtTelefono.Text = dgvClientes.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
                txtDireccion.Text = dgvClientes.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
                txtCorreo.Text = dgvClientes.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            }
        }
    }
}
