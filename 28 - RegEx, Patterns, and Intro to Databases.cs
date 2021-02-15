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
        var items = new List<string>();

        Regex regex = new Regex(@"^([a-z]+)\s.+@gmail\.com$");

        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string input = Console.ReadLine();

            string[] firstNameEmailID = input.Split(' ');

            string firstName = firstNameEmailID[0];

            string emailID = firstNameEmailID[1];

            if (regex.Match(input).Success)
            {
                items.Add(firstName);
            }
        }

        items.Sort();

        foreach (var item in items)
        {
            Console.WriteLine(item);
        }

    }
}
