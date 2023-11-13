namespace frontend
{
    partial class UCSpisakPredmeta
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
            this.dgvSviPredmeti = new System.Windows.Forms.DataGridView();
            this.dgvMojiPredmeti = new System.Windows.Forms.DataGridView();
            this.btnPrikaziMojePredmete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviPredmeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMojiPredmeti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSviPredmeti
            // 
            this.dgvSviPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviPredmeti.Location = new System.Drawing.Point(13, 25);
            this.dgvSviPredmeti.Name = "dgvSviPredmeti";
            this.dgvSviPredmeti.RowHeadersWidth = 51;
            this.dgvSviPredmeti.RowTemplate.Height = 24;
            this.dgvSviPredmeti.Size = new System.Drawing.Size(672, 274);
            this.dgvSviPredmeti.TabIndex = 0;
            // 
            // dgvMojiPredmeti
            // 
            this.dgvMojiPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMojiPredmeti.Location = new System.Drawing.Point(13, 530);
            this.dgvMojiPredmeti.Name = "dgvMojiPredmeti";
            this.dgvMojiPredmeti.RowHeadersWidth = 51;
            this.dgvMojiPredmeti.RowTemplate.Height = 24;
            this.dgvMojiPredmeti.Size = new System.Drawing.Size(672, 220);
            this.dgvMojiPredmeti.TabIndex = 1;
            // 
            // btnPrikaziMojePredmete
            // 
            this.btnPrikaziMojePredmete.Location = new System.Drawing.Point(13, 444);
            this.btnPrikaziMojePredmete.Name = "btnPrikaziMojePredmete";
            this.btnPrikaziMojePredmete.Size = new System.Drawing.Size(672, 68);
            this.btnPrikaziMojePredmete.TabIndex = 2;
            this.btnPrikaziMojePredmete.Text = "Prikazi predmete koje sam ja uneo";
            this.btnPrikaziMojePredmete.UseVisualStyleBackColor = true;
            this.btnPrikaziMojePredmete.Click += new System.EventHandler(this.btnPrikaziMojePredmete_Click);
            // 
            // UCSpisakPredmeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrikaziMojePredmete);
            this.Controls.Add(this.dgvMojiPredmeti);
            this.Controls.Add(this.dgvSviPredmeti);
            this.Name = "UCSpisakPredmeta";
            this.Size = new System.Drawing.Size(763, 928);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviPredmeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMojiPredmeti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSviPredmeti;
        private System.Windows.Forms.DataGridView dgvMojiPredmeti;
        private System.Windows.Forms.Button btnPrikaziMojePredmete;
    }
}
