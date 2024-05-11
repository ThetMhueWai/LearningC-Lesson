using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class clsSwitch
    {
        static void Main(string[] args)
        {
            char grade = 'a';
            switch (grade)
            {
                case 'a': Console.WriteLine("Grade A"); break;
                case 'A': Console.WriteLine("Grade A"); break;
                case 'b': Console.WriteLine("Grade B"); break;
                case 'B': Console.WriteLine("Grade B"); break;
                default: Console.WriteLine("INVALID"); break;
            }
            Console.Read();
        }
    }
}
