﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrent.Coffee.V1.CoffeeShop.Drinks
{
    class Americano : IDrink
    {
        public string Name
        {
            get
            {
                return "Americano";
            } 
        }

        public DrinkName Type
        {
            get
            {
                return DrinkName.Americano;
            }
        }
    }

}
