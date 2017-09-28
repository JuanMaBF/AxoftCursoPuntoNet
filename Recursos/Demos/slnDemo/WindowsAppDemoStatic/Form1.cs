using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibDemoStatic;

namespace WindowsAppDemoStatic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente objCli1 = new Cliente("María");
            Cliente objCli2 = new Cliente("Pedro");
            Cliente objCli3 = new Cliente("Gabriela");
            Cliente objCli4 = new Cliente("Gustavo");

            MessageBox.Show(Cliente.Instancias.ToString());
        }
    }
}
