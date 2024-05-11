using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class clsEnterYourNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number COnsole Program");
            Console.Write("Enter Number: ");

            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine("You enter One");
            }
            Console.Read();
        }
    }
}
