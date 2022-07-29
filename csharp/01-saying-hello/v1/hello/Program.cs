namespace hello;

// Example
// What is your name? Brian
// Hello, Brian, nice to meet you!

public class Program
{
    static void Main()
    {
        string? name = GetName();
        string message = GetMessage(name);
        WriteMessage(message);
    }

    public static string? GetName()
    {
        Console.Write("What is your name? ");
        return Console.ReadLine();
    }

    public static string GetMessage(string? name)
    {
        if (string.IsNullOrEmpty(name))
            return "Hello. It is nice to meet you!";
        return $"Hello, {name}, nice to meet you!";
    }

    public static void WriteMessage(string message)
    {
        Console.WriteLine(message);
    }
}