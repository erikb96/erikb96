﻿using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many lines should the pyramid have?");
            int lines = Convert.ToInt32(Console.ReadLine());


            string star = "*";

            for (int i = 0; i < lines; i++)
            {
                for (int ii = i; ii < lines - 1; ii++)
                {
                    Console.Write(" ");
                }

                {
                    Console.WriteLine(star);
                    star += "**";
                }



                Console.ReadLine();
            }
        }
    }
}
        