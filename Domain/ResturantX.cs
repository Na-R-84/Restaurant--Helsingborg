using Resturant.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.Domain
{
    class RestaurantX
    {
        private string v;
        private CookMaster5000 cookMaster5000;

        public string Name { get; set; }
        public Queue<Order> OrderQueue { get; } = new Queue<Order>();
        private ICook Chef { get; }

        public RestaurantX(string name, ICook chef)
        {
            Name = name;
            Chef = chef;
        }

        public RestaurantX(string v, CookMaster5000 cookMaster5000)
        {
            this.v = v;
            this.cookMaster5000 = cookMaster5000;
        }

        public void RegisterOrder(Order order)
        {
            OrderQueue.Enqueue(order);
        }

        public List<Order> ProcessOrders()
        {
            Console.WriteLine($"{Chef.Name} is processing the orders");

            List<Order> completedOrders = new List<Order>();

            while (OrderQueue.Any())
            {
                Order currentOrder = OrderQueue.Dequeue();

                Chef.Cook(currentOrder);

                completedOrders.Add(currentOrder);
            }

            return completedOrders;
        }
    }
}
