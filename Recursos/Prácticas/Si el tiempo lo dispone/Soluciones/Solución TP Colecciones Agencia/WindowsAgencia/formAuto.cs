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
    public partial class formAuto : Form
    {
        ADMAgencia.AdmAuto objAdmAuto;
        public formAuto()
        {
            InitializeComponent();
        }

        private void formAuto_Load(object sender, EventArgs e)
        {
            ADMAgencia.AdmModelo objListaModelo = new ADMAgencia.AdmModelo();
            cbModelo.DataSource = objListaModelo.listar();
            cbModelo.DisplayMember = "Nombre";
            cbModelo.ValueMember = "IdModelo";

            objAdmAuto = new ADMAgencia.AdmAuto();

            cargaGridauto();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int modelo = (int) cbModelo.SelectedValue;
            Entidades.Auto objAuto = new Entidades.Auto(Convert.ToInt32(txtId.Text), modelo, txtColor.Text);
            objAdmAuto.agregar(objAuto);

            cargaGridauto();

        }
        void cargaGridauto()
        {
            gridAuto.DataSource = null;
            gridAuto.DataSource = objAdmAuto.listar();
        }

        private void cbModelo_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
    }
}
