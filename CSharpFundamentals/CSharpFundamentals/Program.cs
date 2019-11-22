﻿using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating
            var timeSpan = new TimeSpan(1, 2, 3);
            
            var timeSpan1=new TimeSpan(1,0,0);
            var timeSpan2 = TimeSpan.FromHours(1);


            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: "+duration);

            //Properties
            Console.WriteLine("Minutes: "+timeSpan.Minutes);
            Console.WriteLine("Total minutes: "+timeSpan.TotalMinutes);

            //Add
            Console.WriteLine("Add Example: "+timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Add Example: "+timeSpan.Subtract(TimeSpan.FromMinutes(2)));
        }

    }
}
