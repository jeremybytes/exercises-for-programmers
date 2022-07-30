using quotes;

namespace quotes_test;

public class Tests
{
    [Test]
    public void GetOutput_OnEntry_ReturnsQuoteAndAuthor()
    {
        string quote = "These aren't the droids you're looking for.";
        string author = "Obi-Wan Kenobi";
        string expected = "Obi-Wan Kenobi says, \"These aren't the droids you're looking for.\"";

        string output = Program.GetOutput(quote, author);

        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void GetOutput_OnNullQuote_Errors()
    {
        string? quote = null;
        string? author = "Obi-Wan Kenobi";

        Assert.Throws<ArgumentNullException>(() => Program.GetOutput(quote, author));
    }

    [Test]
    public void GetOutput_OnBlankQuote_Errors()
    {
        string? quote = "";
        string? author = "Obi-Wan Kenobi";

        Assert.Throws<ArgumentNullException>(() => Program.GetOutput(quote, author));
    }

    [Test]
    public void GetOutput_OnNullAuthor_Errors()
    {
        string? quote = "These aren't the droids you're looking for.";
        string? author = null;

        Assert.Throws<ArgumentNullException>(() => Program.GetOutput(quote, author));
    }

    [Test]
    public void GetOutput_OnBlankAuthor_Errors()
    {
        string? quote = "These aren't the droids you're looking for.";
        string? author = "";

        Assert.Throws<ArgumentNullException>(() => Program.GetOutput(quote, author));
    }
}