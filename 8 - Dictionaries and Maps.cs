using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int entries = int.Parse(Console.ReadLine());
        string searchKey;
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        for (int i = 0; i < entries; i++)
        {
            var items = Console.ReadLine().Split(' ');
            if (!phoneBook.ContainsKey(items[0]))
                phoneBook.Add(items[0], items[1]);
        }

        while ((searchKey = Console.ReadLine()) != null)
            Console.WriteLine(phoneBook.TryGetValue(searchKey, out string value)
                ? $"{searchKey}={value}" : "Not found");
    }
}