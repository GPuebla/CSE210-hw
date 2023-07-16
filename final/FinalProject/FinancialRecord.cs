using System;

public class FinancialRecord
{
    private double _totalExpenses;
    private double _totalIncome;
    private double _balance;

    private List<Transaction> transactions = new List<Transaction>();
    private List<Category> categories = new List<Category>();
    
    public FinancialRecord ()
    {
        categories.Add(new Category("Salaries","I"));
        categories.Add(new Category("Other income","I"));
        categories.Add(new Category("Commodities","E"));
        categories.Add(new Category("Clothing and footwear","E"));
        categories.Add(new Category("Housing and supplies","E"));
        categories.Add(new Category("Health","E"));
        categories.Add(new Category("Transportation","E"));
        categories.Add(new Category("Entrepreneurship","E"));
        categories.Add(new Category("Education","E"));
        categories.Add(new Category("Leisure and culture","E"));
        categories.Add(new Category("Communications","E"));
        categories.Add(new Category("Other expenses","E"));

    }

    public List<Transaction> GetTransactions
    {
        get{return transactions;}
    }

    public void AddTransaction(Transaction t)
    {
        transactions.Add(t);
    }

    public List<Category> GetCategories
    {
        get{return categories;}
    }

    public void AddCategory(Category t)
    {
        categories.Add(t);
    }

    public double TotalIncome
    {
        get{return _totalIncome;}
        set{_totalIncome = value;}
    }

    public double TotalExpenses
    {
        get{return _totalExpenses;}
        set{_totalExpenses = value;}
    }

    public double Balance
    {
        get{return _balance;}
        set{_balance = value;}
    }

    public void DisplayCategoryList(String categoryType)
    {
        int x = 0;
        foreach (var item in categories)
        {   
            if(item.CategoryType == categoryType)
            {
                x++;
                Console.WriteLine($"{x}- {item.Name}");
            }
            
        }
    }

    public void ShowDetailCategory()
    {
        Console.WriteLine("Income by category:\n");
        foreach (var category in categories)
        {
            if(category.Amount != 0 && category.CategoryType == "I")
            {
                Console.WriteLine($"* {category.Name}.....${category.Amount}");
            }
        }
        Console.WriteLine("\nExpenses by category:\n");
        foreach (var category in categories)
        {
            if(category.Amount != 0 && category.CategoryType == "E")
            {
                Console.WriteLine($"* {category.Name}.....${category.Amount}");
            }
        }
    }

    
    

}