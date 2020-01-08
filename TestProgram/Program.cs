using ABCNET.Extensions;
using ABCNET.Utils;

namespace TestProgram
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Arr.Gen(10, i => i).ZipTuple(Arr.Gen(10, i => i + 3)).Println();
		}
	}
}
