using ABCNET.Extensions;
using ABCNET.Utils;

namespace TestProgram
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Arr.Rand(Base.ReadInteger("N:"), -20, 25).Println().Numerate().MinBy(x => x.Item).Index.Println();
        }
    }
}