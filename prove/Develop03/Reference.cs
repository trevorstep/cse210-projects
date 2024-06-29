class Reference
{
    private string Book { get; set; }
    private int Chapter { get; set; }
    private int VerseStart { get; set; }
    private int VerseEnd { get; set; }
    
    public Reference()
    {

    }

    public Reference (string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        VerseStart = verse;
        VerseEnd = verse;  

    }

    public Reference (string book, int chapter, int verse1, int verse2End)
    {
        Book = book;
        Chapter = chapter;
        VerseStart = verse1;
        VerseEnd = verse2End;
    }

    public override string ToString()
{
    if (VerseStart == VerseEnd)
    {
        return $"{Book} {Chapter}:{VerseStart}";
    }
    else
    {
        return $"{Book} {Chapter}:{VerseStart}-{VerseEnd}";
    }
    // Chatgpt wrote the method,for public override string ToString() One thing im still trying to understand is why it prefers this method over just using your average method otherwise I understand this code.
}
}