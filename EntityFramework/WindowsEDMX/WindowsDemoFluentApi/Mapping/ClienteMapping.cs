using System.Data.Entity.ModelConfiguration;

namespace WindowsDemoFluentApi.Mapping
{
    public class ClienteMapping : EntityTypeConfiguration<Cliente>
    {

        public ClienteMapping()
        {
            HasKey(c => c.CliId);
            Property(p => p.Nombre).IsRequired();
            Property(p => p.Nombre).HasMaxLength(50);
            Ignore(p => p.Comentario);
        }

    }
}
