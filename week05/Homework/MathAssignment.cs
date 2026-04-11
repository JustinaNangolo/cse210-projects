public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // The constructor takes 4 arguments, but sends 2 of them to the parent (Assignment)
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}