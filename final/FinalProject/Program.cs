using System;

class Program
{
    static void Main(string[] args)
    {
        FinancialRecord record1 = new FinancialRecord();
        // DisplayMenu();
       
        
        record1.AddTransaction(new Income(3500,"Paimment of salary",0,record1));
        record1.AddTransaction(new Expense(1100,"Paimment of house rent",4,record1));
        record1.AddTransaction(new Income(500,"Bonus for achievement",0,6,25,2023,record1));
        record1.AddTransaction(new Expense(40,"Family outing to a restaurant",6,6,27,2023,record1));
        record1.AddTransaction(new Income(300,"Paimment of salary",7,record1));
        record1.AddTransaction(new Expense(300,"Paimment of house rent",4,record1));
        record1.AddTransaction(new Income(500,"Bonus for achievement",1,6,28,2023,record1));
        record1.AddTransaction(new Expense(400,"Family outing to a restaurant",6,6,29,2023,record1));
        record1.AddTransaction(new Income(3800,"Paimment of salary",0,record1));
        record1.AddTransaction(new Expense(100,"Paimment of house rent",3,record1));
        record1.AddTransaction(new Income(200,"Bonus for achievement",1,6,29,2023,record1));
        record1.AddTransaction(new Expense(240,"Family outing to a restaurant",6,6,30,2023,record1));

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

        Console.WriteLine("------------------------------------Example of format date to save---------------------------------");

        foreach (var transaction in record1.GetTransactions)
        {
            Console.WriteLine(transaction.GetDataToSave());
        }

    }
   
    public static void DisplayMenu()
    {
        bool defaultMode = false; 
        int menuOption = 0;
        
        do
        {   
            if(!defaultMode)
            {   
                // Console.Clear();
                Console.WriteLine(" \n-------------------------------------- Menu Options: -------------------------------------- ");
                Console.WriteLine("\n1) Create a new Financial Record. \n2) Load an existent financial record. \n3) Quit.");
                Console.Write(" \n Please, select the option number that you want: ");
                menuOption = int.Parse(Console.ReadLine());
                // Console.Clear();
                Console.WriteLine("-----------------------------------------------------------------------------------------");
            }
            
            switch (menuOption)
            {
                case 1:
                    defaultMode = false;  
                    Console.WriteLine("case 1");

                    break;
                case 2:
                    defaultMode = false;
                    Console.WriteLine("case 2");
                    
                    break;
                case 3:
                    defaultMode = false;
                    Console.WriteLine("Thank you for using this program");
                    
                    break;
                default:
                    defaultMode = true;
                    for (int i = 0; i < 3; i++)
                    {
                    Console.WriteLine("The entered character isn't found among the options. Try again: ");
                    menuOption = int.Parse(Console.ReadLine());  

                    if (menuOption >0 && menuOption < 3)
                    {
                        break;
                    }

                    if(i==2)
                    {
                        Console.WriteLine("Sorry, your attempts have been exhausted.");
                    }
                    }
                    break;
            }

        } while (menuOption >0 && menuOption < 3);

    }

    public static void DisplayMenu2()
    {
        bool defaultMode = false; 
        int menuOption = 0;
        
        do
        {   
            if(!defaultMode)
            {   
                // Console.Clear();
                Console.WriteLine(" \n-------------------------------------- Menu Options: -------------------------------------- ");
                Console.WriteLine("\n1) Record an income. \n2) List Goals. \n3) Save Goals. \n4) Load Goals. \n5) Record Event. \n6) Quit.");
                Console.Write(" \n Please, select the option number that you want: ");
                menuOption = int.Parse(Console.ReadLine());
                // Console.Clear();
                Console.WriteLine("-----------------------------------------------------------------------------------------");
            }
            
            switch (menuOption)
            {
                case 1:
                    defaultMode = false;  
                    Console.WriteLine("case 1");

                    break;
                case 2:
                    defaultMode = false;
                    Console.WriteLine("case 2");
                    
                    break;
                case 3:
                    defaultMode = false;
                    Console.WriteLine("case 3");

                    break;
                case 4:
                    defaultMode = false;
                    Console.WriteLine("case 4");
                    
                    break;
                case 5:
                    defaultMode = false;
                    Console.WriteLine("case 5");
                    
                    break;
                case 6:
                    defaultMode = false;
                    Console.WriteLine("case 6");
                    
                    break;
                default:
                    defaultMode = true;
                    for (int i = 0; i < 3; i++)
                    {
                    Console.WriteLine("The entered character isn't found among the options. Try again: ");
                    menuOption = int.Parse(Console.ReadLine());  

                    if (menuOption >0 && menuOption < 6)
                    {
                        break;
                    }

                    if(i==2)
                    {
                        Console.WriteLine("Sorry, your attempts have been exhausted.");
                    }
                    }
                    break;
            }

        } while (menuOption >0 && menuOption < 6);
    }
}
