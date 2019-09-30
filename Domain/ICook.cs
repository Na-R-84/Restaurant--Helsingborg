using Restaurant.Domain;
using System;

namespace Resturant.Domain
{
    interface ICook
    {
        String Name { get; }
        void Cook(Order order);
    }
}
