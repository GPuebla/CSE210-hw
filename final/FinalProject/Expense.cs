public class Expense : Transaction
{
    public Expense(double amount, string description, Category category, FinancialRecord FRobject) : base(amount, description, category,FRobject)
    {
    }

    public Expense(double amount, string description, Category category, int monthNum, int dayNum, int yearNum,FinancialRecord FRobject) : base(amount, description, category, monthNum, dayNum, yearNum, FRobject)
    {
    }

    public override void AddTransactionIntoRecord(FinancialRecord fr)
    {
        fr.TotalExpenses += Amount;
        fr.Balance -= Amount;
    }

    

   
    
}