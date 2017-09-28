using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Producto: IProducto
    {

        public Producto() { ;}
        public Producto(string pNombre, string pDescripcion, 
            decimal pPrecioCosto, double pMagen, 
            Empresa pProveedor, Categoria pCategoria, Categoria pSubcategoria )
        {
            this.Nombre = pNombre;
            this.Descripcion = pDescripcion;
            this.PrecioCosto = pPrecioCosto;
            this.Margen = pMagen;
            //this.IVA = pIVA;
            this.Proveedor = pProveedor;
            this.Categoria = pCategoria;
            this.SubCategoria = pSubcategoria;
        }
        
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        //public double IVA { get; set; }
        private static double iva=0;
        public static double IVA
        {
            get { return iva; }
            set { iva = value; }
        }
        public decimal PrecioBruto
        {
            get 
            {
                return this.PrecioCosto * (Convert.ToDecimal(1 + this.Margen));
            }
        }
        public decimal PrecioVenta
        {
            get
            {
                return this.PrecioBruto * (Convert.ToDecimal(1 + IVA));
            }
        }
        public Empresa Proveedor { get; set; }
        public Categoria Categoria { get; set; }
        public Categoria SubCategoria { get; set; }
        public DateTime FechaExpiracion { get; set; }


      
    }
}
