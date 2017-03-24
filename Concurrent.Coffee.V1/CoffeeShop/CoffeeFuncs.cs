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
        static IEnumerable<Grounds> GrindBeans(IList<CoffeeBeans> Beans)
        {
            var Grinder = GenerateList(() => new Grounds());

            Console.WriteLine("Grinding the Beans!");
            System.Threading.Thread.Sleep(Beans.Count * 1000);
            return Grinder(Beans.Count);
        }

        static void BoilWater(int amountToBoilMl)
        {
            Console.WriteLine($"Boiling :{amountToBoilMl} Ml");
            System.Threading.Thread.Sleep(amountToBoilMl);
        }

        static T PourCoffee<T>(IEnumerable<Grounds> grounds, int amountInMl) where T : IDrink
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

        static IDrink MakeCoffee(CupSize CupSize, DrinkName DrinkName)
        {
            // Cupsize decides how much water we need.
            // but CupSize is a property of the drink order
            var sizes = GetMeasures(CupSize, DrinkName);
            BoilWater(3000);
            var grnds = GrindBeans(sizes.Item1);
            

        }

        private static Tuple<List<CoffeeBeans>, MilliLitres> GetMeasures(CupSize cupSize, DrinkName drinkName)
        {
            if(drinkName == DrinkName.Espresso)
            {
                switch (cupSize)
                {
                    case CupSize.Shot:
                    case CupSize.Small:
                        return Tuple.Create(new List<CoffeeBeans> { { new CoffeeBeans() }, { new CoffeeBeans() } }, new MilliLitres(75));
                    case CupSize.Large:
                        return Tuple.Create(new List<CoffeeBeans> { { new CoffeeBeans() },
                                                                    { new CoffeeBeans() },
                                                                    { new CoffeeBeans() } }, new MilliLitres(150));
                    default:
                        throw new ArgumentOutOfRangeException("Unknown Size!");

                }
            }else
            {
                switch (cupSize) {
                    case CupSize.Small:
                        return Tuple.Create(new List<CoffeeBeans> {
                                                { new CoffeeBeans() },
                                                { new CoffeeBeans() } }, new MilliLitres(400));
                    case CupSize.Medium:
                        return Tuple.Create(new List<CoffeeBeans> {
                                                { new CoffeeBeans() },
                                                { new CoffeeBeans() } }, new MilliLitres(500));
                    case CupSize.Large:
                        return Tuple.Create(new List<CoffeeBeans> {
                                            { new CoffeeBeans() },
                                            { new CoffeeBeans() },
                                            { new CoffeeBeans() } }, new MilliLitres(500));
                    default:
                        throw new ArgumentOutOfRangeException("Unknown Size!");
                }
            }
        }
        
        static MilliLitres AmountToBoil<T>(CupSize CupSize)
        {
            return null;
        }

        static Func<T,U> Memoiz<T,U>(Func<T,U>FuncToStore)
        {
            Dictionary<T, U> Dict = new Dictionary<T, U>();
            return (ky) =>
            {
                if (!Dict.ContainsKey(ky))
                {
                    Dict.Add(ky, FuncToStore(ky));
                }
                return Dict[ky];
            };
        }

        static Func<int, IEnumerable<T>> GenerateList<T>(Func<T> itemConstructor)
        {
            return (count) =>
            {
                var itms = new List<T>();
                for (var x = 0; x < count; x++)
                {
                    itms.Add(itemConstructor());
                }
                return itms;
            };
        }

    }
}
