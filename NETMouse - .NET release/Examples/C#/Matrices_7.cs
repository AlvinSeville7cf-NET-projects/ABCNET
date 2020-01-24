using ABCNET.Extensions;
using ABCNET.Utils;

namespace TestProgram
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Matr.Gen(4, 4, (i, j) => i == j ? 1 : 0).Print();
        }
    }
}