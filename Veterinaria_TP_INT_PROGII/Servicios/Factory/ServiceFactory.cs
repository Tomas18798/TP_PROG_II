using Servicios.Implementaciones;
using Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Factory
{
    class ServiceFactory : AbstractServiceFactory
    {
        public override IService CrearService()
        {
            return new Service();
        }
    }
}
