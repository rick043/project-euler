﻿using System;
using System.Diagnostics;

namespace Problem7
{
    
    class Program
    {
        private static Stopwatch _stopwatch = new Stopwatch();
        public static void Main(string[] args)
        {
            _stopwatch.Start();
            var count = 0;
            var result = 2;
            while (true)
            {
                if (IsPrime(result))
                {
                    count++;
                }

                if (count == 10001)
                {
                    break;
                }

                result++;
            }

            Console.WriteLine("Result: " + result);
            _stopwatch.Stop();
            Console.WriteLine("Time: " + _stopwatch.Elapsed);
        }

        private static bool IsPrime(int num)
        {
            for (var i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}