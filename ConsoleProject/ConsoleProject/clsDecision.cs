using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class clsDecision
    {
        static void Main(string[] args)
        {
            int age = 18;
            if (age > 18)
            {
                Console.WriteLine("Adult");
            }
            else if(age == 18)
            {
                Console.WriteLine("Age is 18");
            }
            else
            {
                Console.WriteLine("Child");
            }
            Console.Read();
        }
    }
}
