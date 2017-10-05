using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DocumentoComercial
    {
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string CondicionIva { get; set; }
        public string CondicionVenta { get; set; }
        public List<Item> Detalle { get; set; }
        public decimal Total
        {
            get { return Detalle.Sum(i => i.Importe); }
        }

        public DocumentoComercial(
            string numero,
            DateTime fecha,
            string cliente,
            string direccion,
            string condicionIva,
            string condicionVenta,
            List<Item> detalle,
            decimal total)
        {
            Numero = numero;
            Fecha = fecha;
            Cliente = cliente;
            Direccion = direccion;
            CondicionIva = condicionIva;
            CondicionVenta = condicionVenta;
            Detalle = detalle;
        }
    }
}
