using retirement;

namespace retirement_test;

public class Tests
{
    [Test]
    public void GetCurrentYear_ReturnsCurrentYear()
    {
        int expected = DateTime.Now.Year;
        int actual = Program.GetCurrentYear();
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void YearsToRetirement_OnPositive_ReturnsExpectedYears()
    {
        int expected = 40;
        int currentAge = 25;
        int retirementAge = 65;
        int actual = Program.CalcYearsToRetirement(currentAge, retirementAge);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void YearsToRetirement_OnNegative_ThrowsRetiredException()
    {
        int currentAge = 70;
        int retirementAge = 65;

        Assert.Throws<RetirementException>(() => Program.CalcYearsToRetirement(currentAge, retirementAge));
    }

    [Test]
    public void RetirementYear_OnPositive_ReturnsExpectedYear()
    {
        int currentYear = 2015;
        int yearsToRetirement = 40;
        int expected = 2055;
        int actual = Program.GetRetirementYear(currentYear, yearsToRetirement);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void RetirementYear_OnNegativeThrowsRetiredException()
    {
        int currentYear = 2015;
        int yearsToRetirement = 0;
        Assert.Throws<RetirementException>(() => Program.GetRetirementYear(currentYear, yearsToRetirement));
    }

    [Test]
    public void ConvertStringToInt_OnNumber_ReturnsNumber()
    {
        string input = "10";
        int expected = 10;

        int result = Program.ConvertStringToInt(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void ConvertStringToInt_OnPaddedNumber_ReturnsNumber()
    {
        string input = "   10   ";
        int expected = 10;

        int result = Program.ConvertStringToInt(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void ConvertStringToInt_OnNonNumber_ThrowsFormatException()
    {
        string input = "hello";

        Assert.Throws<FormatException>(() => Program.ConvertStringToInt(input));
    }

    [Test]
    public void ConvertStringToInt_OnNull_ThrowsArgumentNullException()
    {
        string? input = null;

        Assert.Throws<ArgumentNullException>(() => Program.ConvertStringToInt(input));
    }

    [Test]
    public void ConvertStringToInt_OnBlank_ThrowsArgumentNullException()
    {
        string? input = "";

        Assert.Throws<ArgumentNullException>(() => Program.ConvertStringToInt(input));
    }
}