using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeechChatAnalytics.Logic.Entities
{
    class ProgressBarArguments
    {
        public int MinValue { get; private set; }
        public int MaxValue { get; private set; }
        public int CurrentValue { get; private set; }
        public int SizeOfStep { get; private set; }

        public ProgressBarArguments(int minValue, int maxValue, int currentValue, int sizeOfStep)
        {
            MinValue = minValue;
            MaxValue = maxValue;
            CurrentValue = currentValue;
            SizeOfStep = sizeOfStep;
        }
    }
}
