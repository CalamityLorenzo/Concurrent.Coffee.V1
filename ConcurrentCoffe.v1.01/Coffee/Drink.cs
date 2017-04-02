using Concurrent.Coffee.V101.CoffeeShop.Measures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentCoffe.v1._01.Coffee
{
    class Drink
    {
        public string DrinkName { get; }
        public MilliLitres LiquidAmount { get; }
        public Drink(string DrinkName="coffee", int liquidAmount=500)
        {
            this.DrinkName = DrinkName;
            this.LiquidAmount = liquidAmount;
        }

        public override string ToString()
        {
            return $"{DrinkName} : {LiquidAmount}";
        }
    }
}
