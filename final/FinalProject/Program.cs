using System;

class Program
{
    static void Main(string[] args)
    {
       
       List<Transaction> transactions = new List<Transaction>();

       transactions.Add(new Income(3500,"Paimment of salary","Salary"));
       transactions.Add(new Expense(300,"Paimment of house rent","Rent"));
       transactions.Add(new Income(500,"Bonus for achievement","Salary",6,28,2023));
       transactions.Add(new Expense(40,"Family outing to a restaurant","Recreation",6,29,2023));

       foreach (var transaction in transactions)
       {
        Console.WriteLine(transaction.ToString());
       }

    }
}