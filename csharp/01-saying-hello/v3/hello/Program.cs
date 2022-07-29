namespace hello;

// Example
// What is your name? Brian
// Hello, Brian, nice to meet you!

// Challenge
// different greetings for different people

public class Program
{
    static void Main()
    {
        Console.Write("What is your name? ");
        var name = Console.ReadLine();
        var message = GetMessage(name);
        Console.WriteLine(message);
    }

    public static string GetMessage(string? name)
    {
        return name switch
        {
            "Jeremy" => $"Hello, {name}. How's it going?",
            "Kelly" => $"Hello, {name}, you are awesome!",
            null => "Hello. It is nice to meet you!",
            "" => "Hello. It is nice to meet you!",
            _ => $"Hello, {name}. It looks like you are new here.",
        };
    }
}