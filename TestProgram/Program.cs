using NETMouse.Extensions;
using NETMouse.Utils;
using System;

namespace TestProgram
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Arr.ReadInteger(3).Println();
			Matr.ReadInteger(2, 2).Print();
		}
	}
}