public class EternalGoal:Goal
{
    public EternalGoal(String goalName, String goalDescription, int valueOfPoints) : base (goalName, goalDescription, valueOfPoints)
    {
       
    }

    public override String ConcatenateAttribute()
    {
        String text = $"EternalGoal**{GetGoalName()}**{GetGoalDescription()}**{GetValueOfPoints()}**{GetIsAchieved()}";
        SetConcatenatedAttribute(text);
        return text;
    }

    public override void IncreaseScore()
    {
        SetScore(GetValueOfPoints());
    }
}