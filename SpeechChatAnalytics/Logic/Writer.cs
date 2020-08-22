using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace SpeechChatAnalytics.Logic
{
    class Writer
    {
        private MainForm form;
        private _Application excel;
        private Workbook wb;
        private Worksheet ws;
        private Range lastCell;
        private string[,] list;

        public Writer(MainForm form)
        {
            this.form = form;
            excel = new _Excel.Application();
        }

        public void Write()
        {
            try
            {
                Interaction interaction;
                int counter = 2;
                while (form.results.Count != 0)
                {
                    try
                    {
                        interaction = form.results.Dequeue();
                        ws.Cells[counter, 1] = String.Format(interaction.typeOfCommunication.ToString());
                        ws.Cells[counter, 2] = String.Format(interaction.sessionID.ToString());
                        ws.Cells[counter, 3] = String.Format(interaction.dateOfStartInteraction.ToString());
                        ws.Cells[counter, 4] = String.Format(interaction.dateIfAdmissionInteraction.ToString());
                        ws.Cells[counter, 5] = String.Format(interaction.dateOfStartProcessing.ToString());
                        ws.Cells[counter, 6] = String.Format(interaction.dateOfFinishProcessing.ToString());
                        ws.Cells[counter, 7] = String.Format(interaction.chatDurationGeneral.ToString());
                        ws.Cells[counter, 8] = String.Format(interaction.chatDurationWithOperator.ToString());
                        ws.Cells[counter, 9] = String.Format(interaction.clientNumber.ToString());
                        ws.Cells[counter, 10] = String.Format(interaction.clientID.ToString());
                        ws.Cells[counter, 11] = String.Format(interaction.botPresence.ToString());
                        ws.Cells[counter, 12] = String.Format(interaction.operatorRole.ToString());
                        ws.Cells[counter, 13] = String.Format(interaction.operatorSiabelLogin.ToString());
                        ws.Cells[counter, 14] = String.Format(interaction.operatorGenesisLogin.ToString());
                        ws.Cells[counter, 15] = String.Format(interaction.operatorFCs.ToString());
                        ws.Cells[counter, 16] = String.Format(interaction.operatorGroupe.ToString());
                        ws.Cells[counter, 17] = String.Format(interaction.apexUnit.ToString());
                        ws.Cells[counter, 18] = String.Format(interaction.clientWaitingDuration.ToString());
                        ws.Cells[counter, 19] = String.Format(interaction.operatorFirstReaction.ToString());
                        ws.Cells[counter, 20] = String.Format(interaction.durationLastMessage.ToString());
                        ws.Cells[counter, 21] = String.Format(interaction.operatorAverageTimeAnswer.ToString());
                        ws.Cells[counter, 22] = String.Format(interaction.clientAverageTimeAnswer.ToString());
                        ws.Cells[counter, 23] = String.Format(interaction.assessmentOfOperator.ToString());
                        ws.Cells[counter, 24] = String.Format(interaction.assessmentCommentary.ToString());
                        ws.Cells[counter, 25] = String.Format(interaction.textOfInteraction.ToString());
                        counter++;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        continue;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                excel.Quit();
            }
        }

        public void OpenExcel()
        {
            try
            {
                wb = excel.Workbooks.Open(form.textBoxDirectionForWritting.Text);
                ws = wb.Worksheets[1];
                lastCell = excel.Cells.SpecialCells(_Excel.XlCellType.xlCellTypeLastCell);
                list = new string[lastCell.Column, lastCell.Row];
            }
            catch (Exception)
            {
                excel.Quit();
            }
        }
    }
}
