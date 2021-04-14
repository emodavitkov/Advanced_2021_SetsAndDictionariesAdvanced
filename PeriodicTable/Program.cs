using System;
using System.Linq;
using System.Collections.Generic;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that keeps all the unique chemical elements. 
            //On the first line you will be given a number n - the count of input lines that you are going to receive. 
            //On the next n lines you will be receiving chemical compounds, separated by a single space.
            //Your task is to print all the unique ones in ascending order:

            int n = int.Parse(Console.ReadLine());
            SortedSet<string> elementsrepository = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split();

                for (int j = 0; j < elements.Length; j++)
                {
                    elementsrepository.Add(elements[j]);
                }

            }

            foreach (var element in elementsrepository)
            {
                Console.Write(element + " " );
            }
        }
    }
}
