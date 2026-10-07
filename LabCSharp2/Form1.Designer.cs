using System.Collections.Generic;

namespace LabCSharp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.browser = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.home = new System.Windows.Forms.ToolStripButton();
            this.back = new System.Windows.Forms.ToolStripButton();
            this.forward = new System.Windows.Forms.ToolStripButton();
            this.go = new System.Windows.Forms.ToolStripButton();
            this.urlInput = new System.Windows.Forms.ToolStripTextBox();
            this.blockedWordManager = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // browser
            // 
            this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser.Location = new System.Drawing.Point(0, 0);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(978, 544);
            this.browser.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.home,
            this.back,
            this.forward,
            this.go,
            this.urlInput,
            this.blockedWordManager});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(978, 38);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // home
            // 
            this.home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(34, 33);
            this.home.Text = "Home";
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // back
            // 
            this.back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(34, 28);
            this.back.Text = "Back";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // forward
            // 
            this.forward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forward.Image = ((System.Drawing.Image)(resources.GetObject("forward.Image")));
            this.forward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(34, 28);
            this.forward.Text = "Forward";
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // go
            // 
            this.go.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.go.Image = ((System.Drawing.Image)(resources.GetObject("go.Image")));
            this.go.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(34, 28);
            this.go.Text = "Go";
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // urlInput
            // 
            this.urlInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.urlInput.Name = "urlInput";
            this.urlInput.Size = new System.Drawing.Size(300, 33);
            this.urlInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.urlInput_KeyDown);
            // 
            // blockedWordManager
            // 
            this.blockedWordManager.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.blockedWordManager.Image = ((System.Drawing.Image)(resources.GetObject("blockedWordManager.Image")));
            this.blockedWordManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.blockedWordManager.Name = "blockedWordManager";
            this.blockedWordManager.Size = new System.Drawing.Size(34, 33);
            this.blockedWordManager.Text = "ManageBlockedWords";
            this.blockedWordManager.Click += new System.EventHandler(this.blockedWordManager_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.browser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton home;
        private System.Windows.Forms.ToolStripButton back;
        private System.Windows.Forms.ToolStripButton forward;
        private System.Windows.Forms.ToolStripButton go;
        private System.Windows.Forms.ToolStripTextBox urlInput;
        private System.Windows.Forms.ToolStripButton blockedWordManager;

        private Form2 blockedWordManagerWindow;
    }
}

