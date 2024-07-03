class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public void HideWord (bool hidden)
    {
        _hidden = hidden;
    }

    public bool IsHidden ()
    {
        return _hidden;
    }

    public string GetWord()
    {
        if (!_hidden)
        {
            return _word;
        }
        else
        {
            string tempString = "";
            for (int i = 0; i < _word.Length; i++)
            {
                tempString += "_";

            }
            return tempString;
        }
// set to true 

    }


}