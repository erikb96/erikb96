﻿using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int mynumber = 1000;
            Counter(mynumber);
            Console.ReadLine();
            
        }
        public static int Counter(int number)
        {
            Console.WriteLine(number);
            if (number == 0)
            {
                return 0;
            }
            else
            {
                return Counter(number - 1);
            }
            
            
        }
    }
}
// Write a recursive function that takes one parameter: n and counts down from n.
