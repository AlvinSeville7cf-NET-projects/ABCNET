using ABCNET.Extensions;
using ABCNET.Utils;

namespace TestProgram
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Arr.Rand(Base.ReadInteger("N:"), -23, 34).Println();
        }
    }
}