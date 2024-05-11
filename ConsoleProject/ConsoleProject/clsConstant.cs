using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class clsConstant
    {
        static void Main(string[] args)
        {
            double radius = 3.5;
            double area = constants.pi * (radius * radius);
            Console.WriteLine(area);
            Console.Read();
        }
        class constants
        {
            public const double pi = 3.1416;
        }
    }
}
