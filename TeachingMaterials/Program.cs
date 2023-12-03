namespace TeachingMaterials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The program calculates how much money user will need to collect to pay the final bill.
            // For input, user shoud write number of packages of pens, number of packets of markers,
            // liters of board cleaner and discount percentage as user is regular client.
            // Example - Input: number of packages of pens = 2, number of packets of markers = 3,
            // liters of board ceaner = 4, discount percentage = 25%
            // Output: 28.5

            const double pricePackageOfPens = 5.8;
            const double pricePackageOfMarkers = 7.2;
            const double priceBoardCleanerPerLiter = 1.2;

            int numberPackagesOfPens = int.Parse(Console.ReadLine());
            int numberPackagesOfMarkers = int.Parse(Console.ReadLine());
            int litersBoardCleaner = int.Parse(Console.ReadLine());
            decimal discountPercentage = decimal.Parse(Console.ReadLine());

            double pricePackagesOfPens = numberPackagesOfPens * pricePackageOfPens;
            double priceMarkerPackages = numberPackagesOfMarkers * pricePackageOfMarkers;
            double priceBoardCleaner = litersBoardCleaner * priceBoardCleanerPerLiter;
            double priceAllMaterials = pricePackagesOfPens + priceMarkerPackages + priceBoardCleaner;
            decimal discountAfterChanges = Math.Round(discountPercentage / 100m, 2);
            double priceMaterialsAfterDiscount = priceAllMaterials - (priceAllMaterials * (double) discountAfterChanges);
            Console.WriteLine(priceMaterialsAfterDiscount);
        }
    }
}