class Scripture
{

    public Scripture()
    {

    }

    public Scripture(string reference, string scriputre)
    {
        string References = reference;
        string Scriptures = scriputre;
    }

    public Scripture (string reference, string scripture, int x)
    {
        return $"{reference}: {scripture}";
    }


    public static List<string> scriptureList;

    public Scripture(List<string> scriptures)
    {
        scriptureList = scriptures;
    }
    // ChatGPT wrote assisted in passing the List value in as a parameter. Lists are still slightly confusing to me but im getting there.
}
