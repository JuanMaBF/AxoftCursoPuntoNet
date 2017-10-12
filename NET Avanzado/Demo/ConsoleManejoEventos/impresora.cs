using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleManejoEventos
{
    class impresora
    {
        private string _texto;

        //declaración del evento
        public event EventHandler ImpresionOK;

        public impresora(string texto)
        {
            this._texto = texto;
        }

        public void Imprimir()
        {
            Console.Write(this._texto);
            //invocación del evento
            ImpresionOK(_texto, null);
        
        }

    }
}
