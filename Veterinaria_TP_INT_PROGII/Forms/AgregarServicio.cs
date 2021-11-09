using Entidades;
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
    public partial class AgregarServicio : Form
    {
        private IService servicio;
        bool flag = false;

        public AgregarServicio()
        {
            InitializeComponent();
            servicio = new Service();
        }

        private void CargarCombo()
        {

            List<TipoServicio> tipos = servicio.GetTiposServicios();

            cboTipos.Items.AddRange(tipos.ToArray());
            cboTipos.DisplayMember = "_tipoServicio";
            cboTipos.ValueMember = "_id";

        }

        private void CargarLista()
        {
            List<Servicio> lista = servicio.ConsultarServicios();
            //listaServicios.DataSource = lista;

            foreach(Servicio servicio in lista)
            {                
                //listaServicios.DataSource = lista;
                string data = servicio._id.ToString()+"- "+servicio._tipo._tipoServicio + " -  " + servicio._descripcion;
                listaServicios.ValueMember = servicio._id.ToString();
                listaServicios.Items.Add(data);

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AgregarServicio_Load(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnBorrar.Enabled = false;
            btnNuevo.Enabled = false;
            CargarCombo();
            CargarLista();
        }

        private void listaServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditar.Enabled = true ;
            btnBorrar.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Validacion() == true)
            {
                Servicio oServicio = new Servicio();
                oServicio._descripcion = txtDescripcion.Text;
                oServicio._precio = Convert.ToDouble(txtPrecio.Text);

                TipoServicio oTipo = new TipoServicio();
                oTipo._id = cboTipos.SelectedIndex + 1;
                oTipo._tipoServicio = cboTipos.DisplayMember;

                oServicio._tipo = oTipo;

                if (flag == false)
                {
                    if (servicio.GuardarServicio(oServicio))
                    {
                        MessageBox.Show("Cargado correctamente");
                        listaServicios.Items.Clear();
                        CargarLista();
                        cboTipos.SelectedIndex = -1;
                        txtDescripcion.Text = "";
                        txtPrecio.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar el servicio");
                    }
                }
                else if (flag == true)
                {
                    string value = listaServicios.GetItemText(listaServicios.SelectedItem);
                    string id_servicio = "";
                    foreach (char c in value)
                    {
                        if (Char.IsDigit(c))
                        {
                            id_servicio += c;
                        }
                    }
                    DialogResult result = MessageBox.Show("¿Está seguro que desea editar el servicio?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (servicio.ActualizarServicio(Convert.ToInt32(id_servicio), oServicio) == true)
                        {
                            flag = false;
                            cboTipos.SelectedIndex = -1;
                            txtDescripcion.Text = "";
                            txtPrecio.Text = "";
                            MessageBox.Show("Actualizado correctamente");
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar el servicio");
                        }

                    }

                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string value = listaServicios.GetItemText(listaServicios.SelectedItem);
            string id_servicio = "";
            foreach(char c in value)
            {   
                if (Char.IsDigit(c))
                {
                    id_servicio += c;
                }
            }


            flag = true;
            btnNuevo.Enabled = true;
            cboTipos.Enabled = false;
            txtDescripcion.Enabled = false;

            List<Servicio> lista = servicio.ConsultarServicios();
            foreach (Servicio servicio in lista) 
            { 
                if(servicio._id == Convert.ToInt32(id_servicio))
                {
                    cboTipos.SelectedIndex = servicio._tipo._id - 1;
                    txtDescripcion.Text = servicio._descripcion;
                    txtPrecio.Text = servicio._precio.ToString();
                    break;
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            listaServicios.SelectedIndex = -1;
            cboTipos.Enabled = true;
            txtDescripcion.Enabled = true;
            btnEditar.Enabled = false;
            btnBorrar.Enabled = false;
            flag = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string value = listaServicios.GetItemText(listaServicios.SelectedItem);
            string id_servicio = "";
            foreach (char c in value)
            {
                if (Char.IsDigit(c))
                {
                    id_servicio += c;
                }
            }
            DialogResult result = MessageBox.Show("¿Está seguro que desea borrar el servicio?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                servicio.Borrarservicio(Convert.ToInt32(id_servicio));
                listaServicios.Items.Clear();
                CargarLista();
            }
        }

        private bool Validacion()
        {
            bool flag = true;
            if (cboTipos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Seleccionar un tipo de servicio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTipos.Focus();
                flag = false;
            }
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Debe completar la descripcion", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcion.Focus();
                flag = false;
            }
            if (txtPrecio.Text == "")
            {
                MessageBox.Show("Debe completar el precio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcion.Focus();
                flag = false;
            }
            else if (SoloNumeros(txtPrecio.Text)==false)
            {
                MessageBox.Show("El campo precio solo acepta numeros", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcion.Focus();
                flag = false;
            }
            return flag;
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
