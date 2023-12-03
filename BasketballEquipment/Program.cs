namespace BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
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