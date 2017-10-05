using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Item
    {
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public Decimal PrecioUnitario { get; set; }

        public Decimal Importe
        {
            get { return (PrecioUnitario * Cantidad); }
        }

        public Item(int cantidad, string descripcion, Decimal precioUnitario)
        {
            Cantidad = cantidad;
            Descripcion = descripcion;
            PrecioUnitario = precioUnitario;
        }

    }
}
