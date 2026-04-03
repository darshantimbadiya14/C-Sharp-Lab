using System;

namespace ElectroMart
{
    public static class UIManager
    {
        public static void PrintHeader(string title)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(new string('=', Console.WindowWidth - 1));

            Console.ForegroundColor = ConsoleColor.Yellow;
            int spaces = (Console.WindowWidth - title.Length) / 2;
            Console.WriteLine(new string(' ', Math.Max(0, spaces)) + title);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(new string('=', Console.WindowWidth - 1));
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void PrintMenu(string[] options)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"  {i + 1}. {options[i]}");
            }
            Console.WriteLine();
            Console.ResetColor();
        }

        public static string GetInput(string prompt)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{prompt}: ");
            string input = Console.ReadLine();
            Console.ResetColor();
            return input;
        }

        public static void ShowSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n[SUCCESS] {message}");
            Console.ResetColor();
            Pause();
        }

        public static void ShowError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n[ERROR] {message}");
            Console.ResetColor();
            Pause();
        }

        public static void ShowWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n[WARNING] {message}");
            Console.ResetColor();
            Pause();
        }

        public static void Pause()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPress any key to continue...");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}