using Concurrent.Coffee.V1.CoffeeShop.Drinks;
using Concurrent.Coffee.V1.CoffeeShop.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrent.Coffee.V1.CoffeeShop
{
    static class CoffeeFuncs
    {
        static Grounds GrindBeans(CoffeeBeans Beans)
        {
            Console.WriteLine("Grinding the Beans!");
            System.Threading.Thread.Sleep(2000);
            return new Grounds();
        }

        static void BoilWater(int amountToBoilMl)
        {
            Console.WriteLine($"Boiling :{amountToBoilMl} Ml");
            System.Threading.Thread.Sleep(amountToBoilMl);
        }

        static T PourCoffee<T>(Grounds grounds, int amountInMl) where T : IDrink
        {
            Console.WriteLine($"Pouring {amountInMl} ml of Coffee");
            System.Threading.Thread.Sleep(amountInMl);
            return default(T);
        }

        static T MakeCoffee<T>(Size CupSize) where T: IDrink{
            var grnds = GrindBeans(new CoffeeBeans());
            BoilWater(3000);
            return PourCoffee<T>(grnds, 2000);
        }

    }
}
