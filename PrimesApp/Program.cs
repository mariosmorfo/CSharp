﻿namespace PrimesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine($"{i} : is prime : {isPrime(i)}");
            }
        }

        public static bool isPrime(int n)
        {
            bool prime = true;

            for (int divider = 2; divider <= (int)Math.Sqrt(n); divider++)
            {
                if ((n % divider) == 0)
                {
                    prime = false;
                    break;
                } 

            }
            return prime;
        }

    }
}
