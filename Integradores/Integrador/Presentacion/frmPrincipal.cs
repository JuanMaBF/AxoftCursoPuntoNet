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
using Enumeraciones;

namespace Presentacion
{
    public partial class frmPrincipal : Form
    {

        private object ClienteSeleccionado = null;
        private admProductos admProductos = new admProductos();
        private Enumeraciones.Enumeraciones.ColumnasDocumentosComerciales Orden = 0;

        public frmPrincipal()
        {
            InitializeComponent();
            
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = Application.ProductName ;
            this.toolStripStatusLabelUsuario.Text = "Vendedor:";

            this.ConfigurarDataGridView(this.dataGridViewClientesIndividuo);
            this.ConfigurarDataGridView(this.dataGridViewClientesEmpresa);
            this.ConfigurarDataGridView(this.dataGridViewProductos);
            this.ConfigurarDataGridView(this.dataGridViewProveedores);
            this.ConfigurarDataGridView(this.dataGridViewSeleccionarClienteEmpresa);
            this.ConfigurarDataGridView(this.dataGridViewSeleccionarClienteIndividuo);
            this.ConfigurarDataGridView(this.dataGridViewPedido);
            this.ConfigurarDataGridView(this.dataGridViewPedidoProductos);
            this.ConfigurarDataGridView(this.dataGridViewFacturas);
            this.ConfigurarDataGridView(this.dataGridViewRemitos);

            Producto.IVA = Properties.Settings.Default.IVA;

            try
            {
                this.ListarProveedores();
                this.ListarProductos();
                this.ListarClientesIndividuo();
                this.ListarClientesEmpresa();
                this.ListarCategorias();
                this.ListarFacturas();
                this.ListarRemitos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.comboBoxCondicionIVA.DataSource = Enumeraciones.Enumeraciones.ListarCondicionesIVA();
            this.comboBoxCondicionVenta.DataSource = Enumeraciones.Enumeraciones.ListarCondicionesVenta();
        }

        public void impresionOK(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfigurarDataGridView(DataGridView pDataGridView)
        {
            pDataGridView.ReadOnly = true;
            pDataGridView.MultiSelect = false;
            pDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pDataGridView.RowHeadersVisible = false;
            pDataGridView.AllowUserToResizeRows = false;
            pDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
        }

        private void ListarProveedores()
        {
            this.dataGridViewProveedores.DataSource = admProveedores.Listar();
            this.dataGridViewProveedores.Columns["Id"].Visible = false;
            this.dataGridViewProveedores.Columns["Id_Empresa"].Visible = false;
            this.dataGridViewProveedores.Columns["Contacto"].Visible = false;
            this.dataGridViewProveedores.Columns["DatosContacto"].Visible = false;
        }

        private void ListarProductos()
        {
            this.dataGridViewProductos.DataSource = admProductos.Listar();
            this.dataGridViewProductos.Columns["Id"].Visible = false;
            this.dataGridViewProductos.Columns["PrecioCosto"].HeaderText = "Costo";
            this.dataGridViewProductos.Columns["PrecioCosto"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewProductos.Columns["PrecioCosto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewProductos.Columns["PrecioCosto"].DefaultCellStyle.Format = "c";
            this.dataGridViewProductos.Columns["Margen"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewProductos.Columns["Margen"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewProductos.Columns["Margen"].DefaultCellStyle.Format = "p";
            this.dataGridViewProductos.Columns["PrecioBruto"].HeaderText = "Bruto";
            this.dataGridViewProductos.Columns["PrecioBruto"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewProductos.Columns["PrecioBruto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewProductos.Columns["PrecioBruto"].DefaultCellStyle.Format = "c";
            this.dataGridViewProductos.Columns["PrecioVenta"].HeaderText = "Venta";
            this.dataGridViewProductos.Columns["PrecioVenta"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewProductos.Columns["PrecioVenta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewProductos.Columns["PrecioVenta"].DefaultCellStyle.Format = "c";
            this.dataGridViewProductos.Columns["Proveedor"].Visible = false;
            this.dataGridViewProductos.Columns["ViewProveedor"].HeaderText = "Proveedor";
            this.dataGridViewProductos.Columns["Categoria"].Visible = false;
            this.dataGridViewProductos.Columns["ViewCategoria"].HeaderText = "Categoria";
            this.dataGridViewProductos.Columns["ViewCategoria"].DisplayIndex = 0;
            this.dataGridViewProductos.Columns["Subcategoria"].Visible = false;
            this.dataGridViewProductos.Columns["ViewSubcategoria"].HeaderText = "Subcategoria";
            this.dataGridViewProductos.Columns["ViewSubcategoria"].DisplayIndex = 1;
        }

        private void ListarClientesIndividuo()
        {
           
            this.dataGridViewClientesIndividuo.DataSource = admClientes.ListarClienteIndividuo();
            this.dataGridViewClientesIndividuo.Columns["Id"].Visible = false;
            this.dataGridViewClientesIndividuo.Columns["Id_Persona"].Visible = false;
            this.dataGridViewClientesIndividuo.Columns["Nombre"].Visible = false;
            this.dataGridViewClientesIndividuo.Columns["Apellido"].Visible = false;
            this.dataGridViewClientesIndividuo.Columns["DatosContacto"].Visible = false;
            this.dataGridViewClientesIndividuo.Columns["NombreCompleto"].HeaderText = "Apellido, Nombre";
            this.dataGridViewClientesIndividuo.Columns["NombreCompleto"].DisplayIndex = 0;

            this.dataGridViewSeleccionarClienteIndividuo.DataSource = admClientes.ListarClienteIndividuo();
            this.dataGridViewSeleccionarClienteIndividuo.Columns["Id"].Visible = false;
            this.dataGridViewSeleccionarClienteIndividuo.Columns["Id_Persona"].Visible = false;
            this.dataGridViewSeleccionarClienteIndividuo.Columns["Nombre"].Visible = false;
            this.dataGridViewSeleccionarClienteIndividuo.Columns["Apellido"].Visible = false;
            this.dataGridViewSeleccionarClienteIndividuo.Columns["DatosContacto"].Visible = false;
            this.dataGridViewSeleccionarClienteIndividuo.Columns["NombreCompleto"].HeaderText = "Apellido, Nombre";
            this.dataGridViewSeleccionarClienteIndividuo.Columns["NombreCompleto"].DisplayIndex = 0;
        }

        private void ListarClientesEmpresa()
        {
            this.dataGridViewClientesEmpresa.DataSource = admClientes.ListarClienteEmpresa();
            this.dataGridViewClientesEmpresa.Columns["Id"].Visible = false;
            this.dataGridViewClientesEmpresa.Columns["Id_Empresa"].Visible = false;
            this.dataGridViewClientesEmpresa.Columns["Contacto"].Visible = false;
            this.dataGridViewClientesEmpresa.Columns["DatosContacto"].Visible = false;

            this.dataGridViewSeleccionarClienteEmpresa.DataSource = admClientes.ListarClienteEmpresa();
            this.dataGridViewSeleccionarClienteEmpresa.Columns["Id"].Visible = false;
            this.dataGridViewSeleccionarClienteEmpresa.Columns["Id_Empresa"].Visible = false;
            this.dataGridViewSeleccionarClienteEmpresa.Columns["Contacto"].Visible = false;
            this.dataGridViewSeleccionarClienteEmpresa.Columns["DatosContacto"].Visible = false;
        }

        private void ListarCategorias()
        {
            this.comboBoxCategoria.ValueMember = "Id";
            this.comboBoxCategoria.DisplayMember = "Nombre";
            this.comboBoxCategoria.DataSource = admCategorias.Listar();
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

        private void comboBoxSubcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.dataGridViewPedidoProductos.DataSource = admProductos.Listar(Convert.ToInt32(this.comboBoxCategoria.SelectedValue), Convert.ToInt32(this.comboBoxSubcategoria.SelectedValue));
                this.dataGridViewPedidoProductos.Columns["Id"].Visible = false;
                this.dataGridViewPedidoProductos.Columns["Descripcion"].Visible = false;
                this.dataGridViewPedidoProductos.Columns["PrecioCosto"].Visible = false;
                this.dataGridViewPedidoProductos.Columns["Margen"].Visible = false;
                this.dataGridViewPedidoProductos.Columns["PrecioBruto"].Visible = false;
                this.dataGridViewPedidoProductos.Columns["PrecioVenta"].Visible = false;
                this.dataGridViewPedidoProductos.Columns["Proveedor"].Visible = false;
                this.dataGridViewPedidoProductos.Columns["Categoria"].Visible = false;
                this.dataGridViewPedidoProductos.Columns["Subcategoria"].Visible = false;
                this.dataGridViewPedidoProductos.Columns["ViewProveedor"].Visible = false;
                this.dataGridViewPedidoProductos.Columns["ViewCategoria"].Visible = false;
                this.dataGridViewPedidoProductos.Columns["ViewSubcategoria"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewSeleccionarClienteIndividuo_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(this.dataGridViewSeleccionarClienteIndividuo.SelectedRows[0].Cells["Id"].Value);
                ClienteIndividuo obj = admClientes.ListarClienteIndividuo(Id);
                this.labelNombreClienteSeleccionado.Text = "Nombre: " + obj.NombreCompleto;
                this.labelCUITClienteSeleccionado.Text = "C.U.I.T.: " + obj.CUIT;
                this.labelEmailClienteSeleccionado.Text = "Email: " + obj.DatosContacto.Email;
                this.labelTelefonoClienteSeleccionado.Text = "Teléfono: " + obj.DatosContacto.Telefono;
                this.labelDireccionClienteSeleccionado.Text = "Dirección: " + obj.DatosContacto.Direccion;
                ClienteSeleccionado = obj;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewSeleccionarClienteEmpresa_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(this.dataGridViewSeleccionarClienteEmpresa.SelectedRows[0].Cells["Id"].Value);
                Empresa obj = admClientes.ListarClienteEmpresa(Id);
                this.labelNombreClienteSeleccionado.Text = "Nombre: " + obj.Nombre;
                this.labelCUITClienteSeleccionado.Text = "C.U.I.T.: " + obj.CUIT;
                this.labelEmailClienteSeleccionado.Text = "Email: " + obj.DatosContacto.Email;
                this.labelTelefonoClienteSeleccionado.Text = "Teléfono: " + obj.DatosContacto.Telefono;
                this.labelDireccionClienteSeleccionado.Text = "Dirección: " + obj.DatosContacto.Direccion;
                this.labelNombreContactoClienteSeleccionado.Text = "Nombre: " + obj.Contacto.NombreCompleto;
                this.labelEmailContactoClienteSeleccionado.Text = "Email: " + obj.Contacto.DatosContacto.Email;
                this.labelTelefonoContactoClienteSeleccionado.Text = "Teléfono: " + obj.Contacto.DatosContacto.Telefono;
                this.labelDireccionContactoClienteSeleccionado.Text = "Dirección: " + obj.Contacto.DatosContacto.Direccion;
                ClienteSeleccionado = obj;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControlSeleccionarCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControlSeleccionarCliente.SelectedIndex == 0)
            {
                this.groupBoxContactoClienteSeleccionado.Visible = false;
            }
            else
            {
                this.groupBoxContactoClienteSeleccionado.Visible = true;
            }
        }

        private void dataGridViewPedidoProductos_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(Convert.ToInt32(this.dataGridViewPedidoProductos.SelectedRows[0].Cells["Id"].Value), DragDropEffects.Copy);
        }

        private void dataGridViewPedido_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Int32)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void dataGridViewPedido_DragDrop(object sender, DragEventArgs e)
        {
            int Id = Convert.ToInt32(e.Data.GetData(typeof(Int32)));
            frmPedido frm = new frmPedido(Id, Modos.Agregar);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.labelTotal.Text = "Total: " + admCompras.Total.ToString("c");
            }
            this.ListarPedido();   
        }

        private void toolStripMenuItemModificar_Click(object sender, EventArgs e)
        {
            Guid Id = (Guid) this.dataGridViewPedido.SelectedRows[0].Cells["Id"].Value;
            frmPedido frm = new frmPedido(Id, Modos.Modificar);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.labelTotal.Text = "Total: " + admCompras.Total.ToString("c");
            }
            this.ListarPedido();
        }

        private void ListarPedido()
        {
            this.dataGridViewPedido.DataSource = null;
            this.dataGridViewPedido.DataSource = admCompras.Items;
            this.dataGridViewPedido.Columns["Id"].Visible = false;
            this.dataGridViewPedido.Columns["Cantidad"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewPedido.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewPedido.Columns["PrecioUnitario"].HeaderText = "Precio unitario";
            this.dataGridViewPedido.Columns["PrecioUnitario"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewPedido.Columns["PrecioUnitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewPedido.Columns["PrecioUnitario"].DefaultCellStyle.Format = "c";
            this.dataGridViewPedido.Columns["Importe"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewPedido.Columns["Importe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewPedido.Columns["Importe"].DefaultCellStyle.Format = "c";
        }

        private void toolStripMenuItemEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el item seleccionado?",Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Guid Id = (Guid)this.dataGridViewPedido.SelectedRows[0].Cells["Id"].Value;
                admCompras.Eliminar(Id);
                this.ListarPedido();
            }
        }

        private void toolStripButtonAbrirVenta_Click(object sender, EventArgs e)
        {
            this.HabilitarPedido(true);
        }

        private void HabilitarPedido(bool pEstado)
        {
            this.toolStripButtonAbrirVenta.Enabled = !pEstado;
            this.toolStripButtonCancelarVenta.Enabled = pEstado;
            this.toolStripButtonCerrarVenta.Enabled = pEstado;
        }

        private void toolStripButtonCancelarVenta_Click(object sender, EventArgs e)
        {      
             this.HabilitarPedido(false);
             admCompras.Cancelar();
             this.dataGridViewPedido.DataSource = null;
             this.labelTotal.Text = "Total: " + admCompras.Total.ToString("c"); 
        }

        private void toolStripButtonCerrarVenta_Click(object sender, EventArgs e)
        {
            if (ClienteSeleccionado != null && this.dataGridViewPedido.RowCount > 0)
            {
                Factura objFactura = new Factura();
                objFactura.Tipo = Properties.Settings.Default.TipoFactura;
                objFactura.Numero = this.NumeroFactura();
                objFactura.Fecha = DateTime.Now.Date;
                objFactura.Cliente = this.labelNombreClienteSeleccionado.Text;
                objFactura.Direccion = this.labelDireccionClienteSeleccionado.Text;
                objFactura.CondicionIVA = this.comboBoxCondicionIVA.Text;
                objFactura.CondicionVenta = this.comboBoxCondicionVenta.Text;
                objFactura.Detalle = admCompras.Items;
                Remito objRemito = new Remito();
                objRemito.Numero = this.NumeroRemito();
                objRemito.Fecha = DateTime.Now.Date;
                objRemito.FechaEntrega = DateTime.Now.Date.AddDays(2);
                objRemito.Cliente = this.labelNombreClienteSeleccionado.Text;
                objRemito.Direccion = this.labelDireccionClienteSeleccionado.Text;
                objRemito.CondicionIVA = this.comboBoxCondicionIVA.Text;
                objRemito.CondicionVenta = this.comboBoxCondicionVenta.Text;
                objRemito.Detalle = admCompras.Items;
                admDocumentosComerciales.Generar(objFactura, objRemito);
                this.ActualizarNumerosDocumentosComerciales();
                this.HabilitarPedido(false);
                admCompras.Cancelar();
                this.dataGridViewPedido.DataSource = null;
                this.labelTotal.Text = "Total: " + admCompras.Total.ToString("c");
                this.ListarFacturas();
                this.ListarRemitos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente y al menos un producto antes de cerrar la venta.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void toolStripButtonAgregarProducto_Click(object sender, EventArgs e)
        {
            frmProducto frm = new frmProducto();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.ListarProductos();
            }
        }

        private void toolStripButtonModificarProducto_Click(object sender, EventArgs e)
        {
            frmProducto frm = new frmProducto(Convert.ToInt32(this.dataGridViewProductos.SelectedRows[0].Cells["Id"].Value));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.ListarProductos();
            }
        }

        private void toolStripButtonEliminarProducto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el producto seleccionado?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int Id = Convert.ToInt32(this.dataGridViewProductos.SelectedRows[0].Cells["Id"].Value);
                admProductos.Eliminar(Id);
                this.ListarProductos();
            }
        }

        private void toolStripButtonAgregarCliente_Click(object sender, EventArgs e)
        {
            if (this.tabControlClientes.SelectedIndex == 0)
            {
                frmClienteIndividuo frm = new frmClienteIndividuo();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    this.ListarClientesIndividuo();
                }
            }
            else
            {
                frmEmpresa frm = new frmEmpresa(frmEmpresa.TiposCliente.ClienteEmpresa);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    this.ListarClientesEmpresa();
                }
            }
        }

        private void toolStripButtonModificarCliente_Click(object sender, EventArgs e)
        {
            if (this.tabControlClientes.SelectedIndex == 0)
            {
                frmClienteIndividuo frm = new frmClienteIndividuo(Convert.ToInt32(this.dataGridViewClientesIndividuo.SelectedRows[0].Cells["Id"].Value));
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    this.ListarClientesIndividuo();
                }
            }
            else
            {
                frmEmpresa frm = new frmEmpresa(Convert.ToInt32(this.dataGridViewClientesEmpresa.SelectedRows[0].Cells["Id"].Value), frmEmpresa.TiposCliente.ClienteEmpresa);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    this.ListarClientesEmpresa();
                }
            }
        }

        private void toolStripButtonEliminarCliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el cliente seleccionado?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (this.tabControlClientes.SelectedIndex == 0)
                {
                    int Id = Convert.ToInt32(this.dataGridViewClientesIndividuo.SelectedRows[0].Cells["Id"].Value);
                    ClienteIndividuo objCliente = admClientes.ListarClienteIndividuo(Id);
                    admClientes.Eliminar(objCliente);
                    this.ListarClientesIndividuo();
                }
                else
                {
                    int Id = Convert.ToInt32(this.dataGridViewClientesEmpresa.SelectedRows[0].Cells["Id"].Value);
                    Empresa objCliente = admClientes.ListarClienteEmpresa(Id);
                    admClientes.Eliminar(objCliente);
                    this.ListarClientesEmpresa();
                }
            }
        }

        private void toolStripButtonAgregarProveedor_Click(object sender, EventArgs e)
        {
            frmEmpresa frm = new frmEmpresa(frmEmpresa.TiposCliente.Proveedor);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.ListarProveedores();
            }
        }

        private void toolStripButtonModificarProveedor_Click(object sender, EventArgs e)
        {
            frmEmpresa frm = new frmEmpresa(Convert.ToInt32(this.dataGridViewProveedores.SelectedRows[0].Cells["Id"].Value), frmEmpresa.TiposCliente.Proveedor);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.ListarProveedores(); 
            }
        }

        private void toolStripButtonEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el proveedor seleccionado?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int Id = Convert.ToInt32(this.dataGridViewProveedores.SelectedRows[0].Cells["Id"].Value);
                Empresa objCliente = admProveedores.Listar(Id);
                admProveedores.Eliminar(objCliente);
                this.ListarProveedores();   
            }
        }

        private void ListarFacturas()
        {
            this.dataGridViewFacturas.DataSource = admDocumentosComerciales.ListarFacturas(Orden);
            this.dataGridViewFacturas.Columns["Id"].Visible = false;
            this.dataGridViewFacturas.Columns["Total"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewFacturas.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewFacturas.Columns["Total"].DefaultCellStyle.Format = "c";
        }

        private void ListarRemitos()
        {
            this.dataGridViewRemitos.DataSource = admDocumentosComerciales.ListarRemitos(Orden);
            this.dataGridViewRemitos.Columns["Id"].Visible = false;
            this.dataGridViewRemitos.Columns["Total"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewRemitos.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewRemitos.Columns["Total"].DefaultCellStyle.Format = "c";
        }

        private string NumeroFactura()
        {
            return Properties.Settings.Default.NumeroTalonarioFacturas.ToString("0000") + "-" + Properties.Settings.Default.NumeroFactura.ToString("00000000");
        }

        private string NumeroRemito()
        {
            return Properties.Settings.Default.NumeroTalonarioRemitos.ToString("0000") + "-" + Properties.Settings.Default.NumeroRemito.ToString("00000000");
        }

        private void ActualizarNumerosDocumentosComerciales()
        {
            Properties.Settings.Default.NumeroFactura = Properties.Settings.Default.NumeroFactura + 1;
            Properties.Settings.Default.NumeroRemito = Properties.Settings.Default.NumeroRemito + 1;
            Properties.Settings.Default.Save();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orden = Enumeraciones.Enumeraciones.ColumnasDocumentosComerciales.Cliente;
            this.ListarFacturas();
        }

        private void ascendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orden = Enumeraciones.Enumeraciones.ColumnasDocumentosComerciales.FechaAscendente;
            this.ListarFacturas();
        }

        private void descendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orden = Enumeraciones.Enumeraciones.ColumnasDocumentosComerciales.FechaDescendente;
            this.ListarFacturas();
            this.ListarRemitos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admClientes.ImpresionOK += new EventHandler(impresionOK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admClientes.ImpresionOK -= new EventHandler(impresionOK);
        }
    }
}
 