using System;

namespace StudyConsoleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            OtherConsoleFuncs();
            Welcoming();
            Console.ResetColor();
        }

        static void WorkingWithString()
        {
            Console.Write("\tThis text will stay in the same line!");
            Console.WriteLine("This text will pass to the next line!");
            Console.WriteLine("Hello World!");
        }

        static void Table()
        {
            Console.WriteLine("ID\tName\tType");
        }

        static void Reading()
        {
            Console.ReadLine();
        }

        static void Welcoming()
        {
            Console.Write("What is your name? ");
            Console.WriteLine($"Welcome to my code {Console.ReadLine()}!");
            Console.Write("What is your age? ");
            Console.WriteLine($"You are {Console.ReadLine()} years old!");
        }

        static void OtherConsoleFuncs()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Beep();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Experiement Title";
        }
    }
}
