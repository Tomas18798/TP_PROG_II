using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleAtencion
    {
        public Servicio _servicio { get; set; }
        public int _id { get; set; }

        public DetalleAtencion()
        {
            _servicio = new Servicio();
        }

        public double SubTotal()
        {
            return _servicio._precio;
        }
    }
}
