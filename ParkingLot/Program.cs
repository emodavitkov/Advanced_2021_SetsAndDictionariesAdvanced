using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carRegistrar = new HashSet<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if ( input == "END")
                {
                    break;
                }

                string[] commands = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string commandInOut = commands[0];
                string commandCarPlate = commands[1];

                if (commandInOut=="IN")
                {
                    carRegistrar.Add(commandCarPlate);
                }

                if (commandInOut=="OUT")
                {
                    carRegistrar.Remove(commandCarPlate);
                }
            }

            if (carRegistrar.Count==0)
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            }

            foreach (var cars in carRegistrar)
            {
               
                Console.WriteLine(cars);
            }
        }
    }
}
