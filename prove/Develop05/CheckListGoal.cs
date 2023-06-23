public class CheckListGoal:Goal
{
    private int _achievedBonus;
    private int _timesToAcomplish;
    private int _timesAchieved;

    public CheckListGoal(String goalName, String goalDescription, int valueOfPoints, int achievedBonus, int timesToAcomplish ) : base (goalName, goalDescription, valueOfPoints)
    {
        _achievedBonus = achievedBonus;
        _timesToAcomplish = timesToAcomplish;
        CheckAcomplishment();
    }

    public CheckListGoal(String goalName, String goalDescription, int valueOfPoints, int achievedBonus, int timesToAcomplish, int timesAchieved = 0) : base (goalName, goalDescription, valueOfPoints)
    {
        _achievedBonus = achievedBonus;
        _timesToAcomplish = timesToAcomplish;
        _timesAchieved = timesAchieved;
        CheckAcomplishment();
    }



    public override String ConcatenateAttribute()
    {
        String text = $"CheckListGoal**{GetGoalName()}**{GetGoalDescription()}**{GetValueOfPoints()}**{_achievedBonus}**{_timesToAcomplish}**{GetIsAchieved()}";
        SetConcatenatedAttribute(text);
        return text;
    }

    public override void IncreaseScore()
    {
        SetScore(GetValueOfPoints());
        CheckAcomplishment();
    }

    private void CheckAcomplishment()
    {
        if(_timesAchieved == _timesToAcomplish)
        {
            _isAchieved = true;
            SetScore(_achievedBonus);
        }
    }
}