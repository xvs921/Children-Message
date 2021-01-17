using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Children_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Children> childrenList = new List<Children>();
            List<Message> messageList = new List<Message>();

            Random rnd = new Random();
            int howManyChild = rnd.Next(4, 8);

            for (int i = 0; i < howManyChild; i++)
            {
                //swear
                int saidSwear = rnd.Next(100);
                bool swearing;
                if (saidSwear <= 30)
                {
                    swearing = true;
                }
                else
                {
                    swearing = false;
                }

                //text
                int msgTextError = rnd.Next(100);
                string msgText;
                if (i > 0)
                {
                    if (msgTextError <= 30 || childrenList[i - 1].swear == true)
                    {
                        msgText = "Other smthg";
                    }
                    else
                    {
                        msgText = messageList[i - 1].text;
                    }
                }
                else
                {
                    msgText = Message.originaltext;
                }

                //if first
                if (i == 0)
                {
                    childrenList.Add(new Children(true, false, swearing));
                    messageList.Add(new Message(true, Message.originaltext));
                }
                else //other all children
                {
                    childrenList[i - 1].forward = true;

                    if (childrenList[i-1].swear == true)
                    {
                        childrenList.Add(new Children(true, false, swearing));
                        messageList.Add(new Message(false, msgText));
                        Message.status = "not forward";
                        Console.WriteLine("Somebody is swearing. The message: "+ msgText);
                        Console.WriteLine("Children count: " + childrenList.Count);
                        break;
                    }
                    else
                    {
                        childrenList.Add(new Children(true, false, swearing));
                        messageList.Add(new Message(true, msgText));
                        Message.status = "not forward";
                    }
                }

                if(i+1 == howManyChild)
                {
                    Console.WriteLine("Hey! It\'s good. Say stop to swearing. The message: "+ msgText);
                    Console.WriteLine("Children count: " + childrenList.Count);
                }
            }

            Console.WriteLine("History");
            for (int i = 0; i < childrenList.Count; i++)
            {
                Console.WriteLine(childrenList[i].name + " : " + messageList[i].text);
            }

            Console.ReadLine();
        }
    }
}
