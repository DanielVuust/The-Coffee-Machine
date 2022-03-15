using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace The_Coffee_Machine
{
    class CoffeeMachine : BaseBrewingMachine
    {
        public CoffeeMachine(string name, int maxLiquidMl, int maxCoffeeCount) 
            : base(name, maxLiquidMl, maxCoffeeCount, BrewingType.Coffee, Filter.CoffeeFilter, LiquidType.Water)
        {
            
        }

    }
}
