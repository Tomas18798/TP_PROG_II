
namespace Forms
{
    partial class NuevaAtencion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTotal1 = new System.Windows.Forms.Label();
            this.cboTipoServicio = new System.Windows.Forms.ComboBox();
            this.cboServicios = new System.Windows.Forms.ComboBox();
            this.lblAtencion = new System.Windows.Forms.Label();
            this.cboTiposMascotas = new System.Windows.Forms.ComboBox();
            this.txtEdadMascota = new System.Windows.Forms.TextBox();
            this.txtNombreMascota = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblEdadMascota = new System.Windows.Forms.Label();
            this.lblNombreMascota = new System.Windows.Forms.Label();
            this.lblMascota = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.lblTotal1);
            this.groupBox1.Controls.Add(this.cboTipoServicio);
            this.groupBox1.Controls.Add(this.cboServicios);
            this.groupBox1.Controls.Add(this.lblAtencion);
            this.groupBox1.Controls.Add(this.cboTiposMascotas);
            this.groupBox1.Controls.Add(this.txtEdadMascota);
            this.groupBox1.Controls.Add(this.txtNombreMascota);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Controls.Add(this.lblEdadMascota);
            this.groupBox1.Controls.Add(this.lblNombreMascota);
            this.groupBox1.Controls.Add(this.lblMascota);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblTelefono);
            this.groupBox1.Controls.Add(this.lblDni);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Location = new System.Drawing.Point(19, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 484);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(210, 27);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(38, 15);
            this.lblFecha.TabIndex = 21;
            this.lblFecha.Text = "Fecha";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion,
            this.Precio,
            this.Acciones});
            this.dataGridView.Location = new System.Drawing.Point(17, 328);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(392, 114);
            this.dataGridView.TabIndex = 20;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Acciones
            // 
            this.Acciones.HeaderText = "Accion";
            this.Acciones.Name = "Acciones";
            this.Acciones.ReadOnly = true;
            this.Acciones.Text = "Quitar";
            this.Acciones.UseColumnTextForButtonValue = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(361, 455);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 15);
            this.lblTotal.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(340, 296);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(69, 23);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTotal1
            // 
            this.lblTotal1.AutoSize = true;
            this.lblTotal1.Location = new System.Drawing.Point(319, 455);
            this.lblTotal1.Name = "lblTotal1";
            this.lblTotal1.Size = new System.Drawing.Size(44, 15);
            this.lblTotal1.TabIndex = 1;
            this.lblTotal1.Text = "Total: $";
            // 
            // cboTipoServicio
            // 
            this.cboTipoServicio.FormattingEnabled = true;
            this.cboTipoServicio.Location = new System.Drawing.Point(17, 296);
            this.cboTipoServicio.Name = "cboTipoServicio";
            this.cboTipoServicio.Size = new System.Drawing.Size(157, 23);
            this.cboTipoServicio.TabIndex = 18;
            this.cboTipoServicio.SelectedIndexChanged += new System.EventHandler(this.cboTipoServicio_SelectedIndexChanged);
            // 
            // cboServicios
            // 
            this.cboServicios.FormattingEnabled = true;
            this.cboServicios.Location = new System.Drawing.Point(180, 296);
            this.cboServicios.Name = "cboServicios";
            this.cboServicios.Size = new System.Drawing.Size(150, 23);
            this.cboServicios.TabIndex = 17;
            // 
            // lblAtencion
            // 
            this.lblAtencion.AutoSize = true;
            this.lblAtencion.Location = new System.Drawing.Point(17, 275);
            this.lblAtencion.Name = "lblAtencion";
            this.lblAtencion.Size = new System.Drawing.Size(55, 15);
            this.lblAtencion.TabIndex = 14;
            this.lblAtencion.Text = "Atencion";
            // 
            // cboTiposMascotas
            // 
            this.cboTiposMascotas.FormattingEnabled = true;
            this.cboTiposMascotas.Location = new System.Drawing.Point(159, 233);
            this.cboTiposMascotas.Name = "cboTiposMascotas";
            this.cboTiposMascotas.Size = new System.Drawing.Size(171, 23);
            this.cboTiposMascotas.TabIndex = 13;
            // 
            // txtEdadMascota
            // 
            this.txtEdadMascota.Location = new System.Drawing.Point(159, 203);
            this.txtEdadMascota.Name = "txtEdadMascota";
            this.txtEdadMascota.Size = new System.Drawing.Size(171, 23);
            this.txtEdadMascota.TabIndex = 12;
            // 
            // txtNombreMascota
            // 
            this.txtNombreMascota.Location = new System.Drawing.Point(159, 173);
            this.txtNombreMascota.Name = "txtNombreMascota";
            this.txtNombreMascota.Size = new System.Drawing.Size(171, 23);
            this.txtNombreMascota.TabIndex = 11;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(121, 236);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(30, 15);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Tipo";
            // 
            // lblEdadMascota
            // 
            this.lblEdadMascota.AutoSize = true;
            this.lblEdadMascota.Location = new System.Drawing.Point(66, 206);
            this.lblEdadMascota.Name = "lblEdadMascota";
            this.lblEdadMascota.Size = new System.Drawing.Size(85, 15);
            this.lblEdadMascota.TabIndex = 9;
            this.lblEdadMascota.Text = "Edad (en años)";
            // 
            // lblNombreMascota
            // 
            this.lblNombreMascota.AutoSize = true;
            this.lblNombreMascota.Location = new System.Drawing.Point(97, 176);
            this.lblNombreMascota.Name = "lblNombreMascota";
            this.lblNombreMascota.Size = new System.Drawing.Size(54, 15);
            this.lblNombreMascota.TabIndex = 8;
            this.lblNombreMascota.Text = "Nombre ";
            // 
            // lblMascota
            // 
            this.lblMascota.AutoSize = true;
            this.lblMascota.Location = new System.Drawing.Point(17, 146);
            this.lblMascota.Name = "lblMascota";
            this.lblMascota.Size = new System.Drawing.Size(52, 15);
            this.lblMascota.TabIndex = 7;
            this.lblMascota.Text = "Mascota";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(159, 115);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(171, 23);
            this.txtTelefono.TabIndex = 6;
            this.txtTelefono.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(159, 84);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(171, 23);
            this.txtDni.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(159, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(171, 23);
            this.txtNombre.TabIndex = 4;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(99, 115);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 15);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(124, 87);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(27, 15);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "DNI";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(46, 57);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Completo";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(17, 27);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(44, 15);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(317, 505);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "<< Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NuevaAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(464, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "NuevaAtencion";
            this.Text = "NuevaAtencion";
            this.Load += new System.EventHandler(this.NuevaAtencion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboTipoServicio;
        private System.Windows.Forms.ComboBox cboServicios;
        private System.Windows.Forms.Label lblAtencion;
        private System.Windows.Forms.ComboBox cboTiposMascotas;
        private System.Windows.Forms.TextBox txtEdadMascota;
        private System.Windows.Forms.TextBox txtNombreMascota;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblEdadMascota;
        private System.Windows.Forms.Label lblNombreMascota;
        private System.Windows.Forms.Label lblMascota;
        private System.Windows.Forms.Label lblTotal1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewButtonColumn Acciones;
    }
}