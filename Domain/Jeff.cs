using Restaurant.Domain;
using System.Threading;

namespace Resturant.Domain
{
    class Jeff : ICook
    {
        public string Name { get; } = "Jeff";

        public void Cook(Order order)
        {
            order.Started();

            Thread.Sleep(5000);

            order.Completed();
        }
    }
}
