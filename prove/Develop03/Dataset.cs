using System;
using System.IO; 

public class DataSet
{
    public List<String> _references = new List<String>();
    public List<String> _verse_num = new List<String>();
    public  List<String> _verse_text = new List<String>();

    public DataSet()
    {
        WriteCSV();
        ReadCSV();
    }


    public void ReadCSV()
    {
        string filename = "DataSet2.csv";
        string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split("**");

                this._references.Add(parts[0]);
                this._verse_num.Add(parts[1]);
                this._verse_text.Add(parts[2]);
                
            }
    }

    public void WriteCSV()
        {
            using (StreamWriter outputFile = new StreamWriter("DataSet2.csv"))
            {
                outputFile.WriteLine("reference**verse_num**verse_text");

                for (int i = 0; i < 5; i++)
                {
                    outputFile.WriteLine($"example{i+10}**{i+1}**aaaaa{i*3}aaaaa");
                }
            }
        }

    public List<String> GetRefList()
    {
        return this._references;
    }





}