using System;

namespace WarriorWars
{
    public static class Misc
    {
        public static void ColorWriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
