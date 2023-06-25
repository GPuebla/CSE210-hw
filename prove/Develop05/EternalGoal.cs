public class EternalGoal:Goal
{
    public EternalGoal(String goalName, String goalDescription, int valueOfPoints, bool isAchieved = false, int score = 0) : base (goalName, goalDescription, valueOfPoints)
    {
        _isAchieved = isAchieved;
        _score = score;
    }

    public override String ConcatenateAttribute()
    {
        String text = $"EternalGoal**{GetGoalName()}**{GetGoalDescription()}**{GetValueOfPoints()}**{GetIsAchieved()}**{GetScore()}";
        SetConcatenatedAttribute(text);
        return text;
    }

    public override void IncreaseScore()
    {
        SetScore(GetValueOfPoints());
    }
}