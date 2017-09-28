using System;

namespace Entidades
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public double IVA { get; set; }
        public decimal PrecioBruto { get { return PrecioCosto + Convert.ToDecimal(1 + Margen); } }
        public decimal PrecioVenta { get { return PrecioBruto + Convert.ToDecimal(1 + IVA); } }
        public string Proveedor { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }

        public Producto(string nombre, string descripcion, decimal precioCosto, double margen, double iva, string proveedor,
            string categoria, string subCategoria)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioCosto = precioCosto;
            Margen = margen;
            IVA = iva;
            Proveedor = proveedor;
            Categoria = categoria;
            SubCategoria = subCategoria;
        }

    }
}
