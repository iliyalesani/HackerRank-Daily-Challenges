using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        
        // Declare second integer, double, and String variables.
        int varInt;
        double varDouble;
        string varString;
        // Read and save an integer, double, and String to your variables.
        varInt = int.Parse(Console.ReadLine());
        varDouble = double.Parse(Console.ReadLine());
        varString = Console.ReadLine();        
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + varInt);
        // Print the sum of the double variables on a new line.
        Console.WriteLine("{0:0.0}", d + varDouble);        
        // Concatenate and print the String variables on a new line
        Console.WriteLine($"{s}{varString}");                
        // The 's' variable above should be printed first.

    }
}