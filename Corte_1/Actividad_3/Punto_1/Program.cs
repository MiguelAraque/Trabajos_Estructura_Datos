﻿using System;

namespace numberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un numero");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            for (int i = 1; i <= n1; i++)
            {
                for (int n = 1; n <= i; n++)
                {
                    Console.Write(i);
                }
                Console.Write("\n");
            }
            Console.WriteLine("");
        }
    }
}
