﻿using System;

namespace CSharpFundamentals
{
    public enum ShippingMethod
    {
        RegularAirMail=1,
        RegisteredAirMail=2,
        Express=3

    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());//ToString isn't necessary inside writeline

        }
    }
}
