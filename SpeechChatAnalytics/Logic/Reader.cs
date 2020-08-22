using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using SpeechChatAnalytics.Logic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace SpeechChatAnalytics.GUI
{
    class Reader
    {
        private _Application excel;
        private Workbook wb;
        private Worksheet ws;
        private Range lastCell;
        private string[,] list;
        List<Theme> listOfThemesAndRelevantWords;
        private Queue<Interaction> results;
        MainForm form;


        public Reader(MainForm form)
        {
            excel = new _Excel.Application();
            listOfThemesAndRelevantWords = new List<Theme>();
            results = new Queue<Interaction>();
            this.form = form;
        }

        private void OpenExcel()
        {
            try
            {
                wb = excel.Workbooks.Open(form.textBoxDirectionForReading.Text);
                ws = wb.Worksheets[1];
                lastCell = excel.Cells.SpecialCells(_Excel.XlCellType.xlCellTypeLastCell);
                list = new string[lastCell.Column,lastCell.Row];
            }
            catch (Exception)
            {
                excel.Quit();
            }
        }

        private void ReadExcel()
        {
            try
            {
                for (int i = 4; i < lastCell.Row; i++)
                {
                    foreach (var theme in listOfThemesAndRelevantWords)
                    {
                        foreach (var word in theme.words)
                        {
                            if (CheckChat(word,ws.Cells[i, 25].Text.ToString()))
                            {
                                // добавить в выгрузку по теме, начать смотреть другую тему
                                results.Enqueue(new Interaction(
                                    ws.Cells[i,1].Text.ToString(),
                                    ws.Cells[i, 2].Text.ToString(),
                                    Convert.ToDateTime(ws.Cells[i, 3].Text.ToString()),
                                    Convert.ToDateTime(ws.Cells[i, 4].Text.ToString()),
                                    Convert.ToDateTime(ws.Cells[i, 5].Text.ToString()),
                                    Convert.ToDateTime(ws.Cells[i, 6].Text.ToString()),
                                    ws.Cells[i, 7].Text.ToString(),
                                    ws.Cells[i, 8].Text.ToString(),
                                    ws.Cells[i, 9].Text.ToString(),
                                    ws.Cells[i, 10].Text.ToString(), 
                                    ws.Cells[i, 11].Text.ToString(),
                                    ws.Cells[i, 12].Text.ToString(),
                                    ws.Cells[i, 13].Text.ToString(),
                                    ws.Cells[i, 14].Text.ToString(),
                                    ws.Cells[i, 15].Text.ToString(),
                                    ws.Cells[i, 16].Text.ToString(),
                                    ws.Cells[i, 17].Text.ToString(),
                                    ws.Cells[i, 18].Text.ToString(),
                                    ws.Cells[i, 19].Text.ToString(),
                                    ws.Cells[i, 20].Text.ToString(),
                                    ws.Cells[i, 21].Text.ToString(),
                                    ws.Cells[i, 22].Text.ToString(),
                                    ws.Cells[i, 23].Text.ToString(),
                                    ws.Cells[i, 24].Text.ToString(),
                                    ws.Cells[i, 25].Text.ToString()));
                                break;
                            }
                        }
                    }
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
            }
        }

        private void AnalyseThemes()
        {
            StringBuilder theme = new StringBuilder();
            StringBuilder neededPhrase = new StringBuilder();
            bool keyTheme = false;
            bool keyWord = false;
            List<string> listOfNeededPhrases = new List<string>();

            for (int i = 0; i < form.richTextBoxSelectedThemes.Text.Length; i++)
            {
                if (form.richTextBoxSelectedThemes.Text[i] == '>')
                {
                    keyTheme = true;
                    continue;
                }
                if (form.richTextBoxSelectedThemes.Text[i] == '<')
                {
                    keyTheme = false;
                    continue;
                }
                if (keyTheme)
                {
                    theme.Append(form.richTextBoxSelectedThemes.Text[i]);
                    continue;
                }
                if ((form.richTextBoxSelectedThemes.Text[i] == '\n') && (form.richTextBoxSelectedThemes.Text[i - 1] == '<'))
                {
                    keyWord = true;
                    continue;
                }
                if (form.richTextBoxSelectedThemes.Text[i] == ',')
                {
                    listOfNeededPhrases.Add(neededPhrase.ToString());
                    neededPhrase.Clear();
                    continue;
                }
                if (form.richTextBoxSelectedThemes.Text[i] == '.')
                {
                    keyWord = false;
                    listOfNeededPhrases.Add(neededPhrase.ToString());
                    listOfThemesAndRelevantWords.Add(new Theme(theme.ToString(), listOfNeededPhrases));
                    neededPhrase.Clear();
                    theme.Clear();
                    continue;
                }
                if (keyWord)
                {
                    neededPhrase.Append(form.richTextBoxSelectedThemes.Text[i]);
                    continue;
                }
            }
        }

        private bool CheckChat(string neededWord,string chat)
        {
            if (chat.Contains(neededWord))
                return true;
            return false;
        }

        private void SendResult()
        {
            form.results = results;
        }

        public void Run()
        {

        }
    }
}
