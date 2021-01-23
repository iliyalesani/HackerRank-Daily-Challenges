using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int T = int.Parse(Console.ReadLine());
        string[] S = new string[10000];

        for (int i = 0; i < T; i++)
            S[i] = Console.ReadLine();

        foreach (string index in S)
        {
            if (index == null)
                break;

            char[] C = index.ToCharArray();

            // Even index
            for (int i = 0; i < C.Length; i += 2)
                Console.Write(C[i]);

            // Space
            Console.Write(" ");

            // Odd index
            for (int i = 1; i < C.Length; i += 2)
                Console.Write(C[i]);

            // Enter
            Console.WriteLine();

        }
    }
}