﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_Data_bool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;

            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);

            bool c = ("abc" == "bcd");
            Console.WriteLine("c: " + c);
        }
    }
}
