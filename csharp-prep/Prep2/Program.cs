using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Letter Grade Calculator");
        Console.Write("Please, enter your grade percentage:");
        String gradePorcentage = Console.ReadLine();
        float grade = float.Parse(gradePorcentage);

        if (grade>=90)
        {
            Console.WriteLine("Your grade is: A");
        }
        else if (grade>=80)
        {
            Console.WriteLine("Your grade is: B");
        }
        else if (grade>=70)
        {
            Console.WriteLine("Your grade is: C");
        }
        else if (grade>=60)
        {
            Console.WriteLine("Your grade is: D");
        }
        else
        {
            Console.WriteLine("Your grade is: F");
        }
    }
}