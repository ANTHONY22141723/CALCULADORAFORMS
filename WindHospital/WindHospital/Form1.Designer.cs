namespace WindHospital
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgvHospital = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHospital)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvHospital
            // 
            this.dtgvHospital.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHospital.Location = new System.Drawing.Point(27, 127);
            this.dtgvHospital.Name = "dtgvHospital";
            this.dtgvHospital.RowHeadersWidth = 51;
            this.dtgvHospital.RowTemplate.Height = 24;
            this.dtgvHospital.Size = new System.Drawing.Size(998, 377);
            this.dtgvHospital.TabIndex = 0;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(921, 67);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(104, 34);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "ListarHospital";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 536);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dtgvHospital);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHospital)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvHospital;
        private System.Windows.Forms.Button btnListar;
    }
}

