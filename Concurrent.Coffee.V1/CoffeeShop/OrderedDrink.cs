using Concurrent.Coffee.V1.CoffeeShop.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concurrent.Coffee.V1.CoffeeShop.Measures;
using Concurrent.Coffee.V1.CoffeeShop.Drinks;

namespace Concurrent.Coffee.V1.CoffeeShop
{
    interface IOrderedDrink
    {
        IEnumerable<CoffeeBeans> Beans { get; }
        MilliLitres RequiredWater { get; }
    }

    class OrderedDrink<T> : IOrderedDrink where T : IDrink
    {
        public T Drink { get; }
        public IEnumerable<CoffeeBeans> Beans { get; }
        public MilliLitres RequiredWater { get; }
        public OrderedDrink(List<CoffeeBeans> Beans, MilliLitres water, T Drink)
        {
            this.Drink = Drink;
            this.Beans = Beans;
            this.RequiredWater = water;
        }
    }
}
