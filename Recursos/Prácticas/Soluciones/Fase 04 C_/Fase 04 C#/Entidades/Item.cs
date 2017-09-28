using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Item
    {
        public Item(int pCantidad, string pDescripcion, decimal pPrecioUnitario)
        {
            this.Cantidad = pCantidad;
            this.Descripcion = pDescripcion;
            this.PrecioUnitario = pPrecioUnitario;
        }

        public int Cantidad {get; set;}
        public string Descripcion { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Importe
        {
            get
            {
                return this.PrecioUnitario * this.Cantidad;
            }
        }
    }
}
