using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Negocio
{
    public static class admCompras
    {
        private static List<Item> lstItems = new List<Item>();

        public static decimal Total
        {
            get
            {
                decimal _Total = 0;
                foreach (Item Item in lstItems)
                {
                    _Total = _Total + Item.Importe;
                }
                return _Total;
            }
        }

        public static List<Item> Items
        {
            get
            {
                return lstItems;
            }
        }

        public static void Agregar(Item pItem)
        {
            lstItems.Add(pItem);
        }
        public static void Modificar(Guid pId, int pCantidad)
        {
            Item Elemento = lstItems.Find(Item => Item.Id == pId);
            Elemento.Cantidad = pCantidad;
        }
        public static void Eliminar(Guid pId)
        {
            Item Elemento = lstItems.Find(Item => Item.Id == pId);
            lstItems.Remove(Elemento);
        }
        public static void Cancelar()
        {
            lstItems.Clear();
        }
    }
}
