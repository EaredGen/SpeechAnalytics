using OfficeOpenXml;
using SpeechChatAnalytics.Logic.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeechChatAnalytics.Logic
{
    class DataReceiver
    {
        private event SetValuesForAppropriateProgressBar setValuesForReadingProgressBar;
        private event PerformStep performStep;

        private string[,] matrixWithData;
        public DataReceiver(string pathForReading, SetValuesForAppropriateProgressBar readingProgress, PerformStep performStep)
        {
            this.performStep = performStep;
            setValuesForReadingProgressBar = readingProgress;
            OpenExcelFile(pathForReading);
        }

        private void OpenExcelFile(string pathForReading)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            FileInfo fileInfo = new FileInfo(pathForReading);
            try
            {
                using (ExcelPackage ep = new ExcelPackage(fileInfo))
                {
                    ExcelWorksheet ew = ep.Workbook.Worksheets[0];
                    GetData(ew);
                }
            }
            catch (System.IO.InvalidDataException)
            {
                MessageBox.Show("Выбран неверный формат файла, программа" +
                    "будет аварийно закрыта. Необходимо для чтения и последующей записи" +
                    "выбирать файлы Excel расширения .xlsx");
                throw;
            }

        }

        private void GetData(ExcelWorksheet ew)
        {
            try
            {
                setValuesForReadingProgressBar(this, new ProgressBarArguments(0, ew.Dimension.End.Row, 0, 1));
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Выбран неверный Excel файл, программа будет закрыта. Необходимо" +
                    "выбрать Excel файл содержащий выгрузку по чатам.");
                throw;
            }
            matrixWithData = new string[ew.Dimension.End.Column, ew.Dimension.End.Row];

            for (int i = 1; i <= ew.Dimension.End.Row; i++)
            {
                for (int j = 1; j <= ew.Dimension.End.Column; j++)
                {
                    matrixWithData[j - 1, i - 1] = ew.Cells[i, j].Value == null ? string.Empty : ew.Cells[i, j].Value.ToString();
                }
                performStep(this);
            }
        }

        public ref string[,] SendResult()
        {
            return ref matrixWithData;
        }
    }
}
