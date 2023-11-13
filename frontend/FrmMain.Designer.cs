namespace frontend
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.predmetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajPredmetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spisakPredmetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajProfesoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.angazovanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledAngazovanjaPoPredmetimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.predmetToolStripMenuItem,
            this.profesorToolStripMenuItem,
            this.angazovanjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // predmetToolStripMenuItem
            // 
            this.predmetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajPredmetToolStripMenuItem,
            this.spisakPredmetaToolStripMenuItem});
            this.predmetToolStripMenuItem.Name = "predmetToolStripMenuItem";
            this.predmetToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.predmetToolStripMenuItem.Text = "Predmet";
            // 
            // dodajPredmetToolStripMenuItem
            // 
            this.dodajPredmetToolStripMenuItem.Name = "dodajPredmetToolStripMenuItem";
            this.dodajPredmetToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.dodajPredmetToolStripMenuItem.Text = "Dodaj predmet";
            this.dodajPredmetToolStripMenuItem.Click += new System.EventHandler(this.dodajPredmetToolStripMenuItem_Click);
            // 
            // spisakPredmetaToolStripMenuItem
            // 
            this.spisakPredmetaToolStripMenuItem.Name = "spisakPredmetaToolStripMenuItem";
            this.spisakPredmetaToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.spisakPredmetaToolStripMenuItem.Text = "Spisak predmeta";
            this.spisakPredmetaToolStripMenuItem.Click += new System.EventHandler(this.spisakPredmetaToolStripMenuItem_Click);
            // 
            // profesorToolStripMenuItem
            // 
            this.profesorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajProfesoraToolStripMenuItem});
            this.profesorToolStripMenuItem.Name = "profesorToolStripMenuItem";
            this.profesorToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.profesorToolStripMenuItem.Text = "Profesor";
            // 
            // dodajProfesoraToolStripMenuItem
            // 
            this.dodajProfesoraToolStripMenuItem.Name = "dodajProfesoraToolStripMenuItem";
            this.dodajProfesoraToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.dodajProfesoraToolStripMenuItem.Text = "Dodaj profesora";
            this.dodajProfesoraToolStripMenuItem.Click += new System.EventHandler(this.dodajProfesoraToolStripMenuItem_Click);
            // 
            // angazovanjeToolStripMenuItem
            // 
            this.angazovanjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledAngazovanjaPoPredmetimaToolStripMenuItem});
            this.angazovanjeToolStripMenuItem.Name = "angazovanjeToolStripMenuItem";
            this.angazovanjeToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.angazovanjeToolStripMenuItem.Text = "Angazovanje";
            // 
            // pregledAngazovanjaPoPredmetimaToolStripMenuItem
            // 
            this.pregledAngazovanjaPoPredmetimaToolStripMenuItem.Name = "pregledAngazovanjaPoPredmetimaToolStripMenuItem";
            this.pregledAngazovanjaPoPredmetimaToolStripMenuItem.Size = new System.Drawing.Size(339, 26);
            this.pregledAngazovanjaPoPredmetimaToolStripMenuItem.Text = "Pregled angazovanja po predmetima";
            this.pregledAngazovanjaPoPredmetimaToolStripMenuItem.Click += new System.EventHandler(this.pregledAngazovanjaPoPredmetimaToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 846);
            this.panel1.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 902);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem predmetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajPredmetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spisakPredmetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajProfesoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem angazovanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledAngazovanjaPoPredmetimaToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}