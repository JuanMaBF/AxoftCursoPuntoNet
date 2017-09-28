using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibSeguridad
{
    public class Circulo : Figura
    {
        public override double superficie(double prValor)
        {
            return Math.PI + Math.Pow(prValor, 2);
        }
    }
}
