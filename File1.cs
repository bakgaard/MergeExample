using System;
using mergeExample.Interfaces;

namespace mergeExample
{
	private readonly IMyInterface MyClass;

	public void main()
	{
		MyClass = new Implementor();
		var input = MyClass.GloriousMethod("A");

		var output = MyFunction("input");
		Console.WriteLine(output);
	}

	private string MyFunction(string input)
	{
		var x = "An example";
		x += $" of file {input}";
		return x;
	}

	public class Implementor : IMyInterface
	{
		public string GloriousMethod(string input)
		{
			var somethingMagical = input;
			return somethingMagical;
		}
	}
}