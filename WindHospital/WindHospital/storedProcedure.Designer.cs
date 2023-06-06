namespace WindHospital
{
    partial class storedProcedure
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
            this.dtgvDoc = new System.Windows.Forms.DataGridView();
            this.btnDoctor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDoc
            // 
            this.dtgvDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDoc.Location = new System.Drawing.Point(30, 166);
            this.dtgvDoc.Name = "dtgvDoc";
            this.dtgvDoc.RowHeadersWidth = 51;
            this.dtgvDoc.RowTemplate.Height = 24;
            this.dtgvDoc.Size = new System.Drawing.Size(1007, 464);
            this.dtgvDoc.TabIndex = 0;
            // 
            // btnDoctor
            // 
            this.btnDoctor.Location = new System.Drawing.Point(962, 100);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(75, 33);
            this.btnDoctor.TabIndex = 1;
            this.btnDoctor.Text = "Doctor ";
            this.btnDoctor.UseVisualStyleBackColor = true;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // storedProcedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 642);
            this.Controls.Add(this.btnDoctor);
            this.Controls.Add(this.dtgvDoc);
            this.Name = "storedProcedure";
            this.Text = "storedProcedure";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDoc;
        private System.Windows.Forms.Button btnDoctor;
    }
}