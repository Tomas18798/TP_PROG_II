using Servicios.Implementaciones;
using Servicios.Interfaces;
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
    public partial class Login : Form
    {
        private IService servicio;

        public Login()
        {
            InitializeComponent();
            servicio = new Service();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string pass = txtPass.Text;
            if(servicio.VerificarUsuario(user,pass) == true)
            {
                Inicio frm = new Inicio(true);

                this.Hide();

                frm.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Error al intentar Ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            Registro frm = new Registro();
            frm.ShowDialog();
        }
    }
}
