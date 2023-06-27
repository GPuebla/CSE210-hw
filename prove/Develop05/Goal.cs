using System;

public abstract class Goal
{
    private String _goalName;
    private String _goalDescription;
    protected bool _isAchieved;
    protected int _score;
    private String _typeOfGoal;
    private int _valueOfPoints;
    private String _concatenatedAttribute;
    private String _checkBox = "[ ]";

    public Goal(){}

    public Goal(String goalName, String goalDescription, int valueOfPoints)
    {
        _goalName  = goalName;
        _goalDescription = goalDescription;
        _valueOfPoints = valueOfPoints;
        _isAchieved = false;
        _score = 0;

        ConcatenateAttribute();
    }

    public String GetGoalName()
    {
        return _goalName;
    }

    public void SetGoalName( String goalName)
    {
        _goalName = goalName;
    }

    public String GetGoalDescription()
    {
        return _goalDescription;
    }

    public void SetGoalDescription( String goalDescription)
    {
        _goalDescription = goalDescription;
    }

    public int GetScore()
    {
        return _score;
    }
    public void SetScore(int points)
    {
        _score += points;
    }
    public int GetValueOfPoints()
    {
        return _valueOfPoints;
    }
    public bool GetIsAchieved()
    {
       return _isAchieved;
    }

    public String GetCheckBox()
    {
        return _checkBox;
    }

    public void SetConcatenatedAttribute( String text)
    {
         _concatenatedAttribute = text;
    }

    public String GetTypeOfGoal()
    {
        return _typeOfGoal;
    }
    protected void SetTypeOfGoal(String typeOfGoal)
    {
        _typeOfGoal = typeOfGoal;
    }

    public virtual String GetInfo()
    {
        return $"{_checkBox} {_goalName} ({_goalDescription}";
    }

    public abstract String ConcatenateAttribute();
    public abstract void IncreaseScore();

    private void CheckIfIsAcomplished()
    {
        if(_isAchieved)
        {
            _checkBox = "[X]";
        }
    }
    
}
