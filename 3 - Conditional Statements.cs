using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());
        Math.DivRem(N, 2, out var result);
        bool isEven = result == 0 ? true : false;
        if (!isEven)
        {
            Console.WriteLine("Weird");
        }
        else if (isEven)
        {
            if (N <= 5 && N >= 2)
                Console.WriteLine("Not Weird");
            else if (N <= 20 && N >= 6)
                Console.WriteLine("Weird");
            else if (N > 20)
                Console.WriteLine("Not Weird");
        }
    }
}
