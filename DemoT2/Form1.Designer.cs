
namespace DemoT2
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
            this.baiTap2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cach2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demoLyThuyetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baiTap2ToolStripMenuItem,
            this.cach2ToolStripMenuItem,
            this.demoLyThuyetToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // baiTap2ToolStripMenuItem
            // 
            this.baiTap2ToolStripMenuItem.Name = "baiTap2ToolStripMenuItem";
            this.baiTap2ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.baiTap2ToolStripMenuItem.Text = "Bai T&ap 2";
            this.baiTap2ToolStripMenuItem.Click += new System.EventHandler(this.baiTap2ToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.thoatToolStripMenuItem.Text = "&Thoat";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // cach2ToolStripMenuItem
            // 
            this.cach2ToolStripMenuItem.Name = "cach2ToolStripMenuItem";
            this.cach2ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cach2ToolStripMenuItem.Text = "Cach 2";
            this.cach2ToolStripMenuItem.Click += new System.EventHandler(this.cach2ToolStripMenuItem_Click);
            // 
            // demoLyThuyetToolStripMenuItem
            // 
            this.demoLyThuyetToolStripMenuItem.Name = "demoLyThuyetToolStripMenuItem";
            this.demoLyThuyetToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.demoLyThuyetToolStripMenuItem.Text = "Demo Ly Thuyet";
            this.demoLyThuyetToolStripMenuItem.Click += new System.EventHandler(this.demoLyThuyetToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem baiTap2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cach2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demoLyThuyetToolStripMenuItem;
    }
}

