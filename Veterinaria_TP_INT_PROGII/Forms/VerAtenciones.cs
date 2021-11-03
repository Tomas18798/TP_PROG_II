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
    public partial class VerAtenciones : Form
    {


        private IService servicio;
        public VerAtenciones()
        {
            InitializeComponent();
            servicio = new Service();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<Parametro> filtros = new List<Parametro>();

            object val = DBNull.Value;
            if (!String.IsNullOrEmpty(txtNombreCliente.Text))
                val = txtNombreCliente.Text;
            filtros.Add(new Parametro("@nombre", val));

            Int64 val2 = Convert.ToInt64(txtdni.Text);
            filtros.Add(new Parametro("@DNI", val2));

            List<Atencion> lista = servicio.BuscarPorFiltro(filtros);

            dataGridView1.Rows.Clear();


            foreach (Atencion oAtencion in lista)
            {
                lblTelefono.Text = "Telefono:              " + oAtencion._mascota._cliente._telefono.ToString();
                lblNombreMascota.Text = "Nombre: " + oAtencion._mascota._nombre.ToString();
                lblTipoMascota.Text = "Tipo: " + oAtencion._mascota._tipo._tipoMascota.ToString();
                lblEdadMascota.Text = "Edad: " + oAtencion._mascota._edad.ToString();
                txtNombreCliente.Text = oAtencion._mascota._cliente._nombre;
                txtdni.Text = oAtencion._mascota._cliente._dni.ToString();
                int contador = 0;
                foreach (DetalleAtencion detalle in oAtencion._detalles)
                {

                    dataGridView1.Rows.Add(new object[] {
                           oAtencion._id,
                           detalle._id,
                           oAtencion._fecha.ToString("dd/MM/yyyy"),
                           detalle._servicio._tipo._tipoServicio,
                           detalle._servicio._descripcion,
                           detalle._servicio._precio
                    });
                    contador = dataGridView1.Rows.Count - 1;
                    //if(detalle._id == detalle._id)
                    //{
                    //    dataGridView1.Rows.RemoveAt(contador);
                    //}
                }

            }
        }

        private void VerAtenciones_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevaAtencion frm = new NuevaAtencion(Convert.ToInt64(txtdni.Text),true);
            frm.ShowDialog();            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentCell.ColumnIndex == 6)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea borrar el detalle?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    servicio.BorrarDetalle(Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString()), Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                }
                
            }
        }
    }
}
