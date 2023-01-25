/* Name: Lyra Karsaj
 * Date: 25/1/23
 * Desc: Pattern printer
 */

namespace Q3
{
    internal class Program
    {
        //a
        private static void PrintTriangle()
        {
            int hashLayers = 5;
            // formula = n + 1 starting from 0
            for(int i = 0; i < hashLayers; i++)
            {
                int counter = 0;
                while(counter <= i)
                {
                    Console.Write("# ");
                    counter++;
                }
                Console.Write("\n");
            }
        }
        //b
        private static void PrintTriangleUpsideDown()
        {
            int hashLayers = 5;
            // formula = n + 1 starting from layerCount - 1
            for (int i = hashLayers; i > 0; i--)
            {
                int counter = 0;
                while (counter <= i - 1)
                {
                    Console.Write("# ");
                    counter++;
                }
                Console.Write("\n");
            }
        }
        //c
        private static void PrintTriangleGeneral(int layerCount)
        {
            // formula = n + 1 starting from 0
            for (int i = 0; i < layerCount; i++)
            {
                int counter = 0;
                while (counter <= i)
                {
                    Console.Write("# ");
                    counter++;
                }
                Console.Write("\n");
            }
        }
        //d
        private static void PrintTriangleGeneralCharacter(int layerCount, string randomCharacter)
        {
            // formula = n + 1 starting from 0
            for (int i = 0; i < layerCount; i++)
            {
                int counter = 0;
                while (counter <= i)
                {
                    Console.Write(randomCharacter + " ");
                    counter++;
                }
                Console.Write("\n");
            }
        }
        static void Main(string[] args)
        {
            PrintTriangle();
            PrintTriangleUpsideDown();
            int layers = 5;
            PrintTriangleGeneral(layers);
            PrintTriangleGeneralCharacter(layers, "s");
        }
    }
}