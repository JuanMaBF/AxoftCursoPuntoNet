using BO;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Alumno nuevoAlumno = new Alumno(100,"Juan", "Perez", "Quilmes", "juanp@hotmail.com", "24.756.987");

            //MessageBox.Show("Alumno :" + nuevoAlumno.Apellido + " " + nuevoAlumno.Nombre + Environment.NewLine +
            //    nuevoAlumno.Ciudad);

            MessageBox.Show(nuevoAlumno.ToString());
        }
    }
}
