namespace ConsoleConverterUSDToBGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The code converts US dollars to Bulgarian leva. 
            // The fixed rate between dollar and lev is 1 USD = 1.79549 BGN.
            // Example - Input: 22, Output: 39.50078

            const double multiplier = 1.79549;
            double sumInDollars = double.Parse(Console.ReadLine());
            double sumInLeva = sumInDollars * multiplier;
            Console.WriteLine(sumInLeva);
        }
    }
}