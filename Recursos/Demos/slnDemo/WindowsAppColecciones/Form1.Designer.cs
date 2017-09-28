namespace WindowsAppColecciones
{
    partial class Form1
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
            this.btnListaMedicos = new System.Windows.Forms.Button();
            this.gridMedicos = new System.Windows.Forms.DataGridView();
            this.lstMedicos = new System.Windows.Forms.ListBox();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListaMedicos
            // 
            this.btnListaMedicos.Location = new System.Drawing.Point(262, 28);
            this.btnListaMedicos.Name = "btnListaMedicos";
            this.btnListaMedicos.Size = new System.Drawing.Size(181, 23);
            this.btnListaMedicos.TabIndex = 0;
            this.btnListaMedicos.Text = "Generar lista de médicos";
            this.btnListaMedicos.UseVisualStyleBackColor = true;
            this.btnListaMedicos.Click += new System.EventHandler(this.btnListaMedicos_Click);
            // 
            // gridMedicos
            // 
            this.gridMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMedicos.Location = new System.Drawing.Point(271, 73);
            this.gridMedicos.Name = "gridMedicos";
            this.gridMedicos.Size = new System.Drawing.Size(358, 268);
            this.gridMedicos.TabIndex = 1;
            // 
            // lstMedicos
            // 
            this.lstMedicos.FormattingEnabled = true;
            this.lstMedicos.Location = new System.Drawing.Point(13, 73);
            this.lstMedicos.Name = "lstMedicos";
            this.lstMedicos.Size = new System.Drawing.Size(120, 95);
            this.lstMedicos.TabIndex = 2;
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Location = new System.Drawing.Point(13, 190);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(121, 21);
            this.cbEspecialidad.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 353);
            this.Controls.Add(this.cbEspecialidad);
            this.Controls.Add(this.lstMedicos);
            this.Controls.Add(this.gridMedicos);
            this.Controls.Add(this.btnListaMedicos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListaMedicos;
        private System.Windows.Forms.DataGridView gridMedicos;
        private System.Windows.Forms.ListBox lstMedicos;
        private System.Windows.Forms.ComboBox cbEspecialidad;
    }
}

