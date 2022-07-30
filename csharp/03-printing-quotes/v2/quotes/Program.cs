namespace quotes;

// Example
// What is the quote? These aren't the droids you're looking for.
// Who said it? Obi-Wan Kenobi
// Obi-Wan Kenobi says, "These aren't the droids you're looking for."

// Constraints
// Single output statement
// Use string concatenation (not interpolation)

// Challenge
// Instead of propting for input, use a data structure
// and print out all of the items in the quote format.

public class Program
{
    public static void Main()
    {
        try
        {
            foreach (var (quote, author) in quotes)
            {
                string message = GetOutput(quote, author);
                Console.WriteLine(message);
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Sorry, I could not process your answers. Please try again.");
        }
    }

    public static List<(string quote, string author)> quotes = new()
    {
        ("These aren't the droids you're looking for.", "Obi-Wan Kenobi"),
        ("I love you.", "Leia Organa"),
        ("I know.", "Han Solo"),
    };

    public static string GetOutput(string? quote, string? author)
    {
        if (string.IsNullOrEmpty(quote)) throw new ArgumentNullException(nameof(quote));
        if (string.IsNullOrEmpty(author)) throw new ArgumentNullException(nameof(author));

        return author + " says, \"" + quote + "\"";
    }
}