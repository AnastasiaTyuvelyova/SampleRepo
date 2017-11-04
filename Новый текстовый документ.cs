using SYstem;
class SampleClass{
	SampleClass(string str) { this.str = str; }
	private string str;
}
class SecondCLass {
	static Main()
	{
		SampleClass sc = new SampleCLass("Hello");
		Console.Readline();
	}
}