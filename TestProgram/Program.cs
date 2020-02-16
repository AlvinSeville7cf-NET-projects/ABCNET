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
            int[,] a = new int[5,5];
            a.Fill(1);
            //a.ToTup5().PrintlnBy(d=>d+10).Println();
            a.Println();
            Console.WriteLine();
            a.Cols().PrintLines();
            Console.WriteLine();
            a.Rows().PrintLines();
            Console.Read();
        }
    }
}