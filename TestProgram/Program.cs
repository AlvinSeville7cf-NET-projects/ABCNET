using NETMouse.Extensions;
using NETMouse.Utils;
using System;
using System.Linq;

namespace TestProgram
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Seq.Rand(10, 0, 2).Print();
			Tuple.Create(1, 2).Println();
		}
	}
}