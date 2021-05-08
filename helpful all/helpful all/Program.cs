using System;
using System.Collections.Generic;
using System.IO;

namespace helpful_all
{
    class Program
    {
        static void Main(string[] args)
        {
            // TryParse, Split, ToLower, get the first/last character, etc.

            //TRY PARSE 
            bool res;
            int a;
            string myStr = "12";
            res = int.TryParse(myStr, out a);
            Console.WriteLine("String is a numeric representation: " + res);
            //String is a numeric representation: True

            // SPLIT
            string input = "cat;bird";

            string[] array = input.Split(';');

            foreach (string value in array)
            {
                Console.WriteLine($"Part: {value}");
            }
            //

            List<Cereal> bowls = new List<Cereal>();
            string[] lines = File.ReadAllLines("Cereal_Data.txt");

            for (int i = 1; i < lines.Length; i++)
            {
                string currentLineOfFile = lines[i];

                string[] pieces = currentLineOfFile.Split("|");




            }
        }
}
