﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Children_Message
{
    class Child
    {
        private string name;
        private bool swearTendency;
        private int messageId;
        public static List<string> nameList = new List<string>() { "John", "David", "Ethan", "Esther", "Dora", "Monica", "Kiara", "Anthony" };
        public static List<Child> childrenList = new List<Child>();
        Random rnd = new Random();

        public Child()
        {
            this.generateName();
            this.generateSwear();
        }

        public string Name { get => name; set => name = value; }
        public bool SwearTendency { get => swearTendency; set => swearTendency = value; }

        public void receive(int messageId)
        {
            Message.messageList[messageId].Received = true;
        }

        public void forward(int messageId)
        {
            Message.messageList[messageId].Forwarded = true;
        }

        public void generateName()
        {
            int whichName = rnd.Next(0, Child.nameList.Count - 1);
            this.Name = Child.nameList[whichName];
            Child.nameList.Remove(this.Name);
        }

        public void generateSwear()
        {
            int saidSwear = rnd.Next(100);
            if (saidSwear <= 25)
            {
                this.SwearTendency = true;
            }
            else
            {
                this.SwearTendency = false;
            }
        }

    }
}
