using System;

class Program
{
    static void Main(string[] args)
    {
        string latterGrade;

        Console.WriteLine("Letter Grade Calculator");
        Console.Write("Please, enter your grade percentage:");
        String gradePorcentage = Console.ReadLine();
        float grade = float.Parse(gradePorcentage);

        if (grade>=90)
        {
            latterGrade = "A";
        }
        else if (grade>=80)
        {
            latterGrade = "B";
        }
        else if (grade>=70)
        {
            latterGrade = "C";
        }
        else if (grade>=60)
        {
            latterGrade = "E";
        }
        else
        {
            latterGrade = "F";
        }

        Console.WriteLine($"Your grade is: {latterGrade}");
    }
}