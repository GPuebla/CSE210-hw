using System;

public class Word
{
    private String _word;
    private String _text;
    private String _hideText;
    private bool isHide{get;set;}

    public Word(String text)
    {
        this._text = text;
        this.isHide = false;
        CreatHideText();
    }

    private void CreatHideText(){
        int nLetters = _text.Count();

        foreach (var letter in this._text)
        {
            this._hideText += "_";
        }
    }

    public String GetWord()
    {
        if(!isHide)
        {
            this._word = this._text;
        }else
        {
            this._word = this._hideText;
        }
        return this._word;
    }

    public void HideWord()
    {
        this.isHide = true;
    }

    public void ShowWord()
    {
        this.isHide = false;
    }

    public bool getIsHide()
    {
        return this.isHide;
    }

}
