using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Children_Message
{
    class Message
    {
        private bool possibleForward;
        private string text;
        public static string status = "forward"; //forward, not forward
        public static string originaltext = "Peter has a new red car";

        public Message(bool possibleForward, string text)
        {
            this.PossibleForward = possibleForward;
            this.Text = text;
        }

        public bool PossibleForward { get => possibleForward; set => possibleForward = value; }
        public string Text { get => text; set => text = value; }
    }
}
