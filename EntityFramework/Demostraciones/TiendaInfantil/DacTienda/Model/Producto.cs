using DacTienda.Enums;

namespace DacTienda.Model
{
    public class Producto
    {
        public int ID_Producto { get; set; }
        public string CodProducto { get; set; }
        public string Tipo { get; set; }
        public CodigoGenero Sexo { get; set; }
        public string Estacion { get; set; }
        public int Talle { get; set; }
        public string Caracteristicas { get; set; }
        public int CantInicial { get; set; }
        public int CantStock { get; set; }
        public int PrecioCosto { get; set; }
        public int PrecioEfectivo { get; set; }
        public int PrecioLista { get; set; }
        public string Notas { get; set; }
    }
}
