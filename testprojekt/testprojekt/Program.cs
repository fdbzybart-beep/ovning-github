internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== UTFLYKTSKALKYLATOR ===");

        Console.Write("Hur många personer ska följa med? ");
        int antal = Convert.ToInt32(Console.ReadLine());

        Console.Write("Vad kostar resan per person? ");
        int resa = Convert.ToInt32(Console.ReadLine());

        Console.Write("Vad kostar maten per person? ");
        int mat = Convert.ToInt32(Console.ReadLine());

        // Räknar ut kostnaden för en person.
        int kostnadPerPerson = resa + mat;

        // Räknar ut kostnaden för hela gruppen.
        int totalKostnad = kostnadPerPerson * antal;

        Console.WriteLine();
        Console.WriteLine("Kostnad per person: " + kostnadPerPerson + " kr");
        Console.WriteLine("Total kostnad: " + totalKostnad + " kr");
    }
}