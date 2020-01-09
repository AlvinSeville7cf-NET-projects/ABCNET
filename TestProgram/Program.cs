using ABCNET.Extensions;
using ABCNET.Utils;

namespace TestProgram
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			foreach (var item in Arr.Gen(10, i => i).Batch(3, x => x + 1))
				item.Println();
		}
	}
}
