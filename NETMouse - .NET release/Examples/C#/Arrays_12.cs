using ABCNET.Extensions;
using ABCNET.Utils;
using System.Linq;

namespace TestProgram
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int c = Base.ReadInteger("C:");
            Arr.ReadInteger(10, "Элемент {0}-ый:").Where(x => x > c).Average().Println();
        }
    }
}