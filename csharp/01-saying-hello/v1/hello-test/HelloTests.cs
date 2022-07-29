using hello;

namespace hello_test;

public class Tests
{
    [Test]
    public void GetMessage_WithName_ReturnsMessageWithName()
    {
        string? name = "Jeremy";
        string expected = "Hello, Jeremy, nice to meet you!";

        string message = Program.GetMessage(name);

        Assert.That(message, Is.EqualTo(expected));
    }

    [Test]
    public void GetMessage_WithNullName_ReturnsDefaultMessage()
    {
        string? name = null;
        string expected = "Hello. It is nice to meet you!";

        string message = Program.GetMessage(name);

        Assert.That(message, Is.EqualTo(expected));
    }

    [Test]
    public void GetMessage_WithEmptyName_ReturnsDefaultMessage()
    {
        string? name = "";
        string expected = "Hello. It is nice to meet you!";

        string message = Program.GetMessage(name);

        Assert.That(message, Is.EqualTo(expected));
    }
}