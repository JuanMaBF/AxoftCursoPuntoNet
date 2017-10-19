using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WindowsEDMX.Modelo
{
    public class SchoolContext:DbContext
    {
        public SchoolContext() : base("KeySchoolDB")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Standar> Standars { get; set; }
    }
}
