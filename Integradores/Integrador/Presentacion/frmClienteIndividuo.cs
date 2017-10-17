using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class frmClienteIndividuo : Form
    {
        private enum Modos
        {
            Agregar,
            Modificar
        }
        private bool Cerrar = false;
        private Modos Modalidad = 0;

        ClienteIndividuo objCliente = null;
        
        public frmClienteIndividuo()
        {
            InitializeComponent();
            this.InicializarFormulario();
            this.Modalidad = Modos.Agregar;
            this.Text = "Agregar cliente particular";
        }

        public frmClienteIndividuo(int pIdCliente)
        {
            InitializeComponent();
            this.InicializarFormulario();
            this.Modalidad = Modos.Modificar;
            this.Text = "Modificar cliente particular";
            try
            {
                objCliente = admClientes.ListarClienteIndividuo(pIdCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.textBoxNombre.Text = objCliente.Nombre;
            this.textBoxApellido.Text = objCliente.Apellido;
            this.textBoxCUIT.Text = objCliente.CUIT;
            this.textBoxEmail.Text = objCliente.DatosContacto.Email;
            this.textBoxTelefono.Text = objCliente.DatosContacto.Telefono;
            this.textBoxDireccion.Text = objCliente.DatosContacto.Direccion;
        }

        private void InicializarFormulario()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ShowInTaskbar = false;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        { 
            try
            {
                if (Modalidad == Modos.Agregar)
                {   
                    DatosContacto objDatosContacto =  new DatosContacto(this.textBoxEmail.Text.Trim(),this.textBoxTelefono.Text.Trim(), textBoxDireccion.Text.Trim());
                    objCliente = new ClienteIndividuo(this.textBoxNombre.Text.Trim(), this.textBoxApellido.Text.Trim(), this.textBoxCUIT.Text.Trim(), objDatosContacto);
                    admClientes.Agregar(objCliente);
                    Cerrar = true;
                }
                else
                {
                    objCliente.Nombre = this.textBoxNombre.Text.Trim();
                    objCliente.Apellido = this.textBoxApellido.Text.Trim();
                    objCliente.CUIT = this.textBoxCUIT.Text.Trim();
                    objCliente.DatosContacto.Email = this.textBoxEmail.Text.Trim();
                    objCliente.DatosContacto.Telefono = this.textBoxTelefono.Text.Trim();
                    objCliente.DatosContacto.Direccion = textBoxDireccion.Text.Trim();
                    admClientes.Modificar(objCliente);
                    Cerrar = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Cerrar = true;
            this.Close();
        }

        private void frmClienteIndividuo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Cerrar)
            {
                e.Cancel = true;
            }
        }

    }
}
