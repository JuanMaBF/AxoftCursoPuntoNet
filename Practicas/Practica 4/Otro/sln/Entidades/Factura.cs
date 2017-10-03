using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura: DocumentoComercial
    {
        public String Tipo { get; set; }

        public Factura(
            string tipo,
            string numero,
            DateTime fecha,
            string cliente,
            string direccion,
            string condicionIva,
            string condicionVenta,
            List<Item> detalle,
            decimal total)
            : base(numero, fecha, cliente, direccion, condicionIva, condicionVenta, detalle, total)
        {
            Tipo = tipo;
        }

        public override string ToString()
        {
            return
                "Tipo=" + Tipo +
                "Numero=" + Numero +
                "Fecha=" + Fecha.ToString() +
                "Cliente=" + Cliente +
                "Direccion=" + Direccion +
                "CondicionIva=" + CondicionIva +
                "CondicionVenta=" + CondicionVenta +
                "Detalle=" + Detalle +
                "Total=" + Total.ToString();
        }

    }
}
