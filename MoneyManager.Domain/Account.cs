using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoneyManager.Domain
{
    public sealed class Account:Entity
    {
        public string Description { get; private set; }

        public EAccountType AccountType { get; private set; }
    }
}