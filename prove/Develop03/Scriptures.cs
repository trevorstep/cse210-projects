class Scripture
{
    private Reference _reference;
    private List<Word> _scriptureText;


    public Scripture()
    {

    }

    public Scripture(Reference reference, string scripture)
    {
        _scriptureText = new List<Word>();
        _reference = reference;
        foreach (string w in scripture.Split(" "))
        {
            Word tempWord = new Word(w);
            _scriptureText.Add(tempWord);
        }
    }

    public void DisplayScripture()
    {
        Console.WriteLine(_reference.ToString());
        foreach (Word w in _scriptureText)
        {
            Console.Write(w.GetWord());
            Console.Write(" ");
        }
    }
    public void HideWords()
    {
        Random random = new Random();
        int hiddenCount = 0;

        // Count the number of non-hidden words remaining
        int nonHiddenWords = _scriptureText.Count(word => !word.IsHidden());

        // If there are fewer than 3 non-hidden words left, hide them all
        if (nonHiddenWords <= 3)
        {
            foreach (var word in _scriptureText)
            {
                if (!word.IsHidden())
                {
                    word.HideWord(true);
                    hiddenCount++;
                }
            }
        }
        else
        {
            while (hiddenCount < 3)
            {
                int index = random.Next(0, _scriptureText.Count);

                if (!_scriptureText[index].IsHidden())
                {
                    _scriptureText[index].HideWord(true);
                    hiddenCount++;
                }
            }
        }
    }


    public bool EverythinHidden()
    {
        foreach (Word w in _scriptureText)
        {
            if (!w.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

}
