using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class ShortNames
    {
        public static void FirstMiddle(string str)
        {
            string[] nameParts = str.Split();
            nameParts[0] = nameParts[0].Substring(0, 1);
            nameParts[1] = nameParts[1].Substring(0, 1);
            string name = String.Join(" ", nameParts);
            Console.WriteLine(name);
            Console.Read();
        }
    }
}
