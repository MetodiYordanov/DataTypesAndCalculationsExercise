namespace FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The program calculates how much it will cost a group of people to order takeaways.
            // The price of dessert is 20% of the total bill (excluding delivery).
            // Delivery price is 2.50 and is finaly charged.
            // Example - Input: number of chicken menus = 2, numer of menus with fish = 4,
            // number of vegeterian menus = 3
            // Output = 116.2

            const double chickenMenuPrice = 10.35;
            const double fishMenuPrice = 12.4;
            const double vegeterianMenuPrice = 8.15;
            const double deliveryPrice = 2.5;

            int chickenMenusNumber = int.Parse(Console.ReadLine());
            int fishMenusNumber = int.Parse(Console.ReadLine());
            int vegeterianMenusNumber = int.Parse(Console.ReadLine());

            double allChickenMenusPrice = chickenMenusNumber * chickenMenuPrice;
            double allFishMenusPrice = fishMenusNumber * fishMenuPrice;
            double allVegeterianMenusPrice = vegeterianMenusNumber * vegeterianMenuPrice;
            double allMenusPrice = allChickenMenusPrice + allFishMenusPrice + allVegeterianMenusPrice;
            double dessertPrice = allMenusPrice * 0.2;
            double totalOrderPrice = allMenusPrice + dessertPrice + deliveryPrice;
            Console.WriteLine(totalOrderPrice);
        }
    }
}