using System;

namespace ConsoleScreen
{
    class Program
    {
        static Screen screen = new Screen();

        static string[,] gamespace = new string[128,128];
        static void Main(string[] args)
        {
            string[,] map = IterateGameSpace(gamespace);
            screen.displayFrame(map);
            Console.ReadKey();
        }
        public static string[,] IterateGameSpace(string[,] gamespace)
        {
            for (int x = 0; x < gamespace.GetLength(0); x++)
            {
                for (int y = 0; y < gamespace.GetLength(1); y++)
                {
                    gamespace[x, y] = $" {x},{y} ";
                }
            }
            return gamespace;
        } 
    }
}
