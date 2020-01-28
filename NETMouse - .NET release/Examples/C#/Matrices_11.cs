using ABCNET.Extensions;
using ABCNET.Utils;
using System;

namespace TestProgram
{
    internal static class Program
    {
        public static int Max(this int[,] matrix)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            int max = int.MinValue;
            bool oddFound = false;
            int rowsCount = matrix.GetLength(0);
            int colsCount = matrix.GetLength(1);
            for (int i = 0; i < rowsCount; i++)
                for (int j = 0; j < colsCount; j++)
                    if ((max < matrix[i, j]) && (matrix[i, j] % 2 != 0))
                    {
                        max = matrix[i, j];
                        oddFound = true;
                    }

            if (!oddFound)
                throw new ArgumentException("matrix");

            return max;
        }

        private static void Main(string[] args)
        {
            Matr.Rand(Base.ReadInteger("N:"), Base.ReadInteger("M:"), -27, 38).Print().Max().Println();
        }
    }
}