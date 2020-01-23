using ABCNET.Extensions;
using ABCNET.Utils;
using System;

namespace TestProgram
{
    internal static class Program
    {
        public static int[,] Sort(this int[,] matrix)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            int[,] result = (int[,])matrix.Clone();
            int rowsCount = result.GetLength(0);
            int colsCount = result.GetLength(1);
            for (int j = 0; j < colsCount; j++)
                for (int k = 0; k < rowsCount; k++)
                    for (int i = 0; i < rowsCount - k - 1; i++)
                        if (result[i, j] > result[i + 1, j])
                            Base.Swap(ref result[i, j], ref result[i + 1, j]);

            return result;
        }

        private static void Main(string[] args)
        {
            Matr.Rand(Base.ReadInteger("N:"), Base.ReadInteger("M:"), -17, 26).Print().Sort().Print();
        }
    }
}