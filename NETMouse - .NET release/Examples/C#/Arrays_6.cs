using ABCNET.Extensions;
using ABCNET.Utils;
using System.Linq;

namespace TestProgram
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Arr.Rand(Base.ReadInteger("N:"), -19, 26).Println()
                .Where((x, i) => i % 2 != 0).Aggregate((a, b) => a * b).Println();
        }
    }
}