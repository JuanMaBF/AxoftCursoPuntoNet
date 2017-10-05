using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Item
    {
        private Guid _Id;
        private int _Cantidad = 0;
        private string _Descripcion = string.Empty;
        private decimal _PrecioUnitario = 0; 
        
        public Item(int pCantidad, string pDescripcion, decimal pPrecioUnitario)
        {
            this._Id = Guid.NewGuid();
            this.Cantidad = pCantidad;
            this.Descripcion = pDescripcion;
            this.PrecioUnitario = pPrecioUnitario;
        }

        public Guid Id 
        {
            get { return _Id; }
        }

        public int Cantidad
        {
            get { return _Cantidad; }
            set
            {
                if (value < 1)
                {
                    throw new Exception("La cantidad no puede ser menor a 1.");
                }
                _Cantidad = value;
            }
        }
        public string Descripcion
        {
            get { return _Descripcion; }
            set
            {
                if (value.Trim().Length == 0 || value.Trim().Length > 50)
                {
                    throw new Exception("La descripción debe tener una longitud comprendida entre 1 y 50 caracteres.");
                }
                _Descripcion = value.Trim();
            }
        }
        public decimal PrecioUnitario
        {
            get { return _PrecioUnitario; }
            set
            {
                if (value < Convert.ToDecimal(0.1))
                {
                    throw new Exception("El precio unitario no puede ser menor a 0.1.");
                }
                _PrecioUnitario = value;
            }
        }
        public decimal Importe
        {
            get
            {
                return this.PrecioUnitario * this.Cantidad;
            }
        }
    }
}
