using System;
using System.Threading;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;
            Console.WriteLine(a+b*c);
            Console.WriteLine((a+b)*c);
        }
    }
}
