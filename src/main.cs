using SLNK_Shell.codecrafters_shell_csharp.src;
using System.Security.Cryptography;
using System.Net;
using System.Net.Sockets;

class Program
{
    static int Main()
    {
        while (true)
        {            
            Console.WriteLine("$ ");
            var cmd = Console.ReadLine();

            if (cmd == "exit")
            {
                return 0;
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
