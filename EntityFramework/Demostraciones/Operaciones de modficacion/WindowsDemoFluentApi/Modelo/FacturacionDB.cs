using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;//entityframework
using WindowsDemoFluentApi.Modelo.Mapping;

namespace WindowsDemoFluentApi.Modelo
{
    public class FacturacionDB:DbContext
    {
        public FacturacionDB() : base("KeyFacturacionDB")
        { }

        public DbSet<Cliente> Clientes{ get; set; }
        public DbSet<Factura> Facturas{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //pk
            //modelBuilder.Entity<Cliente>().HasKey(c => c.CliId);
          modelBuilder.Entity<Factura>().HasKey(c => c.FactId);

            //modelBuilder.Entity<Cliente>().Property(p => p.Nombre).IsRequired();
           // modelBuilder.Entity<Cliente>().Property(p => p.Nombre).HasMaxLength(50);
           // modelBuilder.Entity<Cliente>().Ignore(i => i.Comentario);
           modelBuilder.Configurations.Add(new ClienteMapping());
            //relacion de uno a mucho 
            modelBuilder.Entity<Factura>()
                .HasRequired<Cliente>(s => s.Cliente)
                .WithMany(s => s.Facturas)
                .HasForeignKey(s => s.CliId);


            base.OnModelCreating(modelBuilder);
        }
    }
}
