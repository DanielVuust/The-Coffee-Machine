using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Coffee_Machine.BrewingType;
using The_Coffee_Machine.Containers;
using The_Coffee_Machine.Filters;
using The_Coffee_Machine.Interfaces;
using The_Coffee_Machine.Liquids;

namespace The_Coffee_Machine
{
    public class TeaMachine : BaseBrewingMachine, ILiquidAndSolidMachine
    {
        private const string machineName = "TeaMachine";
        private const int liquidServingSizeInMl = 30;
        private const int solidUsagePerServingInGrams = 20;

        public MediumBrewingMachineSolidContainer solidContainer;
        public MediumBrewingMachineLiquidContainer liquidContainer;
        public TeaMachine()
            : base(machineName, new PapirFilter())
        {
            solidContainer = new MediumBrewingMachineSolidContainer(new Tea());
            liquidContainer = new MediumBrewingMachineLiquidContainer(new Water());
        }

        public override void StartBrewing()
        {
            while(this.liquidContainer.ContainerCurrentLiquidInMl > liquidServingSizeInMl && this.solidContainer.ContainerCurrentInGrams > solidUsagePerServingInGrams)
            {
                liquidContainer.ContainerCurrentLiquidInMl -= liquidServingSizeInMl;
                Console.WriteLine("20 ml of tea has been brewed");
            }
            Console.WriteLine("All available tea has now been brewed");
        }
        public void AddLiquidInMlToContainer(int mlLiquid)
        {
            liquidContainer.ContainerCurrentLiquidInMl += mlLiquid;
        }
        public void AddSolidInGramsToContainer(int gramsSolid)
        {
            solidContainer.ContainerCurrentInGrams += gramsSolid;
        }
    }
}
