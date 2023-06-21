using System;

public class SimpleGoal:Goal
{
    public string exampleName;

    public SimpleGoal(String goalName, String goalDescription, int valueOfPoints) : base (goalName, goalDescription, valueOfPoints)
    {
       
    }

    public override String ConcatenateAttribute()
    {
        String text = $"{GetGoalName()}:Simple, {GetGoalDescription()}, {GetValueOfPoints()}, {GetIsAchieved()}";
        SetConcatenatedAttribute(text);
        return text;
    }

    public override void IncreaseScore()
    {

    }
}