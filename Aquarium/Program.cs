namespace Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
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