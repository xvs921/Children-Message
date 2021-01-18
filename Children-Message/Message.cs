using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Children_Message
{
    class Message
    {
        private int id;
        private string text;
        private bool swear;
        private bool received;
        private bool forwarded;
        //status here
        public static string originaltext = "Peter has a new red car";

        public static List<Message> messageList = new List<Message>();

        public Message(string text)
        {
            this.Text = text;
        }

        public int Id { get => id; set => id = value; }
        public string Text { get => text; set => text = value; }
        public bool Swear { get => swear; set => swear = value; }
        public bool Received { get => received; set => received = value; }
        public bool Forwarded { get => forwarded; set => forwarded = value; }


    }
}
