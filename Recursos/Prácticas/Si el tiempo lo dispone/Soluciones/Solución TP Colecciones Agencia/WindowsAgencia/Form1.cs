using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAgencia
{
    public partial class Form1 : Form
    {
        ADMAgencia.AdmModelo objADMModelo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objADMModelo = new ADMAgencia.AdmModelo();

            cargaGridModelo();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Entidades.Modelo objModelo= new Entidades.Modelo(Convert.ToInt32(txtId.Text), txtNombre.Text);
            objADMModelo.agregar(objModelo);

            cargaGridModelo();
        }

        void cargaGridModelo()
        {
            gridModelos.DataSource = null;
            gridModelos.DataSource = objADMModelo.listar();
        }
    }
}
