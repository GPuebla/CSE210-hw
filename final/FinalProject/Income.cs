using System;

public class Income : Transaction
{
    private String _payer = "";
    private String _source = "";

    public Income(double amount, string description, int indexCategory, FinancialRecord FRobject) : base(amount, description, indexCategory,FRobject)
    {
        _transactionType = "I";
        GetExtraInformation();
        _extraInfo = $"{_payer} - {_source}";
    }

    public Income(double amount, string description, int indexCategory, int monthNum, int dayNum, int yearNum,String extraInfo,FinancialRecord FRobject) : base(amount, description, indexCategory, monthNum, dayNum, yearNum,extraInfo, FRobject)
    {
        _transactionType = "I";
        _extraInfo = $"{_payer} - {_source}";
    }

    public override void AddTransactionIntoRecord(FinancialRecord fr)
    {
        fr.TotalIncome += Amount;
        fr.Balance += Amount;
    }

  
    public override void GetExtraInformation()
    {
        Console.Write("Who made this payment?(optional) ");
        _payer = Console.ReadLine();
        Console.Write("Where was the money transferred from?(optional) ");
        _source = Console.ReadLine();
    }
    

}