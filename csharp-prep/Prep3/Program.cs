using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------------------------- Find the magic number --------------------------");
        string result= "";

        Console.Write("What is the magic number? ");
        int magic_number = int.Parse(Console.ReadLine());
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
            }

        Console.WriteLine($"{result}");
    
    }
}