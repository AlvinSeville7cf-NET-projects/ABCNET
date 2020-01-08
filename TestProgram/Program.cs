using ABCNET.Extensions;
using ABCNET.Utils;

namespace TestProgram
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Tup.New(1, 2, 3).Println();
			Arr.New(1, 2, 3).Println();
			Matr.New(2, 2,
				1, 2,
				3, 4).Print();
		}
	}
}
