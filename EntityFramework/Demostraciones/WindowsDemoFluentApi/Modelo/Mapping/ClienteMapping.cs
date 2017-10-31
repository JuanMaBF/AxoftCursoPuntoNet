using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace WindowsDemoFluentApi.Modelo.Mapping
{
   public class ClienteMapping:EntityTypeConfiguration<Cliente>
    {

        public ClienteMapping()
        {
            this.HasKey(c => c.CliId);
            this.Property(p => p.Nombre).IsRequired();
            this.Property(p => p.Nombre).HasMaxLength(50);
            this.Ignore(p => p.Comentario);

        }

    }
}
