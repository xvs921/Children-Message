using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Children_Message
{
    interface Helper
    {
        int HowManyChild()
        {
            Random rnd = new Random();
            int generateChildNum = rnd.Next(4, 8);
            return generateChildNum;
        }
    }
}
