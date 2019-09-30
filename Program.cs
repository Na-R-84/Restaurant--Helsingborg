using Restaurant.Domain;
using Resturant.Domain;
using System;
using System.Collections.Generic;
using System.Threading;
using static System.Console;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            RestaurantX restaurant = new RestaurantX("MaxDonalds");

            bool shouldNotExit = true;

            while (shouldNotExit)
            {
                WriteLine("1. Register order");
                WriteLine("2. List orders");
                WriteLine("3. Exit");

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

                        Order neworder = new Order(dish, table);

                        restaurant.RegisterOrder(neworder);

                       // orderQueue.Enqueue(order);

                        Clear();

                        WriteLine("Order registered");

                        Thread.Sleep(2000); // 2 sek

                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.WriteLine("Table           Dish                          Registered");
                        Console.WriteLine("---------------------------------------------------------");

                        foreach (Order order in restaurant.OrderQueue)
                        {
                            Console.WriteLine($"{order.Table} {order.Dish}              {order.RegisteredAt}");
                        }

                        Console.WriteLine("");
                        Console.WriteLine("Press key to continue");

                        Readkey();
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:

                        shouldNotExit = false;

                        break;
                }

                Clear();
            }

        }

        private static void Readkey()
        {
            throw new NotImplementedException();
        }
    }
}
