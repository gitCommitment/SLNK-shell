using SLNK_Shell.codecrafters_shell_csharp.src;
using System.Security.Cryptography;
using System.Net;
using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static int Main()
    {

        while (true)
        { 
            Console.Write("$ ");
            var cmd = Console.ReadLine();
            string[] parseCmd = cmd.Split(' ');


            switch (parseCmd[0])
            {
                case "echo":
                    Utilities.Echo(parseCmd[1..]);
                    break;
                case "type":
                    Utilities.Type(parseCmd[1..]);
                    break;
                case "exit":
                    return 0;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{cmd}: command not found");
                    Console.ResetColor();
                    break;
            }
            

        }


    }
}
