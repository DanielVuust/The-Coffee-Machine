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
        private IFilterType filter;

        public string MachineName
        {
            get { return machineName; }
        }

        public IFilterType Filter
        {
            get { return filter; }
            set { filter = value; }
        }

        public BaseBrewingMachine(string machineName, IFilterType filter)
        {
            this.machineName = machineName;
            this.filter = filter;
        }

        public abstract void StartBrewing();
    }
}
