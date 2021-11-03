using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Atencion
    {
        public int _id { get; set; }
        public DateTime _fecha { get; set; }
        public Mascota _mascota { get; set; }
        public List<DetalleAtencion> _detalles { get; set; }
        public double _total { get; set; }

        public Atencion()
        {
            _mascota = new Mascota();
            _detalles = new List<DetalleAtencion>();
        }

        public void AgregarDetalle(DetalleAtencion detalle)
        {
            _detalles.Add(detalle);
        }

        public void QuitarDetalle(int nro)
        {
            _detalles.RemoveAt(nro);
        }

        public double CalcularTotal()
        {
            double total = 0;
            foreach (DetalleAtencion item in _detalles)
            {
                total += item.SubTotal();
            }
            return total;

        }

    }
}
