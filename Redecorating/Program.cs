namespace Redecorating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double nylonPricePerSquareMeter = 1.5;
            const double pricePaintPerLiter = 14.5;
            const double pricePaintThinnerPerLiter = 5.0;
            const double amountForBags = 0.4;

            int requiredAmountNylon = int.Parse(Console.ReadLine());
            int requiredAmountPaint = int.Parse(Console.ReadLine());
            int quantityThinner = int.Parse(Console.ReadLine());
            int hoursForWork = int.Parse(Console.ReadLine());

            double nylonAmount = (requiredAmountNylon + 2) * nylonPricePerSquareMeter;
            double paintAmount = (requiredAmountPaint + (requiredAmountPaint * 0.1)) * pricePaintPerLiter;
            double thinnerAmount = quantityThinner * pricePaintThinnerPerLiter;
            double amountAllMaterials = nylonAmount + paintAmount + thinnerAmount + amountForBags;
            double craftsmenAmount = (amountAllMaterials * 0.3) * hoursForWork;
            double totalAmount = amountAllMaterials + craftsmenAmount;
            Console.WriteLine(totalAmount);

        }
    }
}