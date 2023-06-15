using System;

public class BreathingActivity:Activity
{
    private List<String> breathingList = new List<String>();

    public BreathingActivity(int timeDuration) : base(timeDuration)
    {
        SetNameActivity("BreathingActivity");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        
        breathingList.Add("Breathe in...");
        breathingList.Add("Breathe out...");

    }

    public void ShownBreathingMessages()
    {
        
    }

}