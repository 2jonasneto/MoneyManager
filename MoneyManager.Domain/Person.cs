using System.Security.Principal;

namespace MoneyManager.Domain
{
    public sealed class Person : Entity
    {
        public string Name { get; private set; } = "";
        public EPersonType PersonType { get; private set; }


    }

}