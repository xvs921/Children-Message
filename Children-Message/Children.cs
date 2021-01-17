using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Children_Message
{
    class Children
    {
        public string name;
        public bool received;
        public bool forward;
        public bool swear;
        public static List<string> nameList = new List<string>() { "John", "David", "Ethan", "Esther", "Dora", "Monica", "Kiara", "Anthony" };
        Random rnd = new Random();


        public Children(bool received, bool forward, bool swear)
        {
            int whichName = rnd.Next(0, Children.nameList.Count-1);
            this.name = Children.nameList[whichName];
            Children.nameList.Remove(this.name);
            this.received = received;
            this.forward = forward;
            this.swear = swear;
        }

    }
}
