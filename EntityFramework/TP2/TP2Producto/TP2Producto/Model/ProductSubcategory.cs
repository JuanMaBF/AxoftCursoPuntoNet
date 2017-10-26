using System;

namespace TP2Producto.Model
{
    public class ProductSubcategory
    {
        public int ProductSubcategoryID { get; set; } //Key
        public int ProductCategoryID { get; set; }
        public string Name { get; set; } //ML(50)
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
