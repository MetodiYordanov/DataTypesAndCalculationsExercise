namespace BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The program calculates the expenses of user's basketball equipment and training fee for 1 year.
            // User also knows that:
            // basketball sneakers are 40% less than the training fee for one year
            // basketball team is 20% cheaper than the price of sneakers
            // basketball is 25% of the price of the basketball team
            // basketball accessories price is 20% of the price of the basketball
            // Example - Input: annual basketball training fee = 365
            // Output: 811.76

            int annualTrainingFee = int.Parse(Console.ReadLine());

            double sneakers = annualTrainingFee - (annualTrainingFee * 0.4);
            double team = sneakers - (sneakers * 0.2);
            double basketball = team * 0.25;
            double accessories = basketball * 0.2;

            double totalEquipmentprice = annualTrainingFee + sneakers + team + basketball + accessories;
            Console.WriteLine(totalEquipmentprice);
        }
    }
}