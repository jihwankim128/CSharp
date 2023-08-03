using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_HelloWorld3
{
    internal class Program
    {
        // main 설정법 1 - return nothing and input param
        /*static void Main(string[] args)
        {
            Console.WriteLine("static void Main(string[] args)");
        }*/

        // main 설정법 2 - return nothing and no param entered
        /*static void Main()
        {
            Console.WriteLine("static void Main()");
        }*/

        // main 설정법 3 - return int and no param entered
        // 0 : exit_success, -1 : exit_fail
        // return > 0, Successfull, but with additional meaning
        // return < -1, Failed, but with additional meaning
        // 0 is returned to the OS
        /*static int Main()
        {
            Console.WriteLine("static int Main()");
            return 0;
        }*/

        // main 설정법 4 - input param and return int
        static int Main(string[] args)
        {
            // Python fstring
            Console.WriteLine("AAA{0} BBB{1}", 1, "ggg");
            // no newLine
            Console.Write("{0}{1}{2}", 'A', 'B', 'C');
            Console.WriteLine("static int Main(string[] args");
            return 0;
        }

    }
}
