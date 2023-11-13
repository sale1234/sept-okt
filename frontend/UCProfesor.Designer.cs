namespace frontend
{
    partial class UCProfesor
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtTipNastave = new System.Windows.Forms.TextBox();
            this.cmbPredmeti = new System.Windows.Forms.ComboBox();
            this.btnDodajAngazovanje = new System.Windows.Forms.Button();
            this.dgvAngazovanja = new System.Windows.Forms.DataGridView();
            this.btnSacuvajAngazovanja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngazovanja)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "predmet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "tip nastave";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(182, 39);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(118, 22);
            this.txtIme.TabIndex = 4;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(182, 96);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(118, 22);
            this.txtPrezime.TabIndex = 5;
            // 
            // txtTipNastave
            // 
            this.txtTipNastave.Location = new System.Drawing.Point(182, 194);
            this.txtTipNastave.Name = "txtTipNastave";
            this.txtTipNastave.Size = new System.Drawing.Size(118, 22);
            this.txtTipNastave.TabIndex = 6;
            // 
            // cmbPredmeti
            // 
            this.cmbPredmeti.FormattingEnabled = true;
            this.cmbPredmeti.Location = new System.Drawing.Point(182, 147);
            this.cmbPredmeti.Name = "cmbPredmeti";
            this.cmbPredmeti.Size = new System.Drawing.Size(121, 24);
            this.cmbPredmeti.TabIndex = 7;
            // 
            // btnDodajAngazovanje
            // 
            this.btnDodajAngazovanje.Location = new System.Drawing.Point(111, 255);
            this.btnDodajAngazovanje.Name = "btnDodajAngazovanje";
            this.btnDodajAngazovanje.Size = new System.Drawing.Size(202, 33);
            this.btnDodajAngazovanje.TabIndex = 8;
            this.btnDodajAngazovanje.Text = "Dodaj Angazovanje";
            this.btnDodajAngazovanje.UseVisualStyleBackColor = true;
            this.btnDodajAngazovanje.Click += new System.EventHandler(this.btnDodajAngazovanje_Click);
            // 
            // dgvAngazovanja
            // 
            this.dgvAngazovanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAngazovanja.Location = new System.Drawing.Point(25, 310);
            this.dgvAngazovanja.Name = "dgvAngazovanja";
            this.dgvAngazovanja.RowHeadersWidth = 51;
            this.dgvAngazovanja.RowTemplate.Height = 24;
            this.dgvAngazovanja.Size = new System.Drawing.Size(589, 193);
            this.dgvAngazovanja.TabIndex = 9;
            this.dgvAngazovanja.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSacuvajAngazovanja
            // 
            this.btnSacuvajAngazovanja.Location = new System.Drawing.Point(45, 524);
            this.btnSacuvajAngazovanja.Name = "btnSacuvajAngazovanja";
            this.btnSacuvajAngazovanja.Size = new System.Drawing.Size(255, 45);
            this.btnSacuvajAngazovanja.TabIndex = 10;
            this.btnSacuvajAngazovanja.Text = "Sacuvaj profesora i angazovanja/e";
            this.btnSacuvajAngazovanja.UseVisualStyleBackColor = true;
            this.btnSacuvajAngazovanja.Click += new System.EventHandler(this.btnSacuvajAngazovanja_Click);
            // 
            // UCProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSacuvajAngazovanja);
            this.Controls.Add(this.dgvAngazovanja);
            this.Controls.Add(this.btnDodajAngazovanje);
            this.Controls.Add(this.cmbPredmeti);
            this.Controls.Add(this.txtTipNastave);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCProfesor";
            this.Size = new System.Drawing.Size(676, 687);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngazovanja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtTipNastave;
        private System.Windows.Forms.ComboBox cmbPredmeti;
        private System.Windows.Forms.Button btnDodajAngazovanje;
        private System.Windows.Forms.DataGridView dgvAngazovanja;
        private System.Windows.Forms.Button btnSacuvajAngazovanja;
    }
}
