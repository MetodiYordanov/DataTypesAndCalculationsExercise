namespace MandatoryLiterature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The program calculates how many hours user should spent on reading a book for one day, so he reads it on time.
            // User enters from the console number of book's pages, pages that he reads for 1 hour and the number of days he needs to finish the book.
            // Example - Input: book's pages = 212, pages that user reads for 1 hour = 20, number of days to finish book = 2
            // Output: 5 hours per day

            int numberOfPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int numberOfDaysToRead = int.Parse(Console.ReadLine());
            int totalReadTimeForBook = numberOfPages / pagesPerHour;
            int hoursToReadPerDay = totalReadTimeForBook / numberOfDaysToRead;
            Console.WriteLine(hoursToReadPerDay);
        }
    }
}