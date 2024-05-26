using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class clsDowhileloop
    {
        static void Main(string[] args)
        {
            int i = 6;
            do
            {
                Console.WriteLine(i);
                i += 1;
            }
            while (i <= 5);
            Console.ReadLine();
        }
    }
}
