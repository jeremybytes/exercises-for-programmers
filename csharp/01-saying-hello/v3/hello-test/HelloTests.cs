using hello;

namespace hello_test;

public class Tests
{
    [Test]
    public void GetMessage_WithJeremy_ReturnsMessageWithName()
    {
        string? name = "Jeremy";
        string expected = "Hello, Jeremy. How's it going?";

        string message = Program.GetMessage(name);

        Assert.That(message, Is.EqualTo(expected));
    }

    [Test]
    public void GetMessage_WithKelly_ReturnsMessageWithName()
    {
        string? name = "Kelly";
        string expected = "Hello, Kelly, you are awesome!";

        string message = Program.GetMessage(name);

        Assert.That(message, Is.EqualTo(expected));
    }

    [Test]
    public void GetMessage_WithNullName_ReturnsMessage()
    {
        string? name = null;
        string expected = "Hello. It is nice to meet you!";

        string message = Program.GetMessage(name);

        Assert.That(message, Is.EqualTo(expected));
    }

    [Test]
    public void GetMessage_WithEmptyName_ReturnsMessage()
    {
        string? name = "";
        string expected = "Hello. It is nice to meet you!";

        string message = Program.GetMessage(name);

        Assert.That(message, Is.EqualTo(expected));
    }

    [Test]
    public void GetMessage_WithOtherName_ReturnsDefaultMessageWithName()
    {
        string? name = "Brian";
        string expected = "Hello, Brian. It looks like you are new here.";

        string message = Program.GetMessage(name);

        Assert.That(message, Is.EqualTo(expected));
    }
}