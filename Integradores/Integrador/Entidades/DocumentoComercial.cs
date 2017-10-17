using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public abstract class DocumentoComercial
    {
        private string _Numero = string.Empty;
        private string _Cliente = string.Empty;
        private string _Direccion = string.Empty;

        public DocumentoComercial() { ;}

        public string Numero
        {
            get { return _Numero; }
            set
            {
                if (value.Trim().Length != 13)
                {
                    throw new Exception("El nombre debe tener una longitud de 13 caracteres.");
                }
                _Numero = value.Trim();
            }
        }
        public DateTime Fecha { get; set; }
        public string Cliente
        {
            get { return _Cliente; }
            set
            {
                if (value.Trim().Length == 0 || value.Trim().Length > 100)
                {
                    throw new Exception("El nombre debe tener una longitud comprendida entre 1 y 100 caracteres.");
                }
                _Cliente = value.Trim();
            }
        }
        public string Direccion
        {
            get { return _Direccion; }
            set
            {
                if (value.Trim().Length < 15 || value.Trim().Length > 100)
                {
                    throw new Exception("La dirección debe tener una longitud comprendida entre 15 y 100 caracteres.");
                }
                _Direccion = value.Trim();
            }
        }
        public string CondicionIVA { get; set; }
        public string CondicionVenta { get; set; }
        public List<Item> Detalle { get; set; }
        public decimal Total
        {
            get
            {
                decimal _Total = 0;
                foreach (Item obj in Detalle)
                {
                    _Total = _Total + obj.Importe;
                }
                return _Total;
            }
        }
    }
}
