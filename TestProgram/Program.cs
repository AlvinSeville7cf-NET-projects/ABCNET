using ABCNET.Extensions;
using ABCNET.Utils;

namespace TestProgram
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var a = Arr.Fill(10, 2);
			a.Println();
			a.Gen(i => i * 2);
			a.Println();
		}
	}
}