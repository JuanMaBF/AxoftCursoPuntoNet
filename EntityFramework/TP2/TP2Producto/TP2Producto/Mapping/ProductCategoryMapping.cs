using System.Data.Entity.ModelConfiguration;
using TP2Producto.Model;

namespace TP2Producto.Mapping
{
    class ProductCategoryMapping : EntityTypeConfiguration<ProductCategory>
    {

        public ProductCategoryMapping()
        {
            HasKey(c => c.ProductCategoryID);
            Property(c => c.Name).HasMaxLength(50);
        }

    }
}
