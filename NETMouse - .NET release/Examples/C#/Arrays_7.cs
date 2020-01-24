using ABCNET.Extensions;
using ABCNET.Utils;
using System.Linq;

namespace TestProgram
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int t = Base.ReadInteger("T:");
            Arr.Rand(Base.ReadInteger("N:"), -56, 47).Println()
                .Where((x, i) => (i % 2 == 0) && (x > t)).Aggregate((a, b) => a * b).Println();
        }
    }
}
