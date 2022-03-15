using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Coffee_Machine
{
    public class TeaMachine : BaseBrewingMachine
    {
        public TeaMachine(string name, int maxLiquidMl, int maxCoffeeCount) 
            : base(name, maxLiquidMl, maxCoffeeCount, BrewingType.Tea, Filter.TeaFilter, LiquidType.Water)
        {
            
        }
    }
}
