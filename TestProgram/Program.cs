using NETMouse.Extensions;
using NETMouse.Utils;

namespace TestProgram
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Arr.Gen(10, i => i).Print();
		}
	}
}