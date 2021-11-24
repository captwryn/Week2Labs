using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
       
        static void WelcomeMenu(Dictionary<string, decimal> glist)
        {
            foreach (var pair in glist)
            {
                Console.WriteLine($"      {pair.Key,-12} ${pair.Value}");
            }
        }
        static void AddtoCart(Dictionary<string, decimal> glist, Dictionary<string, decimal> basket)
        {
            bool adding = true;
            do
            {
                Console.WriteLine("\n  What would you like to add something to your basket?:\n   (enter item or 'done' to finish; any other entries are ignored)");
                string entry = Console.ReadLine().ToLower();

                if (glist.ContainsKey(entry))
                {
                    basket.Add(entry, glist[entry]);
                    Console.WriteLine($"Added {entry} to your basket for {glist[entry]}");
                }
                else if (entry == "done")
                {
                    adding = false;
                }
                else if (entry == "menu")
                {
                    WelcomeMenu(glist);
                }
                else
                {
                    Console.WriteLine("We don't have that item.  (enter 'menu' to see the menu)");
                }
            } while (adding);
        }
        static void PrintReceipt(Dictionary<string, decimal> basket)
        {
            decimal total = 0;

            Console.WriteLine("\n---------------------------\n");
            Console.WriteLine("   Your basket has:\n");
            foreach (var pair in basket)
            {
                Console.WriteLine($"      {pair.Key,-12} ${pair.Value}");
                total += pair.Value;
            }
            Console.WriteLine($"\n   Your total cost is:\n   ${total,20}");
            Console.WriteLine("\n---------------------------");
        }


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

            int amount = 0;
            Dictionary<string, decimal> basket = new Dictionary<string, decimal>();

            Console.WriteLine("  Welcome to the store\n\n  Here's a list of available items:");
            WelcomeMenu(glist);
            
            AddtoCart(glist, basket);

            PrintReceipt(basket);
        }
    }
}