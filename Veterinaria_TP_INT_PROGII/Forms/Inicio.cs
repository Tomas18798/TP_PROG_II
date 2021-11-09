using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Inicio : Form
    {
        bool flag = false;
        public Inicio(bool flag1)
        {
            InitializeComponent();
            flag = flag1;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString().ToString();
            if (flag == false)
            {
                grupoInicio.Enabled = false;
            }
            else 
            { 
                grupoInicio.Enabled = true;
                btnIngresar.Enabled = false;
            }
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alumnos que participaron del proyecto: \n \n" +
                            " 112788 - Guillamondegui, Néstor Ignacio \n" +
                            " 113197 - Guiñazú, Gastón Ignacio \n" +
                            " 112952 - Gutierrez, Tomás Maximiliano ", "Acerca De", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnNuevaAtencion_Click_1(object sender, EventArgs e)
        {
            NuevaAtencion frm = new NuevaAtencion();
            frm.ShowDialog();
        }

        private void btnVer_Click_1(object sender, EventArgs e)
        {
            VerAtenciones frm = new VerAtenciones();
            frm.ShowDialog();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {            

            Login frm = new Login();

            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnAcercaDe_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(" 112788 - Guillamondegui, Néstor Ignacio \n" +
                " 113197 - Guiñazú, Gastón Ignacio \n" +
                " 112952 - Gutierrez, Tomás Maximiliano ", "Alumnos que participaron del proyecto:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            AgregarServicio frm = new AgregarServicio();
            frm.ShowDialog();
        }
    }
}
