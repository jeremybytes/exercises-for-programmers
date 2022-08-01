using mad_libs;

namespace mad_libs_test;

public class Tests
{
    [Test]
    public void GetOutput_WithAllWords_ReturnsPhrase()
    {
        string noun = "dog";
        string verb = "walk";
        string adjective = "blue";
        string adverb = "quickly";
        string expected = "Do you walk your blue dog quickly? That's hilarious!";

        string output = Program.GetOutput(noun, verb, adjective, adverb);
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void GetOutput_WithMissingNoun_ThrowsException()
    {
        string noun = "";
        string verb = "walk";
        string adjective = "blue";
        string adverb = "quickly";

        Assert.Throws<ArgumentNullException>(() => Program.GetOutput(noun, verb, adjective, adverb));
    }

    [Test]
    public void GetOutput_WithMissingVerb_ThrowsException()
    {
        string noun = "dog";
        string verb = "";
        string adjective = "blue";
        string adverb = "quickly";

        Assert.Throws<ArgumentNullException>(() => Program.GetOutput(noun, verb, adjective, adverb));
    }

    [Test]
    public void GetOutput_WithMissingAdjective_SkipsAdjective()
    {
        string noun = "dog";
        string verb = "walk";
        string adjective = "";
        string adverb = "quickly";
        string expected = "Do you walk your dog quickly? That's hilarious!";

        string output = Program.GetOutput(noun, verb, adjective, adverb);
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void GetOutput_WithMissingAdverb_SkipsAdverb()
    {
        string noun = "dog";
        string verb = "walk";
        string adjective = "blue";
        string adverb = "";
        string expected = "Do you walk your blue dog? That's hilarious!";

        string output = Program.GetOutput(noun, verb, adjective, adverb);
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void GetOutput_WithPaddedNoun_ReturnsPhrase()
    {
        string noun = "   dog   ";
        string verb = "walk";
        string adjective = "blue";
        string adverb = "quickly";
        string expected = "Do you walk your blue dog quickly? That's hilarious!";

        string output = Program.GetOutput(noun, verb, adjective, adverb);
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void GetOutput_WithPaddedVerb_ReturnsPhrase()
    {
        string noun = "dog";
        string verb = "   walk   ";
        string adjective = "blue";
        string adverb = "quickly";
        string expected = "Do you walk your blue dog quickly? That's hilarious!";

        string output = Program.GetOutput(noun, verb, adjective, adverb);
        Assert.That(output, Is.EqualTo(expected));
    }

}