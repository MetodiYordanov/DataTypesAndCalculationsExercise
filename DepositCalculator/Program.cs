namespace DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositedAmount = double.Parse(Console.ReadLine());
            int termOfDeposit = int.Parse(Console.ReadLine());
            double annualInterestRate = double.Parse(Console.ReadLine());
            double accumulatedInterest = (depositedAmount * annualInterestRate) / 100;
            double interestForOnemonth = accumulatedInterest / 12;
            double amount = depositedAmount + termOfDeposit * interestForOnemonth;
            Console.WriteLine(amount);
        }
    }
}