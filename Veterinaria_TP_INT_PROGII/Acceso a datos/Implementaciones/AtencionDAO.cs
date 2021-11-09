using Acceso_a_datos.Interfaces;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_a_datos.Implementaciones
{
    public class AtencionDAO : IAtencion
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-9AQR2QIE\SQLEXPRESS01;Initial Catalog=veterinaria_prog2;Integrated Security=True");

        // ATENCIONES
        public bool Borrar(int nro)
        {
            throw new NotImplementedException();
        }
        public List<Atencion> BuscarPorFiltro(List<Parametro> criterios)
        {
            List<Atencion> lista = new List<Atencion>();
            DataTable tabla = new DataTable();
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SP_MOSTRAR_ATENCION", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                foreach (Parametro p in criterios)
                {
                    comando.Parameters.AddWithValue(p._nombre, p._valor);
                }
                tabla.Load(comando.ExecuteReader());

                foreach (DataRow row in tabla.Rows)
                {
                    Atencion oAtencion = new Atencion();
                    oAtencion._id = Convert.ToInt32(row[0].ToString());
                    oAtencion._fecha = Convert.ToDateTime(row[1].ToString());
                    oAtencion._total = Convert.ToDouble(row[3].ToString());

                    Mascota oMascota = new Mascota();
                    oMascota._id = Convert.ToInt32(row[4].ToString());
                    oMascota._nombre = row[5].ToString();
                    oMascota._edad = Convert.ToInt32(row[6].ToString());

                    TipoMascota tipoMascota = new TipoMascota();
                    tipoMascota._id = Convert.ToInt32(row[9].ToString());
                    tipoMascota._tipoMascota = row[10].ToString();

                    oMascota._tipo = tipoMascota;

                    Cliente oCliente = new Cliente();
                    oCliente._id = Convert.ToInt32(row[11].ToString());
                    oCliente._nombre = row[13].ToString();
                    oCliente._telefono = Convert.ToInt64(row[15].ToString());
                    oCliente._dni = Convert.ToInt64(row[14].ToString());

                    oMascota._cliente = oCliente;
                    oAtencion._mascota = oMascota;

                    DetalleAtencion detalle = new DetalleAtencion();
                    TipoServicio tipoServicio = new TipoServicio();
                    Servicio servicio = new Servicio();

                    SqlCommand comando1 = new SqlCommand("SP_CONSULTAR_DETALLES", conexion);
                    comando1.CommandType = CommandType.StoredProcedure;
                    comando1.Parameters.AddWithValue("@id_atencion", oAtencion._id);
                    DataTable tabla1 = new DataTable();
                    tabla1.Load(comando1.ExecuteReader());

                    foreach(DataRow row1 in tabla1.Rows)
                    {
                        detalle._id = Convert.ToInt32(row1[0].ToString());
                        tipoServicio._id= Convert.ToInt32(row1[11].ToString());
                        tipoServicio._tipoServicio= row1[12].ToString();
                        servicio._tipo = tipoServicio;
                        servicio._id= Convert.ToInt32(row1[7].ToString());
                        servicio._descripcion=row1[9].ToString();
                        servicio._precio= Convert.ToDouble(row1[10].ToString());
                        detalle._servicio = servicio;

                        oAtencion.AgregarDetalle(detalle);
                    }
                    lista.Add(oAtencion);
                }
                conexion.Close();
            }
            catch (SqlException)
            {
                throw;
            }
            return lista;
        }

        public int GetNextAtencionID()
        {
            throw new NotImplementedException();
        }
        public Atencion GetxID(int id)
        {
            throw new NotImplementedException();
        }
        public bool GuardarAtencion(Atencion oAtencion)
        {


            SqlTransaction transaccion = null;
            bool flag = true;
            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();


                SqlCommand comando = new SqlCommand("SP_INSERTAR_ATENCION",conexion,transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@mascota", oAtencion._mascota._id);
                comando.Parameters.AddWithValue("@total", oAtencion._total);
                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@atencion_nro";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parametro);

                comando.ExecuteNonQuery();

                int atencion_nro = (int)parametro.Value;
                

                foreach (DetalleAtencion det in oAtencion._detalles)
                {
                    SqlCommand cmd = new SqlCommand("SP_INSERTAR_DETALLE", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = transaccion;
                    cmd.Parameters.AddWithValue("@atencion_nro", atencion_nro);
                    cmd.Parameters.AddWithValue("@servicio ", det._servicio._id);
                    cmd.ExecuteNonQuery();
                }

                transaccion.Commit();
            }
            catch(Exception)
            {
                  
                transaccion.Rollback();
                flag = false;              
                throw;


            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();

            }
            return flag;
        }

        //public List<DetalleAtencion> GetDetalleXID(int id_atencion)
        //{
        //    List<DetalleAtencion> detalles = new List<DetalleAtencion>();
        //    conexion.Open();
        //    SqlCommand comando = new SqlCommand("SP_CONSULTAR_DETALLES",conexion);
        //    comando.CommandType = CommandType.StoredProcedure;
        //    comando.Parameters.AddWithValue("@nro", id_atencion);
        //    DataTable tabla = new DataTable();
        //    tabla.Load(comando.ExecuteReader());
        //    conexion.Close();


        //}
        // SERVICIOS

        public List<Servicio> GetServicios()
        {
            List<Servicio> servicios = new List<Servicio>();

            conexion.Open();
            SqlCommand comando = new SqlCommand("SP_MOSTRAR_SERVICIOS", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();

            foreach (DataRow row in tabla.Rows)
            {
                Servicio oServicio = new Servicio();
                oServicio._id = Convert.ToInt32(row["id_servicio"].ToString());

                TipoServicio oTipoServicio = new TipoServicio();
                oTipoServicio._id = Convert.ToInt32(row["id_tipo"].ToString());
                oTipoServicio._tipoServicio = row["servicio"].ToString();

                oServicio._tipo = oTipoServicio;
                oServicio._descripcion = row["descripcion"].ToString();
                oServicio._precio = Convert.ToDouble(row["precio"].ToString()); 

                servicios.Add(oServicio);
            }

            return servicios;
        }

        public List<Servicio> GetServicioXtipo(int tipo)
        {
            List<Servicio> servicios = new List<Servicio>();
            conexion.Open();
            string sql = $"select id_servicio,descripcion,precio from servicios where tipo={tipo}";
            SqlCommand comando = new SqlCommand(sql, conexion);
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();

            foreach (DataRow row in tabla.Rows)
            {
                Servicio oServicio = new Servicio();
                oServicio._id = Convert.ToInt32(row["id_servicio"].ToString());
                oServicio._descripcion = row["descripcion"].ToString();
                oServicio._precio = Convert.ToDouble(row["precio"].ToString());

                servicios.Add(oServicio);
            }
            return servicios;
        }

        public List<TipoServicio> GetTiposServicios()
        {
            List<TipoServicio> tiposServicios = new List<TipoServicio>();
            conexion.Open();
            string sql = "select id_tipo,servicio from tipo_servicios";
            SqlCommand comando = new SqlCommand(sql, conexion);
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();

            foreach (DataRow row in tabla.Rows)
            {
                TipoServicio oTipoServicio = new TipoServicio();
                oTipoServicio._id = Convert.ToInt32(row["id_tipo"].ToString());
                oTipoServicio._tipoServicio = row["servicio"].ToString();

                tiposServicios.Add(oTipoServicio);
            }
            return tiposServicios;
        }

        // MASCOTAS

        public List<Mascota> GetMascotas()
        {
            throw new NotImplementedException();
        }

        public Mascota GetMascotaXID(Int64 DNI)
        {
            Mascota oMascota = new Mascota();
            conexion.Open();
            SqlCommand comando = new SqlCommand("SP_CargarDatos",conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@dni", DNI);
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();

            foreach (DataRow row in tabla.Rows)
            {
                oMascota._id = Convert.ToInt32(row[5].ToString());
                oMascota._nombre = row[6].ToString();
                oMascota._edad = Convert.ToInt32(row[7].ToString());
                Cliente oCliente = new Cliente();
                oCliente._id = Convert.ToInt32(row[0].ToString());
                oCliente._nombre = row[2].ToString();
                oCliente._telefono = Convert.ToInt64(row[4].ToString());
                oCliente._dni = Convert.ToInt64(row[3].ToString());
                oMascota._cliente = oCliente;
                TipoMascota oTipo = new TipoMascota();
                oTipo._id = Convert.ToInt32(row[10].ToString());
                oTipo._tipoMascota= row[11].ToString();
                oMascota._tipo = oTipo;
            }
            return oMascota;
        }

        public List<TipoMascota> GetTiposMascotas()
        {
            List<TipoMascota> tiposMascotas = new List<TipoMascota>();
            conexion.Open();
            string sql = "select id_tipo,tipo from tipo_mascotas";
            SqlCommand comando = new SqlCommand(sql, conexion);
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();

            foreach (DataRow row in tabla.Rows)
            {
                TipoMascota oTipoMascota = new TipoMascota();
                oTipoMascota._id = Convert.ToInt32(row["id_tipo"].ToString());
                oTipoMascota._tipoMascota = row["tipo"].ToString();

                tiposMascotas.Add(oTipoMascota);
            } 

            return tiposMascotas;
        }

        public int GetProximoID(string SP)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand(SP, conexion);
            comando.CommandType = CommandType.StoredProcedure;

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@next";
            parametro.SqlDbType = SqlDbType.Int;
            parametro.Direction = ParameterDirection.Output;

            comando.Parameters.Add(parametro);
            comando.ExecuteNonQuery();
            conexion.Close();

            return (int)parametro.Value;
        }

        public bool GuardarMascota(Mascota oMascota)
        {
            bool flag;
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SP_INSERTAR_MASCOTA", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombre", oMascota._nombre);
                comando.Parameters.AddWithValue("@edad", oMascota._edad);
                comando.Parameters.AddWithValue("@duenio", oMascota._cliente._id);
                comando.Parameters.AddWithValue("@tipo", oMascota._tipo._id);
                comando.ExecuteNonQuery();

                flag = true;
            }
            catch (Exception)
            {
                flag = false;
                throw;


            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();

            }
            return flag;
        }

        public bool GuardarCliente(Cliente oCliente)
        {
            bool flag;
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SP_INSERTAR_CLIENTE", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombre", oCliente._nombre);
                comando.Parameters.AddWithValue("@DNI", oCliente._dni);
                comando.Parameters.AddWithValue("@tel", oCliente._telefono);
                comando.ExecuteNonQuery();

                flag = true;
            }
            catch (Exception)
            {               
                flag = false;
                throw;


            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();

            }
            return flag;
        }

        public List<Cliente> GetClientes()
        {
            List<Cliente> lista = new List<Cliente>();
            conexion.Open();
            string sql = "select * from clientes";
            SqlCommand comando = new SqlCommand(sql, conexion);
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();

            foreach (DataRow row in tabla.Rows)
            {
                Cliente oCliente = new Cliente();
                oCliente._id = Convert.ToInt32(row[0].ToString());
                oCliente._nombre = row[2].ToString();
                oCliente._telefono = Convert.ToInt64(row[4].ToString());
                oCliente._dni = Convert.ToInt64(row[3].ToString());

                lista.Add(oCliente);
            }

            return lista;
        }

        public bool ExisteCliente(Int64 DNI)
        {
            List<Cliente> lista = GetClientes();
            bool flag = false;

            foreach(Cliente clientes in lista)
            {
                Cliente oCliente = new Cliente();
                oCliente._dni = clientes._dni;
                if(oCliente._dni == DNI)
                {
                    flag = true;
                    break;
                }
            }

            return flag;
        }

        public void BorrarDetalle(int id_det,int id_at)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("SP_BorrarDetalle", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id2", id_det);
            comando.Parameters.AddWithValue("@id1", id_at);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void Borrarservicio(int id_servicio)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("SP_BORRAR_SERVICIO", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_servicio", id_servicio);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public bool GuardarServicio(Servicio oServicio)
        {
            bool flag;
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SP_GUARDAR_SERVICIO", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@tipo", oServicio._tipo._id);
                comando.Parameters.AddWithValue("@descripcion", oServicio._descripcion);
                comando.Parameters.AddWithValue("@precio", oServicio._precio);
                comando.ExecuteNonQuery();

                flag = true;
            }
            catch (Exception)
            {
                flag = false;
                throw;


            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();

            }
            return flag;
        }

        public bool ActualizarServicio(int id_servicio,Servicio oServicio)
        {
            bool flag;
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SP_EDITAR_SERVICIO", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", id_servicio);
                comando.Parameters.AddWithValue("@tipo", oServicio._tipo._id);
                comando.Parameters.AddWithValue("@descripcion", oServicio._descripcion);
                comando.Parameters.AddWithValue("@precio", oServicio._precio);
                comando.ExecuteNonQuery();

                flag = true;
            }
            catch (Exception)
            {
                flag = false;
                throw;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return flag;
        }
    }
}
