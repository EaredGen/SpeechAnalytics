using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeechChatAnalytics.Logic.Entities
{
    class Theme
    {
        public string Name
        { get; set; }

        public List<String> Words
        { get; private set; }

        public Theme(string name, List<string> words)
        {
            this.Name = name;
            this.Words = words;
        }
    }
}
