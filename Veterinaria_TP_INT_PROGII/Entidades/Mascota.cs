using System;

namespace Entidades
{
    public class Mascota
    {
        public int _id { get; set; }
        public string _nombre { get; set; }
        public int _edad { get; set; }
        public TipoMascota _tipo { get; set; }
        public Cliente _cliente { get; set; }

        public Mascota()
        {
            _cliente = new Cliente();
            _tipo = new TipoMascota();
        }
    }
}
