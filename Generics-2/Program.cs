using System;
using System.Collections.Generic;

namespace Generics_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();

            dictionary.Add("Alper", "Tasci");
            dictionary.Add("Kevin", "Flyer");
            dictionary.Add("Michael", "Jakesun");


            dictionary.List();

            // This will search for the key and  return related value if exists
            Console.WriteLine($"Value of Alper: {dictionary["Alper"]}");
            Console.WriteLine($"Value of Kevin: {dictionary["Kevin"]}");
        }
    }
}
