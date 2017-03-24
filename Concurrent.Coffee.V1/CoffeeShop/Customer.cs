using Concurrent.Coffee.V1.CoffeeShop.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrent.Coffee.V1.CoffeeShop
{
    internal class Customer
    {
        List<IDrink> _Drinks;

        public IEnumerable<Tuple<DrinkName, CupSize>> Order { get; }
        public string Name { get; }
        public Guid Id { get; }
        public IEnumerable<IDrink> Drinks { get { return _Drinks; } }
        public Customer(string Name, IEnumerable<Tuple<DrinkName, CupSize>> Order)
        {
            this.Id = Guid.NewGuid();
            this.Name = Name;
            this.Order = new List<Tuple<DrinkName, CupSize>>(Order);
            this._Drinks = new List<IDrink>();
        }

        private Customer (string Name, IEnumerable<Tuple<DrinkName, CupSize>> Order, Guid Id, IEnumerable<IDrink> Drinks)
        {
            this.Name = Name;
            this.Id = Id;
            this.Order = new List<Tuple<DrinkName, CupSize>>(Order);
            this._Drinks = new List<IDrink>(Drinks);
        }

        public override string ToString()
        {
            return $"{Name}  {String.Join(";", Order)} Drinks:{_Drinks.Count()}";
        }

        internal static Customer AddDrinks(Customer customer, IEnumerable<IDrink> Drinks)
        {
            return new Customer(customer.Name, customer.Order, customer.Id, Drinks);
        }
    }
}
