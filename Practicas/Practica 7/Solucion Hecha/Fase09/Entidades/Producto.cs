using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Producto
    {
        private string _Nombre = string.Empty;
        private string _Descripcion = string.Empty;
        private decimal _PrecioCosto = 0;

        public Producto() { ;}
        public Producto(int pId, string pNombre)
        {
            this.Id = pId;
            this.Nombre = pNombre;
        }
        public Producto(string pNombre, string pDescripcion, decimal pPrecioCosto, double pMagen, Empresa pProveedor, Categoria pCategoria, Categoria pSubcategoria)
        {
            this.Nombre = pNombre;
            this.Descripcion = pDescripcion;
            this.PrecioCosto = pPrecioCosto;
            this.Margen = pMagen;
            this.Proveedor = pProveedor;
            this.Categoria = pCategoria;
            this.SubCategoria = pSubcategoria;
        }
        public Producto(int pId, string pNombre, string pDescripcion, decimal pPrecioCosto, double pMagen, Empresa pProveedor, Categoria pCategoria, Categoria pSubcategoria )
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Descripcion = pDescripcion;
            this.PrecioCosto = pPrecioCosto;
            this.Margen = pMagen;
            this.Proveedor = pProveedor;
            this.Categoria = pCategoria;
            this.SubCategoria = pSubcategoria;
        }

        public int Id { get; set; }
        public string Nombre
        {
            get { return _Nombre; }
            set
            {
                if (value.Trim().Length == 0 || value.Trim().Length > 50)
                {
                    throw new Exception("El nombre debe tener una longitud comprendida entre 1 y 50 caracteres.");
                }
                _Nombre = value.Trim();
            }
        }
        public string Descripcion
        {
            get { return _Descripcion; }
            set
            {
                if (value.Trim().Length > 500)
                {
                    throw new Exception("La descripción debe tener una longitud máxima de 500 caracteres.");
                }
                _Descripcion = value.Trim();
            }
        }
        public decimal PrecioCosto
        {
            get { return _PrecioCosto; }
            set
            {
                if (value < Convert.ToDecimal(0.1))
                {
                    throw new Exception("El precio de costo no puede ser menor a 0.1.");
                }
                _PrecioCosto = value;
            }
        }
        public double Margen { get; set; }
        public static double IVA { get; set; }
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

        public string ViewProveedor
        {
            get 
            {
                if (this.Proveedor != null)
                { 
                    return this.Proveedor.Nombre; 
                }
                return string.Empty;
            }
        }
        public string ViewCategoria
        {
            get
            {
                if (this.Categoria != null)
                {
                    return this.Categoria.Nombre;
                }
                return string.Empty;
            }
        }
        public string ViewSubcategoria
        {
            get 
            { 
                if (this.SubCategoria != null)
                {
                    return this.SubCategoria.Nombre; 
                }
                return string.Empty;  
            }
        }
    }
}
