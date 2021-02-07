using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int numberOfSwaps = 0;
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        // Write Your Code Here
        for (int i = 0; i < n; i++)
        {
            // Track number of elements swapped during a single array traversal
            for (int j = 0; j < n - 1; j++)
            {
                // Swap adjacent elements if they are in decreasing order
                if (a[j] > a[j + 1])
                {
                    var temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                    //swap(a[j], a[j + 1]);
                    numberOfSwaps++;
                }
            }

            // If no elements were swapped during a traversal, array is sorted
            if (numberOfSwaps == 0)
            {
                break;
            }
        }
        Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.\nFirst Element: {a.First()}\nLast Element: {a.Last()}");
    }

}