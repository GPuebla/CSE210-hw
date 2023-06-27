public class CheckListGoal:Goal
{
    private int _achievedBonus;
    private int _timesToAcomplish;
    private int _timesAchieved;


    public CheckListGoal(String goalName, String goalDescription, int valueOfPoints, int achievedBonus, int timesToAcomplish, int timesAchieved = 0,bool isAchieved = false, int score = 0) : base (goalName, goalDescription, valueOfPoints)
    {
        _achievedBonus = achievedBonus;
        _timesToAcomplish = timesToAcomplish;
        _timesAchieved = timesAchieved;
        _isAchieved = isAchieved;
        _score = score;
        SetTypeOfGoal("checklist");
        CheckAcomplishment();
        ConcatenateAttribute();
    }



    public override String ConcatenateAttribute()
    {
        String text = $"CheckListGoal**{GetGoalName()}**{GetGoalDescription()}**{GetValueOfPoints()}**{_achievedBonus}**{_timesToAcomplish}**{_timesAchieved}**{GetIsAchieved()}**{GetScore()}";
        SetConcatenatedAttribute(text);
        return text;
    }

    public override void IncreaseScore()
    {
        SetScore(GetValueOfPoints());
        _timesAchieved++;
        CheckAcomplishment();
        CheckIfIsAcomplished();
    }

    private void CheckAcomplishment()
    {
        if(_timesAchieved == _timesToAcomplish)
        {
            _isAchieved = true;
            SetScore(_achievedBonus);
        }
    }

      public override String GetInfo()
    {
        return $"{GetCheckBox()} {GetGoalName()} ({GetGoalDescription()}) -- Currently completed {_timesAchieved}/{_timesToAcomplish}.";
    }

  
}