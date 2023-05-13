using System;

class Entry
{
    public String _date;

    public String _prompt;

    public String _response;

    public Entry()
    {
        DateTime theCurrentTime = DateTime.Now;
        this._date = theCurrentTime.ToShortDateString();

        PromptGenerator pg = new PromptGenerator();
        this._prompt = pg.randomlyChoosePrompt();
    }

    public void displayEntry()
    {
        Console.WriteLine($"Date: {_date} Prompt: {_prompt} \n{_response}");
    }

    public String getEntry()
    {
        return $"Date: {_date} Prompt: {_prompt} \n{_response}";
    }

    
}