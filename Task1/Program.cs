namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the carpet cleaning service.");
            int priceSmall = 25;
            int priceLarge = 35;
            float taxRate = 6;
            Console.WriteLine($"{priceSmall}$ per small carpet");
            Console.WriteLine($"{priceLarge}$ per large carpet");
            Console.WriteLine($"{taxRate}% tax rate");
            Console.WriteLine("How many small carpets need cleaning?");
            int smallCarpets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many large carpets need cleaning?");
            int largeCarpets = Convert.ToInt32(Console.ReadLine());
            int totalPrice = (smallCarpets * priceSmall) + (largeCarpets * priceLarge);
            Console.WriteLine($"Total price: {totalPrice}$");
            float taxAmount = (totalPrice * taxRate) / 100;
            Console.WriteLine($"Tax amount: {taxAmount}$");
            Console.WriteLine($"Total with tax: {totalPrice + taxAmount}$");

        }
    }
}
