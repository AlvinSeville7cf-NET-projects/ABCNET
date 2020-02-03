using ABCNET.Extensions;
using ABCNET.Utils;
using System.Linq;

namespace TestProgram
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            //100.To(999).Where(x=>
            //  {
            //      var c = x % 10;
            //      var b = x % 100 / 10;
            //      var a = x / 100;
            //      var s = a + b + c;
            //      return (s == x % 100) || (s == c * 10 + b);
            //  }).Println();
            //Base.ReadChar();
            int[,] matr = new int[10, 10];
            matr.Rand(0, 10);
            matr.Print("||");
            matr.Read();
        }
    }
}