using System;
using System.Linq;
using System.Collections.Generic; 

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that helps you decide what clothes to wear from your wardrobe. 
            //You will receive the clothes, which are currently in your wardrobe, sorted by their color in the following format:
            //            "{color} -> {item1},{item2},{item3}…"
            //If you receive a certain color, which already exists in your wardrobe, just add the clothes to its records. 
            //You can also receive repeating items for a certain color and you have to keep their count.
            //In the end, you will receive a color and a piece of clothing, which you will look for in the wardrobe, 
            // separated by a space in the following format:
            //"{color} {clothing}"
            //Your task is to print all the items and their count for each color in the following format: 
            //"{color} clothes:
            //            * { item1} - { count}
            //            * { item2} - { count}

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");

                //approach to split using mmore than one operator
                //string[] inputData = Console.ReadLine()
                //    .Split(new[] { " ", "->", "," }, StringSplitOptions.RemoveEmptyEntries);

                //string color = input[0];
                //string[] clothes = input.Skip(1).ToArray();


                string color = input[0];
                string[] clothes = input[1].Split(",");

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                foreach (var item in clothes)
                {

                    if (!wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color].Add(item, 1);
                    }
                    else
                    {
                        wardrobe[color][item]++;
                    }

                }
                

            }
            string[] search = Console.ReadLine().Split();
            string searchColor = search[0];
            string searchCloth = search[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");


                foreach (var item in color.Value)
                {
                    Console.Write($"* {item.Key} - {item.Value}");
                    if (searchColor == color.Key && searchCloth == item.Key)
                    {
                        Console.WriteLine(" (found!)");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }


        }
    }
}
