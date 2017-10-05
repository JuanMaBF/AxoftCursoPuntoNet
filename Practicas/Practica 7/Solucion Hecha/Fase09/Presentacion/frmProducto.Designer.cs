namespace Presentacion
{
    partial class frmProducto
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.labelPrecioCosto = new System.Windows.Forms.Label();
            this.numericUpDownPrecioCosto = new System.Windows.Forms.NumericUpDown();
            this.labelMargen = new System.Windows.Forms.Label();
            this.numericUpDownMargen = new System.Windows.Forms.NumericUpDown();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.labelSubcategoria = new System.Windows.Forms.Label();
            this.comboBoxSubcategoria = new System.Windows.Forms.ComboBox();
            this.labelProveedor = new System.Windows.Forms.Label();
            this.comboBoxProveedor = new System.Windows.Forms.ComboBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecioCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMargen)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(72, 21);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(153, 18);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(248, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(53, 53);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(66, 13);
            this.labelDescripcion.TabIndex = 2;
            this.labelDescripcion.Text = "Descripción:";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.AcceptsReturn = true;
            this.textBoxDescripcion.Location = new System.Drawing.Point(153, 53);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescripcion.Size = new System.Drawing.Size(248, 77);
            this.textBoxDescripcion.TabIndex = 3;
            // 
            // labelPrecioCosto
            // 
            this.labelPrecioCosto.AutoSize = true;
            this.labelPrecioCosto.Location = new System.Drawing.Point(35, 267);
            this.labelPrecioCosto.Name = "labelPrecioCosto";
            this.labelPrecioCosto.Size = new System.Drawing.Size(84, 13);
            this.labelPrecioCosto.TabIndex = 4;
            this.labelPrecioCosto.Text = "Precio de costo:";
            // 
            // numericUpDownPrecioCosto
            // 
            this.numericUpDownPrecioCosto.DecimalPlaces = 2;
            this.numericUpDownPrecioCosto.Location = new System.Drawing.Point(153, 265);
            this.numericUpDownPrecioCosto.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPrecioCosto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownPrecioCosto.Name = "numericUpDownPrecioCosto";
            this.numericUpDownPrecioCosto.Size = new System.Drawing.Size(85, 20);
            this.numericUpDownPrecioCosto.TabIndex = 5;
            this.numericUpDownPrecioCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownPrecioCosto.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // labelMargen
            // 
            this.labelMargen.AutoSize = true;
            this.labelMargen.Location = new System.Drawing.Point(73, 308);
            this.labelMargen.Name = "labelMargen";
            this.labelMargen.Size = new System.Drawing.Size(46, 13);
            this.labelMargen.TabIndex = 6;
            this.labelMargen.Text = "Margen:";
            // 
            // numericUpDownMargen
            // 
            this.numericUpDownMargen.DecimalPlaces = 2;
            this.numericUpDownMargen.Location = new System.Drawing.Point(153, 306);
            this.numericUpDownMargen.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownMargen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownMargen.Name = "numericUpDownMargen";
            this.numericUpDownMargen.Size = new System.Drawing.Size(85, 20);
            this.numericUpDownMargen.TabIndex = 7;
            this.numericUpDownMargen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownMargen.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(62, 149);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(57, 13);
            this.labelCategoria.TabIndex = 8;
            this.labelCategoria.Text = "Categoría:";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(153, 146);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(248, 21);
            this.comboBoxCategoria.TabIndex = 9;
            this.comboBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoria_SelectedIndexChanged);
            // 
            // labelSubcategoria
            // 
            this.labelSubcategoria.AutoSize = true;
            this.labelSubcategoria.Location = new System.Drawing.Point(44, 187);
            this.labelSubcategoria.Name = "labelSubcategoria";
            this.labelSubcategoria.Size = new System.Drawing.Size(75, 13);
            this.labelSubcategoria.TabIndex = 10;
            this.labelSubcategoria.Text = "Subcategoría:";
            // 
            // comboBoxSubcategoria
            // 
            this.comboBoxSubcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubcategoria.FormattingEnabled = true;
            this.comboBoxSubcategoria.Location = new System.Drawing.Point(153, 184);
            this.comboBoxSubcategoria.Name = "comboBoxSubcategoria";
            this.comboBoxSubcategoria.Size = new System.Drawing.Size(248, 21);
            this.comboBoxSubcategoria.TabIndex = 11;
            // 
            // labelProveedor
            // 
            this.labelProveedor.AutoSize = true;
            this.labelProveedor.Location = new System.Drawing.Point(60, 225);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(59, 13);
            this.labelProveedor.TabIndex = 12;
            this.labelProveedor.Text = "Proveedor:";
            // 
            // comboBoxProveedor
            // 
            this.comboBoxProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProveedor.FormattingEnabled = true;
            this.comboBoxProveedor.Location = new System.Drawing.Point(153, 222);
            this.comboBoxProveedor.Name = "comboBoxProveedor";
            this.comboBoxProveedor.Size = new System.Drawing.Size(248, 21);
            this.comboBoxProveedor.TabIndex = 13;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(326, 354);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 14;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAceptar.Location = new System.Drawing.Point(245, 354);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 15;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // frmProducto
            // 
            this.AcceptButton = this.buttonAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonAceptar;
            this.ClientSize = new System.Drawing.Size(425, 400);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.comboBoxProveedor);
            this.Controls.Add(this.labelProveedor);
            this.Controls.Add(this.comboBoxSubcategoria);
            this.Controls.Add(this.labelSubcategoria);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.numericUpDownMargen);
            this.Controls.Add(this.labelMargen);
            this.Controls.Add(this.numericUpDownPrecioCosto);
            this.Controls.Add(this.labelPrecioCosto);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.Name = "frmProducto";
            this.Text = "frmProducto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProducto_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecioCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMargen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label labelPrecioCosto;
        private System.Windows.Forms.NumericUpDown numericUpDownPrecioCosto;
        private System.Windows.Forms.Label labelMargen;
        private System.Windows.Forms.NumericUpDown numericUpDownMargen;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Label labelSubcategoria;
        private System.Windows.Forms.ComboBox comboBoxSubcategoria;
        private System.Windows.Forms.Label labelProveedor;
        private System.Windows.Forms.ComboBox comboBoxProveedor;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
    }
}