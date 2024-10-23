using System.Net.Mime;

namespace AdventureF24;

public static class IO
{
    public static void Write(string output)
    {
        Console.WriteLine(output);
    }
    
    public static string Read()
    {
        Console.Write("> ");
        return Console.ReadLine();
    }

    public static void Error(string error)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("ERROR: " + error + "\n");
        Console.ResetColor();
    }
}