using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LabCSharp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void go_Click(object sender, EventArgs e)
        {
            IEnumerable<string> blockedWordsMatched =
                    from blocked in blockedWords
                    where urlInput.Text.Contains(blocked)
                    select blocked;
            if (blockedWordsMatched.Any())
            {
                MessageBox.Show("This website is blocked.");
                return;
            }
            browser.Navigate(urlInput.Text);
        }

        private void forward_Click(object sender, EventArgs e)
        {
            browser.GoForward();
        }

        private void back_Click(object sender, EventArgs e)
        {
            browser.GoBack();
        }

        private void home_Click(object sender, EventArgs e)
        {
            browser.GoHome();
        }

        private void urlInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                IEnumerable<string> blockedWordsMatched =
                    from blocked in blockedWords
                    where urlInput.Text.Contains(blocked)
                    select blocked;
                if (blockedWordsMatched.Any())
                {
                    MessageBox.Show("This website is blocked.");
                    return;
                }
                browser.Navigate(urlInput.Text);
                // Gets rid of the "ding" sound when pressing enter
                e.SuppressKeyPress = true;
            }
        }
    }
}
