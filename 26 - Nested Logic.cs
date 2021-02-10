using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var returned = Console.ReadLine().Split(' ');
        int d1 = int.Parse(returned[0]);
        int m1 = int.Parse(returned[1]);
        int y1 = int.Parse(returned[2]);
        var due = Console.ReadLine().Split(' ');
        int d2 = int.Parse(due[0]);
        int m2 = int.Parse(due[1]);
        int y2 = int.Parse(due[2]);
        var fine = 0;

        if (y1 < y2)
            fine = 0;
        else
        {
            if (y1 > y2)
                fine = 10000;
            else if (m1 > m2)
                fine = 500 * (m1 - m2);
            else if (d1 > d2)
                fine = 15 * (d1 - d2);
        }
        Console.WriteLine(fine);
    }
}