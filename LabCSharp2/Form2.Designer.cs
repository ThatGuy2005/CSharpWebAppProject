using System.Collections.Generic;

namespace LabCSharp2
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.blockedWordInput = new System.Windows.Forms.TextBox();
            this.blockedWordShower = new System.Windows.Forms.ComboBox();
            this.quit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a new word to block";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current blocked words";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // blockedWordInput
            // 
            this.blockedWordInput.Location = new System.Drawing.Point(344, 132);
            this.blockedWordInput.Name = "blockedWordInput";
            this.blockedWordInput.Size = new System.Drawing.Size(180, 26);
            this.blockedWordInput.TabIndex = 2;
            this.blockedWordInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.blockedWordInput_KeyDown);
            // 
            // blockedWordShower
            // 
            this.blockedWordShower.FormattingEnabled = true;
            this.blockedWordShower.Location = new System.Drawing.Point(344, 182);
            this.blockedWordShower.Name = "blockedWordShower";
            this.blockedWordShower.Size = new System.Drawing.Size(180, 28);
            this.blockedWordShower.TabIndex = 3;
            this.blockedWordShower.KeyDown += new System.Windows.Forms.KeyEventHandler(this.blockedWordShower_KeyDown);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(670, 359);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(75, 40);
            this.quit.TabIndex = 4;
            this.quit.Text = "Back";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select a word and press DEL to delete it.";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.blockedWordShower);
            this.Controls.Add(this.blockedWordInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox blockedWordInput;
        private System.Windows.Forms.ComboBox blockedWordShower;
        private System.Windows.Forms.Button quit;
        private List<string> blockedWords = new List<string> { "linda", "Rust" };
        private System.Windows.Forms.Label label3;
    }
}