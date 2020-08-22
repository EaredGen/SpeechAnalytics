using SpeechChatAnalytics.Logic;
using SpeechChatAnalytics.Logic.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeechChatAnalytics
{
    public partial class MainForm : Form
    {
        private OpenFileDialog openFileDiaolog;
        private Process process;
        public MainForm()
        {
            this.process = Process.GetCurrentProcess();
            this.process.PriorityClass = ProcessPriorityClass.High;

            InitializeComponent();
            openFileDiaolog = new OpenFileDialog();
            richTextBoxAllThemes.Text = Properties.Settings.Default.Themes;
        }

        private void buttonChooseDirection_MouseClick(object sender, MouseEventArgs e)
        {
            if (openFileDiaolog.ShowDialog() == DialogResult.OK)
            {
                    textBoxDirectionForReading.Text = openFileDiaolog.FileName;
                    if (textBoxDirectionForReading.Text != "")
                        buttonRead.Enabled = true;
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

        private void buttonRead_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller(textBoxDirectionForReading.Text,richTextBoxSelectedThemes.Text,
                ShowResultOfWriting, SetEventValues, PerformStep);
        }

        private void ShowResultOfWriting()
        {
            MessageBox.Show("Запись успешно завершена");
        }

        private void SetEventValues(object sendler, ProgressBarArguments args)
        {
            if (sendler is DataReceiver)
            {
                progressBarReading.Minimum = args.MinValue;
                progressBarReading.Maximum = args.MaxValue;
                progressBarReading.Value = args.CurrentValue;
                progressBarReading.Step = args.SizeOfStep;
            }
            if (sendler is Analyzer)
            {
                progressBarAnalyze.Minimum = args.MinValue;
                progressBarAnalyze.Maximum = args.MaxValue;
                progressBarAnalyze.Value = args.CurrentValue;
                progressBarAnalyze.Step = args.SizeOfStep;
            }
            if (sendler is Writer)
            {
                progressBarWriting.Minimum = args.MinValue;
                progressBarWriting.Maximum = args.MaxValue;
                progressBarWriting.Value = args.CurrentValue;
                progressBarWriting.Step = args.SizeOfStep;
            }
        }

        private void PerformStep(object sendler)
        {
            if (sendler is DataReceiver)
            {
                progressBarReading.PerformStep();
            }
            if (sendler is Analyzer)
            {
                progressBarAnalyze.PerformStep();
            }
            if(sendler is Writer)
            {
                progressBarWriting.PerformStep();
            }
        }


    }
}
