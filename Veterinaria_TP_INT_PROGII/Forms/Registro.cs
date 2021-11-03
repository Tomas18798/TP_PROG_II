using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios;
using Servicios.Interfaces;
using Servicios.Implementaciones;
using Servicios.Factory;
using Entidades;
using System.Text.RegularExpressions;

namespace Forms
{
    public partial class Registro : Form
    {
        private IService servicio;
        

        public Registro()
        {
            InitializeComponent();
            servicio = new Service();
        }



        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                Vendedor oVendedor = new Vendedor();
        
                oVendedor._nombre = txtNombre.Text;
                oVendedor._apellido = txtApellido.Text;
                oVendedor._telefono = Convert.ToInt64(txtTelefono.Text);
                oVendedor._mail = txtMail.Text;
                oVendedor._usuario = txtUsuario.Text;
                oVendedor._contraseña = txtPass.Text;


                if(servicio.VerificarUsuario(oVendedor._usuario,oVendedor._contraseña) == true)
                {
                    MessageBox.Show("Error, el usuario ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Focus();
                }
                else
                {
                    if (servicio.RegistrarVendedor(oVendedor))
                    {
                        MessageBox.Show(" Registrado con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Validaciones()
        {
            bool flag = true;

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return false;
            }
            else if (SoloLetras(txtNombre.Text) == false)
            {
                MessageBox.Show("El nombre no puede contener numeros", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return false;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar el DNI", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
                return false;
            }
            else if (SoloLetras(txtApellido.Text) == false)
            {
                MessageBox.Show("El nombre no puede contener numeros", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
                return false;
            }
            if (txtTelefono.Text == "")
            {
                MessageBox.Show("Debe ingresar un telefono", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Focus();
                return false;
            }
            else if (SoloNumeros(txtTelefono.Text) == false)
            {
                MessageBox.Show("El telefono no puede contener letras", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Focus();
                return false;
            }
            if (txtMail.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre mail", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMail.Focus();
                return false;
            }
            else if (ValidacionEmail(txtMail.Text) == false)
            {
                MessageBox.Show("Mail invalido", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMail.Focus();
                return false;
            }
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Debe ingresar la edad de la mascota", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                return false;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("Debe ingresar una contraseña", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Focus();
                return false;
            }


            return flag;
        }
        public bool ValidacionEmail(string email)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool SoloNumeros(string TXT)
        {
            bool flag = true;

            foreach (char caracter in TXT)
            {
                if (Char.IsLetter(caracter))
                { flag = false; break; }

                else { flag = true; }
            }
            return flag;
        }
        public bool SoloLetras(string TXT)
        {
            bool flag = true;

            foreach (char caracter in TXT)
            {
                if (Char.IsDigit(caracter))
                { flag = false; break; }
                else { flag = true; }
            }
            return flag;
        }
    }
}
