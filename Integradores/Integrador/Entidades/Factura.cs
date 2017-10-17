using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Factura : DocumentoComercial
    {
        private string _Tipo = string.Empty;

        public Factura() { ;}
        public Factura(string pTipo, string pNumero, DateTime pFecha, string pCliente, string pDireccion, string pCondicionIVA, string pCondicionVenta, List<Item> pDetalle)
        {
            this.Tipo = pTipo;
            this.Numero = pNumero;
            this.Fecha = pFecha;
            this.Cliente = pCliente;
            this.Direccion = pDireccion;
            this.CondicionIVA = pCondicionIVA;
            this.CondicionVenta = pCondicionVenta;
            this.Detalle = pDetalle;
        }
        public Factura(int pId, string pTipo, string pNumero, DateTime pFecha, string pCliente, string pDireccion, string pCondicionIVA, string pCondicionVenta, List<Item> pDetalle)
        {
            this.Id = pId;
            this.Tipo = pTipo;
            this.Numero = pNumero;
            this.Fecha = pFecha;
            this.Cliente = pCliente;
            this.Direccion = pDireccion;
            this.CondicionIVA = pCondicionIVA;
            this.CondicionVenta = pCondicionVenta;
            this.Detalle = pDetalle;
        }
        public int Id { get; set; }
        public string Tipo
        {
            get { return _Tipo; }
            set
            {
                if (value.Trim().Length != 1)
                {
                    throw new Exception("El tipo es obligatorio y debe tener una longitud de 1 caracter.");
                }
                _Tipo = value.Trim();
            }
        }
    }
}
