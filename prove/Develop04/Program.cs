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
                Console.WriteLine(" -------------------------------------- Menu -------------------------------------- ");
                Console.WriteLine("\n1) Option 1 \n2) Option 2. \n3) Option 3. \n4) Exit.");
                Console.Write(" \n Please, select the option number that you want: ");
                menuOption = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------------------------------------------------------------------");
            }
            
            switch (menuOption)
            {
                case 1:
                    defaultMode = false;  

                    Console.WriteLine("option1");

                     BreathingActivity bA1 = new BreathingActivity();

                    bA1.DisplayStartMessage();
                    bA1.DisplayDescription();
                    bA1.SetUserTimeSession();
                    bA1.ShownBreathingMessages();
                    bA1.DisplayFinalMessage();            

                    break;
                case 2:
                    defaultMode = false;

                    Console.WriteLine("option2");  

                    
                    ReflectionActivity rA1 = new ReflectionActivity();
                    
                    rA1.DisplayPrompt();
                    Console.ReadLine();
                    Console.WriteLine("\nNow poder on each of the following questions as they related to this experience. \nYou may begin in: ");
                    rA1.ShowCountdown(5);

                    for (int i = 0; i < 3; i++)
                    {
                    rA1.DisplayReflectQuestion(); 
                    }
                    
                    break;
                case 3:
                    defaultMode = false;

                    Console.WriteLine("option3"); 

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