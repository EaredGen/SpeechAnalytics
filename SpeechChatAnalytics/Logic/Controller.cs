using SpeechChatAnalytics.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeechChatAnalytics.Logic
{
    delegate void SetValuesForAppropriateProgressBar(object sendler, ProgressBarArguments args);
    delegate void PerformStep(object sendler);
    class Controller
    {
        public Controller(string path, string themesAndWordsForAnalyze, EndNotification notification, 
            SetValuesForAppropriateProgressBar valuesInstaller, PerformStep performStep)
        {
            // получение ссылки на матрицу данных, выгруженных с Excel
            DataReceiver dataReceiver = new DataReceiver(path,valuesInstaller,performStep);
            ref string[,] matrixWithData = ref dataReceiver.SendResult();

            // получение ссылки на список найденных по тематикам взаимодействий
            Analyzer analyzer = new Analyzer(ref matrixWithData,themesAndWordsForAnalyze,valuesInstaller,performStep);
            ref List<List<string>> result = ref analyzer.SendResult();

            Writer writer = new Writer(ref result, path, notification, valuesInstaller, performStep);


        }


    }
}
