using ABCNET.Extensions;
using ABCNET.Utils;

namespace TestProgram
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Matr.Rand(Base.ReadInteger("N:"), Base.ReadInteger("M:"), -20, 25).Print();
        }
    }
}