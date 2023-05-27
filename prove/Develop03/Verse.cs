using System;

public class Verse
{
    private int _numberVerse{get;}
    private String _bookName;
    private String _chapterName;
    private String _sentence;
    private bool _isAllHidden{get;set;}
    private int _executionAccount = 0;
    private int _totalWordsHide;
    private int _totalWordsVisible;
    private Random rdm = new Random();

    private List<Word> words = new List<Word>();

    public Verse (int numVer, String bookName, Word singleWord )
    {
        this._numberVerse = numVer;
        this._bookName = bookName;
        checkedIfAllAreHidden();
        CountWordsHideAndVisible();

    }

    public Verse (int numVer, String bookName, List<Word> listOfWords )
    {
        this._numberVerse = numVer;
        this._bookName = bookName;
        checkedIfAllAreHidden();
        CountWordsHideAndVisible();

        this.words.AddRange(listOfWords);
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

}