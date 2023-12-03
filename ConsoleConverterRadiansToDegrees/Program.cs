namespace ConsoleConverterRadiansToDegrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberInRadians = double.Parse(Console.ReadLine());
            double numberInDegrees = numberInRadians * 180 / Math.PI;
            Console.WriteLine(numberInDegrees);
        }
    }
}