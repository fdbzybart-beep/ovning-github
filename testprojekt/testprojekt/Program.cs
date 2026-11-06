internal class Program
{
    private static void Main(string[] args)
    {
        bool loopactive = true; 
        while (loopactive == true) 
        {
            Console.WriteLine("=== UTFLYKTSKALKYLATOR ===");
            Console.WriteLine("vad är din budget");
            int budget = Convert.ToInt32(Console.ReadLine());        //kollar budgeten
            Console.Write("Hur många personer ska följa med? ");
            int antal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Vad kostar resan per person? ");     //kollar kostnaden för resa per person
            int resa = Convert.ToInt32(Console.ReadLine());

            Console.Write("Vad kostar maten per person? ");     //kollar matten per person
            int mat = Convert.ToInt32(Console.ReadLine());

            // Räknar ut kostnaden för en person.
            int kostnadPerPerson = resa + mat;

            // Räknar ut kostnaden för hela gruppen.
            int totalKostnad = kostnadPerPerson * antal;

            Console.WriteLine();
            Console.WriteLine("Kostnad per person: " + kostnadPerPerson + " kr");
            Console.WriteLine("Total kostnad: " + totalKostnad + " kr");
            if (budget < totalKostnad)     // kollar om de har råd beroende på budgeten
            {
                Console.WriteLine($"ni har inte råd, det fattas {budget - totalKostnad}kr");
            }
            else
            {
                Console.WriteLine($"ni har  råd");
            }
            Console.WriteLine("vill du avsluta? \n1: ja \nvalfri tangent: nej ");     
            int sluta = Convert.ToInt32(Console.ReadLine());
            if (sluta == 1)
            {
                loopactive = false;
            }
            else
            {
                Console.Clear();
            }

        }
    }
       
}