public class Scripture
{
    private List<Verse> _verses = new List<Verse>();
    private Reference _reference {get; set;}
    private bool _isAllVersesHidden {get; set;}


    public Scripture( String reference, List<String> verses)
    {
        this._reference = new Reference(reference);
        this._isAllVersesHidden = false;

        foreach (var verse in verses)
        {
            this._verses.Add(new Verse(this._reference.FullReferenceText,$"{verse}"));
        }

        SetAllVersesHidden();
    }

    public String GetVerses() 
    {
        String text= "";
        int verseNum = _reference.Verses[0];

        Console.WriteLine($"{_reference.FullReferenceText}");

            foreach (var ver in _verses)
            {
                text += $"{verseNum} {ver.WriteVerse()}\n";
                verseNum ++;
            }

        SetAllVersesHidden();
        return text;
    }

    public void SetAllVersesHidden()
    {
        int count = 0;
            foreach (var ver in this._verses)
            {
                if(ver.IsAllHidden)
                {
                    count ++;
                }
            };

            if(count == _verses.Count())
            {
                this._isAllVersesHidden = true;
            }
    }

    public bool IsAllVersesHidden
    {
        get {return this._isAllVersesHidden;}
    }

    // public void WriteCSV()
    //     {
    //         using (StreamWriter outputFile = new StreamWriter("DataSet.csv"))
    //         {
    //             outputFile.WriteLine("reference**verse_num**verse_text");


    //             outputFile.WriteLine($"My favorite color is");
    //         }
    //     }


    // public void ReadCSV()
    //     {
    //         string filename = "DataSet.csv";
    //         string[] lines = System.IO.File.ReadAllLines(filename);

    //             foreach (string line in lines)
    //             {
    //                 string[] parts = line.Split("**");

    //                 _references.Add(parts[0]);
    //                 _verse_num.Add(parts[1]);
    //                 _verse_text.Add(parts[2]);
                    
    //             }
    //     }

}