using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Coffee_Machine.Interfaces;

namespace The_Coffee_Machine.Containers
{
    public class MediumBrewingMachineSolidContainer : IContainer
    {
        private ISolidType solidType;
        private int containerCurrentInGrams = 0;
        private bool isFull;

        public ISolidType SolidType { get { return solidType; } }
        public int ContainerCurrentInGrams { get { return containerCurrentInGrams; } set { containerCurrentInGrams = value; } }
        public bool IsFull { get { return isFull; } set { isFull = value; } }


        public MediumBrewingMachineSolidContainer(ISolidType solidType)
        {
            this.solidType = solidType;
        }
    }
}
