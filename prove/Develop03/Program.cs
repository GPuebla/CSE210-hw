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
                Console.WriteLine(" -------------------------------------- Scripture Memorizer Menu -------------------------------------- ");
                Console.WriteLine("\n1) Memorize stored reference. \n2) Save new reference. \n3) Delete stored reference. \n4) Exit.");
                Console.Write(" \n Please, select the option number that you want: ");
                menuOption = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------------------------------------------------------------------");
            }
            
            switch (menuOption)
            {
                case 1:
                    defaultMode = false;

                    Console.WriteLine("Option 1");

                    break;
                case 2:
                    defaultMode = false;

                    Console.WriteLine("Option 2");
                    
                    break;
                case 3:
                    defaultMode = false;

                    Console.WriteLine("Option 3");
                    
                    break;
                case 4:
                    defaultMode = false;
                    Console.WriteLine("Thank you for using the Memorizer scripture program, hope to see you again.\n");
                    
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

        // ------------------------------------------------------------------------------------------------------

        // ShowScripture(new Verse("1 Nephi 3:7","And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."));
        // ShowScripture(new Verse("Proverbs 3:5-6","Trust in the Lord with all thine heart; and lean not unto thine own dunderstanding. In all thy ways acknowledge him, and he shall bdirect thy cpaths."));

        static void ShowScripture(Verse v)
        {
            do
            {
                Console.WriteLine($"{v.Reference.FullReferenceText} -> {v.WriteVerse()}");

                String answer = Console.ReadLine();
                    if(answer == "quit")
                    {
                        break;
                    }
                Console.Clear();
                
            } while (!v.IsAllHidden);
        }

    }
}