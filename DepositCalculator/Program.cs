namespace DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program gets input from the console for deposited amount, term of deposit and annual interest rate.
            // Then it calculates accumulated interest and interest for one month.
            // In the end, program calculates total amount and prints it on the console.
            // Example - Input: deposited amount = 200, term of deposit = 3 months, annual interest rate = 5.7%
            // Output: 202.85
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