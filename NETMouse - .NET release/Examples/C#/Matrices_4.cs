using ABCNET.Extensions;
using ABCNET.Utils;
using System;

namespace TestProgram
{
    internal static class Program
    {
        public static Tuple<int, int> Min(this int[,] matrix)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            int min = int.MaxValue;
            int minRow = 0;
            int rowsCount = matrix.GetLength(0);
            int colsCount = matrix.GetLength(1);
            for (int i = 0; i < rowsCount; i++)
                for (int j = 0; j < colsCount; j++)
                    if (min > matrix[i, j])
                    {
                        min = matrix[i, j];
                        minRow = i;
                    }

            return Tup.New(min, minRow);
        }

        private static void Main(string[] args)
        {
            Matr.ReadInteger(Base.ReadInteger("N:"), Base.ReadInteger("M:"), "Элемент ({0}, {1})-ый:").Min().Println();
        }
    }
}