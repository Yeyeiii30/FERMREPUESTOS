using FRMREPUESTOSMS.Conexion;
using System;
using System.Windows.Forms;

namespace FRMREPUESTOSMS
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        private void repuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRepuesto frm = new FormRepuesto();
            frm.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategoria frm = new FormCategoria();
            frm.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProveedor frm = new FormProveedor();
            frm.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente frm = new FormCliente();
            frm.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVenta frm = new FormVenta();
            frm.ShowDialog();
        }

        private void entradaRepuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEntradaRepuesto frm = new FormEntradaRepuesto();
            frm.ShowDialog();
        }

        private void salidaRepuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSalidaRepuesto frm = new FormSalidaRepuesto();
            frm.ShowDialog();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            this.fileToolStripMenuItem.DropDownItems.Add(this.salirToolStripMenuItem);
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema de Gestión de Repuestos\nVersión 3.0\nEste sistema de gestión de tienda de repuestos automotrices ha sido desarrollado con el objetivo de facilitar y optimizar el control integral de productos, clientes, ventas, proveedores y categorías. La aplicación, construida en Windows Forms utilizando C# y SQL Server, permite a los usuarios manejar el inventario de forma sencilla, registrar ventas con actualización automática de stock, y generar reportes que apoyan la toma de decisiones en el negocio." +
                "\r\n\r\nEl proyecto fue creado para responder a la necesidad real de un negocio local que requería una solución eficiente y práctica para organizar sus procesos diarios, mejorar la atención al cliente y mantener un control preciso de sus productos y ventas.\r\n\r\nEste desarrollo es liderado por Yeison A. Polanco, estudiante de Ingeniería en Software, con el apoyo fundamental de Justin Elias Salas, reconocida por su dedicación y compromiso en el área de desarrollo, y junto a ellos, Lissenny M. Martínez, experta en gestión empresarial y análisis de requerimientos, quien ha brindado la visión estratégica para adaptar el sistema a las necesidades del mercado." +
                "\r\n\r\nEl gerente y dueño del negocio, el Sr. Jonathan Mota, ha sido pieza clave en la definición de funcionalidades y pruebas, asegurando que el sistema cumpla con las expectativas y facilite el crecimiento de su tienda." +
                "\r\n\r\nCon esta herramienta, el usuario encontrará una interfaz amigable y funcional que le permitirá gestionar eficazmente las operaciones diarias, ahorrando tiempo y recursos, y contribuyendo a una administración más organizada y profesional.\r\n\r\n", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void detallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmResumenGeneral resumen = new FrmResumenGeneral();
            resumen.ShowDialog();
        }
    }
}
