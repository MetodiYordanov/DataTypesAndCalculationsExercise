namespace MandatoryLiterature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int numberOfDaysToRead = int.Parse(Console.ReadLine());
            int totalReadTimeForBook = numberOfPages / pagesPerHour;
            int hoursToReadPerDay = totalReadTimeForBook / numberOfDaysToRead;
            Console.WriteLine(hoursToReadPerDay);
        }
    }
}