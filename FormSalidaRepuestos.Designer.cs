namespace FRMREPUESTOSMS
{
    partial class FormSalidaRepuesto
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cmbRepuesto;
        private System.Windows.Forms.TextBox txtPieza;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtObservacion;

        private System.Windows.Forms.Label lblRepuesto;
        private System.Windows.Forms.Label lblPieza;
        private System.Windows.Forms.Label lblFechaSalida;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblExistencia;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblObservacion;

        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnLimpiar;

        private System.Windows.Forms.DataGridView dgvSalidas;

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
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.lblRepuesto = new System.Windows.Forms.Label();
            this.lblPieza = new System.Windows.Forms.Label();
            this.lblFechaSalida = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.dgvSalidas = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).BeginInit();
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
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSalida.Location = new System.Drawing.Point(130, 97);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(250, 22);
            this.dtpFechaSalida.TabIndex = 5;
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
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(130, 217);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(250, 22);
            this.txtDestino.TabIndex = 11;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(130, 257);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(250, 60);
            this.txtObservacion.TabIndex = 13;
            // 
            // lblRepuesto
            // 
            this.lblRepuesto.AutoSize = true;
            this.lblRepuesto.Location = new System.Drawing.Point(30, 20);
            this.lblRepuesto.Name = "lblRepuesto";
            this.lblRepuesto.Size = new System.Drawing.Size(66, 16);
            this.lblRepuesto.TabIndex = 0;
            this.lblRepuesto.Text = "Repuesto";
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
            // lblFechaSalida
            // 
            this.lblFechaSalida.AutoSize = true;
            this.lblFechaSalida.Location = new System.Drawing.Point(30, 100);
            this.lblFechaSalida.Name = "lblFechaSalida";
            this.lblFechaSalida.Size = new System.Drawing.Size(87, 16);
            this.lblFechaSalida.TabIndex = 4;
            this.lblFechaSalida.Text = "Fecha Salida";
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
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(30, 220);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(53, 16);
            this.lblDestino.TabIndex = 10;
            this.lblDestino.Text = "Destino";
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Location = new System.Drawing.Point(30, 260);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(84, 16);
            this.lblObservacion.TabIndex = 12;
            this.lblObservacion.Text = "Observación";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(420, 20);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(120, 35);
            this.BtnAgregar.TabIndex = 14;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click_1);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(420, 70);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(120, 35);
            this.BtnEditar.TabIndex = 15;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click_1);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(420, 120);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(120, 35);
            this.BtnEliminar.TabIndex = 16;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click_1);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(420, 170);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(120, 35);
            this.BtnLimpiar.TabIndex = 17;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click_1);
            // 
            // dgvSalidas
            // 
            this.dgvSalidas.AllowUserToAddRows = false;
            this.dgvSalidas.AllowUserToDeleteRows = false;
            this.dgvSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalidas.Location = new System.Drawing.Point(30, 330);
            this.dgvSalidas.Name = "dgvSalidas";
            this.dgvSalidas.ReadOnly = true;
            this.dgvSalidas.RowHeadersWidth = 51;
            this.dgvSalidas.RowTemplate.Height = 24;
            this.dgvSalidas.Size = new System.Drawing.Size(700, 200);
            this.dgvSalidas.TabIndex = 18;
            this.dgvSalidas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalidas_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormSalidaRepuesto
            // 
            this.ClientSize = new System.Drawing.Size(760, 560);
            this.Controls.Add(this.dgvSalidas);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.lblObservacion);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.lblExistencia);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.lblFechaSalida);
            this.Controls.Add(this.txtPieza);
            this.Controls.Add(this.lblPieza);
            this.Controls.Add(this.cmbRepuesto);
            this.Controls.Add(this.lblRepuesto);
            this.Name = "FormSalidaRepuesto";
            this.Text = "Gestión Salida de Repuestos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
