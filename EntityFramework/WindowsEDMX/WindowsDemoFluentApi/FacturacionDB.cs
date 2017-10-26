using System.Data.Entity;

namespace WindowsDemoFluentApi
{
    public class FacturacionDB : DbContext
    {

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Factura> Facturas { get; set; }

        public FacturacionDB() 
            : base("KeyFacturacionDB"){
               
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Config Factura
            modelBuilder.Entity<Factura>().HasKey(f => f.FacId);
            //Config Factura-Cliente (uno a Muchos)
            modelBuilder.Entity<Factura>()
                .HasRequired(s => s.Cliente)
                .WithMany(s => s.Facturas)
                .HasForeignKey(s => s.CliId);
        }

    }
}
