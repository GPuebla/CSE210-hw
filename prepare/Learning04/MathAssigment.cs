public class MathAssigment:Assigment
{
    private String _textbookSection = "";
    private String _problems = "";

    public MathAssigment( string studentName, string topic, String textbookSection, String problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public String GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}