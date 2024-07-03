using System.Dynamic;

public class Assignment
{
    private string _studentName = "";
    private string _topic = "";

    // Basic constructor.
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Gets student names and topic ( accesses them.)
    #region 
    public string GetStudentName()
    {

        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }
    #endregion

    // This Method concatnates the student name and the topic togther, very handy for all parent and child functions
    public string GetSummary()
    {
        return _studentName + "-" + _topic;
    }



}