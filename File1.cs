using System;

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
}