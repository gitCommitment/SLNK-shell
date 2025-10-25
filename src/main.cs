using SLNK_Shell.codecrafters_shell_csharp.src;

class Program
{
    static int Main()
    {
        while (true)
        {
            string cmd;

            Console.WriteLine("$ ");

            cmd = Console.ReadLine();

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
