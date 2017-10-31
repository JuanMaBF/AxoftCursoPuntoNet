using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsDemoFluentApi.Modelo;

namespace WindowsDemoFluentApi
{
    public partial class Form1 : Form
    {
        AdminCliente adminCli;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FacturacionDB db= new FacturacionDB() )
            {
                Cliente nuevo = new Cliente() { Nombre = "Ana", Apellido = "Fernandez" };

                db.Clientes.Add(nuevo);

                db.SaveChanges();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            enlaceGridViewClientes();
        }

        void enlaceGridViewClientes()
        {
            adminCli = new AdminCliente();

            gridClientes.DataSource = adminCli.traerTodos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente nuevo = new Cliente() { Apellido = "Marina", Nombre = "Picon" };

            adminCli = new AdminCliente();
            adminCli.agregar(nuevo);
            adminCli.guardar();
            enlaceGridViewClientes();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cliente modificar = new Cliente() { CliId = 2, Apellido = "Giles", Nombre = "Gabriela Marina"};
            adminCli = new AdminCliente();
            adminCli.modificar(modificar);
            adminCli.guardar();
            enlaceGridViewClientes();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idCliente = 2;
            adminCli = new AdminCliente();
            adminCli.eliminar(idCliente);
            adminCli.guardar();
            enlaceGridViewClientes();
        }
    }
}
