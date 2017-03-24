using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrent.Coffee.V1
{
    class MilliLitres
    {
        public int Amount { get; }

        public MilliLitres(int amount)
        {
            if (amount < 0) { throw new ArgumentOutOfRangeException("Cannot have a negative amount"); }
            this.Amount = amount;
        }

        public override string ToString()
        {
            return this.Amount + "Ml";
        }

        public static implicit operator MilliLitres(int amount)
        {
            return new MilliLitres(amount);
        }

        public static implicit operator int(MilliLitres milli)
        {
            return milli.Amount;
        }

        public static implicit operator MilliLitres(Litres ltres)
        {
            if (ltres.Amount > 0)
            {
                return new MilliLitres(ltres * 1000);
            }else
            {
                return new MilliLitres(0);
            }
        }
    }

    class Litres
    {
        public int Amount { get; }

        public Litres(int amount)
        {
            if (amount < 0) { throw new ArgumentNullException("Cannot have a negative amount"); }
            this.Amount = amount;
        }

        public override string ToString()
        {
            return this.Amount + "l";
        }

        public static implicit operator Litres(int amount)
        {
            return new Litres(amount);
        }

        public static implicit operator int(Litres ltres)
        {
            return ltres.Amount;
        }

        public static implicit operator Litres(MilliLitres milli)
        {
            if (milli.Amount > 0)
            {
                return new Litres(milli.Amount / 1000);
            }
            else
            {
                return new Litres(0);
            }
        }
    }
}
