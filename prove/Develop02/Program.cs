using System;

class Program
{
    static void Main(string[] args)
    {
        // PromptGenerator pg = new PromptGenerator();
        // String prompt = pg.randomlyChoosePrompt();
        // Console.WriteLine(prompt);

        // Entry ent1 = new Entry();
        // String prompt = ent1._prompt;
        // Console.WriteLine(prompt);
        // ent1.displayEntry();
        bool isPlay = true;
        Journal journal1 = new Journal();

        do
        {
            Entry newEntry = new Entry();
            Console.WriteLine(newEntry._prompt);
            newEntry._response = Console.ReadLine();

            journal1.addingNewEntry(newEntry);
            
            Console.WriteLine("Would you add more information? Y/N");
            String userChoose = Console.ReadLine();
            
            if (userChoose == "N")
            {
                isPlay = false;
            }
        } while (isPlay);

        journal1.displayAllEntries();

        Console.WriteLine("Please, enter the filename to saving the infomation: ");
        String userFileName = Console.ReadLine();

        journal1.savingFile(userFileName);

    }
}