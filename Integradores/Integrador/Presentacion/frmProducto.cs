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
    public partial class frmProducto : Form
    {
        private enum Modos
        {
            Agregar,
            Modificar
        }
        private bool Cerrar = false;

        private Modos Modalidad = 0;
        Producto objProducto = null;
        admProductos admProductos = new admProductos();

        public frmProducto()
        {
            InitializeComponent();
            this.InicializarFormulario();
            this.Modalidad = Modos.Agregar;
            this.Text = "Agregar producto";
        }
        public frmProducto(int pId_Producto)
        {
            InitializeComponent();
            this.InicializarFormulario();
            this.Modalidad = Modos.Modificar;
            this.Text = "Modificar producto";
            try
            {
                objProducto = admProductos.Listar(pId_Producto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.textBoxNombre.Text = objProducto.Nombre;
            this.textBoxDescripcion.Text = objProducto.Descripcion;
            this.comboBoxCategoria.SelectedValue = objProducto.Categoria.Id;
            this.comboBoxSubcategoria.SelectedValue = objProducto.SubCategoria.Id;
            this.numericUpDownPrecioCosto.Value = objProducto.PrecioCosto;
            this.numericUpDownMargen.Value = Convert.ToDecimal(objProducto.Margen);
        }

        private void InicializarFormulario()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ShowInTaskbar = false;
            try
            {
                this.comboBoxCategoria.ValueMember = "Id";
                this.comboBoxCategoria.DisplayMember = "Nombre";
                this.comboBoxCategoria.DataSource = admCategorias.Listar();

                this.comboBoxProveedor.ValueMember = "Id";
                this.comboBoxProveedor.DisplayMember = "Nombre";
                this.comboBoxProveedor.DataSource = admProveedores.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.comboBoxSubcategoria.ValueMember = "Id";
                this.comboBoxSubcategoria.DisplayMember = "Nombre";
                this.comboBoxSubcategoria.DataSource = admCategorias.ListarSubCategorias(Convert.ToInt32(this.comboBoxCategoria.SelectedValue));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Modalidad == Modos.Agregar)
                {
                    Producto objProducto = new Producto();
                    objProducto.Nombre = this.textBoxNombre.Text.Trim();
                    objProducto.Descripcion = this.textBoxDescripcion.Text.Trim();
                    objProducto.PrecioCosto = this.numericUpDownPrecioCosto.Value;
                    objProducto.Margen = Convert.ToDouble(this.numericUpDownMargen.Value); ;
                    objProducto.Categoria = admCategorias.Listar(Convert.ToInt32(this.comboBoxCategoria.SelectedValue));
                    objProducto.SubCategoria = admCategorias.ListarSubcategoria(Convert.ToInt32(this.comboBoxSubcategoria.SelectedValue));
                    objProducto.Proveedor = admProveedores.Listar(Convert.ToInt32(this.comboBoxProveedor.SelectedValue));
                    admProductos.Agregar(objProducto);
                    Cerrar = true;
                }
                else
                {
                    objProducto.Nombre = this.textBoxNombre.Text.Trim();
                    objProducto.Descripcion = this.textBoxDescripcion.Text.Trim();
                    objProducto.PrecioCosto = this.numericUpDownPrecioCosto.Value;
                    objProducto.Margen = Convert.ToDouble(this.numericUpDownMargen.Value); ;
                    objProducto.Categoria = admCategorias.Listar(Convert.ToInt32(this.comboBoxCategoria.SelectedValue));
                    objProducto.SubCategoria = admCategorias.ListarSubcategoria(Convert.ToInt32(this.comboBoxSubcategoria.SelectedValue));
                    objProducto.Proveedor = admProveedores.Listar(Convert.ToInt32(this.comboBoxProveedor.SelectedValue));
                    admProductos.Modificar(objProducto);
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

        private void frmProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Cerrar)
            {
                e.Cancel = true;
            }
        }
    }
}
