using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class clsUserName
    {
        static void Main(string[] args)
        {
            string correctUserName = "user123";
            string correctPassword = "pass123";

            Console.WriteLine("Welcome to User login");
            Console.Write("Enter Your User Name: ");
            string username = Console.ReadLine();

            Console.Write("Enter Your User Password: ");
            string password = Console.ReadLine();

            if (username == correctUserName && password == correctPassword)
            {
                Console.WriteLine("Success Login");
            }
            else
            {
                Console.WriteLine("Login Failed");
            }
            Console.Read();

        }
    }
}
