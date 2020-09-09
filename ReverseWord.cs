using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class ReverseWord
    {
        public static void WordReverse(string str)
        {
            string strrev = "";
            string temp = "";
            foreach (char ch in str)
            {
                //Console.WriteLine(ch);
                //Console.Read();
                if (ch != ' ')
                {
                    temp = ch + temp;
                    //Console.WriteLine(temp);
                    //Console.Read();
                }
                else
                {
                    strrev = strrev + temp + " ";
                    temp = "";
                }
            }
            strrev = strrev + temp + " ";
            Console.WriteLine(strrev);
            Console.ReadLine();
        }
    }
}
