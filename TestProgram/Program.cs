using ABCNET.Extensions;
using ABCNET.Utils;

namespace TestProgram
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var a = Matr.Fill(10, 10, 2);
			a.Print();
			a.Gen((i, j) => (i + j) % 2);
			a.Print();
			Matr.New(2, 2, 1, 2, 3, 4).Print();
		}
	}
}
