namespace quotes;

// Example
// What is the quote? These aren't the droids you're looking for.
// Who said it? Obi-Wan Kenobi
// Obi-Wan Kenobi says, "These aren't the droids you're looking for."

// Constraints
// Single output statement
// Use string concatenation (not interpolation)

public class Program
{
    public static void Main()
    {
        Console.Write("What is the quote? ");
        string? quote = Console.ReadLine();
        Console.Write("Who said it? ");
        string? author = Console.ReadLine();
        try
        {
            string message = GetOutput(quote, author);
            Console.WriteLine(message);
        }
        catch (Exception)
        {
            Console.WriteLine("Sorry, I could not process your answers. Please try again.");
        }
    }

    public static string GetOutput(string? quote, string? author)
    {
        if (string.IsNullOrEmpty(quote)) throw new ArgumentNullException(nameof(quote));
        if (string.IsNullOrEmpty(author)) throw new ArgumentNullException(nameof(author));

        return author + " says, \"" + quote + "\"";
    }
}