using System;

class Program
{
    static void Main(string[] args)
    {
        
        SimpleGoal sGoal1 = new SimpleGoal("Simple Goal Example 1","This goal, is just an example",30);
        EternalGoal eGoal1 = new EternalGoal("Eternal Goal Example 1","This goal, is just an example",15);
        CheckListGoal cGoal1 = new CheckListGoal("CheckList Goal Example 1","This goal, is just an example",50,500,5);

        sGoal1.IncreaseScore();
        sGoal1.IncreaseScore();
        sGoal1.IncreaseScore();



        Console.WriteLine(sGoal1.ConcatenateAttribute());
        Console.WriteLine($"Score: {sGoal1.GetScore()}");

    }
}