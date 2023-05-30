using System;

public class Reference
{
    private String _fullReferenceText{get;} // format (Book Name / Chapter number / : / verse - verses)
    private String _bookReference{get;set;}
    private int _chapter{get;set;}
    private int _versesQty{get;set;}

    private String _listOfVerses{get;set;}
    private List<int> _verses = new List<int>();

    public Reference(String fullReferenceText)
    {
        this._fullReferenceText = fullReferenceText;
        ConvertReference();
        AddVerses();
    }


    public String FullReferenceText
    {
        get{return this._fullReferenceText;}
    }

    public String BookReference
    {
        get{return this._bookReference;}
    }

    public int Chapter
    {
        get{return this._chapter;}
    }

    public int VersesQty
    {
        get{return this._versesQty;}
    }

    public List<int> Verses
    {
        get{return this._verses;}
    }

    public String ListOfVerses
    {
        get{return this._listOfVerses;}
    }

    private void AddVerses()
    {
        foreach (var verse in _verses)
            {   
                string v = verse.ToString();
                this._listOfVerses += " "+v;
            }
    }

    private void ConvertReference()
    {
        string[] refParts = _fullReferenceText.Split(' ');

        if(refParts[0].All(char.IsDigit) && refParts.Count() == 3)
        {
            this._bookReference = $"{refParts[0]} {refParts[1]}";

            string[] partsOfBook = refParts[2].Split(":");

            this._chapter = int.Parse(partsOfBook[0]);

            if(partsOfBook[1].Contains("-"))
            {
                string[] verses = partsOfBook[1].Split("-");

                int ver_start = int.Parse(verses[0]);
                int ver_end = int.Parse(verses[1]);

                    for (int i = ver_start; i < ver_end +1; i++)
                    {
                        this._versesQty ++;
                        this._verses.Add(i);
                    }
            }
            else
            {
                this._versesQty = 1;
                this._verses.Add(int.Parse(partsOfBook[1]));
            }
        } 
        else if(refParts.Count() == 2)
        {
            this._bookReference = $"{refParts[0]}";

            string[] partsOfBook = refParts[1].Split(":");

            this._chapter = int.Parse(partsOfBook[0]);

            if(partsOfBook[1].Contains("-"))
            {
                string[] verses = partsOfBook[1].Split("-");

                int ver_start = int.Parse(verses[0]);
                int ver_end = int.Parse(verses[1]);

                    for (int i = ver_start; i < ver_end +1; i++)
                    {
                        this._versesQty ++;
                        _verses.Add(i);
                    }
            }
            else
            {
                this._versesQty = 1;
                this._verses.Add(int.Parse(partsOfBook[1]));
            }
        }
    }

}