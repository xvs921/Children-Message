using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Children_Message
{
    class Message
    {
        public bool possibleForward;
        public string text;
        public static string status = "forward"; //forward, not forward
        public static string originaltext = "Peter has a new red car";

        public Message(bool possibleForward, string text)
        {
            this.possibleForward = possibleForward;
            this.text = text;
        }
    }
}
