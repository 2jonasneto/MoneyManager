global using MoneyManager.Shared.Enums;

namespace MoneyManager.Application.Base
{
    public abstract class ViewModel
    {
        public Guid Id { get;  set; }
        public string ModifiedBy { get;  set; } 
        public DateTime ModifyDate { get;  set; }
        public bool IsDeleted { get;  set; }

    }
}