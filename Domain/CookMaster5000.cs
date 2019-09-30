using Resturant.Domain;
using System.Threading;

namespace Restaurant.Domain
{
    class CookMaster5000 : ICook
    {
        public string Name => "Cook Master 5000";

        public void Cook(Order order)
        {
            order.Started();

            Thread.Sleep(1000);

            order.Completed();
        }
    }
}
