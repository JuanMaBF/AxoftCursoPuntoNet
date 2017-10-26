using System.Data.Entity.ModelConfiguration;
using TP2Producto.Model;

namespace TP2Producto.Mapping
{
    public class ProductSubcategoryMapping : EntityTypeConfiguration<ProductSubcategory>
    {

        public ProductSubcategoryMapping()
        {
            HasKey(s => s.ProductSubcategoryID);
            Property(s => s.Name).HasMaxLength(50);
        }

    }
}
