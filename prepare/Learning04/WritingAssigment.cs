public class WritingAssigment : Assigment
{ 
    private String _title = "";

    public WritingAssigment(String studentName, String topic, String title): base(studentName, topic)
    {
        _title = title;
    }

    public String GetWritinglnformation()
    {
        return $"{_title} by {base._studentName}";
    }
}