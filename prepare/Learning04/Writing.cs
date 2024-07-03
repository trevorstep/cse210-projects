public class WritingAssignment : Assignment
{
    // Private string for writing assignment titles.
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studentNames = GetStudentName();

        return $"{_title} by {studentNames}";
    }
}