using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Children_Message
{
    class Children
    {
        private string name;
        private bool received;
        private bool forward;
        private bool swear;
        public static List<string> nameList = new List<string>() { "John", "David", "Ethan", "Esther", "Dora", "Monica", "Kiara", "Anthony" };
        Random rnd = new Random();

        public Children(bool received, bool forward, bool swear)
        {
            int whichName = rnd.Next(0, Children.nameList.Count - 1);
            this.Name = Children.nameList[whichName];
            Children.nameList.Remove(this.Name);
            this.Received = received;
            this.Forward = forward;
            this.Swear = swear;
        }

        public string Name { get => name; set => name = value; }
        public bool Received { get => received; set => received = value; }
        public bool Forward { get => forward; set => forward = value; }
        public bool Swear { get => swear; set => swear = value; }

    }
}
