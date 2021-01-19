using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Children_Message
{
    class Status
    {
        private string name;

        public Status(string name)
        {
            this.Name = name;
        }

        public string Name { get => name; set => name = value; }
    }
}
