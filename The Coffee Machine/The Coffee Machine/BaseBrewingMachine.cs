using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Coffee_Machine.Interfaces;

namespace The_Coffee_Machine
{
    public abstract class BaseBrewingMachine
    {
        private string machineName;
        private IBrewingType brewingType;
        private ILiquidType liquidType;
        private IFilterType filter;

        public string MachineName
        {
            get { return machineName; }
        }
        public IBrewingType BrewingType
        {
            get { return BrewingType; }
        } 
        public ILiquidType LiquidType
        {
            get { return liquidType; }
        }

        public IFilterType Filter
        {
            get { return filter; }
            set { filter = value; }
        }

        public BaseBrewingMachine(string machineName, IBrewingType brewingType, IFilterType filter, ILiquidType liquidType)
        {
            this.machineName = machineName;
            this.brewingType = brewingType;
            this.filter = filter;
            this.liquidType = liquidType;
        }

        public abstract void StartBrewing();
    }
}
