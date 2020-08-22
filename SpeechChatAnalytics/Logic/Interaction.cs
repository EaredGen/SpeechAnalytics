using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeechChatAnalytics.Logic
{
    public class Interaction
    {
        private string typeOfCommunication;
        private string sessionID;
        private string dateOfStartInteraction;
        private string dateIfAdmissionInteraction;
        private string dateOfStartProcessing;
        private string dateOfFinishProcessing;
        private string chatDurationGeneral;
        private string chatDurationWithOperator;
        private string clientNumber;
        private string clientID;
        private string botPresence;
        private string operatorRole;
        private string operatorSiabelLogin;
        private string operatorGenesisLogin;
        private string operatorFCs;
        private string operatorGroupe;
        private string apexUnit;
        private string clientWaitingDuration;
        private string operatorFirstReaction;
        private string durationLastMessage;
        private string operatorAverageTimeAnswer;
        private string clientAverageTimeAnswer;
        private string assessmentOfOperator;
        private string assessmentCommentary;
        private string textOfInteraction;

        public Interaction(string typeOfCommunication, string sessionID, string dateOfStartInteraction, 
            string dateIfAdmissionInteraction, string dateOfStartProcessing, string dateOfFinishProcessing, 
            string chatDurationGeneral, string chatDurationWithOperator, string clientNumber, 
            string clientID, string botPresence, string operatorRole, string operatorSiabelLogin, 
            string operatorGenesisLogin, string operatorFCs, string operatorGroupe, string apexUnit,
            string clientWaitingDuration, string operatorFirstReaction, string durationLastMessage, 
            string operatorAverageTimeAnswer, string clientAverageTimeAnswer, string assessmentOfOperator, 
            string assessmentCommentary, string textOfInteraction)
        {
            this.typeOfCommunication = typeOfCommunication;
            this.sessionID = sessionID;
            this.dateOfStartInteraction = dateOfStartInteraction;
            this.dateIfAdmissionInteraction = dateIfAdmissionInteraction;
            this.dateOfStartProcessing = dateOfStartProcessing;
            this.dateOfFinishProcessing = dateOfFinishProcessing;
            this.chatDurationGeneral = chatDurationGeneral;
            this.chatDurationWithOperator = chatDurationWithOperator;
            this.clientNumber = clientNumber;
            this.clientID = clientID;
            this.botPresence = botPresence;
            this.operatorRole = operatorRole;
            this.operatorSiabelLogin = operatorSiabelLogin;
            this.operatorGenesisLogin = operatorGenesisLogin;
            this.operatorFCs = operatorFCs;
            this.operatorGroupe = operatorGroupe;
            this.apexUnit = apexUnit;
            this.clientWaitingDuration = clientWaitingDuration;
            this.operatorFirstReaction = operatorFirstReaction;
            this.durationLastMessage = durationLastMessage;
            this.operatorAverageTimeAnswer = operatorAverageTimeAnswer;
            this.clientAverageTimeAnswer = clientAverageTimeAnswer;
            this.assessmentOfOperator = assessmentOfOperator;
            this.assessmentCommentary = assessmentCommentary;
            this.textOfInteraction = textOfInteraction;
        }

    }
}
