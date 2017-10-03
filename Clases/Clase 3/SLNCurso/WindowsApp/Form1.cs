using BO.Entidades;
using System;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCrearClick(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno("Estu", "Di Ante", 1234567, "email@estudiantes.com", "Sim City", 12345);
            Profesor profesor = new Profesor("Prof E.", "Sor", 7654321, "email@profesor", "Sin City", "Waba luba dubdub");

            MessageBox.Show(alumno.ToString()
                + Environment.NewLine + "DNI: " + alumno.DNI
                + Environment.NewLine + "Ciudad: " + alumno.Ciudad
                + Environment.NewLine + "Email: " + alumno.Email);

            MessageBox.Show(profesor.ToString()
                + Environment.NewLine + "DNI: " + profesor.DNI
                + Environment.NewLine + "Ciudad: " + profesor.Ciudad
                + Environment.NewLine + "Email: " + profesor.Email);
        }
    }
}
