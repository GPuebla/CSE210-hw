public class Expense : Transaction
{
    public Expense(double amount, string description, string category) : base(amount, description, category)
    {
    }

    public Expense(double amount, string description, string category, int monthNum, int dayNum, int yearNum) : base(amount, description, category, monthNum, dayNum, yearNum)
    {
    }

    
}