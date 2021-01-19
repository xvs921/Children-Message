using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Children_Message
{
    class Helper
    {

        public int childNumber()
        {
            Random rnd = new Random();
            int howManyChild = rnd.Next(4, 8);
            return howManyChild;
        }

        public void endCircle(string msgText, int childrenCount)
        {
            if (Message.originaltext == msgText)
            {
                Console.WriteLine("Excellent! Not swear and the message is fantastic. \nThe message: " + msgText);
            }
            else
            {
                Console.WriteLine("Hey! It\'s good. Say stop to swearing. \nThe message: " + msgText);
            }
            Console.WriteLine("Children count: " + childrenCount + '/' + Child.childrenList.Count);
        }

        public void newEvent(string text)
        {
            Child.childrenList.Add(new Child());
            Message.messageList.Add(new Message(text));
        }

        public string optionalStringChange(int i)
        {
            Random rnd = new Random();
            int msgTextError = rnd.Next(100);
            string msgText;
            if (Child.childrenList.Count > 0)
            {
                if (msgTextError <= 30 || Child.childrenList[i - 1].SwearTendency == true)
                {
                    msgText = "Other smthg";
                }
                else
                {
                    msgText = Message.messageList[i - 1].Text;
                }
            }
            else
            {
                msgText = Message.originaltext;
            }
            return msgText;
        }

        public void writeHistory()
        {
            for (int i = 0; i < Child.childrenList.Count; i++)
            {
                if (i + 1 == Child.childrenList.Count)
                {
                    Console.WriteLine(Child.childrenList[i].Name + " : " + Message.messageList[i].Text + "\t-Other Info----" + "REC:" + Child.childrenList[i].SwearTendency +
                        "--FW:" + Child.childrenList[i].SwearTendency);
                }
                else
                {
                    Console.WriteLine(Child.childrenList[i].Name + " : " + Message.messageList[i].Text + "\t-Other Info----" + "REC:" + Child.childrenList[i].SwearTendency +
                        "--FW:" + Child.childrenList[i].SwearTendency + "--SW:" + Child.childrenList[i].SwearTendency);
                }
            }
        }
    }
}
