class Scripture
{
    public static List<Scripture> scriptureList = new List<Scripture> 
    {
        new Scripture("And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true."),
        new Scripture("I can do all things through Christ which strengtheneth me."),
        new Scripture("The Lord is my shepherd; I shall not want."),
        new Scripture("11 And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people. 12 And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities. 13 Now the Spirit knoweth all things; nevertheless the Son of God suffereth according to the flesh that he might take upon him the sins of his people, that he might blot out their transgressions according to the power of his deliverance; and now behold, this is the testimony which is in me.")

    };
        


    public Scripture (string VerseToPass) 
    {

    }

    public static Scripture GetScriptureByIndex(int index)
    {
        if (index >= 0 && index < scriptureList.Count)
        {
            return scriptureList[index];
        }
        else
        {
            throw new IndexOutOfRangeException("Invalid index");
        }
    }

}

