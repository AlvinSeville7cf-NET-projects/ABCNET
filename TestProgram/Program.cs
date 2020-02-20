using ABCNET.Extensions;
using ABCNET.Utils;
using System.Linq;
using System;

namespace TestProgram
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            new int[2, 2]
            {
                { 1, 2 },
                { 3, 4 }
            }.Println().SetCol(new int[] { -1, -3 }, 0).Println();
        }
    }
}