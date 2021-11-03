using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Servicio
    {
        public int _id { get; set; }
        public TipoServicio _tipo { get; set; }
        public string _descripcion { get; set; }
        public double _precio { get; set; }

        public Servicio()
        {
            _tipo = new TipoServicio();
        }
    }
}
