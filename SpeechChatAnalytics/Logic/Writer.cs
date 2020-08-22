using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace SpeechChatAnalytics.Logic
{
    delegate void EndNotification();
    class Writer
    {
        private event SetValuesForAppropriateProgressBar setValuesForWriterProgressBar;
        private event EndNotification SentResultOfWriting;
        private event PerformStep performStep;
        public Writer(ref List<List<string>> result, string path, EndNotification endNotification, 
            SetValuesForAppropriateProgressBar setValuesForWriterProgressBar, PerformStep performStep)
        {
            this.performStep = performStep;
            this.setValuesForWriterProgressBar = setValuesForWriterProgressBar;
            SentResultOfWriting = endNotification;
            CreateExcelFile(ref result,path);
        }

        private void CreateExcelFile(ref List<List<string>> result, string path)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet 2");
                Write(ref result, excelPackage.Workbook.Worksheets[0]);
                FileInfo fi = new FileInfo(path);
                excelPackage.SaveAs(fi);
                SentResultOfWriting();
            }
        }

        private void Write(ref List<List<string>> result, ExcelWorksheet excelWorksheet)
        {
            try
            {
                setValuesForWriterProgressBar(this, new Entities.ProgressBarArguments(0, result.Count, 0, 1));
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Выбран неверный Excel файл, программа будет закрыта. Необходимо" +
                    "выбрать Excel файл содержащий выгрузку по чатам.");
                throw;
            }
            int rowNumber = 1;
            foreach (var row in result)
            {
                performStep(this);
                int columnNumber = 0;
                while (columnNumber < 26)
                {
                    excelWorksheet.Cells[rowNumber,columnNumber+1].Value = String.Format(row[columnNumber]);
                    columnNumber++;
                }
                rowNumber++;
            }
        }

    }
}
