using SpeechChatAnalytics.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeechChatAnalytics.Logic
{
    class Analyzer
    {
        private List<Theme> listOfThemes;
        private List<List<string>> result;
        private event SetValuesForAppropriateProgressBar setValuesForAnalyzeProgressBar;
        private event PerformStep performStep;
        public Analyzer(ref string[,] matrixWithData, string themesAndWordsForAnalyze,
            SetValuesForAppropriateProgressBar setValuesForAnalyzeProgressBar, PerformStep performStep)
        {
            this.performStep = performStep;
            this.setValuesForAnalyzeProgressBar = setValuesForAnalyzeProgressBar;
            result = new List<List<string>>();
            listOfThemes = new List<Theme>();
            AnaylyzeThemesAndNeededWords(themesAndWordsForAnalyze);
            AnalyzeData(matrixWithData);

        }

        private void AnaylyzeThemesAndNeededWords(string themesAndWordsForAnalyze)
        {
            StringBuilder theme = new StringBuilder();
            StringBuilder neededPhrase = new StringBuilder();
            bool keyTheme = false;
            bool keyWord = false;
            List<string> listOfNeededPhrases = new List<string>();

            for (int i = 0; i < themesAndWordsForAnalyze.Length; i++)
            {
                if (themesAndWordsForAnalyze[i] == '>')
                {
                    keyTheme = true;
                    continue;
                }
                if (themesAndWordsForAnalyze[i] == '<')
                {
                    keyTheme = false;
                    continue;
                }
                if (keyTheme)
                {
                    theme.Append(themesAndWordsForAnalyze[i]);
                    continue;
                }
                if ((themesAndWordsForAnalyze[i] == '\n') && (themesAndWordsForAnalyze[i - 1] == '<'))
                {
                    keyWord = true;
                    continue;
                }
                if (themesAndWordsForAnalyze[i] == ',')
                {
                    listOfNeededPhrases.Add(neededPhrase.ToString());
                    neededPhrase.Clear();
                    continue;
                }
                if (themesAndWordsForAnalyze[i] == '.')
                {
                    keyWord = false;
                    listOfNeededPhrases.Add(neededPhrase.ToString());
                    listOfThemes.Add(new Theme(theme.ToString(), listOfNeededPhrases));
                    neededPhrase.Clear();
                    theme.Clear();
                    listOfNeededPhrases = new List<string>();
                    continue;
                }
                if (keyWord)
                {
                    neededPhrase.Append(themesAndWordsForAnalyze[i]);
                    continue;
                }
            }
        }
        private void AnalyzeData(string[,] matrixWithData)
        {
            setValuesForAnalyzeProgressBar(this,new ProgressBarArguments(0,matrixWithData.GetLength(1),0,1));
            try
            {
                setValuesForAnalyzeProgressBar(this, new ProgressBarArguments(0, matrixWithData.GetLength(1), 0, 1));
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Выбран неверный Excel файл, программа будет закрыта. Необходимо" +
                    "выбрать Excel файл содержащий выгрузку по чатам.");
                throw;
            }

            for (int i = 2; i < matrixWithData.GetLength(1) - 2; i++)
            {
                performStep(this);
                foreach (var theme in listOfThemes)
                {
                    foreach (var word in theme.Words)
                    {
                        if (CheckChat(word, matrixWithData[24, i]))
                        {
                            List<string> row = new List<string>();
                            row.Add(theme.Name);
                            int j = 0;
                            while (j <= 24)
                            {
                                row.Add(matrixWithData[j, i]);
                                j++;
                            }
                            result.Add(row);
                            break;
                        }

                    }
                }
            }
        }
        private bool CheckChat(string neededWord, string chat)
        {
            if (chat.ToLower().Contains(neededWord))
                return true;
            return false;
        }

        public ref List<List<string>> SendResult()
        {
            return ref result;
        }
    }
    
}
