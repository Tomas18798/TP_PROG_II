using Entidades;
using Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_a_datos;
using Acceso_a_datos.Implementaciones;
using Acceso_a_datos.Interfaces;

namespace Servicios.Implementaciones
{
    public class Service : IService
    {
        private IVendedor VendedorDAO;
        private IAtencion AtencionDAO;

        public Service()
        {
            VendedorDAO = new VendedorDAO();
            AtencionDAO = new AtencionDAO();
        }

        // Atenciones
        public bool BorrarAtencion(int nro)
        {
            throw new NotImplementedException();
        }

        public Atencion ConsultarAtencionXID(int id)
        {
            throw new NotImplementedException();
        }
        public bool GuardarAtencion(Atencion oAtencion)
        {
            return AtencionDAO.GuardarAtencion(oAtencion);
        }
        public int ProximoIDAtencion()
        {
            throw new NotImplementedException();
        }
        // Servicios
        public List<Servicio> ConsultarServicios()
        {
            return AtencionDAO.GetServicios();
        }
        public List<Servicio> GetServicioXtipo(int tipo)
        {
            return AtencionDAO.GetServicioXtipo(tipo);
        }

        public List<TipoServicio> GetTiposServicios()
        {
            return AtencionDAO.GetTiposServicios();
        }

        // Vendedores / Usuarios
        public bool RegistrarVendedor(Vendedor oVendedor)
        {
            return VendedorDAO.RegistrarVendedor(oVendedor);
        }

        public bool VerificarUsuario(string user, string pass)
        {
            return VendedorDAO.CompareUserPass(user, pass);
        }

        // Mascotas
        public List<TipoMascota> GetTiposMascotas()
        {
            return AtencionDAO.GetTiposMascotas();
        }

        public int GetProximoID(string SP)
        {
            return AtencionDAO.GetProximoID(SP);
        }

        public bool GuardarMascota(Mascota oMascota)
        {
            return AtencionDAO.GuardarMascota(oMascota);
        }

        public bool GuardarCliente(Cliente oCliente)
        {
            return AtencionDAO.GuardarCliente(oCliente);
        }

        public List<Atencion> BuscarPorFiltro(List<Parametro> criterios)
        {
            return AtencionDAO.BuscarPorFiltro(criterios);
        }

        public List<Cliente> GetClientes()
        {
            return AtencionDAO.GetClientes();
        }

        public bool ExisteCliente(long DNI)
        {
            return AtencionDAO.ExisteCliente(DNI);
        }

        public Mascota GetMascotaXID(long DNI)
        {
            return AtencionDAO.GetMascotaXID(DNI);
        }

        public void BorrarDetalle(int id_det, int id_at)
        {
             AtencionDAO.BorrarDetalle(id_det,id_at);
        }
    }
}
