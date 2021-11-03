using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Parametro
    {
        public string _nombre { get; set; }
        public object _valor { get; set; }

        public Parametro()
        {

        }


        public Parametro(string nombre, object valor)
        {
            _nombre = nombre;
            _valor = valor;
        }
    }
}
