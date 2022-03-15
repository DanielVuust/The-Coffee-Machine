using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Coffee_Machine.Interfaces
{
    interface ILiquidAndSolidMachine
    {
        void AddLiquidInMlToContainer(int mlLiquid);
        void AddSolidInGramsToContainer(int gramsSolid);
    }
}
