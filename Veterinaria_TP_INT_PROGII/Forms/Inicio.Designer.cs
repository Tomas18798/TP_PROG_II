
namespace Forms
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.grupoInicio = new System.Windows.Forms.GroupBox();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.btnNuevaAtencion = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.grupoInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Location = new System.Drawing.Point(20, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 227);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnIngresar);
            this.groupBox2.Controls.Add(this.grupoInicio);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(38, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 268);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(287, 33);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(204, 24);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "Iniciar Sesion";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // grupoInicio
            // 
            this.grupoInicio.Controls.Add(this.btnAcercaDe);
            this.grupoInicio.Controls.Add(this.btnNuevaAtencion);
            this.grupoInicio.Controls.Add(this.btnVer);
            this.grupoInicio.Location = new System.Drawing.Point(258, 63);
            this.grupoInicio.Name = "grupoInicio";
            this.grupoInicio.Size = new System.Drawing.Size(262, 183);
            this.grupoInicio.TabIndex = 6;
            this.grupoInicio.TabStop = false;
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.Location = new System.Drawing.Point(29, 137);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(204, 23);
            this.btnAcercaDe.TabIndex = 7;
            this.btnAcercaDe.Text = "Acerca de";
            this.btnAcercaDe.UseVisualStyleBackColor = true;
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click_1);
            // 
            // btnNuevaAtencion
            // 
            this.btnNuevaAtencion.Location = new System.Drawing.Point(29, 74);
            this.btnNuevaAtencion.Name = "btnNuevaAtencion";
            this.btnNuevaAtencion.Size = new System.Drawing.Size(204, 23);
            this.btnNuevaAtencion.TabIndex = 6;
            this.btnNuevaAtencion.Text = "Nueva Atencion";
            this.btnNuevaAtencion.UseVisualStyleBackColor = true;
            this.btnNuevaAtencion.Click += new System.EventHandler(this.btnNuevaAtencion_Click_1);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(29, 31);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(204, 23);
            this.btnVer.TabIndex = 5;
            this.btnVer.Text = "Ver Atenciones";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click_1);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(38, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(109, 21);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Bienvenidos";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(370, 27);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(65, 15);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha jaja";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(445, 339);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(605, 376);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBox2);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.groupBox2.ResumeLayout(false);
            this.grupoInicio.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grupoInicio;
        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.Button btnNuevaAtencion;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnIngresar;
    }
}