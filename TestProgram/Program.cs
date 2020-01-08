using ABCNET.Extensions;
using ABCNET.Utils;

namespace TestProgram
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Matr.New(2, 2,
				1, 2,
				3, 4).Print().SwapCols(0, 1).Print();
		}
	}
}
