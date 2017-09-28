namespace WindowsClinica
{
    partial class Formulario
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
            this.dtaGridMedicos = new System.Windows.Forms.DataGridView();
            this.lstBoxMedico = new System.Windows.Forms.ListBox();
            this.cmbBoxEspecialidad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtaGridMedicos
            // 
            this.dtaGridMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridMedicos.Location = new System.Drawing.Point(153, 12);
            this.dtaGridMedicos.Name = "dtaGridMedicos";
            this.dtaGridMedicos.Size = new System.Drawing.Size(320, 246);
            this.dtaGridMedicos.TabIndex = 0;
            // 
            // lstBoxMedico
            // 
            this.lstBoxMedico.FormattingEnabled = true;
            this.lstBoxMedico.Location = new System.Drawing.Point(12, 12);
            this.lstBoxMedico.Name = "lstBoxMedico";
            this.lstBoxMedico.Size = new System.Drawing.Size(125, 95);
            this.lstBoxMedico.TabIndex = 1;
            // 
            // cmbBoxEspecialidad
            // 
            this.cmbBoxEspecialidad.FormattingEnabled = true;
            this.cmbBoxEspecialidad.Location = new System.Drawing.Point(13, 114);
            this.cmbBoxEspecialidad.Name = "cmbBoxEspecialidad";
            this.cmbBoxEspecialidad.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxEspecialidad.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 270);
            this.Controls.Add(this.cmbBoxEspecialidad);
            this.Controls.Add(this.lstBoxMedico);
            this.Controls.Add(this.dtaGridMedicos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridMedicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtaGridMedicos;
        private System.Windows.Forms.ListBox lstBoxMedico;
        private System.Windows.Forms.ComboBox cmbBoxEspecialidad;
    }
}

