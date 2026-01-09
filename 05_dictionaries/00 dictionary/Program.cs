using System;
using System.Collections.Generic;

namespace _00_dictionary;

class Program
{
    static void Main(string[] args)
    {
        run();
    }

    static void run()
    {
        Dictionary<int, string> personen = new Dictionary<int, string>();

        personen.Add(1, "Max");
        personen.Add(2, "Moritz");
        personen.Add(3, "Lisa");

        string name1 = personen[1];
        string name2 = personen[3];

        Console.WriteLine(name1);
        Console.WriteLine(name2); 

        Console.WriteLine();

        foreach(KeyValuePair<int, string > item in personen)
        {
            Console.WriteLine(item.Key + "- " + item.Value);
        }

        foreach(int kay in personen.Keys)
        {
            Console.WriteLine("Key: " + kay);
        }
        Console.WriteLine();
        foreach(string val in personen.Values)
        {
            Console.WriteLine("Value: " + val);
        }
    }
}


