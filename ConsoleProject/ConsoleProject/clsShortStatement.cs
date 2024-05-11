using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class clsShortStatement
    {
        static void Main(string[] args)
        {
            int grade = 10;
            string result = (grade > 11) ? "A" : "B";
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
