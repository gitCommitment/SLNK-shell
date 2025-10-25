class Program
{
    static void Main()
    {
         Console.Write("$ ");

        string userInput = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{userInput}: command not found");
        Console.ResetColor();
    }
}
