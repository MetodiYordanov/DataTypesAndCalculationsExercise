namespace Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The program calculates liters of water needed tofill aquarium.
            // For input user enters length, width and height of the aquarium in cm
            // and also percentage of the aquarium that will be occupied by sand, plants, heater and pump.
            // User also knows that one liter equals one cubic decimeter (1l = 1dm3).
            // Example - Input: length = 85, width = 75, height = 47, percentage = 17
            // Output: 248.69

            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            int volumeOfAquarium = length * width * height;
            double volumeInLiters = volumeOfAquarium * 0.001;
            decimal occupiedSpace = (decimal) percentage / 100m;
            decimal requiredLiters = (decimal)volumeInLiters * (1 - occupiedSpace);
            Console.WriteLine(requiredLiters.ToString("0.00"));
        }
    }
}