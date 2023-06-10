namespace MoneyManager.Domain
{
    public abstract class Entity
    {
        protected Entity(string modifiedBy="", bool isDeleted=false)
        {
            Id = Guid.NewGuid();
            ModifiedBy = modifiedBy;
            ModifyDate = DateTime.Now;
            IsDeleted = isDeleted;
        }

        public Guid Id { get; protected set; }
        public string ModifiedBy { get; protected set; } = "";
        public DateTime ModifyDate { get; protected set; }
        public bool IsDeleted { get; protected set; }

    }
}