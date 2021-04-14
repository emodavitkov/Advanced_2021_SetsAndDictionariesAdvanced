using System;
using System.Collections.Generic;
using System.Linq;

namespace CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Write a program that reads continents, countries and their cities, puts them in a nested dictionary and prints them. 

            //Use a nested dictionary(string -> (Dictionary -> List<string>)) 
            //Check if the continent exists before adding the country. If it doesn’t, add it to the dictionary.
            //Check if the country exists, before adding the city.If it doesn’t, add it to the dictionary.
            //Pass through all key-value pairs in the dictionary and the values’ key - value pairs and print the results.

            Dictionary<string, Dictionary<string, List<string>>> cityCountryRegister = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine()
                    .Split();

                string continent = data[0];
                string country = data[1];
                string city = data[2];

                if (!cityCountryRegister.ContainsKey(continent))
                {
                    cityCountryRegister.Add(continent,new Dictionary<string, List<string>>());
                }

                if (!cityCountryRegister[continent].ContainsKey(country))
                {
                    cityCountryRegister[continent].Add(country, new List<string>());
                }
                cityCountryRegister[continent][country].Add(city);
            }

            foreach (var continent in cityCountryRegister)
            {
                Console.WriteLine($"{continent.Key}:");

               
                foreach (var city in continent.Value)
                {
                    Console.WriteLine($"{city.Key} -> {string.Join(", ", city.Value)}");
                }
            }

        }
    }
}
