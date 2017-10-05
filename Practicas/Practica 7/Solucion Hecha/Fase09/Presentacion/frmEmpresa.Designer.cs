namespace Presentacion
{
    partial class frmEmpresa
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
            this.tabControlEmpresa = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.tabPagePersonaContacto = new System.Windows.Forms.TabPage();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxCUIT = new System.Windows.Forms.TextBox();
            this.labelCUIT = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxDireccionContacto = new System.Windows.Forms.TextBox();
            this.labelDireccionContacto = new System.Windows.Forms.Label();
            this.textBoxTelefonoContacto = new System.Windows.Forms.TextBox();
            this.labelTefonoContacto = new System.Windows.Forms.Label();
            this.textBoxEmailContacto = new System.Windows.Forms.TextBox();
            this.labelEmialContacto = new System.Windows.Forms.Label();
            this.textBoxApellidoContacto = new System.Windows.Forms.TextBox();
            this.labelApellidoContacto = new System.Windows.Forms.Label();
            this.textBoxNombreContacto = new System.Windows.Forms.TextBox();
            this.labelNombreContacto = new System.Windows.Forms.Label();
            this.tabControlEmpresa.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.tabPagePersonaContacto.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlEmpresa
            // 
            this.tabControlEmpresa.Controls.Add(this.tabPageGeneral);
            this.tabControlEmpresa.Controls.Add(this.tabPagePersonaContacto);
            this.tabControlEmpresa.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlEmpresa.Location = new System.Drawing.Point(0, 0);
            this.tabControlEmpresa.Name = "tabControlEmpresa";
            this.tabControlEmpresa.Padding = new System.Drawing.Point(6, 6);
            this.tabControlEmpresa.SelectedIndex = 0;
            this.tabControlEmpresa.Size = new System.Drawing.Size(374, 325);
            this.tabControlEmpresa.TabIndex = 0;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.groupBox1);
            this.tabPageGeneral.Controls.Add(this.textBoxCUIT);
            this.tabPageGeneral.Controls.Add(this.labelCUIT);
            this.tabPageGeneral.Controls.Add(this.textBoxNombre);
            this.tabPageGeneral.Controls.Add(this.labelNombre);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 28);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(366, 293);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "General";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // tabPagePersonaContacto
            // 
            this.tabPagePersonaContacto.Controls.Add(this.groupBox2);
            this.tabPagePersonaContacto.Controls.Add(this.textBoxApellidoContacto);
            this.tabPagePersonaContacto.Controls.Add(this.labelApellidoContacto);
            this.tabPagePersonaContacto.Controls.Add(this.textBoxNombreContacto);
            this.tabPagePersonaContacto.Controls.Add(this.labelNombreContacto);
            this.tabPagePersonaContacto.Location = new System.Drawing.Point(4, 28);
            this.tabPagePersonaContacto.Name = "tabPagePersonaContacto";
            this.tabPagePersonaContacto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePersonaContacto.Size = new System.Drawing.Size(366, 293);
            this.tabPagePersonaContacto.TabIndex = 1;
            this.tabPagePersonaContacto.Text = "Persona de contacto";
            this.tabPagePersonaContacto.UseVisualStyleBackColor = true;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAceptar.Location = new System.Drawing.Point(201, 343);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 19;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(282, 343);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 18;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDireccion);
            this.groupBox1.Controls.Add(this.labelDireccion);
            this.groupBox1.Controls.Add(this.textBoxTelefono);
            this.groupBox1.Controls.Add(this.labelTelefono);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Location = new System.Drawing.Point(17, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 187);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de contacto";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.AcceptsReturn = true;
            this.textBoxDireccion.Location = new System.Drawing.Point(97, 98);
            this.textBoxDireccion.Multiline = true;
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDireccion.Size = new System.Drawing.Size(210, 76);
            this.textBoxDireccion.TabIndex = 13;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(33, 97);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(55, 13);
            this.labelDireccion.TabIndex = 12;
            this.labelDireccion.Text = "Dirección:";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(97, 61);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(210, 20);
            this.textBoxTelefono.TabIndex = 11;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(36, 64);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(52, 13);
            this.labelTelefono.TabIndex = 10;
            this.labelTelefono.Text = "Teléfono:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(97, 27);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(210, 20);
            this.textBoxEmail.TabIndex = 9;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(53, 30);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxCUIT
            // 
            this.textBoxCUIT.Location = new System.Drawing.Point(116, 55);
            this.textBoxCUIT.Name = "textBoxCUIT";
            this.textBoxCUIT.Size = new System.Drawing.Size(210, 20);
            this.textBoxCUIT.TabIndex = 12;
            // 
            // labelCUIT
            // 
            this.labelCUIT.AutoSize = true;
            this.labelCUIT.Location = new System.Drawing.Point(60, 58);
            this.labelCUIT.Name = "labelCUIT";
            this.labelCUIT.Size = new System.Drawing.Size(47, 13);
            this.labelCUIT.TabIndex = 11;
            this.labelCUIT.Text = "C.U.I.T.:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(116, 21);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(210, 20);
            this.textBoxNombre.TabIndex = 10;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(60, 24);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 9;
            this.labelNombre.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxDireccionContacto);
            this.groupBox2.Controls.Add(this.labelDireccionContacto);
            this.groupBox2.Controls.Add(this.textBoxTelefonoContacto);
            this.groupBox2.Controls.Add(this.labelTefonoContacto);
            this.groupBox2.Controls.Add(this.textBoxEmailContacto);
            this.groupBox2.Controls.Add(this.labelEmialContacto);
            this.groupBox2.Location = new System.Drawing.Point(17, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 187);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de contacto";
            // 
            // textBoxDireccionContacto
            // 
            this.textBoxDireccionContacto.AcceptsReturn = true;
            this.textBoxDireccionContacto.Location = new System.Drawing.Point(97, 98);
            this.textBoxDireccionContacto.Multiline = true;
            this.textBoxDireccionContacto.Name = "textBoxDireccionContacto";
            this.textBoxDireccionContacto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDireccionContacto.Size = new System.Drawing.Size(210, 76);
            this.textBoxDireccionContacto.TabIndex = 13;
            // 
            // labelDireccionContacto
            // 
            this.labelDireccionContacto.AutoSize = true;
            this.labelDireccionContacto.Location = new System.Drawing.Point(33, 97);
            this.labelDireccionContacto.Name = "labelDireccionContacto";
            this.labelDireccionContacto.Size = new System.Drawing.Size(55, 13);
            this.labelDireccionContacto.TabIndex = 12;
            this.labelDireccionContacto.Text = "Dirección:";
            // 
            // textBoxTelefonoContacto
            // 
            this.textBoxTelefonoContacto.Location = new System.Drawing.Point(97, 61);
            this.textBoxTelefonoContacto.Name = "textBoxTelefonoContacto";
            this.textBoxTelefonoContacto.Size = new System.Drawing.Size(210, 20);
            this.textBoxTelefonoContacto.TabIndex = 11;
            // 
            // labelTefonoContacto
            // 
            this.labelTefonoContacto.AutoSize = true;
            this.labelTefonoContacto.Location = new System.Drawing.Point(36, 64);
            this.labelTefonoContacto.Name = "labelTefonoContacto";
            this.labelTefonoContacto.Size = new System.Drawing.Size(52, 13);
            this.labelTefonoContacto.TabIndex = 10;
            this.labelTefonoContacto.Text = "Teléfono:";
            // 
            // textBoxEmailContacto
            // 
            this.textBoxEmailContacto.Location = new System.Drawing.Point(97, 27);
            this.textBoxEmailContacto.Name = "textBoxEmailContacto";
            this.textBoxEmailContacto.Size = new System.Drawing.Size(210, 20);
            this.textBoxEmailContacto.TabIndex = 9;
            // 
            // labelEmialContacto
            // 
            this.labelEmialContacto.AutoSize = true;
            this.labelEmialContacto.Location = new System.Drawing.Point(53, 30);
            this.labelEmialContacto.Name = "labelEmialContacto";
            this.labelEmialContacto.Size = new System.Drawing.Size(35, 13);
            this.labelEmialContacto.TabIndex = 8;
            this.labelEmialContacto.Text = "Email:";
            // 
            // textBoxApellidoContacto
            // 
            this.textBoxApellidoContacto.Location = new System.Drawing.Point(116, 55);
            this.textBoxApellidoContacto.Name = "textBoxApellidoContacto";
            this.textBoxApellidoContacto.Size = new System.Drawing.Size(210, 20);
            this.textBoxApellidoContacto.TabIndex = 17;
            // 
            // labelApellidoContacto
            // 
            this.labelApellidoContacto.AutoSize = true;
            this.labelApellidoContacto.Location = new System.Drawing.Point(60, 58);
            this.labelApellidoContacto.Name = "labelApellidoContacto";
            this.labelApellidoContacto.Size = new System.Drawing.Size(47, 13);
            this.labelApellidoContacto.TabIndex = 16;
            this.labelApellidoContacto.Text = "Apellido:";
            // 
            // textBoxNombreContacto
            // 
            this.textBoxNombreContacto.Location = new System.Drawing.Point(116, 21);
            this.textBoxNombreContacto.Name = "textBoxNombreContacto";
            this.textBoxNombreContacto.Size = new System.Drawing.Size(210, 20);
            this.textBoxNombreContacto.TabIndex = 15;
            // 
            // labelNombreContacto
            // 
            this.labelNombreContacto.AutoSize = true;
            this.labelNombreContacto.Location = new System.Drawing.Point(60, 24);
            this.labelNombreContacto.Name = "labelNombreContacto";
            this.labelNombreContacto.Size = new System.Drawing.Size(47, 13);
            this.labelNombreContacto.TabIndex = 14;
            this.labelNombreContacto.Text = "Nombre:";
            // 
            // frmEmpresa
            // 
            this.AcceptButton = this.buttonAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(374, 377);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.tabControlEmpresa);
            this.Name = "frmEmpresa";
            this.Text = "frmEmpresa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEmpresa_FormClosing);
            this.tabControlEmpresa.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.tabPagePersonaContacto.ResumeLayout(false);
            this.tabPagePersonaContacto.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlEmpresa;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TabPage tabPagePersonaContacto;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxCUIT;
        private System.Windows.Forms.Label labelCUIT;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxDireccionContacto;
        private System.Windows.Forms.Label labelDireccionContacto;
        private System.Windows.Forms.TextBox textBoxTelefonoContacto;
        private System.Windows.Forms.Label labelTefonoContacto;
        private System.Windows.Forms.TextBox textBoxEmailContacto;
        private System.Windows.Forms.Label labelEmialContacto;
        private System.Windows.Forms.TextBox textBoxApellidoContacto;
        private System.Windows.Forms.Label labelApellidoContacto;
        private System.Windows.Forms.TextBox textBoxNombreContacto;
        private System.Windows.Forms.Label labelNombreContacto;
    }
}