using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Acceso_a_datos.Interfaces
{
    public interface IVendedor
    {
        List<Vendedor> GetVendedores();
        bool CompareUserPass(string user, string pass);
        bool RegistrarVendedor(Vendedor oVendedor);
    }
}
