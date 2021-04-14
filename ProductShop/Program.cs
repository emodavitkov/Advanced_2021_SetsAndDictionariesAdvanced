using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, double>> foodShops = new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Revision")
                {
                    break;
                }

                string[] commands = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string shop = commands[0];
                string product = commands[1];
                double price = double.Parse(commands[2]);


                if (!foodShops.ContainsKey(shop))
                {
                    foodShops.Add(shop, new Dictionary<string, double>());
                    
                }
                foodShops[shop].Add(product, price);
            }

            var orderedShops = foodShops.OrderBy(s => s.Key).ToDictionary(k => k.Key, v => v.Value);


            foreach (var shop in orderedShops)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }


        }


    }

}
