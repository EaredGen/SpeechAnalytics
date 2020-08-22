using SpeechChatAnalytics.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeechChatAnalytics
{
    public partial class MainForm : Form
    {
        private OpenFileDialog ofd;
        public Queue<Interaction> results;
        public MainForm()
        {
            InitializeComponent();
            ofd = new OpenFileDialog();
            richTextBoxAllThemes.Text = Properties.Settings.Default.Themes;
        }

        private void buttonChooseDirection_MouseClick(object sender, MouseEventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (sender == buttonChooseReadingDirection)
                {
                    textBoxDirectionForReading.Text = ofd.FileName;
                    if (textBoxDirectionForReading.Text != "")
                        buttonRead.Enabled = true;
                }
                else
                {
                    textBoxDirectionForWritting.Text = ofd.FileName;
                    if (textBoxDirectionForWritting.Text != "")
                        buttonWrite.Enabled = true;
                }
            }
        }

        private void buttonSaveThemes_MouseClick(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.Themes = richTextBoxAllThemes.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Изменения в перечень всех тематик внесены");
        }

        private void checkBoxAllowChangeThemes_Click(object sender, EventArgs e)
        {
            if (checkBoxAllowChangeThemes.Checked)
            {
                richTextBoxAllThemes.ReadOnly = false;
            }
            else
            {
                richTextBoxAllThemes.ReadOnly = true;
            }

        }

        private void buttonRead_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
