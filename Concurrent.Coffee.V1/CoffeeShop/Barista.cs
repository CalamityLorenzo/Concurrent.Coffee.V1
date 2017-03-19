using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrent.Coffee.V1.CoffeeShop
{
    class Barista
    {
        public string Name { get; }
        public Guid Id { get; }
        public Barista(string Name)
        {
            this.Name = Name;
            this.Id = Id;
        }
    }
}
