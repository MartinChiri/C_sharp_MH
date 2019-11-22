using System;
using System.Threading.Channels;

namespace CSharpFundamentals
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is {0} {1}",FirstName,LastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var john=new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();
        }
    }
}
