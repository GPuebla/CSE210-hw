using System;

class Program
{
    static void Main(string[] args)
    {
        bool defaultMode = false; 
        int menuOption = 0;
        
        do
        {   
            if(!defaultMode)
            {   
                Console.Clear();
                Console.WriteLine(" -------------------------------------- Menu -------------------------------------- ");
                Console.WriteLine("\n1) Breathing Activity. \n2) Reflection Activity. \n3) Listing Activity. \n4) Quit.");
                Console.Write(" \n Please, select the option number that you want: ");
                menuOption = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("-----------------------------------------------------------------------------------------");
            }
            
            switch (menuOption)
            {
                case 1:
                    defaultMode = false;  

                    BreathingActivity bA1 = new BreathingActivity();

                    bA1.DisplayStartMessage();
                    bA1.DisplayDescription();
                    bA1.SetUserTimeSession();
                    bA1.ShownBreathingMessages();
                    bA1.DisplayFinalMessage();            

                    break;
                case 2:
                    defaultMode = false;

                    ReflectionActivity rA1 = new ReflectionActivity();

                    rA1.DisplayStartMessage();
                    rA1.DisplayDescription();
                    rA1.SetUserTimeSession();
                    rA1.DisplayPrompt();
                    Console.ReadLine();
                    Console.WriteLine("Now poder on each of the following questions as they related to this experience.");
                    Console.Write("You may begin in: ");
                    rA1.ShowCountdown(5);
                    Console.WriteLine();

                    rA1.DisplayReflectQuestion(); 
                    rA1.DisplayFinalMessage();
                    break;
                case 3:
                    defaultMode = false;

                    ListingActivity lA1 = new ListingActivity();

                    lA1.DisplayStartMessage();
                    lA1.DisplayDescription();
                    lA1.SetUserTimeSession();
                    lA1.DisplayPromptQuestions(); 

                    break;
                case 4:
                    defaultMode = false;
                    Console.WriteLine("Thank you for using this program");
                    
                    break;
                default:
                    defaultMode = true;
                    for (int i = 0; i < 3; i++)
                    {
                      Console.WriteLine("The entered character isn't found among the options. Try again: ");
                      menuOption = int.Parse(Console.ReadLine());  

                      if (menuOption >0 && menuOption < 4)
                      {
                        break;
                      }

                      if(i==2)
                      {
                        Console.WriteLine("Sorry, your attempts have been exhausted.");
                      }
                    }
                    break;
            }

        } while (menuOption >0 && menuOption < 4);

    }
}