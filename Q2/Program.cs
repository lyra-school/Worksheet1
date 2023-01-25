/* Name: Lyra Karsaj
 * Date: 25/1/23
 * Desc: Number counter + average
 */
namespace Q2
{
    internal class Program
    {
        //a
        private static int CountOddNumbers()
        {
            List<int> numbers = new List<int>();
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Enter an integer: ");
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            int counter = 0;
            foreach(int i in numbers)
            {
                if(i % 2 == 1)
                {
                    counter++;
                }
            }
            return counter;
        }
        //b
        private static void AverageMinMax()
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter an integer: ");
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            double average = 0;
            int largestNumber = numbers[0];
            int smallestNumber = numbers[0];
            foreach (int i in numbers)
            {
                if (i > largestNumber)
                {
                    largestNumber = i;
                }
                if(i < smallestNumber)
                {
                    smallestNumber = i;
                }
                average = average + i;
            }
            average = average / numbers.Count;
            Console.WriteLine(average);
            Console.WriteLine(smallestNumber);
            Console.WriteLine(largestNumber);

        }
        static void Main(string[] args)
        {
            int oddNumberCount = CountOddNumbers();
            Console.WriteLine(oddNumberCount);
            AverageMinMax();
        }
    }
}