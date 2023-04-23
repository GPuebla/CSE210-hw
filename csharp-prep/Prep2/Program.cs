using System;

class Program
{
    static void Main(string[] args)
    {
        string latterGrade;
        bool isApproved = false;

        Console.WriteLine("Letter Grade Calculator");
        Console.Write("Please, enter your grade percentage:");
        String gradePorcentage = Console.ReadLine();
        float grade = float.Parse(gradePorcentage);

        if (grade>=90)
        {
            latterGrade = "A";
            isApproved = true;
        }
        else if (grade>=80)
        {
            latterGrade = "B";
            isApproved = true;
        }
        else if (grade>=70)
        {
            latterGrade = "C";
            isApproved = true;
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

        if (isApproved)
        {
            Console.WriteLine("Congratulations, you have passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you can't advance to the next class, but try again, I'm sure you'll do better!");
        }


    }
}