using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Servicios.Interfaces
{
    public interface IService
    {
        // Atenciones
        bool GuardarAtencion(Atencion oAtencion);
        bool BorrarAtencion(int nro);

        List<Atencion> BuscarPorFiltro(List<Parametro> criterios);
        int ProximoIDAtencion();
        Atencion ConsultarAtencionXID(int id);

        // Servicios
        List<Servicio> ConsultarServicios();
        List<Servicio> GetServicioXtipo(int tipo);
        List<TipoServicio> GetTiposServicios();
        // Usuarios
        bool RegistrarVendedor(Vendedor oVendedor);
        bool VerificarUsuario(string user, string pass);
        // Mascotas
        //List<Mascota> GetMascotas();
        //Mascota GetMascotaXID(int id);
        List<TipoMascota> GetTiposMascotas();
        bool GuardarMascota(Mascota oMascota);

        bool GuardarCliente(Cliente oCliente);
        List<Cliente> GetClientes();
        public int GetProximoID(string SP);
        public Mascota GetMascotaXID(Int64 DNI);
        public bool ExisteCliente(Int64 DNI);

        void BorrarDetalle(int id_det, int id_at);
    }
}
