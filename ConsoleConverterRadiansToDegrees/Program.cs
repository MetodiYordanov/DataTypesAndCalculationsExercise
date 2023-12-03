namespace ConsoleConverterRadiansToDegrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The program reads an angle in radians and converts it to degrees.
            // After the convert is made, result is printed on the console.
            // Example - Input: 6.2832; Output: 360.0008418365988

            double numberInRadians = double.Parse(Console.ReadLine());
            double numberInDegrees = numberInRadians * 180 / Math.PI;
            Console.WriteLine(numberInDegrees);
        }
    }
}