using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Decimal PrecioCosto { get; set; }
        public Double Margen { get; set; }
        public Double Iva { get; set; }
        public Decimal PrecioBruto
        {   get { return PrecioCosto * Convert.ToDecimal(1 + Margen); } }
        public Decimal PrecioVenta 
        {   get { return PrecioBruto * Convert.ToDecimal(1 + Iva); } }
        public Empresa Proveedor { get; set; }
        public Categoria Categoria { get; set; }
        public Categoria SubCategoria { get; set; }

        public Producto(
            string nombre,
            string descripcion,
            Decimal precioCosto,
            Double margen,
            Double iva,
            Empresa proveedor,
            Categoria categoria,
            Categoria subcategoria)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioCosto = precioCosto;
            Margen = margen;
            Iva = iva;
            Proveedor = proveedor;
            Categoria = categoria;
            SubCategoria = subcategoria;
        }

        public override string ToString()
        {
            return
                "Nombre=" + Nombre +
                "Descripcion=" + Descripcion +
                "PrecioCosto=" + PrecioCosto.ToString() +
                "PrecioBruto=" + PrecioBruto.ToString() +
                "PrecioVenta=" + PrecioVenta .ToString() + 
                "Margen=" + Margen.ToString() +
                "Iva=" + Iva.ToString() +
                "Proveedor=" + Proveedor +
                "Categoria=" + Categoria +
                "SubCategoria=" + SubCategoria;
        }

    }
}
