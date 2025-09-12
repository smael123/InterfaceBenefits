using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBenefits.Models
{
    public interface IDuplicatableItem
    {
        string GetUniqueId();
        string GetDisplaybaleNonUniqueData();
    }
}
