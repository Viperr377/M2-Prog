namespace Forherhaling;

class Program
{
    static void Main(string[] args)
    {
        Run();
    }
    static void Run()
    {
        double[] prijzen = { 2.5, 3.0, 4.75, 1.25, 5.0 };
        string[] artikelen = { "Brood", "Melk", "Kaas", "Boter", "Eieren" };
        Formulier[] formulieren = new Formulier[2];
        formulieren[0] = new Formulier();
        formulieren[0].naam = "Formulier 1";
        formulieren[0].review = "Goed";

        formulieren[1] = new Formulier();
        formulieren[1].naam = "Formulier 2";
        formulieren[1].review = "Slecht";

        for (int i = 0; i < prijzen.Length; i++)
        {
            Console.WriteLine ("Prijs: " + prijzen[i]);
            Console.WriteLine ("Artikel: " + artikelen[i]);
        }
            prijzen = new double[] { 2.5, 3.0, 4.75, 1.25, 5.0, 6.0 };

            artikelen = new string[] { "Brood", "Melk", "Kaas", "Boter", "Eieren", "Yoghurt" };

            foreach (Formulier f in formulieren)
            {
                Console.WriteLine("Naam: " + f.naam);
                Console.WriteLine("Review: " + f.review);
            }
        
    }
}
