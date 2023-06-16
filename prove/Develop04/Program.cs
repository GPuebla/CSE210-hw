using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity bA1 = new BreathingActivity();
        ReflectionActivity rA1 = new ReflectionActivity();

        // bA1.DisplayStartMessage();
        // bA1.DisplayDescription();
        // bA1.SetUserTimeSession();
        // bA1.ShownBreathingMessages();
        // bA1.DisplayFinalMessage();
        

        for (int i = 0; i < 6; i++)
        {
           rA1.DisplayPrompt(); 
        }

    }
}