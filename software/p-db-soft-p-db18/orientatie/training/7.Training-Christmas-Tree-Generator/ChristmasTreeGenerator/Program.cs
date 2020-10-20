using System;
using System.Drawing;

namespace ChristmasTreeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.GenerateChristmasTree(ConsoleColor.Blue, 30, 0, 0, "X");
            p.GenerateChristmasTree(ConsoleColor.Red, 15, 10, 10, "X");
            p.GenerateChristmasTree(ConsoleColor.Yellow, 40, 5, 15, "X");
            Console.ReadKey();
        }

        public void GenerateChristmasTree(ConsoleColor color, int height, int startX, int startY, string symbol)
        {
            int numOfSymbols = 1;
            int numOfSpaces = height - 1;

            int currentX = startX;
            int currentY = startY;

            for (int i = 0; i < height; i++)
            {
                currentX += numOfSpaces;

                for (int f = 0; f < numOfSymbols; f++)
                {
                    PrintText(currentX, currentY, symbol, color);
                    currentX++;
                }

                numOfSymbols += 2;
                numOfSpaces--;

                currentX = startX;
                currentY++;
            }
        }

        /**
         * This version is using Console.WriteLine.
         */
        /*public void GenerateChristmasTree(ConsoleColor color, int height, int startX, int startY, string symbol)
        {
            int numOfSymbols = 1;
            int numOfSpaces = height - 1;

            int currentX = startX;
            int currentY = startY;

            for (int i = 0; i < height; i++)
            {
                string output = "";

                for (int j = 0; j < numOfSpaces; j++)
                {
                    output += " ";
                }

                for (int f = 0; f < numOfSymbols; f++)
                {
                    output += symbol;
                }

                PrintText(currentX, currentX, output, color);

                numOfSymbols += 2;
                numOfSpaces--;

                currentY++;
            }
        }*/

        private void PrintText(int x, int y, string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(x, y);
            Console.Write(text);
            Console.ResetColor();
        }
    }
}
