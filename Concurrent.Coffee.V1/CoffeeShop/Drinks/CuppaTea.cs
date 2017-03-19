using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrent.Coffee.V1.CoffeeShop.Drinks
{
    class CuppaTea : IDrink
    {
        public string Name
        {
            get
            {
                return "Cuppa Tea";
            }
        }

        public DrinkTypes Type
        {
            get
            {
                return DrinkTypes.CuppaTea;
            }
        }
    }
}
