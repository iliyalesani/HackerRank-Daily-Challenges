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
        uint n = Convert.ToUInt32(Console.ReadLine());
        var consecutives = Convert.ToString(n, 2).Split('0').Max();
        Console.WriteLine(consecutives.Count(c => c == '1'));
    }
}
