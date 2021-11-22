using System;
namespace StudentDatabase
{
    class Program
    {
        static void Students(int[] numb, string[] names)
        {
            Console.WriteLine("Here is the list of students:");
            for (int i = 0; i < numb.Length; i++)
            {
                Console.WriteLine($"{numb[i],-1}.) {names[i],-12}");
            }
        }
        static bool GoAgain()
        {
            while (true)
            {
                Console.Write("Would you like to go again? (y/n)");
                string entry = Console.ReadLine();
                if (entry.ToLower() == "n")
                {
                    return false;
                }
                if (entry.ToLower() == "y")
                {
                    return true;
                }
                Console.WriteLine("I'm sorry I don't know what that means.");
            }
        }
        static bool TryAgain()
        {
            while (true)
            {
                Console.Write("Would you like to learn more about this student? (y/n)");
                string entry = Console.ReadLine();
                if (entry.ToLower() == "n")
                {
                    return false;
                }
                if (entry.ToLower() == "y")
                {
                    return true;
                }
                Console.WriteLine("I'm sorry I don't know what that means.");
            }
        }
        static void Main(string[] args)
        {
            int[] num = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] name = new string[] {"Tae", "Samuel", "Josh", "Alex", "Tarik", "Luke", "Alexis", "Dan", "Antonio"};
            string[] hometown = new string[] {"Adrian", "Alma", "Ann Arbor", "Battle Creek", "Bay City", "Benton Harbor", "Bloomfield Hills", "Cadillac", "Charlevoix" };
            string[] favfood = new string[] {"Beans", "Yogurt", "Beef Liver", "Salmon", "Mushrooms", "Lobster", "Soybeans", "Oysters", "Spinach" };

            Students(num, name);
            do
            {
                Console.WriteLine("Which student would you like to learn more about? (1-9)");
                string entry1 = Console.ReadLine();
                int nume = int.Parse(entry1) - 1;

                do
                {
                    Console.WriteLine($"Do you want to know about {name[nume]}'s hometown or favorite food? (town/food)");
                    string entry2 = Console.ReadLine().ToLower();

                    if (entry2 == "town")
                    {
                        Console.WriteLine($"{name[nume]} is from {hometown[nume]}");
                    }
                    else if (entry2 == "food")
                    {
                        Console.WriteLine($"{name[nume]}'s favorite food is {favfood[nume]}");
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry that input is invalid.");
                    }
                } while (TryAgain());
            } while (GoAgain());
        }
    }
}