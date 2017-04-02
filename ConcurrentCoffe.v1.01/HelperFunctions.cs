using ConcurrentCoffe.v1._01.Coffee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentCoffe.v1._01
{
    static class HelperFunctions
    {
        public static Drink LargeCoffee()   => new Drink(liquidAmount: 1500);
        public static Drink MediumCoffee() => new Drink();
        public static Drink SmallCoffee() => new Drink(liquidAmount: 250);
        public static Drink Espresso() => new Drink("Espresso", 125);
    }
}
