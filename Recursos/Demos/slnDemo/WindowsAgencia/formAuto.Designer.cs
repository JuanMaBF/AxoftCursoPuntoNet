namespace WindowsAgencia
{
    partial class formAuto
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
            this.gridAuto = new System.Windows.Forms.DataGridView();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAuto
            // 
            this.gridAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAuto.Location = new System.Drawing.Point(28, 166);
            this.gridAuto.Name = "gridAuto";
            this.gridAuto.Size = new System.Drawing.Size(430, 150);
            this.gridAuto.TabIndex = 11;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(135, 102);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 10;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(135, 24);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 9;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(74, 102);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 8;
            this.lblColor.Text = "Color";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(74, 27);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "Id";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(383, 22);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbModelo
            // 
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(135, 63);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(121, 21);
            this.cbModelo.TabIndex = 12;
            this.cbModelo.SelectionChangeCommitted += new System.EventHandler(this.cbModelo_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Modelo";
            // 
            // formAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.gridAuto);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnAgregar);
            this.Name = "formAuto";
            this.Text = "formAuto";
            this.Load += new System.EventHandler(this.formAuto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAuto;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.Label label1;
    }
}