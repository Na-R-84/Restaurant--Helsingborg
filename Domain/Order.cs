using System;

namespace Restaurant.Domain
{
    class Order
    {
        public string Dish { get; }
        public string Table { get; }
        public DateTime RegisteredAt { get; } = DateTime.Now;
        public DateTime? StartedAt { get; private set; }
        public DateTime? CompletedAt { get; set; }

        public Order(string dish, string table)
        {
            Dish = dish;
            Table = table;
        }

        public void Started()
        {
            if (StartedAt != null)
            {
                throw new Exception("Order already started");
            }

            StartedAt = DateTime.Now;
        }

        public void Completed()
        {
            if (StartedAt == null)
            {
                throw new Exception("Order not started");
            }

            if (CompletedAt != null)
            {
                throw new Exception("Order already completed");
            }

            CompletedAt = DateTime.Now;
        }
    }
}
