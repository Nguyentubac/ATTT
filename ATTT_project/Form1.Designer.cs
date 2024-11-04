namespace ATTT_project
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.affineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ceasarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maThayTheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playfairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vigennereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diffieHellmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.affineToolStripMenuItem,
            this.ceasarToolStripMenuItem,
            this.maThayTheToolStripMenuItem,
            this.playfairToolStripMenuItem,
            this.vigennereToolStripMenuItem,
            this.rSAToolStripMenuItem,
            this.hillToolStripMenuItem,
            this.diffieHellmanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // affineToolStripMenuItem
            // 
            this.affineToolStripMenuItem.Name = "affineToolStripMenuItem";
            this.affineToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.affineToolStripMenuItem.Text = "Affine";
            this.affineToolStripMenuItem.Click += new System.EventHandler(this.affineToolStripMenuItem_Click);
            // 
            // ceasarToolStripMenuItem
            // 
            this.ceasarToolStripMenuItem.Name = "ceasarToolStripMenuItem";
            this.ceasarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ceasarToolStripMenuItem.Text = "Ceasar";
            this.ceasarToolStripMenuItem.Click += new System.EventHandler(this.ceasarToolStripMenuItem_Click);
            // 
            // maThayTheToolStripMenuItem
            // 
            this.maThayTheToolStripMenuItem.Name = "maThayTheToolStripMenuItem";
            this.maThayTheToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.maThayTheToolStripMenuItem.Text = "MaThayThe";
            this.maThayTheToolStripMenuItem.Click += new System.EventHandler(this.maThayTheToolStripMenuItem_Click);
            // 
            // playfairToolStripMenuItem
            // 
            this.playfairToolStripMenuItem.Name = "playfairToolStripMenuItem";
            this.playfairToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.playfairToolStripMenuItem.Text = "Playfair";
            this.playfairToolStripMenuItem.Click += new System.EventHandler(this.playfairToolStripMenuItem_Click);
            // 
            // vigennereToolStripMenuItem
            // 
            this.vigennereToolStripMenuItem.Name = "vigennereToolStripMenuItem";
            this.vigennereToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.vigennereToolStripMenuItem.Text = "Vigennere";
            this.vigennereToolStripMenuItem.Click += new System.EventHandler(this.vigennereToolStripMenuItem_Click);
            // 
            // rSAToolStripMenuItem
            // 
            this.rSAToolStripMenuItem.Name = "rSAToolStripMenuItem";
            this.rSAToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.rSAToolStripMenuItem.Text = "RSA";
            this.rSAToolStripMenuItem.Click += new System.EventHandler(this.rSAToolStripMenuItem_Click);
            // 
            // hillToolStripMenuItem
            // 
            this.hillToolStripMenuItem.Name = "hillToolStripMenuItem";
            this.hillToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.hillToolStripMenuItem.Text = "Hill";
            this.hillToolStripMenuItem.Click += new System.EventHandler(this.hillToolStripMenuItem_Click);
            // 
            // diffieHellmanToolStripMenuItem
            // 
            this.diffieHellmanToolStripMenuItem.Name = "diffieHellmanToolStripMenuItem";
            this.diffieHellmanToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.diffieHellmanToolStripMenuItem.Text = "Diffie-Hellman";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 513);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem affineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ceasarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maThayTheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playfairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vigennereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diffieHellmanToolStripMenuItem;
    }
}

