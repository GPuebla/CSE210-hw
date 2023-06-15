using System;

public class Activity
{
    private String _nameActivity = "";
    private  String _description;
    private  int _timeDuration;

    //----------------------------------------- Constructors ----------------------------------------------\\

    public Activity(){}

    public Activity( int timeDuration)
    {
        _timeDuration = timeDuration;
    }

    public Activity(String nameActivity, String description)
    {
        _nameActivity = nameActivity;
        _description = description;
    }

    public Activity(String nameActivity, String description, int timeDuration)
    {
        _nameActivity = nameActivity;
        _description = description;
        _timeDuration = timeDuration;
    }

    //----------------------------------------- Getters and Setters ----------------------------------------------\\

    public void SetTimeDuration( int time)
    {
        _timeDuration = time;
    }

    public int GetTimeDuration()
    {
        return _timeDuration;
    }

     public void SetNameActivity( String name)
    {
        _nameActivity = name;
    }

    public String GetNameActivity()
    {
        return _nameActivity;
    }

    public void SetDescription( String description)
    {
        _description = description;
    }

    public String GetDescription()
    {
        return _description;
    }


    //----------------------------------------- Methods ----------------------------------------------\\

     protected void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_nameActivity}");
    }

    protected void ShowDescription()
    {
        Console.WriteLine(_description);
    }

    protected void DisplayFinalMessage()
    {
       Console.WriteLine($"You have completed another {_timeDuration} seconds of {_nameActivity}");
    }

    protected List<String> ChooseRandomListElement( List<String> elementlist) 
    {
        List<String> elementAndIndex = new List<String>();
        Random rnd = new Random();
        int num = rnd.Next(0,elementlist.Count()+1);
        String elementSelected = elementlist[num];

        elementAndIndex.Add(elementSelected);
        elementAndIndex.Add(num.ToString());

        return elementAndIndex;
    }
    
    protected int ShowCountdown(int secondsTime) 
    {
        for (int i = secondsTime; i >= 0; i--)
        {
            Console.Write(i);

            Thread.Sleep(1000);

            if(i > 9)
            {
                Console.Write("\b \b"); 
            }

            Console.Write("\b \b");
        }

        return secondsTime;
    }

    protected int ShowSpinnerAnimation(int secondsTime) 
    {
        List<String> animationElements = new List<string>();
        animationElements.Add("|");
        animationElements.Add("/");
        animationElements.Add("-");
        animationElements.Add("\\");
        animationElements.Add("|");
        animationElements.Add("/");
        animationElements.Add("-");
        animationElements.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(secondsTime);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(animationElements[i]);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if(i >=animationElements.Count)
            {
                i = 0;
            }
        }

        return secondsTime;
    }


}