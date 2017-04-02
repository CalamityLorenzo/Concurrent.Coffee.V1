using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrent.Coffee.V1.CoffeeShop.Drinks
{
    static class DrinkSizes
    {
        internal static MilliLitres GetLiquidAmount<T>(Size size, T drink) where T : IDrink
        {

            if (drink.Name != "Espresso")
            {
                switch (size)
                {
                    case Size.Small:
                        return 300;
                        break;
                    case Size.Shot:
                        return 75;
                        break;
                    case Size.Medium:
                        return 500;
                        break;
                    case Size.Large:
                        return 750;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("What size of cup is this?");
                }
            }
            else
            {
                switch (size)
                {
                    case Size.Shot:
                    case Size.Small:
                        return 75;
                    default:
                        throw new ArgumentOutOfRangeException("Espressos aint that big");
                }
            }
        }
    }
}
