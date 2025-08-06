using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FRMREPUESTOSMS
{
    [ComVisible(true)] 
    public partial class FormRepuesto : Form
    {
        int idRepuestoSeleccionado = 0;

        public FormRepuesto()
        {
            InitializeComponent();
            this.Load += FormRepuesto_Load;
        }

        private void FormRepuesto_Load(object sender, EventArgs e)
        {
            btnAgregar.Click += btnAgregar_Click;
            btnEditar.Click += btnEditar_Click;
            btnEliminar.Click += btnEliminar_Click;
            dgvRepuestos.CellMouseClick += DgvRepuestos_CellMouseClick;

            try
            {
                CargarCategorias();
                CargarProveedores();
                CargarRepuestos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message);
            }
        }

        private void CargarCategorias()
        {
            SqlConnection con = new SqlConnection("Server=YEISON-POLANCO\\SQLEXPRESS;Database=RepuestosMSP;Trusted_Connection=True;");
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT IdCategoria AS Id, Nombre FROM Categoria", con);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                cmbCategoria.DisplayMember = "Nombre";
                cmbCategoria.ValueMember = "Id";
                cmbCategoria.DataSource = dt;
            }
        }

        private void CargarProveedores()
        {
            SqlConnection con = new SqlConnection("Server=YEISON-POLANCO\\SQLEXPRESS;Database=RepuestosMSP;Trusted_Connection=True;");
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT IdProveedor AS Id, Nombre FROM Proveedor", con);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                cmbProveedor.DisplayMember = "Nombre";
                cmbProveedor.ValueMember = "Id";
                cmbProveedor.DataSource = dt;
            }
        }

        private void CargarRepuestos()
        {
            SqlConnection con = new SqlConnection("Server=YEISON-POLANCO\\SQLEXPRESS;Database=RepuestosMSP;Trusted_Connection=True;");
            {
                con.Open();
                string query = @"
                    SELECT R.IdRepuesto AS Id, R.Nombre, R.Precio, R.Existencia AS Stock,
                           R.IdCategoria, R.IdProveedor,
                           C.Nombre AS Categoria,
                           P.Nombre AS Proveedor
                    FROM Repuesto R
                    INNER JOIN Categoria C ON R.IdCategoria = C.IdCategoria
                    INNER JOIN Proveedor P ON R.IdProveedor = P.IdProveedor";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRepuestos.DataSource = dt;

                dgvRepuestos.Columns["Id"].HeaderText = "Código";
                dgvRepuestos.Columns["Nombre"].HeaderText = "Nombre";
                dgvRepuestos.Columns["Precio"].HeaderText = "Precio";
                dgvRepuestos.Columns["Stock"].HeaderText = "Cantidad";
                dgvRepuestos.Columns["Categoria"].HeaderText = "Categoría";
                dgvRepuestos.Columns["Proveedor"].HeaderText = "Proveedor";
            }
        }

        private bool ValidarCampos()
        {
            bool valido = true;
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese el nombre del repuesto");
                valido = false;
            }

            if (cmbCategoria.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbCategoria, "Seleccione una categoría");
                valido = false;
            }

            if (cmbProveedor.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbProveedor, "Seleccione un proveedor");
                valido = false;
            }

            return valido;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            SqlConnection con = new SqlConnection("Server=YEISON-POLANCO\\SQLEXPRESS;Database=RepuestosMSP;Trusted_Connection=True;");
            {
                con.Open();
                string sql = "INSERT INTO Repuesto (Nombre, Precio, Existencia, IdCategoria, IdProveedor) " +
                             "VALUES (@Nombre, @Precio, @Existencia, @CategoriaId, @ProveedorId)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Precio", decimal.Parse(txtPrecio.Text));
                cmd.Parameters.AddWithValue("@Existencia", int.Parse(txtStock.Text));
                cmd.Parameters.AddWithValue("@CategoriaId", cmbCategoria.SelectedValue);
                cmd.Parameters.AddWithValue("@ProveedorId", cmbProveedor.SelectedValue);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Repuesto agregado");
            CargarRepuestos();
            LimpiarCampos();
        }

        private void DgvRepuestos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvRepuestos.Rows[e.RowIndex];

                idRepuestoSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtPrecio.Text = fila.Cells["Precio"].Value.ToString();
                txtStock.Text = fila.Cells["Stock"].Value.ToString();
                cmbCategoria.SelectedValue = fila.Cells["IdCategoria"].Value;
                cmbProveedor.SelectedValue = fila.Cells["IdProveedor"].Value;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            SqlConnection con = new SqlConnection("Server=YEISON-POLANCO\\SQLEXPRESS;Database=RepuestosMSP;Trusted_Connection=True;");
            {
                con.Open();
                string query = "UPDATE Repuesto SET Nombre = @nombre, Precio = @precio, Existencia = @existencia, IdCategoria = @categoria, IdProveedor = @proveedor WHERE IdRepuesto = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@precio", decimal.Parse(txtPrecio.Text));
                cmd.Parameters.AddWithValue("@existencia", int.Parse(txtStock.Text));
                cmd.Parameters.AddWithValue("@categoria", cmbCategoria.SelectedValue);
                cmd.Parameters.AddWithValue("@proveedor", cmbProveedor.SelectedValue);
                cmd.Parameters.AddWithValue("@id", idRepuestoSeleccionado);
                cmd.ExecuteNonQuery();
            }

            CargarRepuestos();
            MessageBox.Show("Repuesto editado correctamente");
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idRepuestoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un repuesto primero");
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este repuesto?", "Confirmar", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection("Server=YEISON-POLANCO\\SQLEXPRESS;Database=RepuestosMSP;Trusted_Connection=True;");
                {
                    con.Open();
                    string query = "DELETE FROM Repuesto WHERE IdRepuesto = @idRepuesto";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", idRepuestoSeleccionado);
                    cmd.ExecuteNonQuery();
                }

                CargarRepuestos();
                MessageBox.Show("Repuesto eliminado correctamente");
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            cmbCategoria.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;
            errorProvider1.Clear();
            idRepuestoSeleccionado = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
