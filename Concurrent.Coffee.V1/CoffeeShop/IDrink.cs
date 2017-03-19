using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrent.Coffee.V1.CoffeeShop
{
    internal interface IDrink
    {
        DrinkTypes Type { get; }
        string Name { get; }
    }
}
