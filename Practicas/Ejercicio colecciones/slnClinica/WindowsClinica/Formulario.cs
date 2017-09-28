using Negocio;
using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace WindowsClinica
{
    public partial class Formulario : Form
    {
        private AdmMedico admMedico = new AdmMedico();
        public Formulario()
        {
            InitializeComponent();
            admMedico.CrearMedicos();
            CargarCombo();
        }

        private void CargarCombo()
        {
            cmbBoxEspecialidad.Items.AddRange(admMedico.ObtenerEspecialidades().ToArray());
        }
    }

    

}
