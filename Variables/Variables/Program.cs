using System;
using System.Reflection.PortableExecutable;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            const float PI = 3.14f;
            PI = 1;//error here
        }
    }
}
