using MoneyManager.Application.Base;

namespace MoneyManager.Application.ViewModels;

public sealed class BillViewModel : ViewModel
{
  
    public string Description { get;  set; }

    public EBillType BillType { get;  set; }

    public DateTime DueDate { get;  set; }
    public DateTime Payday { get;  set; }
    public decimal Price { get;  set; }
    public bool IsPaid { get;  set; }
    public Guid TransactionId { get;  set; }
    public EFormPayment FormPayment { get;  set; }

}