using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var T = int.Parse(Console.ReadLine());
        int[] numbers = new int[T];

        for (int i = 0; i < T; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        foreach (var number in numbers)
        {
            Console.WriteLine("{0}",
                (Primality(number)) ? "Prime" : "Not prime");
        }
    }

    private static bool Primality(int number)
    {
        var root = Math.Sqrt(number);
        if (number <= 1)
            return false;
        for (int i = 2; i <= root; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}