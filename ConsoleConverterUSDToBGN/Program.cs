namespace ConsoleConverterUSDToBGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double multiplier = 1.79549;
            double sumInDollars = double.Parse(Console.ReadLine());
            double sumInLeva = sumInDollars * multiplier;
            Console.WriteLine(sumInLeva);
        }
    }
}