using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.WriteLine();

        List<Scripture> scriptures = new List<Scripture>() {
            
            new Scripture(new Reference("Joshua", 1, 9), "Have not I commanded thee? Be strong and of a good courage; be not afraid, neither be thou dismayed: for the Lord thy God is with thee whithersoever thou goest."),
            new Scripture(new Reference("3 Nephi", 11, 9, 10), "And it came to pass that he stretched forth his hand and spake unto the people, saying: Behold, I am Jesus Christ, whom the prophets testified shall come into the world."),
            new Scripture(new Reference("Mosiah", 3, 19), "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father."),

        };

        Random random = new Random();
        int randomIndex = random.Next(scriptures.Count);
        Scripture selectedScripture = scriptures[randomIndex];

        Console.WriteLine(selectedScripture.GetDisplayText());
        Console.WriteLine();

        Console.WriteLine("Press ENTER to continue. Type QUIT to finish");
        string choice = Console.ReadLine();

        while (choice.ToLower() != "quit") {

            if (choice == "") {

                selectedScripture.HideRandomWords(1);

                Console.WriteLine(selectedScripture.GetDisplayText());
                Console.WriteLine();

                if (selectedScripture.IsCompletelyHidden()) {
                    break;
                }

                Console.WriteLine("Press ENTER to continue. Type QUIT to finish");
                choice = Console.ReadLine();

            }
        }

        Console.WriteLine("Thanks! Goodbye!");
    }
}