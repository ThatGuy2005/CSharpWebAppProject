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
using System.IO;

namespace LabCSharp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FileStream file = new FileStream("log.txt", FileMode.Append, FileAccess.Write);
            TextWriterTraceListener listener = new TextWriterTraceListener(file);
            Trace.Listeners.Add(listener);
            this.blockedWordManagerWindow = new Form2();
            this.blockedWordManagerWindow.Hide();
        }
        private async Task logEvent(string message)
        {
            // I put a \n so that each log entry will have a
            // blank line after it, making it easier to read
            Trace.WriteLine($"{DateTime.Now}: {message}\n");
            Trace.Flush();
        }
        private async Task<bool> CheckForBlockedWords()
        {
            bool isBlocked = await Task.Run(() =>
            {
                IEnumerable<string> queryResult = from blocked in SQLManager.GetBlockedWords()
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
            // Don't wait for the logging to finish before navigating,
            // just log it in the background
            Task.Run(() => logEvent($"Navigating to: {urlInput.Text}"));
            bool blocked = await CheckForBlockedWords();
            if (blocked)
            {
                return;
            }
            browser.Navigate(urlInput.Text);
        }

        private void forward_Click(object sender, EventArgs e)
        {
            if (browser.CanGoForward)
            {
                Task.Run(() => logEvent($"Going forward"));
                browser.GoForward();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (browser.CanGoBack)
            {
                Task.Run(() => logEvent($"Going back"));
                browser.GoBack();
            }
        }

        private void home_Click(object sender, EventArgs e)
        {
            Task.Run(() => logEvent($"Going to home page"));
            browser.GoHome();
        }

        private async void urlInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Task.Run(() => logEvent($"Navigating to: {urlInput.Text}"));
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

        private void blockedWordAdder_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
            
        }

        private void blockedWordManager_Click(object sender, EventArgs e)
        {
            this.blockedWordManagerWindow.Show();
        }
    }
}
