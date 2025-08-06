namespace FRMREPUESTOSMS
{
    partial class FrmResumenGeneral
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.dtpDesdeVentas = new System.Windows.Forms.DateTimePicker();
            this.dtpHastaVentas = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrarVentas = new System.Windows.Forms.Button();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblRepuestos = new System.Windows.Forms.Label();
            this.dgvRepuestos = new System.Windows.Forms.DataGridView();
            this.lblClientes = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.lblVentas = new System.Windows.Forms.Label();
            this.lblProveedores = new System.Windows.Forms.Label();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.lblEntradas = new System.Windows.Forms.Label();
            this.dgvEntradas = new System.Windows.Forms.DataGridView();
            this.lblSalidas = new System.Windows.Forms.Label();
            this.dgvSalidas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDesdeVentas
            // 
            this.dtpDesdeVentas.Location = new System.Drawing.Point(100, 20);
            this.dtpDesdeVentas.Name = "dtpDesdeVentas";
            this.dtpDesdeVentas.Size = new System.Drawing.Size(120, 22);
            this.dtpDesdeVentas.TabIndex = 0;
            // 
            // dtpHastaVentas
            // 
            this.dtpHastaVentas.Location = new System.Drawing.Point(230, 20);
            this.dtpHastaVentas.Name = "dtpHastaVentas";
            this.dtpHastaVentas.Size = new System.Drawing.Size(120, 22);
            this.dtpHastaVentas.TabIndex = 1;
            this.dtpHastaVentas.Value = new System.DateTime(2025, 8, 5, 0, 0, 0, 0);
            // 
            // btnFiltrarVentas
            // 
            this.btnFiltrarVentas.Location = new System.Drawing.Point(360, 20);
            this.btnFiltrarVentas.Name = "btnFiltrarVentas";
            this.btnFiltrarVentas.Size = new System.Drawing.Size(100, 23);
            this.btnFiltrarVentas.TabIndex = 2;
            this.btnFiltrarVentas.Text = "Filtrar Ventas";
            this.btnFiltrarVentas.UseVisualStyleBackColor = true;
            this.btnFiltrarVentas.Click += new System.EventHandler(this.btnFiltrarVentas_Click);
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.AutoSize = true;
            this.lblTotalVentas.Location = new System.Drawing.Point(480, 25);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.Size = new System.Drawing.Size(75, 16);
            this.lblTotalVentas.TabIndex = 3;
            this.lblTotalVentas.Text = "Total: $0.00";
            // 
            // dgvVentas
            // 
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.ColumnHeadersHeight = 29;
            this.dgvVentas.Location = new System.Drawing.Point(27, 574);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.Size = new System.Drawing.Size(1478, 128);
            this.dgvVentas.TabIndex = 5;
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.lblRepuestos);
            this.panelMain.Controls.Add(this.dgvRepuestos);
            this.panelMain.Controls.Add(this.lblClientes);
            this.panelMain.Controls.Add(this.dgvClientes);
            this.panelMain.Controls.Add(this.lblVentas);
            this.panelMain.Controls.Add(this.dgvVentas);
            this.panelMain.Controls.Add(this.lblProveedores);
            this.panelMain.Controls.Add(this.dgvProveedores);
            this.panelMain.Controls.Add(this.lblCategorias);
            this.panelMain.Controls.Add(this.dgvCategorias);
            this.panelMain.Controls.Add(this.lblEntradas);
            this.panelMain.Controls.Add(this.dgvEntradas);
            this.panelMain.Controls.Add(this.lblSalidas);
            this.panelMain.Controls.Add(this.dgvSalidas);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1558, 1010);
            this.panelMain.TabIndex = 0;
            // 
            // lblRepuestos
            // 
            this.lblRepuestos.AutoSize = true;
            this.lblRepuestos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRepuestos.Location = new System.Drawing.Point(23, 105);
            this.lblRepuestos.Name = "lblRepuestos";
            this.lblRepuestos.Size = new System.Drawing.Size(91, 23);
            this.lblRepuestos.TabIndex = 0;
            this.lblRepuestos.Text = "Repuestos";
            // 
            // dgvRepuestos
            // 
            this.dgvRepuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRepuestos.ColumnHeadersHeight = 29;
            this.dgvRepuestos.Location = new System.Drawing.Point(27, 148);
            this.dgvRepuestos.Name = "dgvRepuestos";
            this.dgvRepuestos.RowHeadersWidth = 51;
            this.dgvRepuestos.Size = new System.Drawing.Size(1478, 128);
            this.dgvRepuestos.TabIndex = 1;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblClientes.Location = new System.Drawing.Point(23, 306);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(73, 23);
            this.lblClientes.TabIndex = 2;
            this.lblClientes.Text = "Clientes";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.ColumnHeadersHeight = 29;
            this.dgvClientes.Location = new System.Drawing.Point(27, 362);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.Size = new System.Drawing.Size(1478, 128);
            this.dgvClientes.TabIndex = 3;
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblVentas.Location = new System.Drawing.Point(23, 519);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(62, 23);
            this.lblVentas.TabIndex = 4;
            this.lblVentas.Text = "Ventas";
            // 
            // lblProveedores
            // 
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblProveedores.Location = new System.Drawing.Point(23, 733);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(108, 23);
            this.lblProveedores.TabIndex = 6;
            this.lblProveedores.Text = "Proveedores";
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProveedores.ColumnHeadersHeight = 29;
            this.dgvProveedores.Location = new System.Drawing.Point(27, 788);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.RowHeadersWidth = 51;
            this.dgvProveedores.Size = new System.Drawing.Size(1478, 128);
            this.dgvProveedores.TabIndex = 7;
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategorias.Location = new System.Drawing.Point(23, 947);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(95, 23);
            this.lblCategorias.TabIndex = 8;
            this.lblCategorias.Text = "Categorías";
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategorias.ColumnHeadersHeight = 29;
            this.dgvCategorias.Location = new System.Drawing.Point(27, 1002);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.Size = new System.Drawing.Size(1478, 128);
            this.dgvCategorias.TabIndex = 9;
            // 
            // lblEntradas
            // 
            this.lblEntradas.AutoSize = true;
            this.lblEntradas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEntradas.Location = new System.Drawing.Point(23, 1161);
            this.lblEntradas.Name = "lblEntradas";
            this.lblEntradas.Size = new System.Drawing.Size(165, 23);
            this.lblEntradas.TabIndex = 10;
            this.lblEntradas.Text = "Entradas Repuestos";
            // 
            // dgvEntradas
            // 
            this.dgvEntradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEntradas.ColumnHeadersHeight = 29;
            this.dgvEntradas.Location = new System.Drawing.Point(27, 1214);
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.RowHeadersWidth = 51;
            this.dgvEntradas.Size = new System.Drawing.Size(1478, 128);
            this.dgvEntradas.TabIndex = 11;
            // 
            // lblSalidas
            // 
            this.lblSalidas.AutoSize = true;
            this.lblSalidas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSalidas.Location = new System.Drawing.Point(23, 1373);
            this.lblSalidas.Name = "lblSalidas";
            this.lblSalidas.Size = new System.Drawing.Size(152, 23);
            this.lblSalidas.TabIndex = 12;
            this.lblSalidas.Text = "Salidas Repuestos";
            // 
            // dgvSalidas
            // 
            this.dgvSalidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalidas.ColumnHeadersHeight = 29;
            this.dgvSalidas.Location = new System.Drawing.Point(27, 1428);
            this.dgvSalidas.Name = "dgvSalidas";
            this.dgvSalidas.RowHeadersWidth = 51;
            this.dgvSalidas.Size = new System.Drawing.Size(1478, 128);
            this.dgvSalidas.TabIndex = 13;
            // 
            // FrmResumenGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 808);
            this.Controls.Add(this.dtpDesdeVentas);
            this.Controls.Add(this.dtpHastaVentas);
            this.Controls.Add(this.btnFiltrarVentas);
            this.Controls.Add(this.lblTotalVentas);
            this.Controls.Add(this.panelMain);
            this.Name = "FrmResumenGeneral";
            this.Text = "Resumen General del Sistema";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblRepuestos;
        private System.Windows.Forms.DataGridView dgvRepuestos;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Label lblEntradas;
        private System.Windows.Forms.DataGridView dgvEntradas;
        private System.Windows.Forms.Label lblSalidas;
        private System.Windows.Forms.DataGridView dgvSalidas;
        private System.Windows.Forms.DateTimePicker dtpDesdeVentas;
        private System.Windows.Forms.DateTimePicker dtpHastaVentas;
        private System.Windows.Forms.Button btnFiltrarVentas;
        private System.Windows.Forms.Label lblTotalVentas;
    }
}
