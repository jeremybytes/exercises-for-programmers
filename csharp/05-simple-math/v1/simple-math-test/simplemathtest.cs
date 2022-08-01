using simple_math;

namespace simple_math_test;

public class Tests
{
    [Test]
    public void Add_On2Numbers_ReturnsSum()
    {
        int num1 = 10;
        int num2 = 5;
        int expected = 15;

        int sum = Program.Add(num1, num2);

        Assert.That(sum, Is.EqualTo(expected));
    }

    [Test]
    public void OutputAdd_On2Numbers_ReturnsSumString()
    {
        int num1 = 10;
        int num2 = 5;
        string expected = "10 + 5 = 15";
 
        string sumString = Program.OutputAdd(num1, num2);

        Assert.That(sumString, Is.EqualTo(expected));
    }

    [Test]
    public void Subtract_On2Numbers_ReturnsDifference()
    {
        int num1 = 10;
        int num2 = 5;
        int expected = 5;

        int difference = Program.Subtract(num1, num2);

        Assert.That(difference, Is.EqualTo(expected));
    }

    [Test]
    public void OutputSubtract_On2Numbers_ReturnsDifferenceString()
    {
        int num1 = 10;
        int num2 = 5;
        string expected = "10 - 5 = 5";

        string differenceString = Program.OutputSubtract(num1, num2);

        Assert.That(differenceString, Is.EqualTo(expected));
    }

    [Test]
    public void Multiply_On2Numbers_ReturnsProduct()
    {
        int num1 = 10;
        int num2 = 5;
        int expected = 50;

        int product = Program.Multiply(num1, num2);

        Assert.That(product, Is.EqualTo(expected));
    }

    [Test]
    public void OutputMultiply_On2Numbers_ReturnsProductString()
    {
        int num1 = 10;
        int num2 = 5;
        string expected = "10 * 5 = 50";

        string productString = Program.OutputMultiply(num1, num2);

        Assert.That(productString, Is.EqualTo(expected));
    }

    [Test]
    public void Divide_On2Numbers_ReturnsResult()
    {
        int num1 = 10;
        int num2 = 5;
        int expected = 2;

        int result = Program.Divide(num1, num2);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void OutputDivide_On2Numbers_ReturnsResultString()
    {
        int num1 = 10;
        int num2 = 5;
        string expected = "10 / 5 = 2";

        string resultString = Program.OutputDivide(num1, num2);

        Assert.That(resultString, Is.EqualTo(expected));
    }

    [Test]
    public void OutputDivide_On0_ReturnsErrorString()
    {
        int num1 = 10;
        int num2 = 0;
        string expected = "Cannot divide by 0";

        string resultString = Program.OutputDivide(num1, num2);

        Assert.That(resultString, Is.EqualTo(expected));
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