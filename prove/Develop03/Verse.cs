using System;

public class Verse
{
    private int _numberVerse{get;}
    private String _bookName;
    private String _chapterName;
    private bool _isAllHidden;

    private List<Word> words = new List<Word>();

    public Verse (int numVer, String bookName )
    {
        this._numberVerse = numVer;
        this._bookName = bookName;
        checkedIfAllAreHidden();
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



}