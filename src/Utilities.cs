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
            
            while (userInput != "exit")
            {
                
                Console.Write("$ ");
                userInput = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{userInput}: command not found");
                Console.ResetColor();
            }

            Console.WriteLine("0");
        }
        
        

    }
}
