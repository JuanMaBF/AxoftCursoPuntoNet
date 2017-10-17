using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enumeraciones
{
    public static class Enumeraciones
    {
        public enum CondicionesIVA
        {
            ConsumidorFinal,
            Exento,
            NoResponsable,
            ResponsableInscripto,
            ResponsableNoInscripto,
            ResponsableMonotributo
        }
        public enum CondicionesVenta
        {
            Contado,
            CuentaCorrriente
        }
        public enum ColumnasDocumentosComerciales
        {
            Cliente,
            FechaAscendente,
            FechaDescendente
        }
        public enum TiposFacturas
        {
            A,
            B,
            C,
            E,
            X
        }
       
        public static List<CondicionesIVA> ListarCondicionesIVA()
        {
            return Enum.GetValues(typeof(CondicionesIVA)).Cast<CondicionesIVA>().ToList();
        }

        public static List<CondicionesVenta> ListarCondicionesVenta()
        {
            return Enum.GetValues(typeof(CondicionesVenta)).Cast<CondicionesVenta>().ToList();
        }

        public static List<TiposFacturas> ListarTiposFacturas()
        {
            return Enum.GetValues(typeof(TiposFacturas)).Cast<TiposFacturas>().ToList();
        }
    }
    
    
}
