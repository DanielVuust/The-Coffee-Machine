using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Coffee_Machine.Interfaces;

namespace The_Coffee_Machine.Filters
{
    class MetalFilter : IFilterType
    {
        private string filterType = "MetalFilter";
        public string FilterType { get { return filterType; } }
    }
}
