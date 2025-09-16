using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBenefits.Models
{
    internal class FacebookAccountDuplicatableAdapter : IDuplicatableItem
    {
        private readonly FacebookAccount _account;

        public FacebookAccountDuplicatableAdapter(FacebookAccount account)
        {
            _account = account;
        }

        public string GetDisplaybaleNonUniqueData()
        {
            return _account.DisplayName;
        }

        public object GetUniqueId()
        {
            return _account.EmailAddress;
        }
    }
}
