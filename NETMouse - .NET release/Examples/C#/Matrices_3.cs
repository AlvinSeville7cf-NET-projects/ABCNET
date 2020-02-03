using ABCNET.Extensions;
using ABCNET.Utils;
using System;

namespace TestProgram
{
    internal static class Program
    {
        public static int Min(this int[,] matrix)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            int min = int.MaxValue;
            int rowsCount = matrix.GetLength(0);
            int colsCount = matrix.GetLength(1);
            for (int i = 0; i < rowsCount; i++)
                for (int j = 0; j < colsCount; j++)
                    if (min > matrix[i, j])
                        min = matrix[i, j];

            return min;
        }

        private static void Main(string[] args)
        {
            Matr.Rand(Base.ReadInteger("N:"), Base.ReadInteger("M:"), -30, 45).Print().Min().Println();
        }
    }
}