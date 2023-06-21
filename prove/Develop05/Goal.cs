using System;

public abstract class Goal
{
    private String _goalName{get; set;}
    private String _goalDescription;
    private bool _isAchieved;
    private int _score;
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
        text = _concatenatedAttribute;
    }


    public abstract String ConcatenateAttribute();
    public abstract void IncreaseScore();
    
}
