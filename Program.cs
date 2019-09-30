using Restaurant.Domain;
using System;
using System.Threading;
using static System.Console;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            RestaurantX restaurant = new RestaurantX("MaxDonalds", new CookMaster5000());

            bool shouldNotExit = true;

            while (shouldNotExit)
            {
                WriteLine("1. Register order");
                WriteLine("2. List pending orders");
                WriteLine("3. Process orders");
                WriteLine("4. Exit");

                ConsoleKeyInfo keyPressed = ReadKey(true);

                Clear();

                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:

                        Write("Dish: ");

                        string dish = ReadLine();

                        Write("Table: ");

                        string table = ReadLine();

                        Order newOrder = new Order(dish, table);

                        restaurant.RegisterOrder(newOrder);

                        Clear();

                        WriteLine("Order registered");

                        Thread.Sleep(2000); // 2 sek

                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:

                        WriteLine("Table Dish                            Registered");
                        WriteLine("------------------------------------------------------------");

                        foreach (Order order in restaurant.OrderQueue)
                        {
                            WriteLine($"{order.Table}  {order.Dish}                    {order.RegisteredAt}");
                        }

                        WriteLine();
                        WriteLine("Press key to continue");

                        ReadKey();

                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:

                        var completedOrders = restaurant.ProcessOrders();

                        WriteLine("All orders processed");

                        Thread.Sleep(2000);

                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:

                        shouldNotExit = false;

                        break;
                }

                Clear();
            }

        }
    }
}
