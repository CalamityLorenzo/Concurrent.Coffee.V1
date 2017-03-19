using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrent.Coffee.V1.CoffeeShop.Drinks
{
    class VomitTea : IDrink
    {
        public string Name
        {
            get
            {
                return "Vomit Tea";
            }
        }

        public DrinkTypes Type
        {
            get
            {
                return DrinkTypes.VomitTea;
            }
        }
    }
}
