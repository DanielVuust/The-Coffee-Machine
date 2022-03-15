using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Coffee_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine coffeeBrewingMachine = new CoffeeMachine();
            coffeeBrewingMachine.AddSolidInGramsToContainer(80);
            coffeeBrewingMachine.AddLiquidInMlToContainer(120);
            coffeeBrewingMachine.StartBrewing();

            Console.WriteLine();

            TeaMachine teaBrewingMachine = new TeaMachine();
            teaBrewingMachine.AddSolidInGramsToContainer(80);
            teaBrewingMachine.AddLiquidInMlToContainer(120);
            teaBrewingMachine.StartBrewing();

            Console.WriteLine();

            EspressoMachine espressoBrewingMachine = new EspressoMachine();
            espressoBrewingMachine.AddSolidInGramsToContainer(80);
            espressoBrewingMachine.AddLiquidInMlToContainer(120);
            espressoBrewingMachine.StartBrewing();

            Console.Read();
        }
    }
}
