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
            Console.WriteLine(c>b && c>a);
            Console.WriteLine(c > b && c ==a);
            Console.WriteLine(c > b || c == a);
            Console.WriteLine(!(c > b || c == a));

        }
    }
}
