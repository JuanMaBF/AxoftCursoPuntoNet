using System;

namespace DacTienda.Model
{
    public class Ventas
    {
        public int ID_Ventas { get; set; }
        public DateTime FechaVenta { get; set; }
        public int Cantidad { get; set; }
        public Producto Producto { get; set; }
        public string Tipo { get; set; }
        public bool PrecioEfectivo { get; set; }
        public bool PagoEfectivo { get; set; }
        public int Total { get; set; }
    }
}
