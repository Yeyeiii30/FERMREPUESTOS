namespace FRMREPUESTOSMS
{
    partial class FormEntradaRepuesto
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cmbRepuesto;
        private System.Windows.Forms.TextBox txtPieza;
        private System.Windows.Forms.DateTimePicker dtpFechaLlegada;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.TextBox txtObservacion;

        private System.Windows.Forms.Label lblRepuesto;
        private System.Windows.Forms.Label lblPieza;
        private System.Windows.Forms.Label lblFechaLlegada;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblExistencia;
        private System.Windows.Forms.Label lblObservacion;

        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnLimpiar;

        private System.Windows.Forms.DataGridView dgvEntradas;

        private System.Windows.Forms.ErrorProvider errorProvider1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbRepuesto = new System.Windows.Forms.ComboBox();
            this.txtPieza = new System.Windows.Forms.TextBox();
            this.dtpFechaLlegada = new System.Windows.Forms.DateTimePicker();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.lblRepuesto = new System.Windows.Forms.Label();
            this.lblPieza = new System.Windows.Forms.Label();
            this.lblFechaLlegada = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.dgvEntradas = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRepuesto
            // 
            this.cmbRepuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRepuesto.FormattingEnabled = true;
            this.cmbRepuesto.Location = new System.Drawing.Point(130, 17);
            this.cmbRepuesto.Name = "cmbRepuesto";
            this.cmbRepuesto.Size = new System.Drawing.Size(250, 24);
            this.cmbRepuesto.TabIndex = 1;
            // 
            // txtPieza
            // 
            this.txtPieza.Location = new System.Drawing.Point(130, 57);
            this.txtPieza.Name = "txtPieza";
            this.txtPieza.Size = new System.Drawing.Size(250, 22);
            this.txtPieza.TabIndex = 3;
            // 
            // dtpFechaLlegada
            // 
            this.dtpFechaLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLlegada.Location = new System.Drawing.Point(130, 97);
            this.dtpFechaLlegada.Name = "dtpFechaLlegada";
            this.dtpFechaLlegada.Size = new System.Drawing.Size(250, 22);
            this.dtpFechaLlegada.TabIndex = 5;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(130, 137);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(250, 22);
            this.txtCantidad.TabIndex = 7;
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(130, 177);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(250, 22);
            this.txtExistencia.TabIndex = 9;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(130, 217);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(250, 60);
            this.txtObservacion.TabIndex = 11;
            // 
            // lblRepuesto
            // 
            this.lblRepuesto.AutoSize = true;
            this.lblRepuesto.Location = new System.Drawing.Point(30, 20);
            this.lblRepuesto.Name = "lblRepuesto";
            this.lblRepuesto.Size = new System.Drawing.Size(69, 16);
            this.lblRepuesto.TabIndex = 0;
            this.lblRepuesto.Text = "Categoria:";
            // 
            // lblPieza
            // 
            this.lblPieza.AutoSize = true;
            this.lblPieza.Location = new System.Drawing.Point(30, 60);
            this.lblPieza.Name = "lblPieza";
            this.lblPieza.Size = new System.Drawing.Size(41, 16);
            this.lblPieza.TabIndex = 2;
            this.lblPieza.Text = "Pieza";
            // 
            // lblFechaLlegada
            // 
            this.lblFechaLlegada.AutoSize = true;
            this.lblFechaLlegada.Location = new System.Drawing.Point(30, 100);
            this.lblFechaLlegada.Name = "lblFechaLlegada";
            this.lblFechaLlegada.Size = new System.Drawing.Size(98, 16);
            this.lblFechaLlegada.TabIndex = 4;
            this.lblFechaLlegada.Text = "Fecha Llegada";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(30, 140);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(61, 16);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblExistencia
            // 
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.Location = new System.Drawing.Point(30, 180);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(68, 16);
            this.lblExistencia.TabIndex = 8;
            this.lblExistencia.Text = "Existencia";
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Location = new System.Drawing.Point(30, 220);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(84, 16);
            this.lblObservacion.TabIndex = 10;
            this.lblObservacion.Text = "Observación";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(420, 20);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(120, 35);
            this.BtnAgregar.TabIndex = 12;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click_1);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(420, 70);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(120, 35);
            this.BtnEditar.TabIndex = 13;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click_1);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(420, 120);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(120, 35);
            this.BtnEliminar.TabIndex = 14;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click_1);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(420, 170);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(120, 35);
            this.BtnLimpiar.TabIndex = 15;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // dgvEntradas
            // 
            this.dgvEntradas.AllowUserToAddRows = false;
            this.dgvEntradas.AllowUserToDeleteRows = false;
            this.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradas.Location = new System.Drawing.Point(30, 300);
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.ReadOnly = true;
            this.dgvEntradas.RowHeadersWidth = 51;
            this.dgvEntradas.RowTemplate.Height = 24;
            this.dgvEntradas.Size = new System.Drawing.Size(700, 200);
            this.dgvEntradas.TabIndex = 16;
            this.dgvEntradas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntradas_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormEntradaRepuesto
            // 
            this.ClientSize = new System.Drawing.Size(760, 520);
            this.Controls.Add(this.dgvEntradas);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.lblObservacion);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.lblExistencia);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.dtpFechaLlegada);
            this.Controls.Add(this.lblFechaLlegada);
            this.Controls.Add(this.txtPieza);
            this.Controls.Add(this.lblPieza);
            this.Controls.Add(this.cmbRepuesto);
            this.Controls.Add(this.lblRepuesto);
            this.Name = "FormEntradaRepuesto";
            this.Text = "Gestión Entrada de Repuestos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
