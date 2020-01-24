using ABCNET.Extensions;
using ABCNET.Utils;
using System.Linq;

namespace TestProgram
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Arr.ReadInteger(Base.ReadInteger("N:"), "Элемент {0}-ый:").Where(x => x == 0).Count().Println();
        }
    }
}