using Concurrent.Coffee.V1.CoffeeShop;
using Concurrent.Coffee.V1.CoffeeShop.Drinks;
using Concurrent.Coffee.V1.CoffeeShop.Measures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrent.Coffee.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Customer> Customers = new Queue<Customer>(new List<Customer> {
                new Customer("Paul Lawrence", new List<Tuple<DrinkName, CupSize>> {
                                                       Tuple.Create(DrinkName.Americano, CupSize.Shot) }),
                new Customer("Laura Lawrence", new List<Tuple<DrinkName, CupSize>> {
                                                    Tuple.Create(DrinkName.CuppaTea, CupSize.Medium),
                                                    Tuple.Create( DrinkName.StrawberryTea, CupSize.Large)}),
                new Customer("Sarah Hill", new List<Tuple<DrinkName, CupSize>> {
                                                Tuple.Create(DrinkName.BlackTea, CupSize.Medium)}),
                new Customer("Jonah Boner", new List<Tuple<DrinkName, CupSize>> {
                                                Tuple.Create(DrinkName.VomitTea, CupSize.Medium),
                                                Tuple.Create( DrinkName.Americano, CupSize.Small)})
                });



            Customers.ToList().ForEach(Console.WriteLine);


            var cust = Customers.ElementAtOrDefault(0);
            cust = Customer.AddDrinks(cust, new List<IDrink> { new Espresso(), new Latte(), new Latte() });

            MilliLitres ml = 1700;
            MilliLitres ml2 = new MilliLitres(10001 + ml);

            Litres l = ml;

            Console.WriteLine(l);
            Console.WriteLine(ml);
            Console.WriteLine(ml2);


        }
    }
}
