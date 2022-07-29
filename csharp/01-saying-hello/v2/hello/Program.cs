namespace hello;

// Example
// What is your name? Brian
// Hello, Brian, nice to meet you!

// Challenge
// no variables

public class Program
{
    static void Main()
    {
        Console.Write("What is your name? ");
        Console.WriteLine(GetMessage(Console.ReadLine()));
    }

    public static string GetMessage(string? name)
    {
        if (string.IsNullOrEmpty(name))
            return "Hello. It is nice to meet you!";
        return $"Hello, {name}, nice to meet you!";
    }
}