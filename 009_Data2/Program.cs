﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Data2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("short min : {0}, short max : {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("byte min : {0}, byte max : {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("int min : {0}, int max : {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("long min : {0}, long max : {1}", long.MinValue, long.MaxValue);
            Console.WriteLine("ulong min : {0}, ulong max : {1}", ulong.MinValue, ulong.MaxValue);
        }
    }
}
