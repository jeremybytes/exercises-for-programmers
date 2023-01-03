namespace retirement;

public class RetirementException : Exception
{
	public RetirementException()
		: base() { }

	public RetirementException(string message)
		: base(message) { }

	public RetirementException(string message, Exception inner)
		: base(message, inner) { }
}
