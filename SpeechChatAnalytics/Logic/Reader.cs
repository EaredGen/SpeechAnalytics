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
        private string path;
        private string selectedThemes;
        private _Application excel;
        private Workbook wb;
        private Worksheet ws;
        private Range lastCell;
        private string[,] list;
        List<Theme> listOfThemesAndRelevantWords;
        private Queue<Interaction> results;
        MainForm form;


        public Reader(MainForm form, string path, string selectedThemes)
        {
            excel = new _Excel.Application();
            listOfThemesAndRelevantWords = new List<Theme>();
            results = new Queue<Interaction>();
            this.path = path;
            this.form = form;
            this.selectedThemes = selectedThemes;
        }

        public void OpenExcel()
        {
            try
            {
                wb = excel.Workbooks.Open(path);
                ws = wb.Worksheets[1];
                lastCell = excel.Cells.SpecialCells(_Excel.XlCellType.xlCellTypeLastCell);
                list = new string[lastCell.Column,lastCell.Row];
            }
            catch (Exception)
            {
                excel.Quit();
            }
        }

        public void ReadExcel()
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
                                    ws.Cells[i, 3].Text.ToString(),
                                    ws.Cells[i, 4].Text.ToString(),
                                    ws.Cells[i, 5].Text.ToString(),
                                    ws.Cells[i, 6].Text.ToString(),
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

        public void AnalyseThemes()
        {
            StringBuilder theme = new StringBuilder();
            StringBuilder neededPhrase = new StringBuilder();
            bool keyTheme = false;
            bool keyWord = false;
            List<string> listOfNeededPhrases = new List<string>();

            for (int i = 0; i < selectedThemes.Length; i++)
            {
                if (selectedThemes[i] == '>')
                {
                    keyTheme = true;
                    continue;
                }
                if (selectedThemes[i] == '<')
                {
                    keyTheme = false;
                    continue;
                }
                if (keyTheme)
                {
                    theme.Append(selectedThemes[i]);
                    continue;
                }
                if ((selectedThemes[i] == '\n') && (selectedThemes[i - 1] == '<'))
                {
                    keyWord = true;
                    continue;
                }
                if (selectedThemes[i] == ',')
                {
                    listOfNeededPhrases.Add(neededPhrase.ToString());
                    neededPhrase.Clear();
                    continue;
                }
                if (selectedThemes[i] == '.')
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
                    neededPhrase.Append(selectedThemes[i]);
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

        public void SendResult()
        {
            form.results = results;
        }
    }
}
