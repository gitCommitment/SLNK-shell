class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("$ ");

            string userInput = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{userInput}: command not found");
            Console.ResetColor();

        }
    }
}
