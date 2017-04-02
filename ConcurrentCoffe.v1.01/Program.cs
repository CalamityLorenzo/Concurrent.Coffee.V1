using ConcurrentCoffe.v1._01.Coffee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConcurrentCoffe.v1._01.HelperFunctions;
namespace ConcurrentCoffe.v1._01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tuple<int, Drink>> DrinksToMake = new List<Tuple<int, Drink>>()
            {
                Tuple.Create(1, SmallCoffee()),
                Tuple.Create(3, MediumCoffee()),
                Tuple.Create(2, LargeCoffee()),
                Tuple.Create(4, Espresso())
            };
        }
    }
}
