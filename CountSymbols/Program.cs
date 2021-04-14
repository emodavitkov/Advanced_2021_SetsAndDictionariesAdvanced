using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads some text from the console and counts the occurrences of each character in it. 
            //Print the results in alphabetical (lexicographical) order. 

            string text = Console.ReadLine();

            SortedDictionary<char, int> charRepo = new SortedDictionary<char, int>();


            for (int i = 0; i < text.Length; i++)
            {
                if (!charRepo.ContainsKey(text[i]))
                {
                    charRepo.Add(text[i], 0);
                }

                charRepo[text[i]]++;
            }

            
            
            foreach (var symbols in charRepo)
            {
                //S: 1 time/s
                Console.WriteLine($"{symbols.Key}: {symbols.Value} time/s");
            }
        }
    }
}
