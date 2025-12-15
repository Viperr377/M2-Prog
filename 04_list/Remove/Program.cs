namespace Remove;

class Program
{
    static void Main(string[] args)
    {
        Run();
    }
    static void Run()
    {
        List<double> prijzen = new List<double>
        {
            99, 145, 12, 75, 200
        };
        foreach (double prijs in prijzen)
        {
            Console.WriteLine(prijs);
        }
        prijzen.Remove(12);
    }
}
