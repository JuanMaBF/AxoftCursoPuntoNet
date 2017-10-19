using System.Data.Entity;

namespace WindowsEDMX.Modelo
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public SchoolContext()
            : base("KeySchoolDB")
        {
            
        }
    }
}
