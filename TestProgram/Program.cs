using ABCNET.Extensions;
using ABCNET.Utils;

namespace TestProgram
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Arr.New<byte>(1, 2, 3).ToTup3().Println();
        }
    }
}