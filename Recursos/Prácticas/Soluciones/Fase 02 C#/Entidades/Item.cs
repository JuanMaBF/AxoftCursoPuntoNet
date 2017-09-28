using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Item
    {
        public Item(int cantidad, string descripcion, decimal precioUnitario)
        {
            this.cantidad = cantidad;
            this.descripcion = descripcion;
            this.precioUnitario = precioUnitario;
        
        }
        
        private int cantidad;
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        
        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        
        
        
        private decimal precioUnitario;
        public decimal PrecioUnitario
        {
            get { return precioUnitario; }
            set { precioUnitario = value; }
        }
        
        
        private decimal Importe;
        public decimal Importe1
        {
            get { return Importe; }
           
        }

    }
}
