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
    public partial class NuevaAtencion : Form
    {
        private IService servicio;
        Atencion oAtencion = new Atencion();
        Int64 DNIcliente = 0;
        bool flag = false;

        public NuevaAtencion()
        {
            InitializeComponent();
            servicio = new Service();
        }

        public NuevaAtencion(Int64 DNI, bool flag2)
        {
            InitializeComponent();
            servicio = new Service();
            DNIcliente = DNI;
            flag = flag2;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CargarCombo()
        {
            cboServicios.Enabled = false;

            List<TipoServicio> tipos = servicio.GetTiposServicios();
            //cboTipoServicio.DataSource = tipos;

            cboTipoServicio.Items.AddRange(tipos.ToArray());
            cboTipoServicio.DisplayMember = "_tipoServicio";
            cboTipoServicio.ValueMember = "_id";
            //if(cboTipoServicio.SelectedIndex > -1)
            //{
            //    cboServicios.Enabled = true;
            //    CargarServicios();
            //}

            List<TipoMascota> tiposMascotas = servicio.GetTiposMascotas();
            cboTiposMascotas.Items.AddRange(tiposMascotas.ToArray());
            cboTiposMascotas.DisplayMember = "_tipoMascota";
            cboTiposMascotas.ValueMember = "_id";

        }
        private void CargarServicios()
        {
            cboServicios.Enabled = true;
            if (cboTipoServicio.SelectedIndex == 0)
            {
                cboServicios.Items.Clear();
               List<Servicio> servicios = servicio.GetServicioXtipo(1);
                cboServicios.Items.AddRange(servicios.ToArray());
                cboServicios.DisplayMember = "_descripcion";
                cboServicios.ValueMember = "_id";
            }
            else if (cboTipoServicio.SelectedIndex == 1)
            {
                cboServicios.Items.Clear();
                List<Servicio> servicios = servicio.GetServicioXtipo(2);
                cboServicios.Items.AddRange(servicios.ToArray());
                cboServicios.DisplayMember = "_descripcion";
                cboServicios.ValueMember = "_id";
            }
            else if (cboTipoServicio.SelectedIndex == 2)
            {
                cboServicios.Items.Clear();
                List<Servicio> servicios = servicio.GetServicioXtipo(3);
                cboServicios.Items.AddRange(servicios.ToArray());
                cboServicios.DisplayMember = "_descripcion";
                cboServicios.ValueMember = "_id";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NuevaAtencion_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            CargarCombo();
            if(flag == true)
            {
                cargarDatos();
            }

        }

        private void cboTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarServicios();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ExisteProductoEnGrilla(cboServicios.Text))
            {
                MessageBox.Show("Servicio ya agregado como detalle", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DetalleAtencion detalle = new DetalleAtencion();
            Servicio oServicio = (Servicio)cboServicios.SelectedItem;
            detalle._servicio = oServicio;

            oAtencion.AgregarDetalle(detalle);

            dataGridView.Rows.Add(new object[] { oServicio._id, oServicio._descripcion, oServicio._precio });
            CalcularTotales();
        }

        private bool ExisteProductoEnGrilla(string text)
        {
            foreach (DataGridViewRow fila in dataGridView.Rows)
            {
                if (fila.Cells["Descripcion"].Value.Equals(text))
                    return true;
            }
            return false;
        }
        private void CalcularTotales()
        {
            double subTotal = oAtencion.CalcularTotal();
            lblTotal.Text = subTotal.ToString();
        }
        private void RestarDetalle(double importe)
        {
            double total = Convert.ToDouble(lblTotal.Text);
            total = total - importe;
            lblTotal.Text = total.ToString();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentCell.ColumnIndex == 3)
            {
                oAtencion.QuitarDetalle(dataGridView.CurrentRow.Index);
                dataGridView.Rows.Remove(dataGridView.CurrentRow);
                CalcularTotales();
            }
        }

        private bool Validaciones()
        {
            bool flag = true;

            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un servicio como detalle", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboServicios.Focus();
                return false;
            }
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
            if (txtDni.Text == "")
            {
                MessageBox.Show("Debe ingresar el DNI", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDni.Focus();
                return false;
            }
                else if (SoloNumeros(txtDni.Text) == false) 
                {
                    MessageBox.Show("El DNI no puede contener letras", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDni.Focus();
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
            if (txtNombreMascota.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre de mascota", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return false;
            }
                else if (SoloLetras(txtNombreMascota.Text) == false)
                {
                    MessageBox.Show("El nombre de la mascota no puede contener numeros", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombreMascota.Focus();
                    return false;
                }
            if (txtEdadMascota.Text == "")
            {
                MessageBox.Show("Debe ingresar la edad de la mascota", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEdadMascota.Focus();
                return false;
            }
                else if (SoloNumeros(txtEdadMascota.Text) == false)
                {
                    MessageBox.Show("La edad no puede contener letras", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEdadMascota.Focus();
                    return false;
                }
            if (cboTiposMascotas.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un tipo de mascota", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDni.Focus();
                return false;
            }
            if (cboTipoServicio.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un tipo de servicio", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDni.Focus();
                return false;
            }
            if (cboServicios.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un servicio", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDni.Focus();
                return false;
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

        private void cargarDatos()
        {
            Mascota oMascota = servicio.GetMascotaXID(DNIcliente);
            txtNombre.Text = oMascota._cliente._nombre;
            txtDni.Text = oMascota._cliente._dni.ToString();
            txtTelefono.Text = oMascota._cliente._telefono.ToString();
            txtNombreMascota.Text = oMascota._nombre;
            txtEdadMascota.Text = oMascota._edad.ToString();
            if(oMascota._tipo._id == 1)
            {
                cboTiposMascotas.SelectedIndex = 0;
            }
            else if (oMascota._tipo._id == 2)
            {
                cboTiposMascotas.SelectedIndex = 1;
            }
            else if (oMascota._tipo._id == 3)
            {
                cboTiposMascotas.SelectedIndex = 2;
            }
            else if (oMascota._tipo._id == 4)
            {
                cboTiposMascotas.SelectedIndex = 3;
            }
            txtNombre.Enabled = false;
            txtDni.Enabled = false;
            txtTelefono.Enabled = false;
            txtNombreMascota.Enabled = false;
            txtEdadMascota.Enabled = false;
            cboTiposMascotas.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!servicio.ExisteCliente(Convert.ToInt64(txtDni.Text)))
            {
                if (Validaciones())
                {
                    oAtencion._id = Convert.ToInt32(servicio.GetProximoID("SP_PROXIMA_ATENCION"));
                    oAtencion._fecha = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                    oAtencion._total = Convert.ToDouble(oAtencion.CalcularTotal());

                    Mascota mascota = new Mascota();
                    mascota._id = Convert.ToInt32(servicio.GetProximoID("SP_PROXIMA_MASCOTA"));
                    mascota._nombre = txtNombreMascota.Text;
                    mascota._edad = Convert.ToInt32(txtEdadMascota.Text);

                    TipoMascota tipoMascota = new TipoMascota();
                    if (cboTiposMascotas.SelectedIndex == 0){tipoMascota._id = 1;}
                    else if (cboTiposMascotas.SelectedIndex == 1) { tipoMascota._id = 2; }
                    else if (cboTiposMascotas.SelectedIndex == 2) { tipoMascota._id = 3; }
                    else if (cboTiposMascotas.SelectedIndex == 3) { tipoMascota._id = 4; }
                    tipoMascota._tipoMascota = cboTiposMascotas.DisplayMember.ToString();

                    mascota._tipo = tipoMascota;

                    Cliente cliente = new Cliente();
                    cliente._id = Convert.ToInt32(servicio.GetProximoID("SP_PROXIMO_CLIENTE"));
                    cliente._nombre = txtNombre.Text;
                    cliente._telefono = Convert.ToInt64(txtTelefono.Text);
                    cliente._dni = Convert.ToInt64(txtDni.Text);
                    servicio.GuardarCliente(cliente);

                    mascota._cliente = cliente;
                    servicio.GuardarMascota(mascota);
                    oAtencion._mascota = mascota;

                    if (servicio.GuardarAtencion(oAtencion))
                    {
                        MessageBox.Show("Presupuesto guardado con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error al intentar grabar el presupuesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (Validaciones())
                {
                    Mascota mascota = servicio.GetMascotaXID(DNIcliente);

                    oAtencion._id = Convert.ToInt32(servicio.GetProximoID("SP_PROXIMA_ATENCION"));
                    oAtencion._fecha = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                    oAtencion._total = Convert.ToDouble(oAtencion.CalcularTotal());
                    oAtencion._mascota = mascota;
                    if (servicio.GuardarAtencion(oAtencion))
                    {
                        MessageBox.Show("Presupuesto guardado con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        
                    }
                    else
                    {
                        MessageBox.Show("Error al intentar grabar el presupuesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }

        public void Limpiar()
        {
            txtNombre.Text = "";
            txtDni.Text = "";
            txtTelefono.Text = "";
            txtNombreMascota.Text = "";
            txtEdadMascota.Text = "";
            cboTiposMascotas.SelectedIndex = -1;
            cboServicios.SelectedIndex = -1;
            cboTipoServicio.SelectedIndex = -1;
            dataGridView.Rows.Clear();
        }
    }
}
