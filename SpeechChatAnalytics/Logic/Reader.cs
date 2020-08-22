using OfficeOpenXml;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SpeechChatAnalytics.Logic
{
    class Reader
    {
        MainForm form;
        string[,] matrix;
        List<Theme> listOfThemes;
        private Queue<Interaction> results;

        public Reader(MainForm form)
        {
            this.form = form;
            listOfThemes = new List<Theme>();
            results = new Queue<Interaction>();
            OpenExcel();
            AnalyseThemes();
            Analysis();
            SendResult();
        }

        private void OpenExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            FileInfo fileInfo = new FileInfo(form.textBoxDirectionForReading.Text);
            using (ExcelPackage ep = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet ew = ep.Workbook.Worksheets[0];
                matrix = new string[ew.Dimension.End.Column, ew.Dimension.End.Row];

                for (int i = 1; i <= ew.Dimension.End.Column; i++) 
                {
                    for (int j = 1; j <= ew.Dimension.End.Row; j++) 
                    {
                        matrix[i-1, j-1] = ew.Cells[j, i].Value == null ? string.Empty : ew.Cells[j, i].Value.ToString();
                    }
                }
            }
        }

        private void Analysis()
        {
            form.progressBar.Minimum = 0;
            form.progressBar.Maximum = matrix.GetLength(1);
            form.progressBar.Step = 1;
            for (int i = 2; i < matrix.GetLength(1)-2; i++)
            {
                foreach(var theme in listOfThemes)
                {
                    foreach (var word in theme.words)
                    {
                        if (CheckChat(word, matrix[24,i]))
                        {
                            results.Enqueue(new Interaction(
                                theme.name,
                                matrix[0,i],
                                matrix[1, i],
                                matrix[2, i],
                                matrix[3, i],
                                matrix[4, i],
                                matrix[5, i],
                                matrix[6, i],
                                matrix[7, i],
                                matrix[8, i],
                                matrix[9, i],
                                matrix[10, i],
                                matrix[11, i],
                                matrix[12, i],
                                matrix[13, i],
                                matrix[14, i],
                                matrix[15, i],
                                matrix[16, i],
                                matrix[17, i],
                                matrix[18, i],
                                matrix[19, i],
                                matrix[20, i],
                                matrix[21, i],
                                matrix[22, i],
                                matrix[23, i],
                                matrix[24, i]));
                            break;
                        }
                    }
                }
                form.progressBar.PerformStep();
            }
        }

        public void AnalyseThemes()
        {
            StringBuilder theme = new StringBuilder();
            StringBuilder neededPhrase = new StringBuilder();
            bool keyTheme = false;
            bool keyWord = false;
            List<string> listOfNeededPhrases = new List<string>();

            for (int i = 0; i < form.richTextBoxSelectedThemes.Text.ToString().Length; i++)
            {
                if (form.richTextBoxSelectedThemes.Text.ToString()[i] == '>')
                {
                    keyTheme = true;
                    continue;
                }
                if (form.richTextBoxSelectedThemes.Text.ToString()[i] == '<')
                {
                    keyTheme = false;
                    continue;
                }
                if (keyTheme)
                {
                    theme.Append(form.richTextBoxSelectedThemes.Text.ToString()[i]);
                    continue;
                }
                if ((form.richTextBoxSelectedThemes.Text.ToString()[i] == '\n') && (form.richTextBoxSelectedThemes.Text.ToString()[i - 1] == '<'))
                {
                    keyWord = true;
                    continue;
                }
                if (form.richTextBoxSelectedThemes.Text.ToString()[i] == ',')
                {
                    listOfNeededPhrases.Add(neededPhrase.ToString());
                    neededPhrase.Clear();
                    continue;
                }
                if (form.richTextBoxSelectedThemes.Text.ToString()[i] == '.')
                {
                    keyWord = false;
                    listOfNeededPhrases.Add(neededPhrase.ToString());
                    listOfThemes.Add(new Theme(theme.ToString(), listOfNeededPhrases));
                    neededPhrase.Clear();
                    theme.Clear();
                    continue;
                }
                if (keyWord)
                {
                    neededPhrase.Append(form.richTextBoxSelectedThemes.Text.ToString()[i]);
                    continue;
                }
            }
        }

        private bool CheckChat(string neededWord, string chat)
        {
            if (chat.ToLower().Contains(neededWord))
                return true;
            return false;
        }

        private void SendResult()
        {
            form.results = results;
        }

    }
}
