using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------------------------- Find the magic number --------------------------");
        string result= "";
        bool guessedIt = false;

        Console.Write("What is the magic number? ");
        int magic_number = int.Parse(Console.ReadLine());

        do
        {
            Console.Write("What is your guess? ");
            int userGuess =  int.Parse(Console.ReadLine());

            if(magic_number < userGuess)
            {
                result = "Lower";
            }
            else if(magic_number > userGuess)
            {
                result = "Higher";
            }
            else if(magic_number == userGuess)
            {
                result = "You guessed it!";
                guessedIt = true;
            }

            Console.WriteLine($"{result}");

        } while (!guessedIt);

    
    }
}