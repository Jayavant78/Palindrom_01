using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {


            string temp = "Namade";

            string uppr = temp.ToUpper();

            char[] arg = uppr.ToCharArray();

            string revers = "";

            for (int i = arg.Length - 1; i > -1; i--)
            {
                revers += arg[i];
            }

            if (revers == uppr)
            {
                Console.WriteLine("This is palindrom:" + revers);
            }
            else
            {
                Console.WriteLine("Not a Palindrom:"  + revers);
            }
        }
    }
}
