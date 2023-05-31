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

}