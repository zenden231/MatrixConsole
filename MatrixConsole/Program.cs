using System;
using System.Threading;
namespace MatrixConsole
{
    class Program
    {
        private static void Main()
        {
            ConsoleProps();
            WriteMessages();
            Thread.Sleep(4000);
        }
        static void ConsoleProps()
        {
            Console.CursorVisible = false;
            //Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            //Console.SetWindowSize(213, 50);
            //Console.SetWindowPosition
            Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
            Console.Title = "Matrix Console";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            
        }
        static void WriteMessages()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Wake Up, Neo...");
            Thread.Sleep(1500);
            Console.Clear();
            string msg = "The Matrix has you...";
            string msg1 = "Follow The white rabbit.";
            string msg2 = "Knock Knock, Neo.";
            foreach (char ch in msg)
            {
                Console.Write(ch);
                Thread.Sleep(200);              
            }
            Thread.Sleep(800);
            Console.WriteLine("\n{Hint: Press Ctrl + x}");    
            if (ReadInput1())
            {
                Console.Clear();
                foreach (char ch in msg1)
                {
                    Console.Write(ch);
                    Thread.Sleep(200);
                }
                Thread.Sleep(800);
                Console.WriteLine("\n{Hint: Press Esc}");
            }
            if (ReadInput2())
            {
                Thread.Sleep(200);
                Console.Clear();
                Console.Write(msg2);
            }             
        }
        static bool ReadInput1()
        {
            Console.TreatControlCAsInput = true;
            var input = Console.ReadKey(true); 
            while ((input.Modifiers.ToString().ToLower() == "control" & 
                input.Key.ToString().ToLower() == "x") == false)
                input = Console.ReadKey(true);
            return true;
        }
        static bool ReadInput2()
        {
            Console.TreatControlCAsInput = true;
            while (true)
                if (Console.ReadKey(true).Key.ToString().ToLower() == "escape") break;
            return true;
        }
    }
}
