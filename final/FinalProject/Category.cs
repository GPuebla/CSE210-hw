using System;

public class Category
{
    private  String _name;
    private  String _categoryType;
    private double _amount;
    private List<String> transactionHistory = new List<string>();
    
    /// <summary>  
    /// posibble categories "E" = Expenses, "I" = Income 
    /// </summary> 
    public Category ( String name, String categoryType)
    {
        _name = name;
        _categoryType = categoryType;
    }

    public String Name
    {
         
        get{return _name;}
    }

    public String CategoryType
    {
        get{return _categoryType;}
    }

    public double Amount
    {
        get{return _amount;}
        set{_amount = value;}
    }

    public void AddTransaction(String transactionDate, String description, double amount)
    {
        transactionHistory.Add($"{transactionDate} - {description} - {amount.ToString()}");
        _amount += amount;
    }

    public void DisplayDetail()
    {
        Console.WriteLine($" -------------------------- {_name} -------------------------- \n");

        foreach (var transaction in transactionHistory)
        {
            
            Console.WriteLine("-" + transaction);
            
        }

        Console.WriteLine($" --------------------------------------------------------------------- \n");
    }



}
