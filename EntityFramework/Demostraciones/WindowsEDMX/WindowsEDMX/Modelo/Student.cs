using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEDMX.Modelo
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        //public int? Edad { get; set; }
        public Standar Standar { get; set; }



    }
}
