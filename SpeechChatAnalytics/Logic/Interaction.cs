using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeechChatAnalytics.Logic
{
    public class Interaction
    {
        public string nameOfTheme;
        public string typeOfCommunication;
        public string sessionID;
        public string dateOfStartInteraction;
        public string dateOfAdmissionInteraction;
        public string dateOfStartProcessing;
        public string dateOfFinishProcessing;
        public string chatDurationGeneral;
        public string chatDurationWithOperator;
        public string clientNumber;
        public string clientID;
        public string botPresence;
        public string operatorRole;
        public string operatorSiabelLogin;
        public string operatorGenesisLogin;
        public string operatorFCs;
        public string operatorGroupe;
        public string apexUnit;
        public string clientWaitingDuration;
        public string operatorFirstReaction;
        public string durationLastMessage;
        public string operatorAverageTimeAnswer;
        public string clientAverageTimeAnswer;
        public string assessmentOfOperator;
        public string assessmentCommentary;
        public string textOfInteraction;

        public Interaction(string theme, string typeOfCommunication, string sessionID, string dateOfStartInteraction,
            string dateIfAdmissionInteraction, string dateOfStartProcessing, string dateOfFinishProcessing,
            string chatDurationGeneral, string chatDurationWithOperator, string clientNumber,
            string clientID, string botPresence, string operatorRole, string operatorSiabelLogin,
            string operatorGenesisLogin, string operatorFCs, string operatorGroupe, string apexUnit,
            string clientWaitingDuration, string operatorFirstReaction, string durationLastMessage,
            string operatorAverageTimeAnswer, string clientAverageTimeAnswer, string assessmentOfOperator,
            string assessmentCommentary, string textOfInteraction)
        {
            this.nameOfTheme = theme;
            this.typeOfCommunication = typeOfCommunication;
            this.sessionID = sessionID;
            this.dateOfStartInteraction = dateOfStartInteraction;
            this.dateOfAdmissionInteraction = dateIfAdmissionInteraction;
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
