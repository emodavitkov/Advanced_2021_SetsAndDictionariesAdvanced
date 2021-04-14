using System;
//using System.Collections.Generic;
//using System.Linq;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints a number from a collection, which appears an even number of times in it.
            //On the first line, you will be given n – the count of integers you will receive.
            //On the next n lines you will be receiving the numbers.
            //It is guaranteed that only one of them appears an even number of times. 
            //Your task is to find that number and print it in the end. 
            
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbersCollection = new Dictionary<int,int>();
            
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (!numbersCollection.ContainsKey(input))
                {
                    numbersCollection.Add(input,1);
                }

                else
                {
                    numbersCollection[input]++;
                }
            }

            foreach (var number in numbersCollection)
            {
                if (number.Value%2==0)
                {
                    Console.WriteLine(number.Key);
                }
            }
        }
    }
}
