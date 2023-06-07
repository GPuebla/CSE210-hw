using System;
using System.IO; 

public class DataSet
{
    private List<String> _references = new List<String>();
    private List<String> _verse_num = new List<String>();
    private  List<String> _verse_text = new List<String>();

    private List<String> specifics_Verses = new List<String>();
    private List<String> listOfReferences = new List<String>();

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

    public List<String> GetSpecificVerses( String reference)
    {   
        specifics_Verses.Clear();

        string filename = "DataSet2.csv";
        string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split("**");

                if(reference == parts[0])
                {
                    this.specifics_Verses.Add(parts[2]);
                }
                
            }

        return specifics_Verses;
    }

    public List<String> GetListOfReferences()
    {   
        specifics_Verses.Clear();
        String refText = "";

        string filename = "DataSet2.csv";
        string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines.Skip(1))
            {
                string[] parts = line.Split("**");

                if(refText != parts[0])
                {
                    this.listOfReferences.Add(parts[0]);
                    refText = parts[0];
                }
                
            }

        return listOfReferences;
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

    public void AddScripture( String refe, String verseNum, String verseText)
    {
        this._references.Add(refe);
        this._verse_num.Add(verseNum);
        this._verse_text.Add(verseText);

        WriteCSV();
    }


}