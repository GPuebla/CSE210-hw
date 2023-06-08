using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {

        bool defaultMode = false; 
        int menuOption = 0;

        DataSet d1 = new DataSet();
        List<String> listOfReferences = new List<string>();
        listOfReferences = d1.GetListOfReferences();  

        List<String> verses = new List<string>();
        String reference = "";

        List<String> newVerses = new List<string>();
        
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
                    d1.ReadCSV();

                    listOfReferences.Clear();
                    listOfReferences = d1.GetListOfReferences();    

                    Console.WriteLine("Select one of the references saved: ");
                    

                    for (int i = 0; i < listOfReferences.Count(); i++)
                    {
                        Console.WriteLine($"{i+1}. {listOfReferences[i]}");
                    }
                
                    int ansewer1 = int.Parse(Console.ReadLine());

                    reference = listOfReferences[ansewer1-1];
                    verses = d1.GetSpecificVerses(reference);

                    Console.Clear();
                    ShowScripture(new Scripture(reference,verses));                 

                    break;
                case 2:
                    defaultMode = false;

                    listOfReferences.Clear();
                    listOfReferences = d1.GetListOfReferences();  

                    Console.WriteLine("Please enter a reference e.g. 'Proverbs 3:5-6'");
                    String newReference = Console.ReadLine();

                    Reference r1 = new Reference(newReference);

                    String newReferenceText = r1.FullReferenceText;
                    
                    for (int i = 0; i < r1.Verses.Count(); i++)
                    {
                        Console.Write($"Please insert the verse {r1.Verses[i]}: ");
                        String numVer = r1.Verses[i].ToString();
                        d1.AddScripture(newReferenceText,numVer,Console.ReadLine());
                    }

                    Console.WriteLine($"You can now memorize {newReferenceText}, it was saved.");
                    d1.WriteCSV();
                    
                    break;
                case 3:
                    defaultMode = false;

                    listOfReferences.Clear();
                    listOfReferences = d1.GetListOfReferences();

                    Console.WriteLine("Select the references that you want delete: ");

                    for (int i = 0; i < listOfReferences.Count(); i++)
                    {
                        Console.WriteLine($"{i+1}. {listOfReferences[i]}");
                    }

                    int x = int.Parse(Console.ReadLine());

                    String refer = listOfReferences[x-1];
                    Console.WriteLine($"Are you sure you want to remove {refer}? y/n");
                    String ansewer2 = Console.ReadLine();
                    
                    if(ansewer2 == "y" || ansewer2 == "Y")
                    {
                        d1.DeleteScripture(refer);
                    }
                    

                    d1.ReadCSV();
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

        static void ShowScripture(Scripture s)
        {
            while (!s.IsAllVersesHidden)
            {
                Console.WriteLine($"{s.GetVerses()}");

                String answer = Console.ReadLine();
                    if(answer == "quit")
                    {
                        break;
                    }
                Console.Clear();
            }
        }

    }
}