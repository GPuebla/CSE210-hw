using System;

public class SimpleGoal:Goal
{
    public SimpleGoal(String goalName, String goalDescription, int valueOfPoints) : base (goalName, goalDescription, valueOfPoints)
    {
       
    }

    public override String ConcatenateAttribute()
    {
        String text = $"SimpleGoal**{GetGoalName()}**{GetGoalDescription()}**{GetValueOfPoints()}**{GetIsAchieved()}";
        SetConcatenatedAttribute(text);
        return text;
    }

    public override void IncreaseScore()
    {
        SetScore(GetValueOfPoints());
        _isAchieved = true;
    }
}