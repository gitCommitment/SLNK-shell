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
            string? cmd;
            
            while (!Exit)
            {

                Console.Write("$ ");
                cmd = Console.ReadLine();
                if (cmd == "exit 0")
                {
                    Exit = true;
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{cmd}: command not found");
                    Console.ResetColor();
                }
            }

        }
        
        

    }
}
