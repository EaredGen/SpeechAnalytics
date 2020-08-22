using OfficeOpenXml;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeechChatAnalytics.Logic;

namespace SpeechChatAnalytics.GUI
{
    class Writer
    {
        private MainForm form;

        public Writer(MainForm form)
        {
            this.form = form;
            this.form.progressBar.Value = 0;
            Write();
        }

        private void Write()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            FileInfo fileInfo = new FileInfo(form.textBoxDirectionForWritting.Text);

            using (ExcelPackage ep = new ExcelPackage(fileInfo))
            {
                form.progressBar.Minimum = 0;
                form.progressBar.Maximum = form.results.Count;
                form.progressBar.Step = 1;
                Interaction interaction;
                ExcelWorksheet ew = ep.Workbook.Worksheets[0];
                int counter = 2;
                while (form.results.Count != 0)
                {
                    try
                    {
                        interaction = form.results.Dequeue();
                        ew.Cells[counter, 1].Value = String.Format(interaction.nameOfTheme);
                        ew.Cells[counter, 2].Value = String.Format(interaction.typeOfCommunication);
                        ew.Cells[counter, 3].Value = String.Format(interaction.sessionID);
                        ew.Cells[counter, 4].Value = String.Format(interaction.dateOfStartInteraction);
                        ew.Cells[counter, 5].Value = String.Format(interaction.dateOfAdmissionInteraction);
                        ew.Cells[counter, 6].Value = String.Format(interaction.dateOfStartProcessing);
                        ew.Cells[counter, 7].Value = String.Format(interaction.dateOfFinishProcessing);
                        ew.Cells[counter, 8].Value = String.Format(interaction.chatDurationGeneral);
                        ew.Cells[counter, 9].Value = String.Format(interaction.chatDurationWithOperator);
                        ew.Cells[counter, 10].Value = String.Format(interaction.clientNumber);
                        ew.Cells[counter, 11].Value = String.Format(interaction.clientID);
                        ew.Cells[counter, 12].Value = String.Format(interaction.botPresence);
                        ew.Cells[counter, 13].Value = String.Format(interaction.operatorRole);
                        ew.Cells[counter, 14].Value = String.Format(interaction.operatorSiabelLogin);
                        ew.Cells[counter, 15].Value = String.Format(interaction.operatorGenesisLogin);
                        ew.Cells[counter, 16].Value = String.Format(interaction.operatorFCs);
                        ew.Cells[counter, 17].Value = String.Format(interaction.operatorGroupe);
                        ew.Cells[counter, 18].Value = String.Format(interaction.apexUnit);
                        ew.Cells[counter, 19].Value = String.Format(interaction.clientWaitingDuration);
                        ew.Cells[counter, 20].Value = String.Format(interaction.operatorFirstReaction);
                        ew.Cells[counter, 21].Value = String.Format(interaction.durationLastMessage);
                        ew.Cells[counter, 22].Value = String.Format(interaction.operatorAverageTimeAnswer);
                        ew.Cells[counter, 23].Value = String.Format(interaction.clientAverageTimeAnswer);
                        ew.Cells[counter, 24].Value = String.Format(interaction.assessmentOfOperator);
                        ew.Cells[counter, 25].Value = String.Format(interaction.assessmentCommentary);
                        ew.Cells[counter, 26].Value = String.Format(interaction.textOfInteraction);
                        counter++;
                        form.progressBar.PerformStep();
                    }
                    catch (Exception ex)
                    {
                        continue;
                    }
                }
                ep.SaveAs(fileInfo);
            }
        }

    }
}
