using ABCNET.Extensions;
using ABCNET.Utils;

namespace TestProgram
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Array.Of(1, 2);
            Matr.Rand(2, 3, 0, 10).PrintBy(x => x, ", ", "[", "]");
            "Hell".PrintLine();
            //Matr.ReadInt32(Base.ReadInt32("N:"), Base.ReadInt32("M:"), "Элемент ({0}, {1})-ый:").Count().Numerate().MaxBy(x => x.Item).Index.Println();
        }
    }
}