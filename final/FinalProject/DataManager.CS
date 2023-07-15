using System;

public static class DataManager
{
    public static List<String> recordsList = new  List<String>();
    public static List<String> categoryList = new  List<String>();

    public static void SaveData(FinancialRecord fr)
    {
        Console.WriteLine("Insert the name of the file where your data will be saved");
        String name = Console.ReadLine();

        String _fileNameToSave = $"{name}.txt";
        
        using (StreamWriter outputFile = new StreamWriter(_fileNameToSave))
        {

             foreach (var transaction in fr.GetTransactions)
            {
                outputFile.WriteLine(transaction.GetDataToSave());
            }
        } 
    }

    public static void ReadData(){}

    public static void ReadData(String fileName, FinancialRecord FRobject)
    {
        String description = "";
        int amount = 0;
        int indexCategory = 0;
        int monthNum = 0;
        int dayNum = 0;
        int yearNum = 0;

        string filename =$"{fileName}.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
              
                string[] parts = line.Split("**");
                
                description = parts[1];
                amount = int.Parse(parts[0]);
                indexCategory = int.Parse(parts[2]);
                monthNum = int.Parse(parts[3]);
                dayNum = int.Parse(parts[4]);
                yearNum = int.Parse(parts[5]);

                FRobject.AddTransaction(new Income(amount,description,indexCategory,monthNum,dayNum,yearNum,FRobject));
                
            }
    }


}