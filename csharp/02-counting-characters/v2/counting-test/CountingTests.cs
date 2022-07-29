using counting;

namespace counting_test;

public class Tests
{
    [Test]
    public void GetCharacterCount_WhenHello_Returns5()
    {
        string input = "hello";
        int expected = 5;

        int count = Program.GetCharacterCount(input);

        Assert.That(count, Is.EqualTo(expected));
    }

    [Test]
    public void GetOutputMessage_OnValid_ReturnsExpected()
    {
        string input = "hello";
        int count = 5;
        string expected = "hello has 5 characters.";

        string message = Program.GetOutputMessage(input, count);

        Assert.That(message, Is.EqualTo(expected));
    }
}