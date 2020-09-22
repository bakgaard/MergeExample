using System;
using mergeExample.Interfaces;

namespace mergeExample
{
	public void main()
	{
		var output = MyFunction("A");
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