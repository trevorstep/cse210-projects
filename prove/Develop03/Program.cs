class Program
{
    static void Main(string[] args)
    {
        int number = 5;
        int response;
        int x =0;

        List<string> scriptureList = new List<string>
        {
            "And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.",
            "I can do all things through Christ which strengtheneth me.",
            "The Lord is my shepherd; I shall not want.",
            "11 And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people. 12 And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities. 13 Now the Spirit knoweth all things; nevertheless the Son of God suffereth according to the flesh that he might take upon him the sins of his people, that he might blot out their transgressions according to the power of his deliverance; and now behold, this is the testimony which is in me."
        };

         new Scripture(scriptureList);

        do
        {
            Console.WriteLine("Please select what scripture you would like to memorize. [Choose a number from 1-5 to select]:");
            Console.WriteLine("1. Alma 32:21");
            Console.WriteLine("2. Philippians 4:13");
            Console.WriteLine("3. Psalm 23:1");
            Console.WriteLine("4. Alma 7:11-13");
            Console.WriteLine("5. Quit");

            string responseAsStrng = Console.ReadLine();
            response = int.Parse(responseAsStrng);

            if (response == 1)
            { 
                Reference reference = new Reference("Alma", 32, 21);
                string newReference = reference.ToString();
                string newsScripture = Scripture.scriptureList[0];
                Scripture scripture = new Scripture (newReference,newsScripture,x );
                string FullScripture = scripture.ToString();

            }
            else if (response == 2)
            {
                Reference reference = new Reference("Philippians", 4, 13);
                Console.WriteLine(reference.ToString());
                Console.WriteLine($"Selected Scripture: {Scripture.scriptureList[1]}");
            }
            else if (response == 3)
            {
                Reference reference = new Reference("Psalm", 23, 1);
                Console.WriteLine(reference.ToString());
                Console.WriteLine($"Selected Scripture: {Scripture.scriptureList[2]}");
            }
            else if (response == 4)
            {
                Reference reference = new Reference("Alma", 7, 11, 13);
                Console.WriteLine(reference.ToString());
                Console.WriteLine($"Selected Scripture: {Scripture.scriptureList[3]}");
            }

        } while (response != number);
    }
}