
namespace Forms
{
    partial class VerAtenciones
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grupoMascota = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEdadMascota = new System.Windows.Forms.Label();
            this.lblTipoMascota = new System.Windows.Forms.Label();
            this.lblNombreMascota = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grupoMascota.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.grupoMascota);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblTelefono);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.txtdni);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.lblDni);
            this.groupBox1.Controls.Add(this.lblNombreCliente);
            this.groupBox1.Location = new System.Drawing.Point(14, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 392);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IDD,
            this.Fecha,
            this.tipoAtencion,
            this.descripcion,
            this.importe,
            this.Borrar});
            this.dataGridView1.Location = new System.Drawing.Point(12, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(529, 139);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // grupoMascota
            // 
            this.grupoMascota.Controls.Add(this.label7);
            this.grupoMascota.Controls.Add(this.lblEdadMascota);
            this.grupoMascota.Controls.Add(this.lblTipoMascota);
            this.grupoMascota.Controls.Add(this.lblNombreMascota);
            this.grupoMascota.Location = new System.Drawing.Point(323, 11);
            this.grupoMascota.Name = "grupoMascota";
            this.grupoMascota.Size = new System.Drawing.Size(185, 167);
            this.grupoMascota.TabIndex = 17;
            this.grupoMascota.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Datos Mascota";
            // 
            // lblEdadMascota
            // 
            this.lblEdadMascota.AutoSize = true;
            this.lblEdadMascota.Location = new System.Drawing.Point(16, 125);
            this.lblEdadMascota.Name = "lblEdadMascota";
            this.lblEdadMascota.Size = new System.Drawing.Size(33, 15);
            this.lblEdadMascota.TabIndex = 5;
            this.lblEdadMascota.Text = "Edad";
            // 
            // lblTipoMascota
            // 
            this.lblTipoMascota.AutoSize = true;
            this.lblTipoMascota.Location = new System.Drawing.Point(16, 93);
            this.lblTipoMascota.Name = "lblTipoMascota";
            this.lblTipoMascota.Size = new System.Drawing.Size(30, 15);
            this.lblTipoMascota.TabIndex = 7;
            this.lblTipoMascota.Text = "Tipo";
            this.lblTipoMascota.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblNombreMascota
            // 
            this.lblNombreMascota.AutoSize = true;
            this.lblNombreMascota.Location = new System.Drawing.Point(16, 58);
            this.lblNombreMascota.Name = "lblNombreMascota";
            this.lblNombreMascota.Size = new System.Drawing.Size(51, 15);
            this.lblNombreMascota.TabIndex = 9;
            this.lblNombreMascota.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(223, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Atenciones";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Datos Cliente";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(41, 131);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 15);
            this.lblTelefono.TabIndex = 11;
            this.lblTelefono.Text = "Telefono";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(132, 155);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(166, 23);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(132, 97);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(166, 23);
            this.txtdni.TabIndex = 3;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(132, 61);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(166, 23);
            this.txtNombreCliente.TabIndex = 2;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(41, 100);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(27, 15);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "DNI";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(41, 64);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(51, 15);
            this.lblNombreCliente.TabIndex = 0;
            this.lblNombreCliente.Text = "Nombre";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(401, 406);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(166, 23);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar Atencion";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(14, 406);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(166, 23);
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "<< Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID Atencion";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // IDD
            // 
            this.IDD.HeaderText = "ID Detalle";
            this.IDD.Name = "IDD";
            this.IDD.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // tipoAtencion
            // 
            this.tipoAtencion.HeaderText = "Tipo de Atencion";
            this.tipoAtencion.Name = "tipoAtencion";
            this.tipoAtencion.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // importe
            // 
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Accion";
            this.Borrar.Name = "Borrar";
            this.Borrar.ReadOnly = true;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseColumnTextForButtonValue = true;
            // 
            // VerAtenciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 436);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox1);
            this.Name = "VerAtenciones";
            this.Text = "VerAtenciones";
            this.Load += new System.EventHandler(this.VerAtenciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grupoMascota.ResumeLayout(false);
            this.grupoMascota.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombreMascota;
        private System.Windows.Forms.Label lblTipoMascota;
        private System.Windows.Forms.Label lblEdadMascota;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grupoMascota;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;
    }
}