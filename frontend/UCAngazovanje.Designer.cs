namespace frontend
{
    partial class UCAngazovanje
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPredmeti = new System.Windows.Forms.ComboBox();
            this.btnPrikaziAngazovanja = new System.Windows.Forms.Button();
            this.dgvAngazovanja = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngazovanja)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Predmet";
            // 
            // cmbPredmeti
            // 
            this.cmbPredmeti.FormattingEnabled = true;
            this.cmbPredmeti.Location = new System.Drawing.Point(169, 68);
            this.cmbPredmeti.Name = "cmbPredmeti";
            this.cmbPredmeti.Size = new System.Drawing.Size(162, 24);
            this.cmbPredmeti.TabIndex = 1;
            // 
            // btnPrikaziAngazovanja
            // 
            this.btnPrikaziAngazovanja.Location = new System.Drawing.Point(75, 137);
            this.btnPrikaziAngazovanja.Name = "btnPrikaziAngazovanja";
            this.btnPrikaziAngazovanja.Size = new System.Drawing.Size(270, 45);
            this.btnPrikaziAngazovanja.TabIndex = 2;
            this.btnPrikaziAngazovanja.Text = "Prikazi angazovanja";
            this.btnPrikaziAngazovanja.UseVisualStyleBackColor = true;
            this.btnPrikaziAngazovanja.Click += new System.EventHandler(this.btnPrikaziAngazovanja_Click);
            // 
            // dgvAngazovanja
            // 
            this.dgvAngazovanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAngazovanja.Location = new System.Drawing.Point(31, 245);
            this.dgvAngazovanja.Name = "dgvAngazovanja";
            this.dgvAngazovanja.RowHeadersWidth = 51;
            this.dgvAngazovanja.RowTemplate.Height = 24;
            this.dgvAngazovanja.Size = new System.Drawing.Size(579, 268);
            this.dgvAngazovanja.TabIndex = 3;
            // 
            // UCAngazovanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvAngazovanja);
            this.Controls.Add(this.btnPrikaziAngazovanja);
            this.Controls.Add(this.cmbPredmeti);
            this.Controls.Add(this.label1);
            this.Name = "UCAngazovanje";
            this.Size = new System.Drawing.Size(640, 565);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngazovanja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPredmeti;
        private System.Windows.Forms.Button btnPrikaziAngazovanja;
        private System.Windows.Forms.DataGridView dgvAngazovanja;
    }
}
