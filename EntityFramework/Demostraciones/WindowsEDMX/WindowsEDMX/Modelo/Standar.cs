using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEDMX.Modelo
{
    public class Standar
    {
        public int Id { get; set; }
        public string StandarName { get; set; }
        public List<Student> Students { get; set; }

    }
}
