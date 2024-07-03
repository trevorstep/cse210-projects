public class MathAssignment : Assignment
{
    // Private attributes
    private string _textbookSection;
    private string _problems;

    // Use custom values within this constructor but also pass in the values of studentName and topic from the Assignments class.
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {

        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Sends back a string.
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
