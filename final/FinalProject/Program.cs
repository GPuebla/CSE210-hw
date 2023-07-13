using System;

class Program
{
    static void Main(string[] args)
    {
        DataManager.SaveData();
        FinancialRecord record1 = new FinancialRecord();
        
        record1.AddTransaction(new Income(3500,"Paimment of salary",record1.GetCategories[0],record1));
        record1.AddTransaction(new Expense(1100,"Paimment of house rent",record1.GetCategories[4],record1));
        record1.AddTransaction(new Income(500,"Bonus for achievement",record1.GetCategories[0],6,25,2023,record1));
        record1.AddTransaction(new Expense(40,"Family outing to a restaurant",record1.GetCategories[6],6,27,2023,record1));
        record1.AddTransaction(new Income(300,"Paimment of salary",record1.GetCategories[1],record1));
        record1.AddTransaction(new Expense(300,"Paimment of house rent",record1.GetCategories[4],record1));
        record1.AddTransaction(new Income(500,"Bonus for achievement",record1.GetCategories[1],6,28,2023,record1));
        record1.AddTransaction(new Expense(400,"Family outing to a restaurant",record1.GetCategories[6],6,29,2023,record1));
        record1.AddTransaction(new Income(3800,"Paimment of salary",record1.GetCategories[0],record1));
        record1.AddTransaction(new Expense(100,"Paimment of house rent",record1.GetCategories[3],record1));
        record1.AddTransaction(new Income(200,"Bonus for achievement",record1.GetCategories[1],6,29,2023,record1));
        record1.AddTransaction(new Expense(240,"Family outing to a restaurant",record1.GetCategories[6],6,30,2023,record1));

        Console.WriteLine("-----------------------------------------------------------------------------------");

        foreach (var transaction in record1.GetTransactions)
        {
            Console.WriteLine($"{transaction.ToString()}");
        }

        Console.WriteLine("");

        record1.ShowDetailCategory();

        Console.WriteLine("");

        Console.WriteLine("Totoal Expenses: $"+record1.TotalExpenses);
        Console.WriteLine("Totoal Income: $"+record1.TotalIncome);
        Console.WriteLine("Balanse: $"+record1.Balance);

        Console.WriteLine("-----------------------------------------------------------------------------------");

        record1.GetCategories[0].DisplayDetail();
        record1.GetCategories[4].DisplayDetail();
        record1.GetCategories[6].DisplayDetail();
        

        

    }
}