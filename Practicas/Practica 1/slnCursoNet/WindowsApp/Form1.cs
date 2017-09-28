using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarClick(object sender, EventArgs e)
        {
            List<object> objetos = new List<object>();
            objetos.Add(new Remito("1234", DateTime.Now, "alguien", "calle falsa 1234", "no", "no", "no", 
                DateTime.Now, 1));
            objetos.Add(new Factura("hola", "hola", DateTime.Now, "hola", "hola", "hola", "hola", "hola", 1));
            objetos.Add(new Vendedor("hola", "hola", "hola", "hola", "hola", "hola"));
            objetos.Add(new ClienteEmpresa("hola", "hola", "hola", "hola", "hola", "hola"));
            objetos.Add(new Producto("hola", "hola", 1, 1, 1, "hola", "hola", "hola"));
            objetos.Add(new Proveedor("hola", "hola", "hola", "hola", "hola", "hola"));
            objetos.Add(new ClienteIndividuo("hola", "hola", "hola", "hola", "hola", "hola"));
            objetos.ForEach(obj => MostrarPropiedades(obj));
        }

        public void MostrarPropiedades(object obj)
        {
            string propConcat = obj.GetType().Name + Environment.NewLine;
            obj.GetType().GetProperties().ToList().ForEach(p =>
            {
                propConcat += p.Name + ": " + p.GetValue(obj) + Environment.NewLine;
            });
            MessageBox.Show(propConcat);
        }

    }
}
