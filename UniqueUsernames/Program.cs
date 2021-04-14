using System;
using System.Linq;
using System.Collections.Generic;

namespace UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            HashSet<string> uniqueUsername = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                uniqueUsername.Add(Console.ReadLine());
            }

            foreach (var username in uniqueUsername)
            {
                Console.WriteLine(username);
            }
            
        }
    }
}
