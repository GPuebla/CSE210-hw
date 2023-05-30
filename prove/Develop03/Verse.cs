using System;

public class Verse
{
    
    private Reference _reference{get;set;}
    private String _sentence;
    private bool _isAllHidden{get;set;}
    private int _executionAccount = 0;
    private int _totalWordsHide;
    private int _totalWordsVisible;
    private Random rdm = new Random();

    private List<Word> words = new List<Word>();

    public Verse (String reference, String text)
    {
        this._reference = new Reference(reference);
        ConvertTextIntoVerse(text);
        checkedIfAllAreHidden();
        CountWordsHideAndVisible();
        
    }

    public Verse (Reference reference, List<Word> listOfWords )
    {
        this._reference = reference;
        this.words.AddRange(listOfWords);
        checkedIfAllAreHidden();
        CountWordsHideAndVisible();
        
    }


    private void checkedIfAllAreHidden()
    {
        foreach (var word in words)
        {
            if(!word.getIsHide()){
                _isAllHidden = false;
            }
        }
    }


    public List<Word> GetWords()
    {
        return this.words;
    }

    public String WriteVerse()
    {
        int lap = 0;
        _sentence = "";

        if(_executionAccount == 0)
        {
            foreach (var w in words)
            {
                _sentence += $" {w.GetWord()}";
            }
            _executionAccount++;
        }
        else if(_totalWordsVisible>3)
        {
            while(lap<3)
            {
                int index = rdm.Next(words.Count());

                if(!words[index].getIsHide())
                {
                  lap ++;
                  words[index].HideWord();
                }
            }

            foreach (var w in words)
            {
                _sentence += $" {w.GetWord()}";
            } 

        }
        else{

            foreach (var i in words)
            {
                 if(!i.getIsHide())
                {
                  i.HideWord();
                }
            }

            foreach (var w in words)
            {
                _sentence += $" {w.GetWord()}";
            } 
        }
        CountWordsHideAndVisible();

        return _sentence;
    }

    private void CountWordsHideAndVisible()
    {
        _totalWordsHide = 0;
        _totalWordsVisible = 0;
        foreach (var i in words)
        {
            if(i.getIsHide())
            {
                _totalWordsHide++;
            }
            else
            {
                _totalWordsVisible++;
            }
        }

        if (_totalWordsVisible == 0)
        {
            _isAllHidden = true;
        }else
        {
            _isAllHidden = false;
        }
    }


    public int GetTotalWordsHide()
    {
        return this._totalWordsHide;
    }

    public int GetTotalWordsVisible()
    {
        return this._totalWordsVisible;
    }

    public bool IsAllHidden
    {
        get{ return this._isAllHidden;}
    }

    private void ConvertTextIntoVerse(String text)
    {
        String[] words = text.Split(" ");

        foreach (var word in words)
        {
            this.words.Add(new Word($"{word}"));
        }
    }

    public Reference Reference
    {
        get{return this._reference;}
    }

}