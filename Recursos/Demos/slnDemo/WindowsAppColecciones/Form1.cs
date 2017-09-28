using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppColecciones.Entidades;

namespace WindowsAppColecciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListaMedicos_Click(object sender, EventArgs e)
        {
            //List<Medico> listaMedicos = new List<Medico>();

            //listaMedicos.Add(new Medico("Carolina", "Garcia", "CarolinaG@Clinica.com", new DateTime(1976, 10, 22), "Pediatra"));
            //listaMedicos.Add(new Medico("Juan", "Perez", "JuanP@Clinica.com", new DateTime(1999, 02, 22), "Pediatra"));
            //listaMedicos.Add(new Medico("Ana", "Pocetti", "AnaP@Clinica.com", new DateTime(1970, 10, 10), "Clinico"));


            AdmClinica.ADMMedico objadmM = new AdmClinica.ADMMedico();

            gridMedicos.DataSource = objadmM.listar();


            foreach (Medico item in objadmM.listar())
            {
                lstMedicos.Items.Add(item.Nombre + " " + item.Apellido);
            }


            cbEspecialidad.DataSource = objadmM.listar();
            cbEspecialidad.DisplayMember = "Especilidad";
            cbEspecialidad.ValueMember = "Especilidad";



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
