using ABCNET.Extensions;
using ABCNET.Utils;

namespace TestProgram
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Seq.Gen(10, i => i, 100).Println().Associate(x => (char)x).Println();
		}
	}
}
