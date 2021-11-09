using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Acceso_a_datos.Interfaces
{
    public interface IAtencion
    {
        // Atencion
        bool GuardarAtencion(Atencion oAtencion);
        bool Borrar(int nro);
        List<Atencion> BuscarPorFiltro(List<Parametro> criterios);
        int GetNextAtencionID();
        Atencion GetxID(int id);

        void BorrarDetalle(int id_det, int id_at);
        //List<DetalleAtencion> GetDetalleXID(int id_atencion);
        // Servicios
        List<Servicio> GetServicios();
        List<Servicio> GetServicioXtipo(int tipo);
        List<TipoServicio> GetTiposServicios();
        // Mascota
        List<Mascota> GetMascotas();

        Mascota GetMascotaXID(Int64 DNI);

        List<TipoMascota> GetTiposMascotas();
        bool GuardarMascota(Mascota oMascota);

        bool GuardarCliente(Cliente oCliente);
        List<Cliente> GetClientes();
        int GetProximoID(string SP);
        public bool ExisteCliente(Int64 DNI);

        bool GuardarServicio(Servicio oServicio);
        bool ActualizarServicio(int id_servicio, Servicio oServicio);
        void Borrarservicio(int id_servicio);

    }
}
