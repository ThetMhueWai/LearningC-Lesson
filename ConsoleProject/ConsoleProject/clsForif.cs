﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class clsForif
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                if ((i % 2) != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}