using System;

public class BreathingActivity:Activity
{
    public BreathingActivity()
    {
        SetNameActivity("Breathing Activity");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public void ShownBreathingMessages()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetTimeDuration());

        Console.WriteLine("\nGet ready...");
        ShowSpinnerAnimation(4);
        Console.WriteLine("\n");


        while (DateTime.Now < endTime)
        {
           Console.Write("Breathe in...");
           ShowCountdown(4);
           Console.WriteLine("");
           Console.Write("Now breathe out...");
           ShowCountdown(6);
           Console.WriteLine("\n");
        }
    }

}