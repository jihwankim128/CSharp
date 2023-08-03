using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("지금 듣는 강의는 ");
            for(int i = 0; i< args.Length; i++)
            {
                Console.Write(args[i] + " ");
            }
            Console.WriteLine("좋아요!!");
        }
    }
}
