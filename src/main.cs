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
            Console.WriteLine("$ ");
            var cmd = Console.ReadLine();

            if (cmd == "exit")
            {
                return 0;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{cmd}: command not found");
            Console.ResetColor();
            
        }

        //while (true)
        //{
        //    Console.Write("$ ");
        //    var cmd = Console.ReadLine();
        //    if (cmd == "exit 0")
        //        return 0;
        //    Console.WriteLine($"{cmd}: command not found");
        //}


    }
}
