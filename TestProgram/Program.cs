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
            int[] a = new int[5];
            a.Fill(1);
            //a.ToTup5().PrintlnBy(d=>d+10).Println();
            a.Print();
            Console.Write("asd");
            Console.Read();
        }
    }
}