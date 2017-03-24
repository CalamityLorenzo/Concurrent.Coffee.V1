using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrent.Coffee.V1.CoffeeShop.Drinks
{
    internal interface IDrink
    {
        DrinkName Type { get; }
        string Name { get; }
    }
}
