using InterfaceBenefits.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBenefits.Utils
{
    public static class Censorer
    {
        public static void CensorData(IEnumerable<ICensorable> censorableItems)
        {
            foreach (ICensorable censorableItem in censorableItems)
            {
                censorableItem.CensorData();
            }
        }
    }
}
