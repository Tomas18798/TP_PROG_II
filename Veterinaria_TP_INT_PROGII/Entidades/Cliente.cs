using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        public int _id { get; set; }
        public string _nombre { get; set; }
        public Int64 _dni { get; set; }
        public Int64 _telefono { get; set; }

        public Cliente()
        {

        }
    }
}
