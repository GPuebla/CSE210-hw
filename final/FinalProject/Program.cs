using System;

class Program
{
    static String currentNameRecord = "";
    static void Main(string[] args)
    {

        DataManager.LoadRecordList();
        FinancialRecord record = new FinancialRecord();
        
        DisplayMenu1(record);
        DisplayMenu2(record);

        DataManager.SaveData(record,currentNameRecord);
       
        
        // record.AddTransaction(new Income(3500,"Paimment of salary",0,record));
        // record.AddTransaction(new Expense(1100,"Paimment of house rent",4,record));
        // record.AddTransaction(new Income(500,"Bonus for achievement",0,6,25,2023,record));
        // record.AddTransaction(new Expense(40,"Family outing to a restaurant",6,6,27,2023,record));
        // record.AddTransaction(new Income(300,"Paimment of salary",7,record));
        // record.AddTransaction(new Expense(300,"Paimment of house rent",4,record));
        // record.AddTransaction(new Income(500,"Bonus for achievement",1,6,28,2023,record));
        // record.AddTransaction(new Expense(400,"Family outing to a restaurant",6,6,29,2023,record));
        // record.AddTransaction(new Income(3800,"Paimment of salary",0,record));
        // record.AddTransaction(new Expense(100,"Paimment of house rent",3,record));
        // record.AddTransaction(new Income(200,"Bonus for achievement",1,6,29,2023,record));
        // record.AddTransaction(new Expense(240,"Family outing to a restaurant",6,6,30,2023,record));

        

        Console.WriteLine("-----------------------------------------------------------------------------------");

        foreach (var transaction in record.GetTransactions)
        {
            Console.WriteLine($"{transaction.ToString()}");
        }

        Console.WriteLine("");

        record.ShowDetailCategory();

        Console.WriteLine("");

        Console.WriteLine("Totoal Expenses: $"+record.TotalExpenses);
        Console.WriteLine("Totoal Income: $"+record.TotalIncome);
        Console.WriteLine("Balanse: $"+record.Balance);

    }
   
    public static void DisplayMenu1(FinancialRecord fr)
    {
        bool defaultMode = false;
        bool isRecordCreate = false; 
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
                    Console.Write("Enter the name under which you want to save your financial records: ");
                    currentNameRecord = Console.ReadLine();
                    DataManager.AddRecordFinancialRecord(currentNameRecord);
                    DataManager.SaveData(fr,currentNameRecord);

                    isRecordCreate = true;

                    break;
                case 2:
                    defaultMode = false;
                    Console.WriteLine("Select the financial record you wish to upload: ");
                    
                    int x = 0;

                    foreach (var item in DataManager.recordsList)
                    {
                        x++;
                        Console.WriteLine($" {x}- {item}");
                    }

                    int option  = int.Parse(Console.ReadLine());
                    currentNameRecord = DataManager.recordsList[option-1];
                    DataManager.LoadFinancialRecord(currentNameRecord,fr);
                    
                    isRecordCreate = true;
                    
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

        } while (menuOption >0 && menuOption < 3 && !isRecordCreate);

    }

    public static void DisplayMenu2(FinancialRecord fr)
    {
        bool defaultMode = false; 
        int menuOption = 0;
        
        do
        {   
            if(!defaultMode)
            {   
                // Console.Clear();
                Console.WriteLine(" \n-------------------------------------- Menu Options: -------------------------------------- ");
                Console.WriteLine("\n1) Display detail of transactions recorded. \n2) Display current financial status. \n3) Record income. \n4) Record expense. \n5) Record Event. \n6) Quit.");
                Console.Write(" \n Please, select the option number that you want: ");
                menuOption = int.Parse(Console.ReadLine());
                // Console.Clear();
                Console.WriteLine("-----------------------------------------------------------------------------------------");
            }
            
            switch (menuOption)
            {
                case 1:
                    defaultMode = false;  
                    Console.WriteLine("Date".PadRight(15)+"TransactionId".PadRight(15)+"Amount".PadRight(12)+"Description".PadRight(32)+"Category".PadRight(30)+"Current Balance".PadRight(10)+"\n");
                    foreach (var transaction in fr.GetTransactions)
                    {
                        Console.WriteLine($"{transaction.ToString()}");
                    }

                    break;
                case 2:
                    defaultMode = false;
                    char pad = '.';
                    fr.ShowDetailCategory();

                    Console.WriteLine("");

                    Console.WriteLine($"Totoal Expenses: {"$".PadLeft(12,pad)}{fr.TotalExpenses}");
                    Console.WriteLine($"Totoal Income: {"$".PadLeft(14,pad)}{fr.TotalIncome.ToString()}");
                    Console.WriteLine($"Balanse: {"$".PadLeft(20,pad)}{fr.Balance.ToString()}");
                        
                    break;
                case 3:
                    defaultMode = false;
                    
                    fr.DisplayCategoryList("I");
                    Console.Write("Select the category of income: ");
                    int indexCategoryI = int.Parse(Console.ReadLine()) -1 ;
                    
                    Console.Write("Enter the amount of transaction: ");
                    double amountI = double.Parse(Console.ReadLine());
                    Console.Write("Enter a brief description: ");
                    String descriptionI = Console.ReadLine();

                    fr.AddTransaction(new Income(amountI,descriptionI,indexCategoryI,fr));

                    break;
                case 4:
                    defaultMode = false;

                    fr.DisplayCategoryList("E");
                    Console.Write("Select the category of expense: ");
                    int indexCategoryE = int.Parse(Console.ReadLine()) +1;

                    Console.Write("Enter the amount of transaction: ");
                    double amountE = double.Parse(Console.ReadLine());
                    Console.Write("Enter a brief description: ");
                    String descriptionE = Console.ReadLine();

                    fr.AddTransaction(new Expense(amountE,descriptionE,indexCategoryE,fr));
                    
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
