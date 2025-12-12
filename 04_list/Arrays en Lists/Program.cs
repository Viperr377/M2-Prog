namespace Arrays_en_Lists;

class Program
{
    static void Main(string[] args)
    {
        Run();
    }
    static void Run()
    {
        string[] characters =
        {
            "Pac-Man",
            "Samus",
            "Crash Bandicoot",
            "Spyro the Dragon",
            "Donkey Kong",
            "Mario",
            "Luigi",
            "Astro",
            "Solid Snake",
            "Master Chief",
            "Kratos",
            "Sonic the Hedgehog",
            "Link"
        };

        List<string> characterList = new List<string>();
        characterList.Add("Witcher Geralt");

        for (int i = 0; i < characters.Length; i++)
        {
            characterList.Add(characters[i]);
        }

        foreach (string character in characterList)
        {
            Console.WriteLine(character);
        }
    }
}
