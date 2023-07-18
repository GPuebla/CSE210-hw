using System;

public class Income : Transaction
{
    private String payer = "";
    private String source = "";

    public Income(double amount, string description, int indexCategory, FinancialRecord FRobject) : base(amount, description, indexCategory,FRobject)
    {
        _transactionType = "I";
    }

    public Income(double amount, string description, int indexCategory, int monthNum, int dayNum, int yearNum,FinancialRecord FRobject) : base(amount, description, indexCategory, monthNum, dayNum, yearNum, FRobject)
    {
        _transactionType = "I";
    }

    public override void AddTransactionIntoRecord(FinancialRecord fr)
    {
        fr.TotalIncome += Amount;
        fr.Balance += Amount;
    }
}