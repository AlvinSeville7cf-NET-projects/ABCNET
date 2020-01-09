using ABCNET.Extensions;
using ABCNET.Utils;

namespace TestProgram
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Arr.Gen(10, i => i).Pairwise(x => x + 1).Println();
		}
	}
}
