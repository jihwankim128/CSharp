using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Data3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte sbyteData = 255;
            // Over Casting
            sbyte sbyteData2 = (sbyte)sbyteData;
            // Auto Casting
            int intData = sbyteData;

            Console.WriteLine("sbyteData = " + sbyteData);
            Console.WriteLine("sbyteData2 = " + sbyteData2);
            Console.WriteLine("intData = " + intData);
        }
    }
}
