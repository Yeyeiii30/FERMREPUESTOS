namespace FRMREPUESTOSMS
{
    partial class FormVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GstVentas = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.btnAbrirDetalle = new System.Windows.Forms.Button();
            this.grpDatosdeVentas = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cmbRepuestos = new System.Windows.Forms.ComboBox();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblRepuesto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregarItem = new System.Windows.Forms.Button();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.btnEliminarItem = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.grpDatosdeVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // GstVentas
            // 
            this.GstVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GstVentas.Location = new System.Drawing.Point(293, 9);
            this.GstVentas.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.GstVentas.Name = "GstVentas";
            this.GstVentas.Size = new System.Drawing.Size(227, 34);
            this.GstVentas.TabIndex = 59;
            this.GstVentas.Text = "Gestión de Ventas";
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.ColumnHeadersHeight = 29;
            this.dgvVentas.Location = new System.Drawing.Point(83, 312);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(640, 216);
            this.dgvVentas.TabIndex = 58;
            this.dgvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellContentClick);
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDetalles.ColumnHeadersHeight = 29;
            this.dgvDetalles.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDetalles.Location = new System.Drawing.Point(83, 534);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.Size = new System.Drawing.Size(28, 10);
            this.dgvDetalles.TabIndex = 0;
            // 
            // btnAbrirDetalle
            // 
            this.btnAbrirDetalle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAbrirDetalle.Location = new System.Drawing.Point(117, 534);
            this.btnAbrirDetalle.Name = "btnAbrirDetalle";
            this.btnAbrirDetalle.Size = new System.Drawing.Size(34, 10);
            this.btnAbrirDetalle.TabIndex = 1;
            this.btnAbrirDetalle.Text = "Abrir";
            this.btnAbrirDetalle.UseVisualStyleBackColor = true;
            // 
            // grpDatosdeVentas
            // 
            this.grpDatosdeVentas.AutoSize = true;
            this.grpDatosdeVentas.Controls.Add(this.dateTimePicker1);
            this.grpDatosdeVentas.Controls.Add(this.txtTotal);
            this.grpDatosdeVentas.Controls.Add(this.cmbRepuestos);
            this.grpDatosdeVentas.Controls.Add(this.cmbClientes);
            this.grpDatosdeVentas.Controls.Add(this.lblTotal);
            this.grpDatosdeVentas.Controls.Add(this.lblCliente);
            this.grpDatosdeVentas.Controls.Add(this.lblRepuesto);
            this.grpDatosdeVentas.Controls.Add(this.lblCantidad);
            this.grpDatosdeVentas.Controls.Add(this.lblFecha);
            this.grpDatosdeVentas.Controls.Add(this.txtCantidad);
            this.grpDatosdeVentas.Controls.Add(this.btnAgregarItem);
            this.grpDatosdeVentas.Controls.Add(this.btnRegistrarVenta);
            this.grpDatosdeVentas.Controls.Add(this.btnEliminarItem);
            this.grpDatosdeVentas.Controls.Add(this.btnLimpiar);
            this.grpDatosdeVentas.Location = new System.Drawing.Point(83, 48);
            this.grpDatosdeVentas.Name = "grpDatosdeVentas";
            this.grpDatosdeVentas.Size = new System.Drawing.Size(640, 279);
            this.grpDatosdeVentas.TabIndex = 66;
            this.grpDatosdeVentas.TabStop = false;
            this.grpDatosdeVentas.Text = "Datos de Ventas";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 164);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 22);
            this.dateTimePicker1.TabIndex = 79;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(116, 206);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(143, 22);
            this.txtTotal.TabIndex = 78;
            // 
            // cmbRepuestos
            // 
            this.cmbRepuestos.FormattingEnabled = true;
            this.cmbRepuestos.Location = new System.Drawing.Point(116, 103);
            this.cmbRepuestos.Name = "cmbRepuestos";
            this.cmbRepuestos.Size = new System.Drawing.Size(143, 24);
            this.cmbRepuestos.TabIndex = 77;
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(116, 66);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(143, 24);
            this.cmbClientes.TabIndex = 76;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(46, 206);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 16);
            this.lblTotal.TabIndex = 75;
            this.lblTotal.Text = "Total:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(46, 66);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(51, 16);
            this.lblCliente.TabIndex = 66;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblRepuesto
            // 
            this.lblRepuesto.AutoSize = true;
            this.lblRepuesto.Location = new System.Drawing.Point(46, 103);
            this.lblRepuesto.Name = "lblRepuesto";
            this.lblRepuesto.Size = new System.Drawing.Size(69, 16);
            this.lblRepuesto.TabIndex = 67;
            this.lblRepuesto.Text = "Repuesto:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(46, 139);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 16);
            this.lblCantidad.TabIndex = 68;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(46, 171);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(48, 16);
            this.lblFecha.TabIndex = 69;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(116, 136);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(143, 22);
            this.txtCantidad.TabIndex = 70;
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.Location = new System.Drawing.Point(417, 50);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(96, 32);
            this.btnAgregarItem.TabIndex = 71;
            this.btnAgregarItem.Text = "Agregar";
            this.btnAgregarItem.UseVisualStyleBackColor = true;
            this.btnAgregarItem.Click += new System.EventHandler(this.btnAgregarItem_Click);
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Location = new System.Drawing.Point(404, 97);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(127, 35);
            this.btnRegistrarVenta.TabIndex = 72;
            this.btnRegistrarVenta.Text = "Registrar Venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // btnEliminarItem
            // 
            this.btnEliminarItem.Location = new System.Drawing.Point(410, 139);
            this.btnEliminarItem.Name = "btnEliminarItem";
            this.btnEliminarItem.Size = new System.Drawing.Size(103, 32);
            this.btnEliminarItem.TabIndex = 73;
            this.btnEliminarItem.Text = "Eliminar";
            this.btnEliminarItem.UseVisualStyleBackColor = true;
            this.btnEliminarItem.Click += new System.EventHandler(this.btnEliminarItem_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(417, 181);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(89, 36);
            this.btnLimpiar.TabIndex = 74;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 889);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.btnAbrirDetalle);
            this.Controls.Add(this.grpDatosdeVentas);
            this.Controls.Add(this.GstVentas);
            this.Controls.Add(this.dgvVentas);
            this.Name = "FormVenta";
            this.Text = "FormVenta";
            this.Load += new System.EventHandler(this.FormVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.grpDatosdeVentas.ResumeLayout(false);
            this.grpDatosdeVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label GstVentas;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.GroupBox grpDatosdeVentas;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cmbRepuestos;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblRepuesto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAgregarItem;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Button btnEliminarItem;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Button btnAbrirDetalle;

    }
}