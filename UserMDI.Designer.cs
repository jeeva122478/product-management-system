﻿
namespace ADOproj1
{
    partial class UserMDI
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
            this.vIEWPEODUCTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWMODELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vIEWPEODUCTToolStripMenuItem,
            this.vIEWMODELToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // vIEWPEODUCTToolStripMenuItem
            // 
            this.vIEWPEODUCTToolStripMenuItem.Name = "vIEWPEODUCTToolStripMenuItem";
            this.vIEWPEODUCTToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.vIEWPEODUCTToolStripMenuItem.Text = "VIEW PRODUCT";
            this.vIEWPEODUCTToolStripMenuItem.Click += new System.EventHandler(this.vIEWPEODUCTToolStripMenuItem_Click);
            // 
            // vIEWMODELToolStripMenuItem
            // 
            this.vIEWMODELToolStripMenuItem.Name = "vIEWMODELToolStripMenuItem";
            this.vIEWMODELToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.vIEWMODELToolStripMenuItem.Text = "VIEW MODEL";
            this.vIEWMODELToolStripMenuItem.Click += new System.EventHandler(this.vIEWMODELToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // UserMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserMDI";
            this.Text = "UserMDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vIEWPEODUCTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIEWMODELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
    }
}