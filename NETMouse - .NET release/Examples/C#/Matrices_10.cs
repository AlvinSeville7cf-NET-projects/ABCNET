using ABCNET.Extensions;
using ABCNET.Utils;

namespace TestProgram
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Matr.Gen(3, 3, (i, j) => i + 1).Print();
        }
    }
}