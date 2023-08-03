using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Data1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 120;
            byte b = 255;
            short c = 30000;
            int d = 2100000000;
            long e = 9000000000000000000;
            ulong f = 18000000000000000000;
            Console.WriteLine("sbyte : {0}, byte : {1}", a, b);
            Console.WriteLine("short : {0}, int : {1}", c, d);
            Console.WriteLine("long : {0}, ulong : {1}", e, f);
        }
    }
}
