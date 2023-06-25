using System;

class Program
{
    static void Main(string[] args)
    {
        int totalScore = 0;
        DataSet dataset = new DataSet();

        SimpleGoal sGoal1 = new SimpleGoal("Simple Goal Example 1","This goal, is just an example",30);
        EternalGoal eGoal1 = new EternalGoal("Eternal Goal Example 1","This goal, is just an example",15);
        CheckListGoal cGoal1 = new CheckListGoal("CheckList Goal Example 1","This goal, is just an example",50,500,5);

        List<Goal> goals = new List<Goal>();
        goals.Add(new SimpleGoal("Simple Goal Example 2","This goal, is just an example 2",50));
        // goals.Add(eGoal1);
        // goals.Add(cGoal1);

        Console.WriteLine($"Total de Goals: {dataset.GetGoalList().Count()}");

        dataset.ReadData("my_goal");

        goals.AddRange(dataset.GetGoalList());

        
        // dataset.AddGoal(sGoal1);
        // dataset.AddGoal(eGoal1);
        // dataset.AddGoal(cGoal1);

        Console.WriteLine($"Total de Goals: {dataset.GetGoalList().Count()}");

        foreach (var goal in dataset.GetGoalList())
        {
            Console.WriteLine($"{goal.ConcatenateAttribute()}");
        } 

        Console.WriteLine(dataset.GetScore());

        dataset.AddGoal(new SimpleGoal("Simple Goal Example 2","This goal, is just an example 2",50));

        dataset.SaveData();


    }
//         foreach (var goal in dataset.GetGoalList())
//         {
//             totalScore += goal.GetScore();
//             dataset.SetScore(totalScore);
//             DisplayGoals(goal);
//         }

//         Console.WriteLine($"TOTAL SCORE: {totalScore}");

//     //    dataset.SaveData();

//     }

//     public static void DisplayGoals(Goal g)
//     {
//         g.IncreaseScore();
//         Console.WriteLine($"{g.ConcatenateAttribute()} // Score: {g.GetScore()}");
//         Console.WriteLine("----------------------------------------------------------------------------\n");
//     }
}