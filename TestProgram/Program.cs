using ABCNET.Extensions;
using ABCNET.Utils;

namespace TestProgram
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Seq.Gen(10, i => i).Associate(x => x + 2).Println();
		}
	}
}
