using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");


        SimpleGoal sGoal1 = new SimpleGoal("Goal Example 1","This goal, is just an example",30);

        Console.WriteLine(sGoal1.ConcatenateAttribute());

    }
}