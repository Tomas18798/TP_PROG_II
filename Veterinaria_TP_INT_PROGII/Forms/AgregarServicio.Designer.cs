
namespace Forms
{
    partial class AgregarServicio
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cboTipos = new System.Windows.Forms.ComboBox();
            this.lblServiciosList = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.listaServicios = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.cboTipos);
            this.groupBox1.Controls.Add(this.lblServiciosList);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Controls.Add(this.lbltitulo);
            this.groupBox1.Controls.Add(this.listaServicios);
            this.groupBox1.Location = new System.Drawing.Point(37, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(287, 255);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(70, 23);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(462, 254);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(71, 23);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(376, 255);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(71, 23);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(128, 206);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(142, 23);
            this.txtPrecio.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(128, 162);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(142, 23);
            this.txtDescripcion.TabIndex = 8;
            // 
            // cboTipos
            // 
            this.cboTipos.FormattingEnabled = true;
            this.cboTipos.Location = new System.Drawing.Point(128, 118);
            this.cboTipos.Name = "cboTipos";
            this.cboTipos.Size = new System.Drawing.Size(142, 23);
            this.cboTipos.TabIndex = 7;
            // 
            // lblServiciosList
            // 
            this.lblServiciosList.AutoSize = true;
            this.lblServiciosList.Location = new System.Drawing.Point(385, 26);
            this.lblServiciosList.Name = "lblServiciosList";
            this.lblServiciosList.Size = new System.Drawing.Size(53, 15);
            this.lblServiciosList.TabIndex = 6;
            this.lblServiciosList.Text = "Servicios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripcion";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(19, 121);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(90, 15);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo de Servicio";
            this.lblTipo.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltitulo.Location = new System.Drawing.Point(91, 56);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(119, 20);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "Agregar Servicio";
            // 
            // listaServicios
            // 
            this.listaServicios.FormattingEnabled = true;
            this.listaServicios.ItemHeight = 15;
            this.listaServicios.Location = new System.Drawing.Point(287, 49);
            this.listaServicios.Name = "listaServicios";
            this.listaServicios.ScrollAlwaysVisible = true;
            this.listaServicios.Size = new System.Drawing.Size(246, 199);
            this.listaServicios.TabIndex = 0;
            this.listaServicios.SelectedIndexChanged += new System.EventHandler(this.listaServicios_SelectedIndexChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(37, 332);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(152, 23);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "<< Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(399, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AgregarServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(618, 368);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox1);
            this.Name = "AgregarServicio";
            this.Text = "AgregarServicio";
            this.Load += new System.EventHandler(this.AgregarServicio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblServiciosList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.ListBox listaServicios;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cboTipos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnNuevo;
    }
}