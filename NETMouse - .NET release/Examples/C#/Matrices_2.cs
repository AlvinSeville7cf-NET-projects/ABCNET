using ABCNET.Extensions;
using ABCNET.Utils;
using System;

namespace TestProgram
{
    internal static class Program
    {
        public static int[] Sum(this int[,] matrix)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            int[] result = new int[matrix.GetLength(0)];
            int rowsCount = matrix.GetLength(0);
            int colsCount = matrix.GetLength(1);
            for (int i = 0; i < rowsCount; i++)
                for (int j = 0; j < colsCount; j++)
                    result[i] += matrix[i, j];

            return result;
        }

        private static void Main(string[] args)
        {
            Matr.ReadInteger(Base.ReadInteger("N:"), Base.ReadInteger("M:"), "Элемент ({0}, {1})-ый:").Sum().Println();
        }
    }
}