using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace LabCSharp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private async Task<bool> CheckForBlockedWords()
        {
            bool isBlocked = await Task.Run(() =>
            {
                IEnumerable<string> queryResult = from blocked in blockedWords
                                                  where urlInput.Text.Contains(blocked)
                                                  select blocked;
                return queryResult.Any();
            });
            if (isBlocked)
            {
                MessageBox.Show("This website is blocked.");
                return true;
            }
            return false;
        }
        private async void go_Click(object sender, EventArgs e)
        {
            bool blocked = await CheckForBlockedWords();
            if (blocked)
            {
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

        private async void urlInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                bool blocked = await CheckForBlockedWords();
                if (blocked)
                {
                    return;
                }
                browser.Navigate(urlInput.Text);
                // Gets rid of the "ding" sound when pressing enter
                e.SuppressKeyPress = true;
            }
        }
    }
}
