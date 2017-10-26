using System;

namespace TP2Producto.Model
{
    public class ProductCategory
    {
        public int ProductCategoryID { get; set; } //Key
        public string Name { get; set; } //ML(50)
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
