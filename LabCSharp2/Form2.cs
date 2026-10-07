using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabCSharp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            FileStream file = new FileStream("log2.txt", FileMode.Append, FileAccess.Write);
            TextWriterTraceListener listener = new TextWriterTraceListener(file);
            Trace.Listeners.Add(listener);
            SQLManager.InitDatabase();
            List<string> blockedWordsSQL = SQLManager.GetBlockedWords();
            foreach (string word in blockedWordsSQL)
            {
                blockedWordShower.Items.Add(word);
                
            }
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        // Check if the given word is already in the blocked list
        private async Task<bool> isDuplicatedBlockedWords(string word)
        {
            bool isBlocked = await Task.Run(() =>
            {
                IEnumerable<string> queryResult = from blocked in SQLManager.GetBlockedWords()
                                                  select blocked;
                
                return queryResult.Contains<string>(word);
            });
            return isBlocked;
        }

        // If someone writes in the textbox and presses enter, then add a new blocked word.
        private async void blockedWordInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string word = blockedWordInput.Text;
                bool isDuplicate = await isDuplicatedBlockedWords(word);
                // We won't add an empty string.
                if (blockedWordInput.Text != "" && !isDuplicate)
                {
                    logEvent("New blocked word entered!");
                    SQLManager.AddBlockedWord(word);
                    blockedWordShower.Items.Add(word);
                }
                // Gets rid of the "ding" sound when pressing enter
                e.SuppressKeyPress = true;
            }
        }

        private async Task logEvent(string message)
        {
            // I put a \n so that each log entry will have a
            // blank line after it, making it easier to read
            Trace.WriteLine($"{DateTime.Now}: {message}\n");
            Trace.Flush();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Remove the selected word when delete is pressed
        private void blockedWordShower_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                string word = blockedWordShower.Text;
                SQLManager.deleteBlockedWord(word);
                blockedWordShower.Items.Remove(word);
            }
        }
    }
}
