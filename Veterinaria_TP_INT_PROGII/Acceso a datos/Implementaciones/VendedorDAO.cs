using Acceso_a_datos.Interfaces;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Acceso_a_datos.Implementaciones
{
    public class VendedorDAO : IVendedor
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-9AQR2QIE\SQLEXPRESS01;Initial Catalog=veterinaria_prog2;Integrated Security=True");

        public bool CompareUserPass(string user, string pass)
        {
            bool flag = false;
            List<Vendedor> usuarios = new List<Vendedor>();
            conexion.Open();
            SqlCommand comando = new SqlCommand("SP_MOSTRAR_USUARIOS", conexion);
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            foreach (DataRow row in tabla.Rows)
            {
                Vendedor oVendedor = new Vendedor();
                oVendedor._usuario = row["usuario"].ToString();
                oVendedor._contraseña = row["pass"].ToString();

                usuarios.Add(oVendedor);
            }
            foreach(Vendedor usuario in usuarios)
            {
                if(usuario._usuario == user && usuario._contraseña == pass)
                {
                    flag = true;
                    break;
                }
            }



            return flag;
        }

        public List<Vendedor> GetVendedores()
        {
            List<Vendedor> vendedores = new List<Vendedor>();
            conexion.Open();
            SqlCommand comando = new SqlCommand("SP_CONSULTAR_VENDEDORES", conexion);
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();

            foreach(DataRow row in tabla.Rows)
            {
                Vendedor oVendedor = new Vendedor();
                oVendedor._id = Convert.ToInt32(row["id_vendedor"].ToString());
                oVendedor._nombre = row["nombre"].ToString();
                oVendedor._apellido = row["apellido"].ToString();
                oVendedor._telefono = Convert.ToInt64(row["tel"].ToString());
                oVendedor._mail = row["mail"].ToString();
                oVendedor._usuario = row["usuario"].ToString();
                oVendedor._contraseña = row["pass"].ToString();

                vendedores.Add(oVendedor);
            }
            return vendedores;
        }

        public bool RegistrarVendedor(Vendedor oVendedor)
        {
            SqlTransaction transaccion = null;
            
            bool flag = true;
            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand("SP_REGISTRAR_VENDEDOR", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                
                comando.Parameters.AddWithValue("@nombre",oVendedor._nombre);
                comando.Parameters.AddWithValue("@apellido", oVendedor._apellido);
                comando.Parameters.AddWithValue("@telefono", oVendedor._telefono);
                comando.Parameters.AddWithValue("@mail", oVendedor._mail);
                comando.Parameters.AddWithValue("@usuario", oVendedor._usuario);
                comando.Parameters.AddWithValue("@pass", oVendedor._contraseña);
                comando.ExecuteNonQuery();

                transaccion.Commit();
            }
            catch
            {
                transaccion.Rollback();
                flag = false;
            }
            finally
            {
                if(conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return flag;

        }
    }
}
