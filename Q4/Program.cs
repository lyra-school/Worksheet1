namespace Q4
{
    internal class Program
    {
        const double PRICE_PER_HOUR = 0.5;
        private static double CalculateCharge(int hours)
        {
            double price = 2;
            if(hours > 3)
            {
                if ((hours - 3) * PRICE_PER_HOUR + 2 > 10)
                {
                    price = 10;
                }
                else
                {
                    price = price + ((hours - 3) * PRICE_PER_HOUR);
                }
            }
            return price;
        }
        static void Main(string[] args)
        {
            double receipt = 0;
            while(true)
            {
                Console.Write("Enter number of hours (-999 to quit):");
                int hours = int.Parse(Console.ReadLine());
                if (hours == -999)
                {
                    return;
                }
                double price = CalculateCharge(hours);
                receipt = receipt + price;
                Console.WriteLine($"Customer Charge: {price:n2}{" ",-20} Total Receipt: {receipt:n2}");

            }
        }
    }
}