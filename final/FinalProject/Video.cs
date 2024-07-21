class Video
{
    private string _title;
    private string _author;
    private int _videoLengthInSeconds;
    private List<Comment> _comments;

    public Video(string title, string author, int videoLengthInSeconds)
    {
        _title = title;
        _author = author;
        _videoLengthInSeconds = videoLengthInSeconds;
        _comments = new List<Comment>();
    }
    public string Title
    {
        get { return _title; }
    }
    public string Author
    {
        get { return _author; }
    }

    public int VideoLengthInSeconds
    {
        get { return _videoLengthInSeconds; }
    }

#region 
// Chat GPT helped me with these since I couldnt figure out how to access my data types.
    public void AddComment(Comment comment){
        _comments.Add(comment);
    }
    public List<Comment> GetComments(){
        return new List<Comment>(_comments);
    }
#endregion

    public int GetNumberOfComments()
    {
        return _comments.Count;

    }

}