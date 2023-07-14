using System;

public class Income : Transaction
{
    public Income(double amount, string description, int indexCategory, FinancialRecord FRobject) : base(amount, description, indexCategory,FRobject)
    {
    }

    public Income(double amount, string description, int indexCategory, int monthNum, int dayNum, int yearNum,FinancialRecord FRobject) : base(amount, description, indexCategory, monthNum, dayNum, yearNum, FRobject)
    {
    }

    public override void AddTransactionIntoRecord(FinancialRecord fr)
    {
        fr.TotalIncome += Amount;
        fr.Balance += Amount;
    }
}