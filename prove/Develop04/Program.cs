using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity bA1 = new BreathingActivity();

        bA1.DisplayStartMessage();

        bA1.DisplayDescription();

        bA1.SetUserTimeSession();

        bA1.ShownBreathingMessages();

        bA1.DisplayFinalMessage();

    }
}