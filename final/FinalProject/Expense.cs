public class Expense : Transaction
{

    private String _payee = "-";
    
    public Expense(double amount, string description, int indexCategory, FinancialRecord FRobject) : base(amount, description, indexCategory,FRobject)
    {
        _transactionType = "E";
        GetExtraInformation();
        _extraInfo = _payee;
    }

    public Expense(double amount, string description, int indexCategory, int monthNum, int dayNum, int yearNum,String extraInfo,FinancialRecord FRobject) : base(amount, description, indexCategory, monthNum, dayNum, yearNum,extraInfo, FRobject)
    {
        _transactionType = "E";
        _extraInfo = _payee;

    }

    public override void AddTransactionIntoRecord(FinancialRecord fr)
    {
        fr.TotalExpenses += Amount;
        fr.Balance -= Amount;
    }

    public override String ToString()
    {
        return $"{Date.ToString("M/dd/yyyy").PadRight(15)}{TransactionId.PadRight(15)}$ -{Amount.ToString().PadRight(9)}{Description.PadRight(32)}{Category.Name.PadRight(30)}$ {_currentRecordBalance.ToString().PadRight(10)}";
    }

    public override void GetExtraInformation()
    {
        Console.Write("To whom was this payment made?(optional) ");
        _payee = Console.ReadLine();
    }

   
    
}