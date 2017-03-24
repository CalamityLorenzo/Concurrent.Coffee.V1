using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrent.Coffee.V1.CoffeeShop.Drinks
{
    class Latte : IDrink
    {
        public string Name
        {
            get
            {
                return "Latte";
            }
        }

        public DrinkName Type
        {
            get
            {
                return DrinkName.Latte;
            }
        }
    }
}
