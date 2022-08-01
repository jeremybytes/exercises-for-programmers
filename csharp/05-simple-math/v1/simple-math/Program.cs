namespace simple_math;

// Example Output
// What is the first number? 10
// What is the second number? 5
// 10 + 5 = 15
// 10 - 5 = 5
// 10 * 5 = 50
// 10 / 5 = 2

// Constraints
// convert input strings to integers
// keep input and output separate from conversions and processing
// generate a single output statement with line breaks

// Note: This code also satisifes Challenges #1, #2, and #3
// Don't let the user proceed if the value is non-numberic
// Don't let the user enter a negative number
// break the program into functions that do the computations

public class Program
{
    public static void Main()
    {
        try
        {
            Console.Write("What is the first number? ");
            string? input1 = Console.ReadLine();
            int num1 = ConvertStringToInt(input1);
            num1 = CheckForNegative(num1);

            Console.Write("What is the second number? ");
            string? input2 = Console.ReadLine();
            int num2 = ConvertStringToInt(input2);
            num2 = CheckForNegative(num2);

            string output = $"{OutputAdd(num1, num2)}\n{OutputSubtract(num1, num2)}\n{OutputMultiply(num1, num2)}\n{OutputDivide(num1, num2)}";

            Console.WriteLine(output);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Number cannot be negative. Please re-run and try agian.");
        }
        catch (Exception)
        {
            Console.WriteLine("Not a valid number. Please re-run and try again.");
        }
    }

    public static int CheckForNegative(int input)
    {
        if (input < 0)
            throw new ArgumentOutOfRangeException(nameof(input));
        return input;
    }

    public static int ConvertStringToInt(string? input)
    {
        input = input?.Trim();
        if (string.IsNullOrEmpty(input))
            throw new ArgumentNullException(input);
        return int.Parse(input);
    }

    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public static string OutputAdd(int num1, int num2)
    {
        return $"{num1} + {num2} = {Add(num1, num2)}";
    }

    public static int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }

    public static string OutputSubtract(int num1, int num2)
    {
        return $"{num1} - {num2} = {Subtract(num1, num2)}";
    }

    public static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    public static string OutputMultiply(int num1, int num2)
    {
        return $"{num1} * {num2} = {Multiply(num1, num2)}";
    }

    public static int Divide(int num1, int num2)
    {
        return num1 / num2;
    }

    public static string OutputDivide(int num1, int num2)
    {
        if (num2 == 0)
            return "Cannot divide by 0";
        return $"{num1} / {num2} = {Divide(num1, num2)}";
    }
}