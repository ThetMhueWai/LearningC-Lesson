using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class clsCalculation
    {
        static void Main(string[] args)
        {
            int mark1, mark2, totalmark;
            mark1 = 100;
            mark2 = 150;
            totalmark = mark1 + mark2;
            Console.WriteLine(totalmark);
            mark1 = 150;
            mark2 = 100;
            totalmark = mark1 - mark2;
            Console.WriteLine("This is total mark\t= " + totalmark);
            Console.ReadKey();
   
        }
    }
}
