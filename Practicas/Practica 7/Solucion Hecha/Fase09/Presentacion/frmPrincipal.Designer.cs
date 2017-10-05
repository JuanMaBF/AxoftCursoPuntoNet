namespace Presentacion
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabPageVentas = new System.Windows.Forms.TabPage();
            this.tabControlVenta = new System.Windows.Forms.TabControl();
            this.tabPageSeleccionarCliente = new System.Windows.Forms.TabPage();
            this.splitContainerSeleccionarCliente = new System.Windows.Forms.SplitContainer();
            this.tabControlSeleccionarCliente = new System.Windows.Forms.TabControl();
            this.tabPageSeleccionarClienteIndividuo = new System.Windows.Forms.TabPage();
            this.dataGridViewSeleccionarClienteIndividuo = new System.Windows.Forms.DataGridView();
            this.tabPageSeleccionarClienteEmpresa = new System.Windows.Forms.TabPage();
            this.dataGridViewSeleccionarClienteEmpresa = new System.Windows.Forms.DataGridView();
            this.groupBoxContactoClienteSeleccionado = new System.Windows.Forms.GroupBox();
            this.labelNombreContactoClienteSeleccionado = new System.Windows.Forms.Label();
            this.labelDireccionContactoClienteSeleccionado = new System.Windows.Forms.Label();
            this.labelTelefonoContactoClienteSeleccionado = new System.Windows.Forms.Label();
            this.labelEmailContactoClienteSeleccionado = new System.Windows.Forms.Label();
            this.groupBoxDatosContactoClienteSeleccionado = new System.Windows.Forms.GroupBox();
            this.labelDireccionClienteSeleccionado = new System.Windows.Forms.Label();
            this.labelTelefonoClienteSeleccionado = new System.Windows.Forms.Label();
            this.labelEmailClienteSeleccionado = new System.Windows.Forms.Label();
            this.groupBoxClienteSeleccionado = new System.Windows.Forms.GroupBox();
            this.labelCUITClienteSeleccionado = new System.Windows.Forms.Label();
            this.labelNombreClienteSeleccionado = new System.Windows.Forms.Label();
            this.tabPageConfigurarPedido = new System.Windows.Forms.TabPage();
            this.splitContainerConfigurarPedido = new System.Windows.Forms.SplitContainer();
            this.dataGridViewPedidoProductos = new System.Windows.Forms.DataGridView();
            this.panelCategorias = new System.Windows.Forms.Panel();
            this.comboBoxSubcategoria = new System.Windows.Forms.ComboBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.panelCondiciones = new System.Windows.Forms.Panel();
            this.comboBoxCondicionVenta = new System.Windows.Forms.ComboBox();
            this.comboBoxCondicionIVA = new System.Windows.Forms.ComboBox();
            this.labelCondicionVenta = new System.Windows.Forms.Label();
            this.labelCondicionIVA = new System.Windows.Forms.Label();
            this.dataGridViewPedido = new System.Windows.Forms.DataGridView();
            this.contextMenuStripDataGridViewPedido = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.toolStripVentas = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAbrirVenta = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelarVenta = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCerrarVenta = new System.Windows.Forms.ToolStripButton();
            this.tabPageProductos = new System.Windows.Forms.TabPage();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.toolStripProductos = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAgregarProducto = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonModificarProducto = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEliminarProducto = new System.Windows.Forms.ToolStripButton();
            this.tabPageClientes = new System.Windows.Forms.TabPage();
            this.tabControlClientes = new System.Windows.Forms.TabControl();
            this.tabPageClienteIndividuo = new System.Windows.Forms.TabPage();
            this.dataGridViewClientesIndividuo = new System.Windows.Forms.DataGridView();
            this.tabControlClienteEmpresa = new System.Windows.Forms.TabPage();
            this.dataGridViewClientesEmpresa = new System.Windows.Forms.DataGridView();
            this.toolStripClientes = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAgregarCliente = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonModificarCliente = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEliminarCliente = new System.Windows.Forms.ToolStripButton();
            this.tabPageProveedores = new System.Windows.Forms.TabPage();
            this.dataGridViewProveedores = new System.Windows.Forms.DataGridView();
            this.toolStripProveedores = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAgregarProveedor = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonModificarProveedor = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEliminarProveedor = new System.Windows.Forms.ToolStripButton();
            this.tabPageDocumentosComerciales = new System.Windows.Forms.TabPage();
            this.tabControlDocumentosComerciales = new System.Windows.Forms.TabControl();
            this.tabPageFacturas = new System.Windows.Forms.TabPage();
            this.dataGridViewFacturas = new System.Windows.Forms.DataGridView();
            this.tabPageRemitos = new System.Windows.Forms.TabPage();
            this.dataGridViewRemitos = new System.Windows.Forms.DataGridView();
            this.toolStripDocumentosComerciales = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonOrdenar = new System.Windows.Forms.ToolStripDropDownButton();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tabControlPrincipal.SuspendLayout();
            this.tabPageVentas.SuspendLayout();
            this.tabControlVenta.SuspendLayout();
            this.tabPageSeleccionarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSeleccionarCliente)).BeginInit();
            this.splitContainerSeleccionarCliente.Panel1.SuspendLayout();
            this.splitContainerSeleccionarCliente.Panel2.SuspendLayout();
            this.splitContainerSeleccionarCliente.SuspendLayout();
            this.tabControlSeleccionarCliente.SuspendLayout();
            this.tabPageSeleccionarClienteIndividuo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeleccionarClienteIndividuo)).BeginInit();
            this.tabPageSeleccionarClienteEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeleccionarClienteEmpresa)).BeginInit();
            this.groupBoxContactoClienteSeleccionado.SuspendLayout();
            this.groupBoxDatosContactoClienteSeleccionado.SuspendLayout();
            this.groupBoxClienteSeleccionado.SuspendLayout();
            this.tabPageConfigurarPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerConfigurarPedido)).BeginInit();
            this.splitContainerConfigurarPedido.Panel1.SuspendLayout();
            this.splitContainerConfigurarPedido.Panel2.SuspendLayout();
            this.splitContainerConfigurarPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidoProductos)).BeginInit();
            this.panelCategorias.SuspendLayout();
            this.panelCondiciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).BeginInit();
            this.contextMenuStripDataGridViewPedido.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.toolStripVentas.SuspendLayout();
            this.tabPageProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.toolStripProductos.SuspendLayout();
            this.tabPageClientes.SuspendLayout();
            this.tabControlClientes.SuspendLayout();
            this.tabPageClienteIndividuo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientesIndividuo)).BeginInit();
            this.tabControlClienteEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientesEmpresa)).BeginInit();
            this.toolStripClientes.SuspendLayout();
            this.tabPageProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProveedores)).BeginInit();
            this.toolStripProveedores.SuspendLayout();
            this.tabPageDocumentosComerciales.SuspendLayout();
            this.tabControlDocumentosComerciales.SuspendLayout();
            this.tabPageFacturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturas)).BeginInit();
            this.tabPageRemitos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRemitos)).BeginInit();
            this.toolStripDocumentosComerciales.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUsuario});
            this.statusStrip.Location = new System.Drawing.Point(0, 498);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelUsuario
            // 
            this.toolStripStatusLabelUsuario.Name = "toolStripStatusLabelUsuario";
            this.toolStripStatusLabelUsuario.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelUsuario.Text = "toolStripStatusLabel1";
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.Controls.Add(this.tabPageVentas);
            this.tabControlPrincipal.Controls.Add(this.tabPageProductos);
            this.tabControlPrincipal.Controls.Add(this.tabPageClientes);
            this.tabControlPrincipal.Controls.Add(this.tabPageProveedores);
            this.tabControlPrincipal.Controls.Add(this.tabPageDocumentosComerciales);
            this.tabControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPrincipal.Location = new System.Drawing.Point(0, 24);
            this.tabControlPrincipal.Multiline = true;
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.Padding = new System.Drawing.Point(6, 6);
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(784, 474);
            this.tabControlPrincipal.TabIndex = 2;
            // 
            // tabPageVentas
            // 
            this.tabPageVentas.Controls.Add(this.tabControlVenta);
            this.tabPageVentas.Controls.Add(this.toolStripVentas);
            this.tabPageVentas.Location = new System.Drawing.Point(4, 28);
            this.tabPageVentas.Name = "tabPageVentas";
            this.tabPageVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVentas.Size = new System.Drawing.Size(776, 442);
            this.tabPageVentas.TabIndex = 0;
            this.tabPageVentas.Text = "Ventas";
            this.tabPageVentas.UseVisualStyleBackColor = true;
            // 
            // tabControlVenta
            // 
            this.tabControlVenta.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlVenta.Controls.Add(this.tabPageSeleccionarCliente);
            this.tabControlVenta.Controls.Add(this.tabPageConfigurarPedido);
            this.tabControlVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlVenta.Location = new System.Drawing.Point(3, 28);
            this.tabControlVenta.Multiline = true;
            this.tabControlVenta.Name = "tabControlVenta";
            this.tabControlVenta.Padding = new System.Drawing.Point(6, 6);
            this.tabControlVenta.SelectedIndex = 0;
            this.tabControlVenta.Size = new System.Drawing.Size(770, 411);
            this.tabControlVenta.TabIndex = 1;
            // 
            // tabPageSeleccionarCliente
            // 
            this.tabPageSeleccionarCliente.Controls.Add(this.splitContainerSeleccionarCliente);
            this.tabPageSeleccionarCliente.Location = new System.Drawing.Point(4, 4);
            this.tabPageSeleccionarCliente.Name = "tabPageSeleccionarCliente";
            this.tabPageSeleccionarCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSeleccionarCliente.Size = new System.Drawing.Size(762, 379);
            this.tabPageSeleccionarCliente.TabIndex = 0;
            this.tabPageSeleccionarCliente.Text = "Seleccionar cliente";
            this.tabPageSeleccionarCliente.UseVisualStyleBackColor = true;
            // 
            // splitContainerSeleccionarCliente
            // 
            this.splitContainerSeleccionarCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerSeleccionarCliente.Location = new System.Drawing.Point(3, 3);
            this.splitContainerSeleccionarCliente.Name = "splitContainerSeleccionarCliente";
            // 
            // splitContainerSeleccionarCliente.Panel1
            // 
            this.splitContainerSeleccionarCliente.Panel1.Controls.Add(this.tabControlSeleccionarCliente);
            // 
            // splitContainerSeleccionarCliente.Panel2
            // 
            this.splitContainerSeleccionarCliente.Panel2.Controls.Add(this.groupBoxContactoClienteSeleccionado);
            this.splitContainerSeleccionarCliente.Panel2.Controls.Add(this.groupBoxDatosContactoClienteSeleccionado);
            this.splitContainerSeleccionarCliente.Panel2.Controls.Add(this.groupBoxClienteSeleccionado);
            this.splitContainerSeleccionarCliente.Size = new System.Drawing.Size(756, 373);
            this.splitContainerSeleccionarCliente.SplitterDistance = 252;
            this.splitContainerSeleccionarCliente.TabIndex = 0;
            // 
            // tabControlSeleccionarCliente
            // 
            this.tabControlSeleccionarCliente.Controls.Add(this.tabPageSeleccionarClienteIndividuo);
            this.tabControlSeleccionarCliente.Controls.Add(this.tabPageSeleccionarClienteEmpresa);
            this.tabControlSeleccionarCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSeleccionarCliente.Location = new System.Drawing.Point(0, 0);
            this.tabControlSeleccionarCliente.Name = "tabControlSeleccionarCliente";
            this.tabControlSeleccionarCliente.SelectedIndex = 0;
            this.tabControlSeleccionarCliente.Size = new System.Drawing.Size(252, 373);
            this.tabControlSeleccionarCliente.TabIndex = 0;
            this.tabControlSeleccionarCliente.SelectedIndexChanged += new System.EventHandler(this.tabControlSeleccionarCliente_SelectedIndexChanged);
            // 
            // tabPageSeleccionarClienteIndividuo
            // 
            this.tabPageSeleccionarClienteIndividuo.Controls.Add(this.dataGridViewSeleccionarClienteIndividuo);
            this.tabPageSeleccionarClienteIndividuo.Location = new System.Drawing.Point(4, 22);
            this.tabPageSeleccionarClienteIndividuo.Name = "tabPageSeleccionarClienteIndividuo";
            this.tabPageSeleccionarClienteIndividuo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSeleccionarClienteIndividuo.Size = new System.Drawing.Size(244, 347);
            this.tabPageSeleccionarClienteIndividuo.TabIndex = 0;
            this.tabPageSeleccionarClienteIndividuo.Text = "Particular";
            this.tabPageSeleccionarClienteIndividuo.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSeleccionarClienteIndividuo
            // 
            this.dataGridViewSeleccionarClienteIndividuo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeleccionarClienteIndividuo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSeleccionarClienteIndividuo.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSeleccionarClienteIndividuo.Name = "dataGridViewSeleccionarClienteIndividuo";
            this.dataGridViewSeleccionarClienteIndividuo.Size = new System.Drawing.Size(238, 341);
            this.dataGridViewSeleccionarClienteIndividuo.TabIndex = 0;
            this.dataGridViewSeleccionarClienteIndividuo.DoubleClick += new System.EventHandler(this.dataGridViewSeleccionarClienteIndividuo_DoubleClick);
            // 
            // tabPageSeleccionarClienteEmpresa
            // 
            this.tabPageSeleccionarClienteEmpresa.Controls.Add(this.dataGridViewSeleccionarClienteEmpresa);
            this.tabPageSeleccionarClienteEmpresa.Location = new System.Drawing.Point(4, 22);
            this.tabPageSeleccionarClienteEmpresa.Name = "tabPageSeleccionarClienteEmpresa";
            this.tabPageSeleccionarClienteEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSeleccionarClienteEmpresa.Size = new System.Drawing.Size(244, 347);
            this.tabPageSeleccionarClienteEmpresa.TabIndex = 1;
            this.tabPageSeleccionarClienteEmpresa.Text = "Empresa";
            this.tabPageSeleccionarClienteEmpresa.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSeleccionarClienteEmpresa
            // 
            this.dataGridViewSeleccionarClienteEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeleccionarClienteEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSeleccionarClienteEmpresa.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSeleccionarClienteEmpresa.Name = "dataGridViewSeleccionarClienteEmpresa";
            this.dataGridViewSeleccionarClienteEmpresa.Size = new System.Drawing.Size(238, 341);
            this.dataGridViewSeleccionarClienteEmpresa.TabIndex = 0;
            this.dataGridViewSeleccionarClienteEmpresa.DoubleClick += new System.EventHandler(this.dataGridViewSeleccionarClienteEmpresa_DoubleClick);
            // 
            // groupBoxContactoClienteSeleccionado
            // 
            this.groupBoxContactoClienteSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxContactoClienteSeleccionado.Controls.Add(this.labelNombreContactoClienteSeleccionado);
            this.groupBoxContactoClienteSeleccionado.Controls.Add(this.labelDireccionContactoClienteSeleccionado);
            this.groupBoxContactoClienteSeleccionado.Controls.Add(this.labelTelefonoContactoClienteSeleccionado);
            this.groupBoxContactoClienteSeleccionado.Controls.Add(this.labelEmailContactoClienteSeleccionado);
            this.groupBoxContactoClienteSeleccionado.Location = new System.Drawing.Point(16, 229);
            this.groupBoxContactoClienteSeleccionado.Name = "groupBoxContactoClienteSeleccionado";
            this.groupBoxContactoClienteSeleccionado.Size = new System.Drawing.Size(468, 124);
            this.groupBoxContactoClienteSeleccionado.TabIndex = 2;
            this.groupBoxContactoClienteSeleccionado.TabStop = false;
            this.groupBoxContactoClienteSeleccionado.Text = "Persona de contacto";
            this.groupBoxContactoClienteSeleccionado.Visible = false;
            // 
            // labelNombreContactoClienteSeleccionado
            // 
            this.labelNombreContactoClienteSeleccionado.AutoSize = true;
            this.labelNombreContactoClienteSeleccionado.Location = new System.Drawing.Point(17, 21);
            this.labelNombreContactoClienteSeleccionado.Name = "labelNombreContactoClienteSeleccionado";
            this.labelNombreContactoClienteSeleccionado.Size = new System.Drawing.Size(44, 13);
            this.labelNombreContactoClienteSeleccionado.TabIndex = 5;
            this.labelNombreContactoClienteSeleccionado.Text = "Nombre";
            // 
            // labelDireccionContactoClienteSeleccionado
            // 
            this.labelDireccionContactoClienteSeleccionado.AutoSize = true;
            this.labelDireccionContactoClienteSeleccionado.Location = new System.Drawing.Point(12, 95);
            this.labelDireccionContactoClienteSeleccionado.Name = "labelDireccionContactoClienteSeleccionado";
            this.labelDireccionContactoClienteSeleccionado.Size = new System.Drawing.Size(52, 13);
            this.labelDireccionContactoClienteSeleccionado.TabIndex = 4;
            this.labelDireccionContactoClienteSeleccionado.Text = "Dirección";
            // 
            // labelTelefonoContactoClienteSeleccionado
            // 
            this.labelTelefonoContactoClienteSeleccionado.AutoSize = true;
            this.labelTelefonoContactoClienteSeleccionado.Location = new System.Drawing.Point(12, 69);
            this.labelTelefonoContactoClienteSeleccionado.Name = "labelTelefonoContactoClienteSeleccionado";
            this.labelTelefonoContactoClienteSeleccionado.Size = new System.Drawing.Size(49, 13);
            this.labelTelefonoContactoClienteSeleccionado.TabIndex = 3;
            this.labelTelefonoContactoClienteSeleccionado.Text = "Teléfono";
            // 
            // labelEmailContactoClienteSeleccionado
            // 
            this.labelEmailContactoClienteSeleccionado.AutoSize = true;
            this.labelEmailContactoClienteSeleccionado.Location = new System.Drawing.Point(29, 45);
            this.labelEmailContactoClienteSeleccionado.Name = "labelEmailContactoClienteSeleccionado";
            this.labelEmailContactoClienteSeleccionado.Size = new System.Drawing.Size(32, 13);
            this.labelEmailContactoClienteSeleccionado.TabIndex = 2;
            this.labelEmailContactoClienteSeleccionado.Text = "Email";
            // 
            // groupBoxDatosContactoClienteSeleccionado
            // 
            this.groupBoxDatosContactoClienteSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDatosContactoClienteSeleccionado.Controls.Add(this.labelDireccionClienteSeleccionado);
            this.groupBoxDatosContactoClienteSeleccionado.Controls.Add(this.labelTelefonoClienteSeleccionado);
            this.groupBoxDatosContactoClienteSeleccionado.Controls.Add(this.labelEmailClienteSeleccionado);
            this.groupBoxDatosContactoClienteSeleccionado.Location = new System.Drawing.Point(16, 110);
            this.groupBoxDatosContactoClienteSeleccionado.Name = "groupBoxDatosContactoClienteSeleccionado";
            this.groupBoxDatosContactoClienteSeleccionado.Size = new System.Drawing.Size(468, 102);
            this.groupBoxDatosContactoClienteSeleccionado.TabIndex = 1;
            this.groupBoxDatosContactoClienteSeleccionado.TabStop = false;
            this.groupBoxDatosContactoClienteSeleccionado.Text = "Información de contacto";
            // 
            // labelDireccionClienteSeleccionado
            // 
            this.labelDireccionClienteSeleccionado.AutoSize = true;
            this.labelDireccionClienteSeleccionado.Location = new System.Drawing.Point(12, 76);
            this.labelDireccionClienteSeleccionado.Name = "labelDireccionClienteSeleccionado";
            this.labelDireccionClienteSeleccionado.Size = new System.Drawing.Size(52, 13);
            this.labelDireccionClienteSeleccionado.TabIndex = 4;
            this.labelDireccionClienteSeleccionado.Text = "Dirección";
            // 
            // labelTelefonoClienteSeleccionado
            // 
            this.labelTelefonoClienteSeleccionado.AutoSize = true;
            this.labelTelefonoClienteSeleccionado.Location = new System.Drawing.Point(12, 50);
            this.labelTelefonoClienteSeleccionado.Name = "labelTelefonoClienteSeleccionado";
            this.labelTelefonoClienteSeleccionado.Size = new System.Drawing.Size(49, 13);
            this.labelTelefonoClienteSeleccionado.TabIndex = 3;
            this.labelTelefonoClienteSeleccionado.Text = "Teléfono";
            // 
            // labelEmailClienteSeleccionado
            // 
            this.labelEmailClienteSeleccionado.AutoSize = true;
            this.labelEmailClienteSeleccionado.Location = new System.Drawing.Point(29, 25);
            this.labelEmailClienteSeleccionado.Name = "labelEmailClienteSeleccionado";
            this.labelEmailClienteSeleccionado.Size = new System.Drawing.Size(32, 13);
            this.labelEmailClienteSeleccionado.TabIndex = 2;
            this.labelEmailClienteSeleccionado.Text = "Email";
            // 
            // groupBoxClienteSeleccionado
            // 
            this.groupBoxClienteSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxClienteSeleccionado.Controls.Add(this.labelCUITClienteSeleccionado);
            this.groupBoxClienteSeleccionado.Controls.Add(this.labelNombreClienteSeleccionado);
            this.groupBoxClienteSeleccionado.Location = new System.Drawing.Point(16, 22);
            this.groupBoxClienteSeleccionado.Name = "groupBoxClienteSeleccionado";
            this.groupBoxClienteSeleccionado.Size = new System.Drawing.Size(468, 75);
            this.groupBoxClienteSeleccionado.TabIndex = 0;
            this.groupBoxClienteSeleccionado.TabStop = false;
            this.groupBoxClienteSeleccionado.Text = "Cliente seleccionado";
            // 
            // labelCUITClienteSeleccionado
            // 
            this.labelCUITClienteSeleccionado.AutoSize = true;
            this.labelCUITClienteSeleccionado.Location = new System.Drawing.Point(20, 51);
            this.labelCUITClienteSeleccionado.Name = "labelCUITClienteSeleccionado";
            this.labelCUITClienteSeleccionado.Size = new System.Drawing.Size(41, 13);
            this.labelCUITClienteSeleccionado.TabIndex = 1;
            this.labelCUITClienteSeleccionado.Text = "C.U.I.T";
            // 
            // labelNombreClienteSeleccionado
            // 
            this.labelNombreClienteSeleccionado.AutoSize = true;
            this.labelNombreClienteSeleccionado.Location = new System.Drawing.Point(17, 25);
            this.labelNombreClienteSeleccionado.Name = "labelNombreClienteSeleccionado";
            this.labelNombreClienteSeleccionado.Size = new System.Drawing.Size(44, 13);
            this.labelNombreClienteSeleccionado.TabIndex = 0;
            this.labelNombreClienteSeleccionado.Text = "Nombre";
            // 
            // tabPageConfigurarPedido
            // 
            this.tabPageConfigurarPedido.Controls.Add(this.splitContainerConfigurarPedido);
            this.tabPageConfigurarPedido.Location = new System.Drawing.Point(4, 4);
            this.tabPageConfigurarPedido.Name = "tabPageConfigurarPedido";
            this.tabPageConfigurarPedido.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfigurarPedido.Size = new System.Drawing.Size(762, 379);
            this.tabPageConfigurarPedido.TabIndex = 1;
            this.tabPageConfigurarPedido.Text = "Configurar pedido";
            this.tabPageConfigurarPedido.UseVisualStyleBackColor = true;
            // 
            // splitContainerConfigurarPedido
            // 
            this.splitContainerConfigurarPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerConfigurarPedido.Location = new System.Drawing.Point(3, 3);
            this.splitContainerConfigurarPedido.Name = "splitContainerConfigurarPedido";
            // 
            // splitContainerConfigurarPedido.Panel1
            // 
            this.splitContainerConfigurarPedido.Panel1.Controls.Add(this.dataGridViewPedidoProductos);
            this.splitContainerConfigurarPedido.Panel1.Controls.Add(this.panelCategorias);
            // 
            // splitContainerConfigurarPedido.Panel2
            // 
            this.splitContainerConfigurarPedido.Panel2.Controls.Add(this.panelCondiciones);
            this.splitContainerConfigurarPedido.Panel2.Controls.Add(this.dataGridViewPedido);
            this.splitContainerConfigurarPedido.Panel2.Controls.Add(this.panelTotal);
            this.splitContainerConfigurarPedido.Size = new System.Drawing.Size(756, 373);
            this.splitContainerConfigurarPedido.SplitterDistance = 252;
            this.splitContainerConfigurarPedido.TabIndex = 0;
            // 
            // dataGridViewPedidoProductos
            // 
            this.dataGridViewPedidoProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPedidoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidoProductos.Location = new System.Drawing.Point(14, 103);
            this.dataGridViewPedidoProductos.Name = "dataGridViewPedidoProductos";
            this.dataGridViewPedidoProductos.Size = new System.Drawing.Size(223, 255);
            this.dataGridViewPedidoProductos.TabIndex = 1;
            this.dataGridViewPedidoProductos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewPedidoProductos_MouseDown);
            // 
            // panelCategorias
            // 
            this.panelCategorias.Controls.Add(this.comboBoxSubcategoria);
            this.panelCategorias.Controls.Add(this.comboBoxCategoria);
            this.panelCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCategorias.Location = new System.Drawing.Point(0, 0);
            this.panelCategorias.Name = "panelCategorias";
            this.panelCategorias.Size = new System.Drawing.Size(252, 87);
            this.panelCategorias.TabIndex = 0;
            // 
            // comboBoxSubcategoria
            // 
            this.comboBoxSubcategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSubcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubcategoria.FormattingEnabled = true;
            this.comboBoxSubcategoria.Location = new System.Drawing.Point(14, 47);
            this.comboBoxSubcategoria.Name = "comboBoxSubcategoria";
            this.comboBoxSubcategoria.Size = new System.Drawing.Size(224, 21);
            this.comboBoxSubcategoria.TabIndex = 1;
            this.comboBoxSubcategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubcategoria_SelectedIndexChanged);
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(13, 14);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(224, 21);
            this.comboBoxCategoria.TabIndex = 0;
            this.comboBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoria_SelectedIndexChanged);
            // 
            // panelCondiciones
            // 
            this.panelCondiciones.Controls.Add(this.comboBoxCondicionVenta);
            this.panelCondiciones.Controls.Add(this.comboBoxCondicionIVA);
            this.panelCondiciones.Controls.Add(this.labelCondicionVenta);
            this.panelCondiciones.Controls.Add(this.labelCondicionIVA);
            this.panelCondiciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCondiciones.Location = new System.Drawing.Point(0, 0);
            this.panelCondiciones.Name = "panelCondiciones";
            this.panelCondiciones.Size = new System.Drawing.Size(500, 87);
            this.panelCondiciones.TabIndex = 2;
            // 
            // comboBoxCondicionVenta
            // 
            this.comboBoxCondicionVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCondicionVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCondicionVenta.FormattingEnabled = true;
            this.comboBoxCondicionVenta.Location = new System.Drawing.Point(148, 47);
            this.comboBoxCondicionVenta.Name = "comboBoxCondicionVenta";
            this.comboBoxCondicionVenta.Size = new System.Drawing.Size(340, 21);
            this.comboBoxCondicionVenta.TabIndex = 3;
            // 
            // comboBoxCondicionIVA
            // 
            this.comboBoxCondicionIVA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCondicionIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCondicionIVA.FormattingEnabled = true;
            this.comboBoxCondicionIVA.Location = new System.Drawing.Point(148, 19);
            this.comboBoxCondicionIVA.Name = "comboBoxCondicionIVA";
            this.comboBoxCondicionIVA.Size = new System.Drawing.Size(340, 21);
            this.comboBoxCondicionIVA.TabIndex = 2;
            // 
            // labelCondicionVenta
            // 
            this.labelCondicionVenta.AutoSize = true;
            this.labelCondicionVenta.Location = new System.Drawing.Point(43, 50);
            this.labelCondicionVenta.Name = "labelCondicionVenta";
            this.labelCondicionVenta.Size = new System.Drawing.Size(99, 13);
            this.labelCondicionVenta.TabIndex = 1;
            this.labelCondicionVenta.Text = "Condición de venta";
            // 
            // labelCondicionIVA
            // 
            this.labelCondicionIVA.AutoSize = true;
            this.labelCondicionIVA.Location = new System.Drawing.Point(18, 22);
            this.labelCondicionIVA.Name = "labelCondicionIVA";
            this.labelCondicionIVA.Size = new System.Drawing.Size(124, 13);
            this.labelCondicionIVA.TabIndex = 0;
            this.labelCondicionIVA.Text = "Condición frente al I.V.A.";
            // 
            // dataGridViewPedido
            // 
            this.dataGridViewPedido.AllowDrop = true;
            this.dataGridViewPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedido.ContextMenuStrip = this.contextMenuStripDataGridViewPedido;
            this.dataGridViewPedido.Location = new System.Drawing.Point(21, 103);
            this.dataGridViewPedido.Name = "dataGridViewPedido";
            this.dataGridViewPedido.Size = new System.Drawing.Size(467, 217);
            this.dataGridViewPedido.TabIndex = 1;
            this.dataGridViewPedido.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridViewPedido_DragDrop);
            this.dataGridViewPedido.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridViewPedido_DragEnter);
            // 
            // contextMenuStripDataGridViewPedido
            // 
            this.contextMenuStripDataGridViewPedido.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemModificar,
            this.toolStripMenuItemEliminar});
            this.contextMenuStripDataGridViewPedido.Name = "contextMenuStripDataGridViewPedido";
            this.contextMenuStripDataGridViewPedido.Size = new System.Drawing.Size(126, 48);
            // 
            // toolStripMenuItemModificar
            // 
            this.toolStripMenuItemModificar.Name = "toolStripMenuItemModificar";
            this.toolStripMenuItemModificar.Size = new System.Drawing.Size(125, 22);
            this.toolStripMenuItemModificar.Text = "Modificar";
            this.toolStripMenuItemModificar.Click += new System.EventHandler(this.toolStripMenuItemModificar_Click);
            // 
            // toolStripMenuItemEliminar
            // 
            this.toolStripMenuItemEliminar.Name = "toolStripMenuItemEliminar";
            this.toolStripMenuItemEliminar.Size = new System.Drawing.Size(125, 22);
            this.toolStripMenuItemEliminar.Text = "Eliminar";
            this.toolStripMenuItemEliminar.Click += new System.EventHandler(this.toolStripMenuItemEliminar_Click);
            // 
            // panelTotal
            // 
            this.panelTotal.Controls.Add(this.labelTotal);
            this.panelTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTotal.Location = new System.Drawing.Point(0, 326);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(500, 47);
            this.panelTotal.TabIndex = 0;
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotal.Location = new System.Drawing.Point(352, 19);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(139, 13);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Total";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // toolStripVentas
            // 
            this.toolStripVentas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripVentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAbrirVenta,
            this.toolStripButtonCancelarVenta,
            this.toolStripButtonCerrarVenta});
            this.toolStripVentas.Location = new System.Drawing.Point(3, 3);
            this.toolStripVentas.Name = "toolStripVentas";
            this.toolStripVentas.Size = new System.Drawing.Size(770, 25);
            this.toolStripVentas.TabIndex = 0;
            this.toolStripVentas.Text = "toolStrip1";
            // 
            // toolStripButtonAbrirVenta
            // 
            this.toolStripButtonAbrirVenta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAbrirVenta.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbrirVenta.Image")));
            this.toolStripButtonAbrirVenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbrirVenta.Name = "toolStripButtonAbrirVenta";
            this.toolStripButtonAbrirVenta.Size = new System.Drawing.Size(37, 22);
            this.toolStripButtonAbrirVenta.Text = "Abrir";
            this.toolStripButtonAbrirVenta.ToolTipText = "Comienza una nueva transacción de venta.";
            this.toolStripButtonAbrirVenta.Click += new System.EventHandler(this.toolStripButtonAbrirVenta_Click);
            // 
            // toolStripButtonCancelarVenta
            // 
            this.toolStripButtonCancelarVenta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelarVenta.Enabled = false;
            this.toolStripButtonCancelarVenta.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelarVenta.Image")));
            this.toolStripButtonCancelarVenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelarVenta.Name = "toolStripButtonCancelarVenta";
            this.toolStripButtonCancelarVenta.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonCancelarVenta.Text = "Cancelar";
            this.toolStripButtonCancelarVenta.ToolTipText = "Cancela un transacción de venta en curso.";
            this.toolStripButtonCancelarVenta.Click += new System.EventHandler(this.toolStripButtonCancelarVenta_Click);
            // 
            // toolStripButtonCerrarVenta
            // 
            this.toolStripButtonCerrarVenta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCerrarVenta.Enabled = false;
            this.toolStripButtonCerrarVenta.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCerrarVenta.Image")));
            this.toolStripButtonCerrarVenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCerrarVenta.Name = "toolStripButtonCerrarVenta";
            this.toolStripButtonCerrarVenta.Size = new System.Drawing.Size(43, 22);
            this.toolStripButtonCerrarVenta.Text = "Cerrar";
            this.toolStripButtonCerrarVenta.ToolTipText = "Confirma la transacción de venta.";
            this.toolStripButtonCerrarVenta.Click += new System.EventHandler(this.toolStripButtonCerrarVenta_Click);
            // 
            // tabPageProductos
            // 
            this.tabPageProductos.Controls.Add(this.dataGridViewProductos);
            this.tabPageProductos.Controls.Add(this.toolStripProductos);
            this.tabPageProductos.Location = new System.Drawing.Point(4, 28);
            this.tabPageProductos.Name = "tabPageProductos";
            this.tabPageProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProductos.Size = new System.Drawing.Size(776, 442);
            this.tabPageProductos.TabIndex = 1;
            this.tabPageProductos.Text = "Catálogo de productos";
            this.tabPageProductos.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProductos.Location = new System.Drawing.Point(3, 28);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.Size = new System.Drawing.Size(770, 411);
            this.dataGridViewProductos.TabIndex = 2;
            // 
            // toolStripProductos
            // 
            this.toolStripProductos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripProductos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAgregarProducto,
            this.toolStripButtonModificarProducto,
            this.toolStripButtonEliminarProducto});
            this.toolStripProductos.Location = new System.Drawing.Point(3, 3);
            this.toolStripProductos.Name = "toolStripProductos";
            this.toolStripProductos.Size = new System.Drawing.Size(770, 25);
            this.toolStripProductos.TabIndex = 1;
            this.toolStripProductos.Text = "toolStrip1";
            // 
            // toolStripButtonAgregarProducto
            // 
            this.toolStripButtonAgregarProducto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAgregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAgregarProducto.Image")));
            this.toolStripButtonAgregarProducto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAgregarProducto.Name = "toolStripButtonAgregarProducto";
            this.toolStripButtonAgregarProducto.Size = new System.Drawing.Size(53, 22);
            this.toolStripButtonAgregarProducto.Text = "Agregar";
            this.toolStripButtonAgregarProducto.ToolTipText = "Agrega un nuevo producto.";
            this.toolStripButtonAgregarProducto.Click += new System.EventHandler(this.toolStripButtonAgregarProducto_Click);
            // 
            // toolStripButtonModificarProducto
            // 
            this.toolStripButtonModificarProducto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonModificarProducto.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonModificarProducto.Image")));
            this.toolStripButtonModificarProducto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonModificarProducto.Name = "toolStripButtonModificarProducto";
            this.toolStripButtonModificarProducto.Size = new System.Drawing.Size(62, 22);
            this.toolStripButtonModificarProducto.Text = "Modificar";
            this.toolStripButtonModificarProducto.ToolTipText = "Modifica el producto seleccionado.";
            this.toolStripButtonModificarProducto.Click += new System.EventHandler(this.toolStripButtonModificarProducto_Click);
            // 
            // toolStripButtonEliminarProducto
            // 
            this.toolStripButtonEliminarProducto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEliminarProducto.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEliminarProducto.Image")));
            this.toolStripButtonEliminarProducto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEliminarProducto.Name = "toolStripButtonEliminarProducto";
            this.toolStripButtonEliminarProducto.Size = new System.Drawing.Size(54, 22);
            this.toolStripButtonEliminarProducto.Text = "Eliminar";
            this.toolStripButtonEliminarProducto.ToolTipText = "Elimina el producto seleccionado.";
            this.toolStripButtonEliminarProducto.Click += new System.EventHandler(this.toolStripButtonEliminarProducto_Click);
            // 
            // tabPageClientes
            // 
            this.tabPageClientes.Controls.Add(this.tabControlClientes);
            this.tabPageClientes.Controls.Add(this.toolStripClientes);
            this.tabPageClientes.Location = new System.Drawing.Point(4, 28);
            this.tabPageClientes.Name = "tabPageClientes";
            this.tabPageClientes.Size = new System.Drawing.Size(776, 442);
            this.tabPageClientes.TabIndex = 2;
            this.tabPageClientes.Text = "Clientes";
            this.tabPageClientes.UseVisualStyleBackColor = true;
            // 
            // tabControlClientes
            // 
            this.tabControlClientes.Controls.Add(this.tabPageClienteIndividuo);
            this.tabControlClientes.Controls.Add(this.tabControlClienteEmpresa);
            this.tabControlClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlClientes.Location = new System.Drawing.Point(0, 25);
            this.tabControlClientes.Name = "tabControlClientes";
            this.tabControlClientes.Padding = new System.Drawing.Point(6, 6);
            this.tabControlClientes.SelectedIndex = 0;
            this.tabControlClientes.Size = new System.Drawing.Size(776, 417);
            this.tabControlClientes.TabIndex = 0;
            // 
            // tabPageClienteIndividuo
            // 
            this.tabPageClienteIndividuo.Controls.Add(this.dataGridViewClientesIndividuo);
            this.tabPageClienteIndividuo.Location = new System.Drawing.Point(4, 28);
            this.tabPageClienteIndividuo.Name = "tabPageClienteIndividuo";
            this.tabPageClienteIndividuo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClienteIndividuo.Size = new System.Drawing.Size(768, 385);
            this.tabPageClienteIndividuo.TabIndex = 0;
            this.tabPageClienteIndividuo.Text = "Particulares";
            this.tabPageClienteIndividuo.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClientesIndividuo
            // 
            this.dataGridViewClientesIndividuo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientesIndividuo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClientesIndividuo.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewClientesIndividuo.Name = "dataGridViewClientesIndividuo";
            this.dataGridViewClientesIndividuo.Size = new System.Drawing.Size(762, 379);
            this.dataGridViewClientesIndividuo.TabIndex = 0;
            // 
            // tabControlClienteEmpresa
            // 
            this.tabControlClienteEmpresa.Controls.Add(this.dataGridViewClientesEmpresa);
            this.tabControlClienteEmpresa.Location = new System.Drawing.Point(4, 28);
            this.tabControlClienteEmpresa.Name = "tabControlClienteEmpresa";
            this.tabControlClienteEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tabControlClienteEmpresa.Size = new System.Drawing.Size(768, 385);
            this.tabControlClienteEmpresa.TabIndex = 1;
            this.tabControlClienteEmpresa.Text = "Empresas";
            this.tabControlClienteEmpresa.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClientesEmpresa
            // 
            this.dataGridViewClientesEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientesEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClientesEmpresa.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewClientesEmpresa.Name = "dataGridViewClientesEmpresa";
            this.dataGridViewClientesEmpresa.Size = new System.Drawing.Size(762, 379);
            this.dataGridViewClientesEmpresa.TabIndex = 0;
            // 
            // toolStripClientes
            // 
            this.toolStripClientes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripClientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAgregarCliente,
            this.toolStripButtonModificarCliente,
            this.toolStripButtonEliminarCliente});
            this.toolStripClientes.Location = new System.Drawing.Point(0, 0);
            this.toolStripClientes.Name = "toolStripClientes";
            this.toolStripClientes.Size = new System.Drawing.Size(776, 25);
            this.toolStripClientes.TabIndex = 2;
            this.toolStripClientes.Text = "toolStrip1";
            // 
            // toolStripButtonAgregarCliente
            // 
            this.toolStripButtonAgregarCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAgregarCliente.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAgregarCliente.Image")));
            this.toolStripButtonAgregarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAgregarCliente.Name = "toolStripButtonAgregarCliente";
            this.toolStripButtonAgregarCliente.Size = new System.Drawing.Size(53, 22);
            this.toolStripButtonAgregarCliente.Text = "Agregar";
            this.toolStripButtonAgregarCliente.ToolTipText = "Agrega un nuevo cliente.";
            this.toolStripButtonAgregarCliente.Click += new System.EventHandler(this.toolStripButtonAgregarCliente_Click);
            // 
            // toolStripButtonModificarCliente
            // 
            this.toolStripButtonModificarCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonModificarCliente.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonModificarCliente.Image")));
            this.toolStripButtonModificarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonModificarCliente.Name = "toolStripButtonModificarCliente";
            this.toolStripButtonModificarCliente.Size = new System.Drawing.Size(62, 22);
            this.toolStripButtonModificarCliente.Text = "Modificar";
            this.toolStripButtonModificarCliente.ToolTipText = "Modifica el cliente seleccionado.";
            this.toolStripButtonModificarCliente.Click += new System.EventHandler(this.toolStripButtonModificarCliente_Click);
            // 
            // toolStripButtonEliminarCliente
            // 
            this.toolStripButtonEliminarCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEliminarCliente.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEliminarCliente.Image")));
            this.toolStripButtonEliminarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEliminarCliente.Name = "toolStripButtonEliminarCliente";
            this.toolStripButtonEliminarCliente.Size = new System.Drawing.Size(54, 22);
            this.toolStripButtonEliminarCliente.Text = "Eliminar";
            this.toolStripButtonEliminarCliente.ToolTipText = "Elimina el cliente seleccionado.";
            this.toolStripButtonEliminarCliente.Click += new System.EventHandler(this.toolStripButtonEliminarCliente_Click);
            // 
            // tabPageProveedores
            // 
            this.tabPageProveedores.Controls.Add(this.dataGridViewProveedores);
            this.tabPageProveedores.Controls.Add(this.toolStripProveedores);
            this.tabPageProveedores.Location = new System.Drawing.Point(4, 28);
            this.tabPageProveedores.Name = "tabPageProveedores";
            this.tabPageProveedores.Size = new System.Drawing.Size(776, 442);
            this.tabPageProveedores.TabIndex = 3;
            this.tabPageProveedores.Text = "Proveedores";
            this.tabPageProveedores.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProveedores
            // 
            this.dataGridViewProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProveedores.Location = new System.Drawing.Point(0, 25);
            this.dataGridViewProveedores.Name = "dataGridViewProveedores";
            this.dataGridViewProveedores.Size = new System.Drawing.Size(776, 417);
            this.dataGridViewProveedores.TabIndex = 4;
            // 
            // toolStripProveedores
            // 
            this.toolStripProveedores.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripProveedores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAgregarProveedor,
            this.toolStripButtonModificarProveedor,
            this.toolStripButtonEliminarProveedor});
            this.toolStripProveedores.Location = new System.Drawing.Point(0, 0);
            this.toolStripProveedores.Name = "toolStripProveedores";
            this.toolStripProveedores.Size = new System.Drawing.Size(776, 25);
            this.toolStripProveedores.TabIndex = 3;
            this.toolStripProveedores.Text = "toolStrip1";
            // 
            // toolStripButtonAgregarProveedor
            // 
            this.toolStripButtonAgregarProveedor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAgregarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAgregarProveedor.Image")));
            this.toolStripButtonAgregarProveedor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAgregarProveedor.Name = "toolStripButtonAgregarProveedor";
            this.toolStripButtonAgregarProveedor.Size = new System.Drawing.Size(53, 22);
            this.toolStripButtonAgregarProveedor.Text = "Agregar";
            this.toolStripButtonAgregarProveedor.ToolTipText = "Agrega un nuevo proveedor.";
            this.toolStripButtonAgregarProveedor.Click += new System.EventHandler(this.toolStripButtonAgregarProveedor_Click);
            // 
            // toolStripButtonModificarProveedor
            // 
            this.toolStripButtonModificarProveedor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonModificarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonModificarProveedor.Image")));
            this.toolStripButtonModificarProveedor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonModificarProveedor.Name = "toolStripButtonModificarProveedor";
            this.toolStripButtonModificarProveedor.Size = new System.Drawing.Size(62, 22);
            this.toolStripButtonModificarProveedor.Text = "Modificar";
            this.toolStripButtonModificarProveedor.ToolTipText = "Modifica el proveedor seleccionado.";
            this.toolStripButtonModificarProveedor.Click += new System.EventHandler(this.toolStripButtonModificarProveedor_Click);
            // 
            // toolStripButtonEliminarProveedor
            // 
            this.toolStripButtonEliminarProveedor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEliminarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEliminarProveedor.Image")));
            this.toolStripButtonEliminarProveedor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEliminarProveedor.Name = "toolStripButtonEliminarProveedor";
            this.toolStripButtonEliminarProveedor.Size = new System.Drawing.Size(54, 22);
            this.toolStripButtonEliminarProveedor.Text = "Eliminar";
            this.toolStripButtonEliminarProveedor.ToolTipText = "Elimina el proveedor seleccionado.";
            this.toolStripButtonEliminarProveedor.Click += new System.EventHandler(this.toolStripButtonEliminarProveedor_Click);
            // 
            // tabPageDocumentosComerciales
            // 
            this.tabPageDocumentosComerciales.Controls.Add(this.tabControlDocumentosComerciales);
            this.tabPageDocumentosComerciales.Controls.Add(this.toolStripDocumentosComerciales);
            this.tabPageDocumentosComerciales.Location = new System.Drawing.Point(4, 28);
            this.tabPageDocumentosComerciales.Name = "tabPageDocumentosComerciales";
            this.tabPageDocumentosComerciales.Size = new System.Drawing.Size(776, 442);
            this.tabPageDocumentosComerciales.TabIndex = 4;
            this.tabPageDocumentosComerciales.Text = "Facturas y remitos";
            this.tabPageDocumentosComerciales.UseVisualStyleBackColor = true;
            // 
            // tabControlDocumentosComerciales
            // 
            this.tabControlDocumentosComerciales.Controls.Add(this.tabPageFacturas);
            this.tabControlDocumentosComerciales.Controls.Add(this.tabPageRemitos);
            this.tabControlDocumentosComerciales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDocumentosComerciales.Location = new System.Drawing.Point(0, 25);
            this.tabControlDocumentosComerciales.Name = "tabControlDocumentosComerciales";
            this.tabControlDocumentosComerciales.Padding = new System.Drawing.Point(6, 6);
            this.tabControlDocumentosComerciales.SelectedIndex = 0;
            this.tabControlDocumentosComerciales.Size = new System.Drawing.Size(776, 417);
            this.tabControlDocumentosComerciales.TabIndex = 6;
            // 
            // tabPageFacturas
            // 
            this.tabPageFacturas.Controls.Add(this.dataGridViewFacturas);
            this.tabPageFacturas.Location = new System.Drawing.Point(4, 28);
            this.tabPageFacturas.Name = "tabPageFacturas";
            this.tabPageFacturas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFacturas.Size = new System.Drawing.Size(768, 385);
            this.tabPageFacturas.TabIndex = 0;
            this.tabPageFacturas.Text = "Facturas";
            this.tabPageFacturas.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFacturas
            // 
            this.dataGridViewFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFacturas.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewFacturas.Name = "dataGridViewFacturas";
            this.dataGridViewFacturas.Size = new System.Drawing.Size(762, 379);
            this.dataGridViewFacturas.TabIndex = 0;
            // 
            // tabPageRemitos
            // 
            this.tabPageRemitos.Controls.Add(this.dataGridViewRemitos);
            this.tabPageRemitos.Location = new System.Drawing.Point(4, 28);
            this.tabPageRemitos.Name = "tabPageRemitos";
            this.tabPageRemitos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRemitos.Size = new System.Drawing.Size(768, 385);
            this.tabPageRemitos.TabIndex = 1;
            this.tabPageRemitos.Text = "Remitos";
            this.tabPageRemitos.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRemitos
            // 
            this.dataGridViewRemitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRemitos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRemitos.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewRemitos.Name = "dataGridViewRemitos";
            this.dataGridViewRemitos.Size = new System.Drawing.Size(762, 379);
            this.dataGridViewRemitos.TabIndex = 0;
            // 
            // toolStripDocumentosComerciales
            // 
            this.toolStripDocumentosComerciales.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripDocumentosComerciales.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonOrdenar});
            this.toolStripDocumentosComerciales.Location = new System.Drawing.Point(0, 0);
            this.toolStripDocumentosComerciales.Name = "toolStripDocumentosComerciales";
            this.toolStripDocumentosComerciales.Size = new System.Drawing.Size(776, 25);
            this.toolStripDocumentosComerciales.TabIndex = 4;
            this.toolStripDocumentosComerciales.Text = "toolStrip1";
            // 
            // toolStripDropDownButtonOrdenar
            // 
            this.toolStripDropDownButtonOrdenar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonOrdenar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.fechaToolStripMenuItem});
            this.toolStripDropDownButtonOrdenar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonOrdenar.Image")));
            this.toolStripDropDownButtonOrdenar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonOrdenar.Name = "toolStripDropDownButtonOrdenar";
            this.toolStripDropDownButtonOrdenar.Size = new System.Drawing.Size(84, 22);
            this.toolStripDropDownButtonOrdenar.Text = "Ordenar por";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Checked = true;
            this.clienteToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // fechaToolStripMenuItem
            // 
            this.fechaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendenteToolStripMenuItem,
            this.descendenteToolStripMenuItem});
            this.fechaToolStripMenuItem.Name = "fechaToolStripMenuItem";
            this.fechaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fechaToolStripMenuItem.Text = "Fecha";
            // 
            // ascendenteToolStripMenuItem
            // 
            this.ascendenteToolStripMenuItem.Name = "ascendenteToolStripMenuItem";
            this.ascendenteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ascendenteToolStripMenuItem.Text = "Ascendente";
            this.ascendenteToolStripMenuItem.Click += new System.EventHandler(this.ascendenteToolStripMenuItem_Click);
            // 
            // descendenteToolStripMenuItem
            // 
            this.descendenteToolStripMenuItem.Name = "descendenteToolStripMenuItem";
            this.descendenteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.descendenteToolStripMenuItem.Text = "Descendente";
            this.descendenteToolStripMenuItem.Click += new System.EventHandler(this.descendenteToolStripMenuItem_Click);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(784, 536);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 520);
            this.Controls.Add(this.tabControlPrincipal);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControlPrincipal.ResumeLayout(false);
            this.tabPageVentas.ResumeLayout(false);
            this.tabPageVentas.PerformLayout();
            this.tabControlVenta.ResumeLayout(false);
            this.tabPageSeleccionarCliente.ResumeLayout(false);
            this.splitContainerSeleccionarCliente.Panel1.ResumeLayout(false);
            this.splitContainerSeleccionarCliente.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSeleccionarCliente)).EndInit();
            this.splitContainerSeleccionarCliente.ResumeLayout(false);
            this.tabControlSeleccionarCliente.ResumeLayout(false);
            this.tabPageSeleccionarClienteIndividuo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeleccionarClienteIndividuo)).EndInit();
            this.tabPageSeleccionarClienteEmpresa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeleccionarClienteEmpresa)).EndInit();
            this.groupBoxContactoClienteSeleccionado.ResumeLayout(false);
            this.groupBoxContactoClienteSeleccionado.PerformLayout();
            this.groupBoxDatosContactoClienteSeleccionado.ResumeLayout(false);
            this.groupBoxDatosContactoClienteSeleccionado.PerformLayout();
            this.groupBoxClienteSeleccionado.ResumeLayout(false);
            this.groupBoxClienteSeleccionado.PerformLayout();
            this.tabPageConfigurarPedido.ResumeLayout(false);
            this.splitContainerConfigurarPedido.Panel1.ResumeLayout(false);
            this.splitContainerConfigurarPedido.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerConfigurarPedido)).EndInit();
            this.splitContainerConfigurarPedido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidoProductos)).EndInit();
            this.panelCategorias.ResumeLayout(false);
            this.panelCondiciones.ResumeLayout(false);
            this.panelCondiciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).EndInit();
            this.contextMenuStripDataGridViewPedido.ResumeLayout(false);
            this.panelTotal.ResumeLayout(false);
            this.toolStripVentas.ResumeLayout(false);
            this.toolStripVentas.PerformLayout();
            this.tabPageProductos.ResumeLayout(false);
            this.tabPageProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.toolStripProductos.ResumeLayout(false);
            this.toolStripProductos.PerformLayout();
            this.tabPageClientes.ResumeLayout(false);
            this.tabPageClientes.PerformLayout();
            this.tabControlClientes.ResumeLayout(false);
            this.tabPageClienteIndividuo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientesIndividuo)).EndInit();
            this.tabControlClienteEmpresa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientesEmpresa)).EndInit();
            this.toolStripClientes.ResumeLayout(false);
            this.toolStripClientes.PerformLayout();
            this.tabPageProveedores.ResumeLayout(false);
            this.tabPageProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProveedores)).EndInit();
            this.toolStripProveedores.ResumeLayout(false);
            this.toolStripProveedores.PerformLayout();
            this.tabPageDocumentosComerciales.ResumeLayout(false);
            this.tabPageDocumentosComerciales.PerformLayout();
            this.tabControlDocumentosComerciales.ResumeLayout(false);
            this.tabPageFacturas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturas)).EndInit();
            this.tabPageRemitos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRemitos)).EndInit();
            this.toolStripDocumentosComerciales.ResumeLayout(false);
            this.toolStripDocumentosComerciales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUsuario;
        private System.Windows.Forms.TabControl tabControlPrincipal;
        private System.Windows.Forms.TabPage tabPageVentas;
        private System.Windows.Forms.TabPage tabPageProductos;
        private System.Windows.Forms.TabPage tabPageClientes;
        private System.Windows.Forms.TabPage tabPageProveedores;
        private System.Windows.Forms.TabPage tabPageDocumentosComerciales;
        private System.Windows.Forms.ToolStrip toolStripVentas;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbrirVenta;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelarVenta;
        private System.Windows.Forms.ToolStripButton toolStripButtonCerrarVenta;
        private System.Windows.Forms.TabControl tabControlVenta;
        private System.Windows.Forms.TabPage tabPageSeleccionarCliente;
        private System.Windows.Forms.TabPage tabPageConfigurarPedido;
        private System.Windows.Forms.SplitContainer splitContainerSeleccionarCliente;
        private System.Windows.Forms.TabControl tabControlSeleccionarCliente;
        private System.Windows.Forms.TabPage tabPageSeleccionarClienteIndividuo;
        private System.Windows.Forms.TabPage tabPageSeleccionarClienteEmpresa;
        private System.Windows.Forms.DataGridView dataGridViewSeleccionarClienteIndividuo;
        private System.Windows.Forms.DataGridView dataGridViewSeleccionarClienteEmpresa;
        private System.Windows.Forms.GroupBox groupBoxClienteSeleccionado;
        private System.Windows.Forms.GroupBox groupBoxDatosContactoClienteSeleccionado;
        private System.Windows.Forms.Label labelCUITClienteSeleccionado;
        private System.Windows.Forms.Label labelNombreClienteSeleccionado;
        private System.Windows.Forms.Label labelDireccionClienteSeleccionado;
        private System.Windows.Forms.Label labelTelefonoClienteSeleccionado;
        private System.Windows.Forms.Label labelEmailClienteSeleccionado;
        private System.Windows.Forms.GroupBox groupBoxContactoClienteSeleccionado;
        private System.Windows.Forms.Label labelNombreContactoClienteSeleccionado;
        private System.Windows.Forms.Label labelDireccionContactoClienteSeleccionado;
        private System.Windows.Forms.Label labelTelefonoContactoClienteSeleccionado;
        private System.Windows.Forms.Label labelEmailContactoClienteSeleccionado;
        private System.Windows.Forms.SplitContainer splitContainerConfigurarPedido;
        private System.Windows.Forms.DataGridView dataGridViewPedidoProductos;
        private System.Windows.Forms.Panel panelCategorias;
        private System.Windows.Forms.DataGridView dataGridViewPedido;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.ComboBox comboBoxSubcategoria;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Panel panelCondiciones;
        private System.Windows.Forms.ComboBox comboBoxCondicionVenta;
        private System.Windows.Forms.ComboBox comboBoxCondicionIVA;
        private System.Windows.Forms.Label labelCondicionVenta;
        private System.Windows.Forms.Label labelCondicionIVA;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.ToolStrip toolStripProductos;
        private System.Windows.Forms.ToolStripButton toolStripButtonAgregarProducto;
        private System.Windows.Forms.ToolStripButton toolStripButtonModificarProducto;
        private System.Windows.Forms.ToolStripButton toolStripButtonEliminarProducto;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.TabControl tabControlClientes;
        private System.Windows.Forms.TabPage tabPageClienteIndividuo;
        private System.Windows.Forms.TabPage tabControlClienteEmpresa;
        private System.Windows.Forms.ToolStrip toolStripClientes;
        private System.Windows.Forms.ToolStripButton toolStripButtonAgregarCliente;
        private System.Windows.Forms.ToolStripButton toolStripButtonModificarCliente;
        private System.Windows.Forms.ToolStripButton toolStripButtonEliminarCliente;
        private System.Windows.Forms.DataGridView dataGridViewClientesIndividuo;
        private System.Windows.Forms.DataGridView dataGridViewClientesEmpresa;
        private System.Windows.Forms.ToolStrip toolStripProveedores;
        private System.Windows.Forms.ToolStripButton toolStripButtonAgregarProveedor;
        private System.Windows.Forms.ToolStripButton toolStripButtonModificarProveedor;
        private System.Windows.Forms.ToolStripButton toolStripButtonEliminarProveedor;
        private System.Windows.Forms.DataGridView dataGridViewProveedores;
        private System.Windows.Forms.ToolStrip toolStripDocumentosComerciales;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonOrdenar;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendenteToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlDocumentosComerciales;
        private System.Windows.Forms.TabPage tabPageFacturas;
        private System.Windows.Forms.DataGridView dataGridViewFacturas;
        private System.Windows.Forms.TabPage tabPageRemitos;
        private System.Windows.Forms.DataGridView dataGridViewRemitos;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDataGridViewPedido;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemModificar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEliminar;
    }
}

