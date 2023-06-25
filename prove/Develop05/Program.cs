using System;

class Program
{
    static void Main(string[] args)
    {
        int totalScore = 0;
        SimpleGoal sGoal1 = new SimpleGoal("Simple Goal Example 1","This goal, is just an example",30);
        EternalGoal eGoal1 = new EternalGoal("Eternal Goal Example 1","This goal, is just an example",15);
        CheckListGoal cGoal1 = new CheckListGoal("CheckList Goal Example 1","This goal, is just an example",50,500,5);

        List<Goal> goals = new List<Goal>();
        goals.Add(sGoal1);
        goals.Add(eGoal1);
        goals.Add(cGoal1);

        // sGoal1.IncreaseScore();
        // sGoal1.IncreaseScore();
        // sGoal1.IncreaseScore();

        for (int i = 0; i < 5; i++)
        {
            foreach (var goal in goals)
            {
                DisplayGoals(goal);
            } 
        }

        foreach (var goal in goals)
        {
            totalScore += goal.GetScore();
        }

        Console.WriteLine($"TOTAL SCORE: {totalScore}");


        // Console.WriteLine(sGoal1.ConcatenateAttribute());
        // Console.WriteLine($"Score: {sGoal1.GetScore()}");

    }

    public static void DisplayGoals(Goal g)
    {
        g.IncreaseScore();
        Console.WriteLine($"{g.ConcatenateAttribute()} // Score: {g.GetScore()}");
        Console.WriteLine("----------------------------------------------------------------------------\n");
    }
}