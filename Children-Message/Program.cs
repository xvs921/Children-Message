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
            int childrenCount=5;
            for (int i = 0; i < childrenCount; i++)
            {
                //text
                Random rnd = new Random();
                int msgTextError = rnd.Next(100);
                string msgText;
                if (i > 0)
                {
                    if (msgTextError <= 30 || Child.childrenList[i - 1].Swear == true)
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

                //if first
                if (i == 0)
                {
                    Child.childrenList.Add(new Child());
                    Message.messageList.Add(new Message(true, Message.originaltext));
                }
                else //other all children
                {
                    Child.childrenList[i - 1].Swear = true;  //forward

                    if (Child.childrenList[i-1].Swear == true)
                    {
                        Child.childrenList.Add(new Child());
                        Message.messageList.Add(new Message(false, msgText));
                        Message.status = "not forward";
                        Console.WriteLine("Somebody is swearing. The message: "+ msgText);
                        Console.WriteLine("Children count: " + childrenCount + '/' + Child.childrenList.Count);
                        break;
                    }
                    else
                    {
                        Child.childrenList.Add(new Child());
                        Message.messageList.Add(new Message(true, msgText));
                        Message.status = "not forward";
                    }
                }

                if(i+1 == childrenCount)
                {
                    if(Message.originaltext == msgText)
                    {
                        Console.WriteLine("Excellent! Not swear and the message is fantastic. \nThe message: " + msgText);
                    }
                    else
                    {
                        Console.WriteLine("Hey! It\'s good. Say stop to swearing. \nThe message: "+ msgText);
                    }
                    Console.WriteLine("Children count: " + childrenCount + '/' +Child.childrenList.Count);
                }
            }

            Console.WriteLine("\nHistory");
            for (int i = 0; i < Child.childrenList.Count; i++)
            {
                if(i+1 == Child.childrenList.Count)
                {
                    Console.WriteLine(Child.childrenList[i].Name + " : " + Message.messageList[i].Text + "\t-Other Info----" + "REC:" + Child.childrenList[i].Swear +
                        "--FW:" + Child.childrenList[i].Swear);
                }
                else
                {
                Console.WriteLine(Child.childrenList[i].Name + " : " + Message.messageList[i].Text + "\t-Other Info----" + "REC:"+ Child.childrenList[i].Swear +
                    "--FW:"+ Child.childrenList[i].Swear + "--SW:"+ Child.childrenList[i].Swear);
                }
            }
            Console.ReadLine();
        }
    }
}
