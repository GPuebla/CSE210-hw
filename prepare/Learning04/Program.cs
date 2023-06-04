using System;

class Program
{
    static void Main(string[] args)
    {

        MathAssigment mA1 = new MathAssigment("Roberto Rodriguez","Fractions","7.3","8-19");
        WritingAssigment wA1 = new WritingAssigment("Mary Waters","European History","The Causes of World War II");

        Console.WriteLine(mA1.GetSummary());
        Console.WriteLine(mA1.GetHomeworkList());
        Console.WriteLine("--------------------------");
        Console.WriteLine(wA1.GetSummary());
        Console.WriteLine(wA1.GetWritinglnformation());


    }
}