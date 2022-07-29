namespace counting;

// Example
// What is the input string? Homer
// Homer has 5 characters.

// Challenge
// If input is empty, prompt for a valid value

public class Program
{
    public static void Main()
    {
        string? input = null;
        do
        {
            Console.Write("What is the input string? ");
            input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
                Console.WriteLine("Please enter a valid value.");
        } while (string.IsNullOrEmpty(input));

        int count = GetCharacterCount(input!);
        string message = GetOutputMessage(input!, count);
        Console.WriteLine(message);
    }

    public static int GetCharacterCount(string input)
    {
        return input.Length;
    }

    public static string GetOutputMessage(string input, int count)
    {
        return $"{input} has {count} characters.";
    }
}