using System.Data.Entity.ModelConfiguration;
using TP2Producto.Model;

namespace TP2Producto.Mapping
{
    public class ProductMapping : EntityTypeConfiguration<Product>
    {
        public ProductMapping()
        {
            HasKey(p => p.ProductID);
            Property(p => p.Name).HasMaxLength(50);
            Property(p => p.Color).HasMaxLength(15);
            Property(p => p.Size).HasMaxLength(5);
            Property(p => p.SizeUnitMeasureCode).HasMaxLength(3);
            Property(p => p.WeightUnitMeasureCode).HasMaxLength(3);
            Property(p => p.ProductLine).HasMaxLength(3);
        }
    }
}
