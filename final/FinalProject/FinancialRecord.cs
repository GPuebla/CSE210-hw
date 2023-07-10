using System;

public class FinancialRecord
{
    private double _totalExpenses;
    private double _totalIncom;
    private double _balance;

    List<Transaction> transactions = new List<Transaction>();
    List<Category> categories = new List<Category>();
    
    public FinancialRecord ()
    {
        categories.Add(new Category("Salaries"));
        categories.Add(new Category("Other income"));
        categories.Add(new Category("Commodities"));
        categories.Add(new Category("Clothing and footwear"));
        categories.Add(new Category("Housing and supplies"));
        categories.Add(new Category("Health"));
        categories.Add(new Category("Transportation"));
        categories.Add(new Category("Salaries"));
        categories.Add(new Category("Education"));
        categories.Add(new Category("Leisure and culture"));
        categories.Add(new Category("Communications"));


    }

    public List<Transaction> GetTransactions
    {
        get{return transactions;}
    }

}