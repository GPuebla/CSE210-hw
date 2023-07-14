using System;

public class DataManager
{

    public static void SaveData(FinancialRecord fr)
    {
        Console.WriteLine("Insert the name of the file where your data will be saved");
        String name = Console.ReadLine();

        String _fileNameToSave = $"{name}.txt";
        
        using (StreamWriter outputFile = new StreamWriter(_fileNameToSave))
        {
            

            // for (int i = 0; i < goals.Count(); i++)
            // {
            //     outputFile.WriteLine(goals[i].ConcatenateAttribute());
                
            // }
        }
    }
    public static void ReadData(){}

}