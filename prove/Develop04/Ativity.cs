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

     public void DisplayStartMessage()
    {
        Console.WriteLine($"\nWelcome to the {_nameActivity}\n");
    }

    public void DisplayDescription()
    {
        Console.WriteLine(_description);
    }

    public void DisplayFinalMessage()
    {
       Console.WriteLine("\nWell done!! ");
       ShowSpinnerAnimation(5);
       Console.WriteLine($"\nYou have completed another {_timeDuration} seconds of {_nameActivity}");
       ShowSpinnerAnimation(5);
    }

    protected List<String> ChooseRandomListElement( List<String> elementlist) 
    {
        List<String> elementAndIndex = new List<String>();
        Random rnd = new Random();
        int num = rnd.Next(0,elementlist.Count());
        String elementSelected = elementlist[num];

        elementAndIndex.Add(elementSelected);
        elementAndIndex.Add(num.ToString());

        return elementAndIndex;
    }
    
    public int ShowCountdown(int secondsTime) 
    {
        for (int i = secondsTime; i >= 1; i--)
        {
            Console.Write(i);

            Thread.Sleep(1100);

            if(i > 9)
            {
                Console.Write("\b \b"); 
            }

            Console.Write("\b \b");
        }

        return secondsTime;
    }

    public int ShowSpinnerAnimation(int secondsTime) 
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

    public void SetUserTimeSession()
    {
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        int userTimeSetion = int.Parse(Console.ReadLine());

        _timeDuration = userTimeSetion;
    }
    


}