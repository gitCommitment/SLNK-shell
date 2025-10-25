using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNK_Shell.codecrafters_shell_csharp.src
{
    internal class Utilities
    {
        private int exitNumber;
        private bool exit = false;

        public int ExitNumber { get; set; }
        public static bool Exit { get; set; }

        public static void Prompt()
        {
            string? userInput = string.Empty;
            
            while (!Exit)
            {
                
                Console.Write("$ ");
                userInput = Console.ReadLine();
                if (userInput == "exit 0")
                {
                    Exit = true;
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{userInput}: command not found");
                    Console.ResetColor();
                }
            }

        }
        
        

    }
}
