namespace Redecorating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The program calculates the cost of the repair, taking the following prices for the calculation:
            // · Protective nylon - 1.50 per square meter
            // · Paint - 14.50 per liter
            // · Paint thinner - 5.00 per liter
            // Just in case, to the necessary materials, user adds another 10 %
            // of the amount of paint and 2 square meters of nylon, also 0.40 cents for bags.
            // The amount paid to the craftsmen for 1 hour of work is equal to 30 % of the sum of all material costs.
            // For input user enters required amount of nylon, required amount of paint,
            // quantity of thinner and hours needed for the craftsmen to do the work
            // For output user gets the sum of all costs
            // Example - Input: required amount of nylon = 10, required amount of paint = 11,
            // quantity of thinner = 4 and hours needed for the craftsmen to do the work = 8
            // Output: 727.09

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