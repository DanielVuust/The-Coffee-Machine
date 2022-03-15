﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using The_Coffee_Machine.BrewingType;
using The_Coffee_Machine.Containers;
using The_Coffee_Machine.Filters;
using The_Coffee_Machine.Interfaces;
using The_Coffee_Machine.Liquids;

namespace The_Coffee_Machine
{
    class CoffeeMachine : BaseBrewingMachine, ILiquidAndSolidMachine
    {
        private const string machineName = "CoffeMachine";
        private const int liquidServingSizeInMl = 20;
        private const int solidUsagePerServingInGrams = 10;

        private MediumBrewingMachineSolidContainer solidContainer;
        private MediumBrewingMachineLiquidContainer liquidContainer;
        public CoffeeMachine() 
            : base(machineName, new PapirFilter())
        {
            solidContainer = new MediumBrewingMachineSolidContainer(new Coffee());
            liquidContainer = new MediumBrewingMachineLiquidContainer(new Water());
        }

        public override void StartBrewing()
        {
            while (this.liquidContainer.ContainerCurrentLiquidInMl > liquidServingSizeInMl && this.solidContainer.ContainerCurrentInGrams > solidUsagePerServingInGrams)
            {
                liquidContainer.ContainerCurrentLiquidInMl -= liquidServingSizeInMl;
                Console.WriteLine("20 ml of coffee has been brewed");
            }
            Console.WriteLine("All available coffee has now been brewed");
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
