using ABCNET.Utils;
using System.Linq;

namespace TestProgram
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] a = Arr.ReadInteger(Base.ReadInteger("N:"), "Элемент {0}-ый:");
            int[] b = a.Where(x => x % 2 == 0).ToArray();
        }
    }
}