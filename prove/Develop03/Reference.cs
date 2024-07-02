class Reference
{
    private string Book { get; set; }
    private int Chapter { get; set; }
    private int VerseStart { get; set; }
    private int VerseEnd { get; set; }

    public Reference()
    {

    }

    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        VerseStart = verse;
        VerseEnd = verse;

    }

    public Reference(string book, int chapter, int verse1, int verse2End)
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

    }
}