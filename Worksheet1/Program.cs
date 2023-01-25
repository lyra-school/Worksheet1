/* Name: Lyra Karsaj
 * Date: 25/1/23
 * Desc: Looping methods
 */
namespace Worksheet1
{
    internal class Program
    {
        //a
        private static void PrintIntegersFor()
        {
            for(int i = 40; i < 61; i++)
            {
                Console.WriteLine(i);
            }
        }
        //b
        private static void PrintIntegersWhile()
        {
            int i = 40;
            while(i < 61)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        //c
        private static void PrintIntegersDo()
        {
            int i = 40;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 61);
        }
        //d
        private static void PrintExcludingFor()
        {
            for(int i = 40; i < 61; i++)
            {
                if(i != 46 && i != 48)
                {
                    Console.WriteLine(i);
                }
            }
        }
        //e
        private static void PrintDescendingFor()
        {
            for (int i = 60; i > 39; i--)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            PrintIntegersFor();
            PrintIntegersWhile();
            PrintIntegersDo();
            PrintExcludingFor();
            PrintDescendingFor();
        }
    }
}