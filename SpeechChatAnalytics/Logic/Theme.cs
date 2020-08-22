using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeechChatAnalytics.Logic
{
    class Theme
    {
        public string name;
        public List<string> words;

        public Theme(string name, List<string> words)
        {
            this.name = name;
            this.words = words;
        }
    }
}
