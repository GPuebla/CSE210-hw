using System;

public abstract class Transaction
{
    private double _amount;
    private String _description;
    private Category _category;
    private DateTime _date;
    private String _transactionId; //date.ToString("Mddyyyyhmm");
    private double _currentRecordBalance;
    

    public Transaction(double amount, string description, Category category, FinancialRecord FRobject)
    {
        _amount = amount;
        _description = description;
        _category = category;
        _date = DateTime.Now;
        _transactionId = _date.ToString("Mddyyyyhmm");
        AddTransactionIntoRecord(FRobject);
        GetCurrentRecordBalance(FRobject);
        UpdateCategory(category);
        
    }
    public Transaction(double amount, string description, Category category, int monthNum, int dayNum, int yearNum,FinancialRecord FRobject)
    {
        _amount = amount;
        _description = description;
        _category = category;
        DateTime today = DateTime.Now;
        int hourAndMin = int.Parse(today.ToString("hmm"));
        _date = new DateTime(yearNum, monthNum, dayNum);
        _transactionId = _date.ToString("Mddyyyy"+hourAndMin);
        AddTransactionIntoRecord(FRobject);
        GetCurrentRecordBalance(FRobject);
        UpdateCategory(category);
    }

    public override String ToString()
    {
        return $"{_amount}-{_description}-{_category.Name}-{_date.ToString("M/dd/yyyy")}-{_transactionId} - {_currentRecordBalance}";
    }

    public DateTime Date
    {
        get {return _date;}
    }

    public double Amount
    {
        get{return _amount;}
    }

    public String TransactionId
    {
        get{return _transactionId;}
    }

    public String Description
    {
        get{return _description;}
        set{_description =value;}
    }

    public Category Category
    {
        get{return _category;}
        set{_category =value;}
    }

    public abstract void AddTransactionIntoRecord( FinancialRecord fr);
    protected virtual void GetCurrentRecordBalance(FinancialRecord fr)
    {
        _currentRecordBalance = fr.Balance;
    }

    public virtual void UpdateCategory(Category c)
    {   
        c.AddTransaction(_date.ToString("M/dd/yyyy"),_description,_amount);
    }
    
}