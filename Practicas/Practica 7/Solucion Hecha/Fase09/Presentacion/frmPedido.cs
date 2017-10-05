using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Negocio;
using Enumeraciones;

namespace Presentacion
{
    public enum Modos
    {
        Agregar,
        Modificar,
    }

    public partial class frmPedido : Form
    {
        private Producto objProducto = null;
        private Modos Modalidad = 0;
        private Guid Id_Item;

        public frmPedido(int pId_Producto, Modos pModo)
        {
            InitializeComponent();
            Modalidad = pModo;
            objProducto = admProductos.Listar(pId_Producto);
        }
        public frmPedido(Guid pId_Item, Modos pModo)
        {
            InitializeComponent();
            Modalidad = pModo;
            Id_Item = pId_Item;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (Modalidad == Modos.Agregar)
            {
                Item objItem = new Item(Convert.ToInt32(this.numericUpDownCantidad.Value), objProducto.Nombre, objProducto.PrecioVenta);
                admCompras.Agregar(objItem);
            }
            else
            {
                admCompras.Modificar(Id_Item, Convert.ToInt32(this.numericUpDownCantidad.Value));
            }
            this.Close();
        }
    }
}
