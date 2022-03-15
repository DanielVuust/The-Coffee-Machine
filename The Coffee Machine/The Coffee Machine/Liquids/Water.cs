using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Coffee_Machine.Liquids
{
    class Water : ILiquidType
    {
        private string liquidType = "Water";
        public string LiquidType { get { return liquidType; } }
    }
}
