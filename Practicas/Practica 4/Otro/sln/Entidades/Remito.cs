using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Remito: DocumentoComercial
    {
        public DateTime FechaEntrega { get; set; }

        public Remito(
            string numero,
            DateTime fecha,
            string cliente,
            string direccion,
            string condicionIva,
            string condicionVenta,
            List<Item> detalle,
            DateTime fechaEntrega,
            decimal total)
            : base(numero, fecha, cliente, direccion, condicionIva, condicionVenta, detalle, total)
        {
            FechaEntrega = fechaEntrega;
        }

        public override string ToString()
        {
            return
                "Numero=" + Numero +
                "Fecha=" + Fecha.ToString() +
                "Cliente=" + Cliente +
                "Direccion=" + Direccion +
                "CondicionIVA=" + CondicionIva +
                "CondicionVenta=" + CondicionVenta +
                "Detalle=" + Detalle +
                "FechaEntrega=" + FechaEntrega.ToString() +
                "Total=" + Total.ToString();
        }

    }

}
