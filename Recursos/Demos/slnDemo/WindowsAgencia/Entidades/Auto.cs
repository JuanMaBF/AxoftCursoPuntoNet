using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAgencia.Entidades
{
    public class Auto
    {
        public int IdAuto { get; set; }
        public int IdModelo { get; set; }
        public string Color { get; set; }

        public Auto(int idAuto, int idModelo, string color  )
        {
            IdAuto = idAuto;
            IdModelo = idModelo;
            Color = color;
       }
    }
}
