using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Datos;

namespace Negocio
{
    public class admDocumentosComerciales
    {
        public static void Generar(Factura pFactura, Remito pRemito)
        {
            dbFacturas.Generar(pFactura);
            dbRemitos.Generar(pRemito);
        }

        public static List<Factura> ListarFacturas(Enumeraciones.Enumeraciones.ColumnasDocumentosComerciales pOrden)
        {
            return dbFacturas.Listar(pOrden);
        }
        public static List<Remito> ListarRemitos(Enumeraciones.Enumeraciones.ColumnasDocumentosComerciales pOrden)
        {
            return dbRemitos.Listar(pOrden);
        }
    }
}
