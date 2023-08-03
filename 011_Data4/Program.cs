using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Data4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0b11111111;
            int b = 0xFF;
            int c = 255;

            Console.WriteLine("2진수 : " + a);
            Console.WriteLine("16진수 : " + b);
            Console.WriteLine("10진수 : " + c);
        }
    }
}
