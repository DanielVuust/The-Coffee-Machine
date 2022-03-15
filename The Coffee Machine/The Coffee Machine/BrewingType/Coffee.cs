using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Coffee_Machine.Interfaces;

namespace The_Coffee_Machine.BrewingType
{
    class Coffee : ISolidType
    {
        private string brewingType = "Coffee";
        public string SolidType { get { return brewingType; } }
    }
}
