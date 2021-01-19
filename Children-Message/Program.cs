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
            Helper hlp = new Helper();
            int childrenCount=hlp.childNumber();
            Random rnd = new Random();

            for (int i = 0; i < childrenCount; i++)
            {
                string msgText = hlp.optionalStringChange(i);

                if (i == 0)
                {
                    hlp.newEvent(Message.originaltext);
                }
                else
                {
                    //forward

                    if (Child.childrenList[i-1].SwearTendency == true)
                    {
                        hlp.newEvent(msgText);
                        //Message.status = "not forward";
                        Console.WriteLine("Somebody is swearing. The message: "+ msgText);
                        Console.WriteLine("Children count: " + childrenCount + '/' + Child.childrenList.Count);
                        break;
                    }
                    else
                    {
                        hlp.newEvent(msgText);
                        //Message.status = "not forward";
                    }
                }

                if(i+1 == childrenCount)
                {
                    hlp.endCircle(msgText, childrenCount);
                }
            }

            Console.WriteLine("\nHistory");
            hlp.writeHistory();

            Console.ReadLine();
        }
    }
}
