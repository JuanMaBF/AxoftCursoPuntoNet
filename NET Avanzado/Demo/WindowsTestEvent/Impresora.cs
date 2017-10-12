using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsTestEvent
{
    public class Impresora
    {
        //declaración del evento
        public event EventHandler ImpresionOK;

        private string _texto;
        public Impresora(string texto)
        {
            this._texto = texto;
        }

        public void Imprimir()
        {
           // Console.Write(this._texto);
            //invocación del evento
            if(ImpresionOK!=null)
            { ImpresionOK(_texto, null);}
            

        }

    }
}
