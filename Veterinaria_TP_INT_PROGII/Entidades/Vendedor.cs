using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor
    {
        public int _id { get; set; }
        public string _nombre { get; set; }
        public string _apellido { get; set; }
        public Int64 _telefono { get; set; }
        public string _mail { get; set; }
        public string _usuario { get; set; }
        public string _contraseña { get; set; }

        public Vendedor()
        {

        }
    }
}
