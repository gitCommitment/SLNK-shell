using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace SLNK_Shell.codecrafters_shell_csharp.src
{
    internal class Utilities
    {
        public static void Echo(string[] words)
        {
            
            if (words.Length > 0)
            {
                Console.WriteLine(string.Join(" ", words));
                return;
            }
            Console.WriteLine("");
        }

        public static void Type(string[] cmd)
        {
            string message = " is a shell builtin";
            switch (cmd[0])
            {
                case "echo":
                    Console.WriteLine($"echo{message}");
                    break;
                case "exit":
                    Console.WriteLine($"exit{message}");
                    break;
                case "type":
                    Console.WriteLine($"type{message}");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{String.Join(" ", cmd)}: command not found");
                    Console.ResetColor();
                    break;
            }
           
        }


    }
}
