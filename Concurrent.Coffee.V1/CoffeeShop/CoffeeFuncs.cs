using Concurrent.Coffee.V1.CoffeeShop.Drinks;
using Concurrent.Coffee.V1.CoffeeShop.Ingredients;
using Concurrent.Coffee.V1.CoffeeShop.Measures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrent.Coffee.V1.CoffeeShop
{
    static class CoffeeFuncs
    {
        static Grounds GrindBeans(IList<CoffeeBeans> Beans)
        {
            Console.WriteLine("Grinding the Beans!");
            System.Threading.Thread.Sleep(Beans.Count * 1000);
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

        static T MakeCoffee<T>(CupSize CupSize) where T : IDrink
        {
            BoilWater(3000);
            var grnds = GrindBeans(new List<CoffeeBeans> { new CoffeeBeans() });
            return PourCoffee<T>(grnds, 2000);
        }

        static IDrink MakeCoffee(CupSize CupSize, DrinkTypes DrinkType)
        {
            // Cupsize decides how much water we need.
            // but CupSize is a property of the drink order

        }



        static MilliLitres AmountToBoil<T>(Size CupSize)
        {

        }

    }
}
