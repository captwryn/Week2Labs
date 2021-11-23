using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> glist = new Dictionary<string, decimal>();
            glist["eggs"] = 0.99m;
            glist["milk"] = 2.50m;
            glist["banana"] = 0.50m;
            glist["cookies"] = 2.99m;
            glist["beef"] = 5.00m;
            glist["cheese"] = 4.00m;
            glist["bread"] = 1.50m;
            glist["rice"] = 6.00m;

            decimal total = 0;
            int amount = 0;
            Dictionary<string, decimal> basket = new Dictionary<string, decimal>();
            bool adding = true;

            Console.WriteLine("  Welcome to the store\n\n  Here's a list of available items:");
            foreach (var pair in glist)
            {
                Console.WriteLine($"    { pair.Key}");
                // Console.WriteLine($"{ pair.Key}  ${pair.Value}");
            }
            do
            {
                Console.WriteLine("\n  What would you like to add something to your basket?:\n   (enter item or done to finish; any other entries are ignored)");
                string entry = Console.ReadLine().ToLower();
                foreach (var pair in glist)
                {
                    if (entry != pair.Key && entry != "done")
                    {
                        Console.WriteLine("Error");
                    }
                }
                foreach (var pair in glist)
                {
                    if (entry == pair.Key)
                    {
                        basket[pair.Key] = pair.Value;
                    }
                    if (entry == "done")
                    {
                        adding = false;
                    }
                }
            } while (adding);

            Console.WriteLine("\n---------------------------\n");
            Console.WriteLine("   Your basket has:\n");
            foreach (var pair in basket)
            {
                Console.WriteLine($"      {pair.Key, -12} ${pair.Value}");
                total = total + pair.Value;
                // Console.WriteLine($"{ pair.Key}  ${pair.Value}");
            }
            Console.WriteLine($"\n   Your total cost is:\n   ${total,20}");
            Console.WriteLine("\n---------------------------");
        }
    }
}