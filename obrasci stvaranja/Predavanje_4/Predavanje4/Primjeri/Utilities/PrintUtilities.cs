using System;

namespace Primjeri.Utilities
{
    class PrintUtilities
    {
        private static String separator = "================================================";
        private static String startText = "Running example: ";

        public static void PrintStart(object name)
        {
            Print(separator);
            Print(startText + name, ConsoleColor.Magenta);
            Print(separator);
        }

        public static void PrintEnd()
        {
            Print(separator + Environment.NewLine);
        }

        private static void Print(String message)
        {
            Console.WriteLine(message);
        }

        private static void Print(String message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Print(message);
            Console.ResetColor();
        }
    }
}
