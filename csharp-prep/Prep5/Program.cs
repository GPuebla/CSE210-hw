using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" ---------------------------- Functions ---------------------------- ");

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int sqrNumber = SquareNumber(userNumber);

        DisplayResult(userName, sqrNumber);


    }


    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNum = int.Parse(Console.ReadLine());
        return userNum;
    }

    static int SquareNumber(int num)
    {
        int sqrNum = num * num;
        return sqrNum;
    }

    static void DisplayResult( string name, int sqrNum)
    {
        Console.WriteLine( name + ", the square of your number is "+ sqrNum);
    }
}