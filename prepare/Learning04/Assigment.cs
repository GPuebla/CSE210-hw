using System;

public class Assigment
{
    protected String _studentName = "";
    protected String _topic = "";

    public Assigment( String studentName, String topic)
    {
        this._studentName = studentName;
        this._topic = topic;
    }

    public String GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}