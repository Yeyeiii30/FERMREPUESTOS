using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FRMREPUESTOSMS
{
    public partial class FrmResumenGeneral : Form
    {
        SqlConnection conexion = new SqlConnection("Server=YEISON-POLANCO\\SQLEXPRESS;Database=RepuestosMSP;Trusted_Connection=True;");

        public FrmResumenGeneral()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            CargarTabla("SELECT * FROM Repuesto", dgvRepuestos);
            CargarTabla("SELECT * FROM Cliente", dgvClientes);
            CargarTabla("SELECT * FROM Venta", dgvVentas);
            CargarTabla("SELECT * FROM Proveedor", dgvProveedores);
            CargarTabla("SELECT * FROM Categoria", dgvCategorias);

            CargarTabla("SELECT IdEntrada, IdRepuesto, Pieza, FechaLlegada, Cantidad, Existencia, Observacion FROM EntradaRepuesto", dgvEntradas);

            CargarTabla("SELECT IdSalida, IdRepuesto, Pieza, FechaSalida, Cantidad, Existencia, Destino, Observacion FROM SalidaRepuesto", dgvSalidas);

        }


        private void CargarTabla(string consulta, DataGridView grid)
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                    conexion.Open();

                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                grid.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnFiltrarVentas_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpDesdeVentas.Value.Date;
            DateTime hasta = dtpHastaVentas.Value.Date.AddDays(1).AddTicks(-1); // Incluye todo el día 'hasta'

            string consulta = "SELECT IdVenta, Fecha, IdCliente, Total FROM Venta WHERE Fecha BETWEEN @desde AND @hasta";

            try
            {
                if (conexion.State != System.Data.ConnectionState.Open)
                    conexion.Open();

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@desde", desde);
                    comando.Parameters.AddWithValue("@hasta", hasta);

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        dgvVentas.DataSource = tabla;

                        // Calcular total sumando la columna Total
                        decimal total = 0;
                        foreach (DataRow row in tabla.Rows)
                        {
                            if (row["Total"] != DBNull.Value)
                                total += Convert.ToDecimal(row["Total"]);
                        }

                        lblTotalVentas.Text = $"Total: {total:C2}"; // Formato moneda con 2 decimales
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar ventas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }
        }

    }
}
