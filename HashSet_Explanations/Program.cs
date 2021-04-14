using System;
using System.Collections.Generic;
using System.Linq;

namespace HashSet_Explanations
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> studentsInAdvanced = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                Console.WriteLine("Enter student in C# advanced course");
                studentsInAdvanced.Add(input);
                input = Console.ReadLine();
            }

            foreach (var student in studentsInAdvanced)
            {
                Console.WriteLine(student);
            }
            //there is count method from C# which is bonus (not present at for other programming languages) but it is not actually used in practice
            Console.WriteLine($"Count is: {studentsInAdvanced.Count}");
            
            studentsInAdvanced.Remove("gogi");

            while (true)
            {
                Console.WriteLine("Check if student is enrolled");
                input = Console.ReadLine();

                Console.WriteLine($"{studentsInAdvanced.Contains(input)}");
            }

            
        }
    }
}
