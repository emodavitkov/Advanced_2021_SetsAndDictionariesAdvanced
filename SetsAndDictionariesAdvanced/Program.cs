using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Dictionary<double, int> times = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {

                if (!times.ContainsKey(numbers[i]))
                {
                    times.Add(numbers[i], 0);
                }

                times[numbers[i]]++;
                
            }

            foreach (var time in times)
            {
                Console.WriteLine($"{time.Key} - {time.Value} times");
            }


            //int[] array = new int[] { 1, 2, 3, 4, 5 };
            //Console.WriteLine(array[0]);

            //SortedDictionary<string, int> studentAge = new SortedDictionary<string, int>()
            //{
            //    { "gogoch", 30},
            //    { "pepi", 30},
            //    { "pesho", 29 }
            //};

            //studentAge.Add("Gogi", 38);
            //studentAge.Add("Doroteq", 19);

            

            //if (!studentAge.ContainsKey("joji"))
            //{
            //    Console.WriteLine("Adding joji");
            //    studentAge.Add("joji", 13);
            //}

            //Console.WriteLine(studentAge["joji"]);

            //foreach (KeyValuePair<string,int> student in studentAge)
            //{
            //    Console.WriteLine($"{student.Key} is {student.Value} old");
            //}
        }
    }
}
