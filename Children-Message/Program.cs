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
                if (saidSwear <= 25)
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
                    if (msgTextError <= 30 || childrenList[i - 1].Swear == true)
                    {
                        msgText = "Other smthg";
                    }
                    else
                    {
                        msgText = messageList[i - 1].Text;
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
                    childrenList[i - 1].Forward = true;

                    if (childrenList[i-1].Swear == true)
                    {
                        childrenList.Add(new Children(true, false, swearing));
                        messageList.Add(new Message(false, msgText));
                        Message.status = "not forward";
                        Console.WriteLine("Somebody is swearing. The message: "+ msgText);
                        Console.WriteLine("Children count: " + howManyChild + '/' + childrenList.Count);
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
                    if(Message.originaltext == msgText)
                    {
                        Console.WriteLine("Excellent! Not swear and the message is fantastic. \nThe message: " + msgText);
                    }
                    else
                    {
                        Console.WriteLine("Hey! It\'s good. Say stop to swearing. \nThe message: "+ msgText);
                    }
                    Console.WriteLine("Children count: " + howManyChild+ '/' +childrenList.Count);
                }
            }

            Console.WriteLine("\nHistory");
            for (int i = 0; i < childrenList.Count; i++)
            {
                if(i+1 == childrenList.Count)
                {
                    Console.WriteLine(childrenList[i].Name + " : " + messageList[i].Text + "\t-Other Info----" + "REC:" + childrenList[i].Received +
                        "--FW:" + childrenList[i].Forward);
                }
                else
                {
                Console.WriteLine(childrenList[i].Name + " : " + messageList[i].Text + "\t-Other Info----" + "REC:"+ childrenList[i].Received+
                    "--FW:"+ childrenList[i].Forward+"--SW:"+ childrenList[i].Swear);
                }
            }

            Console.ReadLine();
        }
    }
}
