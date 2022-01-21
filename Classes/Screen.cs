using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleScreen
{
    public class Screen
    {
        public void displayFrame(string[,] display)
        {
            string storage = "";
            for (int x = 0; x < display.GetLength(0); x++)
            {
                for (int y = 0; y < display.GetLength(1); y++)
                {
                   storage += $"{display[x, y]}";
                }
               storage += System.Environment.NewLine;
            }
            Console.Write(storage);
        }
    }
}
