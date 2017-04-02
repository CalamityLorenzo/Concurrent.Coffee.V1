using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrent.Coffee.V101.CoffeeShop.Measures
{
    public class MilliLitres
    {
        public int Amount { get; }
        public MilliLitres(int amount)
        {
            if (amount < 0) throw new ArgumentOutOfRangeException("Cannot have a negative amount");
            this.Amount = amount;
        }

        public static implicit operator MilliLitres(int amount)
        {
            return new MilliLitres(amount);
        }
        public static implicit operator int(MilliLitres milliL)
        {
            return milliL.Amount;
        }

        public static implicit operator MilliLitres(Litres litres) => new MilliLitres(Convert.ToInt32(litres) * 1000);
        // public static implicit operator Litres(MilliLitres milli) => new Litres(milli / 1000d);
        public override string ToString()
        {
            return $"{Amount} ml";
        }
    }

    public class Litres
    {
        public double Amount { get; }
        public Litres(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Value cannot be negative");
            }
            Amount = amount;
        }
        public Litres(int amount) : this(Convert.ToDouble(amount)) { }

        public static implicit operator Litres(double amountt) => new Litres(amountt);
        public static implicit operator Litres(int amount) => new Litres(amount);
        public static implicit operator Litres(MilliLitres milli) => new Litres(milli / 1000d);
        public static implicit operator MilliLitres(Litres litres) => new MilliLitres(Convert.ToInt32(litres) * 1000);
        public override string ToString()
        {
            return $"{Amount} l";
        }

    }
}