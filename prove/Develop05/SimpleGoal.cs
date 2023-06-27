using System;

public class SimpleGoal:Goal
{
    public SimpleGoal(String goalName, String goalDescription, int valueOfPoints, bool isAchieved = false, int score = 0) : base (goalName, goalDescription, valueOfPoints)
    {
       _isAchieved = isAchieved;
       _score = score;
       SetTypeOfGoal("simple");
       ConcatenateAttribute();
    }

    public override String ConcatenateAttribute()
    {
        String text = $"SimpleGoal**{GetGoalName()}**{GetGoalDescription()}**{GetValueOfPoints()}**{GetIsAchieved()}**{GetScore()}";
        SetConcatenatedAttribute(text);
        return text;
    }

    public override void IncreaseScore()
    {
        if(!_isAchieved)
        {
            SetScore(GetValueOfPoints());
            _isAchieved = true;
        }
    }
      
}