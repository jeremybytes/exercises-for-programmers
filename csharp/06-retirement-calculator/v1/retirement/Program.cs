namespace retirement;

// Example Output
// What is your current age? 25
// At what age would you like to retire? 65
// You have 40 years left until you can retire.
// It's 2015, so you can retire in 2055.

// Constraints
// convert the input to numerical data
// don't hard-code the current year

// Challenge
// handle situations where the program returns a
// negative number by stating that the user can
// already retire.

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("What is your current age? ");
            string? input1 = Console.ReadLine();
            int currentAge = ConvertStringToInt(input1);
            currentAge = CheckForNegative(currentAge);

            Console.Write("At what age would you like to retire? ");
            string? input2 = Console.ReadLine();
            int retirementAge = ConvertStringToInt(input2);
            retirementAge = CheckForNegative(retirementAge);

            int yearsToRetirement = CalcYearsToRetirement(currentAge, retirementAge);

            int currentYear = GetCurrentYear();
            int retirementYear = GetRetirementYear(currentYear, yearsToRetirement);

            string output = $"You have {yearsToRetirement} years left until you can retire.\n";
            output += $"It's {currentYear}, so you can retire in {retirementYear}";

            Console.WriteLine(output);
        }
        catch (RetirementException ex)
        {
            Console.WriteLine(ex.Message);
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

    public static int GetCurrentYear()
    {
        return DateTime.Today.Year;
    }

    public static int CalcYearsToRetirement(int currentAge, int retirementAge)
    {
        int yearsToRetirement = retirementAge - currentAge;
        if (yearsToRetirement <= 0)
        {
            throw new RetirementException("You are already retired");
        }
        return yearsToRetirement;
    }

    public static int GetRetirementYear(int currentYear, int yearsToRetirement)
    {
        int retirementYear =  currentYear + yearsToRetirement;
        if (yearsToRetirement <= 0)
        {
            throw new RetirementException("You are already retired");
        }
        return retirementYear;
    }
}