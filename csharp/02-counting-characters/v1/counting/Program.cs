namespace counting;

// Example
// What is the input string? Homer
// Homer has 5 characters.

public class Program
{
    public static void Main()
    {
        Console.Write("What is the input string? ");
        string? input = Console.ReadLine();
        int count = GetCharacterCount(input);
        string message = GetOutputMessage(input, count);
        Console.WriteLine(message);
    }

    public static int GetCharacterCount(string? input)
    {
        if (input is null)
            return 0;
        return input.Length;
    }

    public static string GetOutputMessage(string? input, int count)
    {
        if (input is null)
            input = "";
        return $"{input} has {count} characters.";
    }
}