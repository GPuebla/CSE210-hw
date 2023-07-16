using System;

public abstract class Transaction
{
    private double _amount;
    private String _description;
    private Category _category;
    private DateTime _date;
    private int _indexCategory;
    private String _transactionId; //date.ToString("Mddyyyyhmm");
    protected double _currentRecordBalance;
    protected String _transactionType;
    

    public Transaction(double amount, string description, int indexCategory, FinancialRecord FRobject)
    {
        _amount = amount;
        _description = description;
        _category = FRobject.GetCategories[indexCategory];
        _date = DateTime.Now;
        _transactionId = _date.ToString("Mddyyyyhmm");
        AddTransactionIntoRecord(FRobject);
        GetCurrentRecordBalance(FRobject);
        UpdateCategory(_category);
        _indexCategory = indexCategory;
        
    }
    public Transaction(double amount, string description, int indexCategory , int monthNum, int dayNum, int yearNum,FinancialRecord FRobject)
    {
        _amount = amount;
        _description = description;
        _category = FRobject.GetCategories[indexCategory];
        DateTime today = DateTime.Now;
        int hourAndMin = int.Parse(today.ToString("hmm"));
        _date = new DateTime(yearNum, monthNum, dayNum);
        _transactionId = _date.ToString("Mddyyyy"+hourAndMin);
        AddTransactionIntoRecord(FRobject);
        GetCurrentRecordBalance(FRobject);
        UpdateCategory(_category);
        _indexCategory = indexCategory;
    }

    public override String ToString()
    {
        return $"{_date.ToString("M/dd/yyyy").PadRight(15)}{_transactionId.PadRight(15)}$ {_amount.ToString().PadRight(10)}{_description.PadRight(32)}{_category.Name.PadRight(30)}$ {_currentRecordBalance.ToString().PadRight(10)}";
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

    public String GetDataToSave()
    {
        return$"{_amount}**{_description}**{_indexCategory}**{_date.Month}**{_date.Day}**{_date.Year}**{_transactionType}";
    }
    
}