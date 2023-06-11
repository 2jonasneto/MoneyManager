using System.Security.Principal;
using MoneyManager.Domain.Base;
using MoneyManager.Domain.Enums;

namespace MoneyManager.Domain.Entities
{
    public sealed class Person : Entity
    {
        public string Name { get; private set; } = "";
        public EPersonType PersonType { get; private set; }


    }

}