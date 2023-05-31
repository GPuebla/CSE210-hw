using System;
using System.IO; 

public class DataSet
{
    private List<String> _references = new List<String>();
    private List<String> _verse_num = new List<String>();
    private  List<String> _verse_text = new List<String>();

    public DataSet()
    {
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

    public void WriteCSV( String filename = "DataSet2.csv" )
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            
            outputFile.WriteLine("reference**verse_num**verse_text");

            for (int i = 1; i < _references.Count(); i++)
            {
                outputFile.WriteLine($"{this._references[i]}**{this._verse_num[i]}**{this._verse_text[i]}");
            }
        }
    }

    public void WriteCSV( String refe, int verse, String text, String filename = "DataSet2.csv" )
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            
            outputFile.WriteLine("reference**verse_num**verse_text");

            for (int i = 1; i < _references.Count(); i++)
            {
                outputFile.WriteLine($"{this._references[i]}**{this._verse_num[i]}**{this._verse_text[i]}");
            }
        }
    }

    public List<String> GetRefList()
    {
        return this._references;
    }

    public List<String> GetVerse_numList()
    {
        return this._verse_num;
    }

    public List<String> GetVerse_textList()
    {
        return this._verse_text;
    }

    public void AddVerse( String ref, String verse, String text)
    {
        this._references.Add(ref);
        this._verse_num.Add(verse);
        this._verse_text.Add(text);
    }
        
        
    }





}