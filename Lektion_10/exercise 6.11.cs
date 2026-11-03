/*
using System;

class Program
{
    static void Main()
    {
        int max = 1000000;

        bool[] isPrime = new bool[max];

        // Antag at alle tal er primtal
        for (int i = 2; i < max; i++)
        {
            isPrime[i] = true;
        }

        // Sieve of Eratosthenes
        for (int i = 2; i <= Math.Sqrt(max); i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j < max; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        int largestPrime = 0;

        for (int i = 2; i < max; i++)
        {
            if (isPrime[i])
            {
                largestPrime = i;
            }
        }

        Console.WriteLine("Største primtal under 1.000.000:");
        Console.WriteLine(largestPrime);
    }
}
*/