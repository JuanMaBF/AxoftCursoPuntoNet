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
    public partial class frmEmpresa : Form
    {

        private enum Modos
        {
            Agregar,
            Modificar
        }
        public enum TiposCliente
        {
            ClienteEmpresa,
            Proveedor
        }

        private bool Cerrar = false;
        private Modos Modalidad = 0;
        private TiposCliente TipoCliente = 0;
        private Empresa objEmpresa = null;


        public frmEmpresa(TiposCliente pTipoCliente)
        {
            InitializeComponent();
            this.InicializarFormulario();
            this.Modalidad = Modos.Agregar;
            this.TipoCliente = pTipoCliente;
            if (pTipoCliente == TiposCliente.ClienteEmpresa)
            {
                this.Text = "Agregar cliente empresa";
            }
            else
            {
                this.Text = "Agregar proveedor";
            }
        }

        public frmEmpresa(int pIdEmpresa, TiposCliente pTipoCliente)
        {
            InitializeComponent();
            this.InicializarFormulario();
            this.Modalidad = Modos.Modificar;
            try
            {
                if (pTipoCliente == TiposCliente.ClienteEmpresa)
                {
                    this.Text = "Modificar cliente empresa";
                    objEmpresa = admClientes.ListarClienteEmpresa(pIdEmpresa);
                }
                else
                {
                    this.Text = "Modificar proveedor";
                    objEmpresa = admProveedores.Listar(pIdEmpresa);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.textBoxNombre.Text = objEmpresa.Nombre;
            this.textBoxCUIT.Text = objEmpresa.CUIT;
            this.textBoxEmail.Text = objEmpresa.DatosContacto.Email;
            this.textBoxTelefono.Text = objEmpresa.DatosContacto.Telefono;
            this.textBoxDireccion.Text = objEmpresa.DatosContacto.Direccion;
            this.textBoxNombreContacto.Text = objEmpresa.Contacto.Nombre;
            this.textBoxApellidoContacto.Text = objEmpresa.Contacto.Apellido;
            this.textBoxEmailContacto.Text = objEmpresa.Contacto.DatosContacto.Email;
            this.textBoxTelefonoContacto.Text = objEmpresa.Contacto.DatosContacto.Telefono;
            this.textBoxDireccionContacto.Text = objEmpresa.Contacto.DatosContacto.Direccion;
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
            if (Modalidad == Modos.Agregar)
            {
                DatosContacto objDatosContactoEmpresa = new DatosContacto(this.textBoxEmail.Text.Trim(), this.textBoxTelefono.Text.Trim(), textBoxDireccion.Text.Trim());
                DatosContacto objDatosContactoPersonaContacto = new DatosContacto(this.textBoxEmail.Text.Trim(), this.textBoxTelefono.Text.Trim(), textBoxDireccion.Text.Trim());
                Persona objPersonaContacto = new Persona(this.textBoxNombreContacto.Text.Trim(), this.textBoxNombreContacto.Text.Trim(), objDatosContactoPersonaContacto);
                objEmpresa = new Empresa(this.textBoxNombre.Text.Trim(), this.textBoxCUIT.Text.Trim(), objPersonaContacto, objDatosContactoEmpresa);
                if (TipoCliente == TiposCliente.ClienteEmpresa)
                {
                    admClientes.Agregar(objEmpresa);
                }
                else
                {
                    admProveedores.Agregar(objEmpresa);
                }
                Cerrar = true;
            }
            else
            {
                objEmpresa.Nombre = this.textBoxNombre.Text.Trim();
                objEmpresa.CUIT = this.textBoxCUIT.Text.Trim();
                objEmpresa.DatosContacto.Email = this.textBoxEmail.Text.Trim();
                objEmpresa.DatosContacto.Telefono = this.textBoxTelefono.Text.Trim();
                objEmpresa.DatosContacto.Direccion = textBoxDireccion.Text.Trim();
                objEmpresa.Contacto.Nombre = this.textBoxNombreContacto.Text.Trim();
                objEmpresa.Contacto.Apellido = this.textBoxApellidoContacto.Text.Trim();
                objEmpresa.Contacto.DatosContacto.Email = this.textBoxEmailContacto.Text.Trim();
                objEmpresa.Contacto.DatosContacto.Telefono = this.textBoxTelefonoContacto.Text.Trim();
                objEmpresa.Contacto.DatosContacto.Direccion = this.textBoxDireccionContacto.Text.Trim();
                if (TipoCliente == TiposCliente.ClienteEmpresa)
                {
                    admClientes.Modificar(objEmpresa);
                }
                else
                {
                    admProveedores.Modificar(objEmpresa);
                }
                Cerrar = true;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Cerrar = true;
            this.Close();
        }

        private void frmEmpresa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Cerrar)
            {
                e.Cancel = true;
            }
        }
    }
}
