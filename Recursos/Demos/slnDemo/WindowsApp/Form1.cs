using LibSeguridad;
using LibSeguridad.Entidades.Base;
using LibSeguridad.Modelo;
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
        Persona objPersona;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //declaración y la instancia de un objeto
            Autenticacion objLogin = new Autenticacion();

            Usuario obj = new Usuario();
            obj.Nombre = "gaby";
            obj.password = "1234";

            Usuario obj2 = new Usuario("Pepe","1254");
         

            if (objLogin.login(obj))
            {
                MessageBox.Show("Bienvenido " + obj.Nombre +  " !");
            }
            else
            {
                MessageBox.Show("Usuario no registrado!");

            }

        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            //objPersona = new Medico();
            //objPersona.Nombre = "Anabel";
            //objPersona.FechaNacimiento = new DateTime(1975, 06, 02);

            //MessageBox.Show(objPersona.Nombre + " " + objPersona.FechaNacimiento);

        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            AdminMedico objAdmMedico = new AdminMedico();

            objAdmMedico.listar("traumatolog", "Flores");
            objAdmMedico.listar();
            objAdmMedico.listar("pediatra");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Medico objMedico = new Medico("Claudio", "Blanco", "Balnco@gmail.com", new DateTime(1970, 10, 20), "Pediatra");

            //objMedico.Nombre = "Carolina";
            //objMedico.Apellido = "Garcia";
            //objMedico.Especilidad = "Pediatra";

            //MessageBox.Show(objMedico.Nombre + " " + objMedico.Especilidad);
            MessageBox.Show(objMedico.ToString());

        }
    }
}
