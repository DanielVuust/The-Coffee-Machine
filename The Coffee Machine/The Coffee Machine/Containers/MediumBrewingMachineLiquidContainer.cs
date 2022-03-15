using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Coffee_Machine.Interfaces;

namespace The_Coffee_Machine.Containers
{
    public class MediumBrewingMachineLiquidContainer : IContainer
    {
        private ILiquidType liquidType;
        private int containerCurrentLiquidInMl = 0;
        private bool isFull;

        public ILiquidType LiquidType { get { return liquidType; } }
        public int ContainerCurrentLiquidInMl { get { return containerCurrentLiquidInMl; } set { containerCurrentLiquidInMl = value; } }
        public bool IsFull { get { return isFull; } set { isFull = value; } }

        public MediumBrewingMachineLiquidContainer(ILiquidType liquidType)
        {
            this.liquidType = liquidType;
        }
    }
}
