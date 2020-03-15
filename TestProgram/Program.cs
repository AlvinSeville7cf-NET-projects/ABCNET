using ABCNET.Extensions;
using ABCNET.Utils;
using System;

namespace TestProgram
{
    internal static class Program
    {
        public static int[] Count(this int[,] matrix)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            int[] result = new int[matrix.GetLength(1)];
            int rowsCount = matrix.GetLength(0);
            int colsCount = matrix.GetLength(1);
            for (int j = 0; j < colsCount; j++)
                for (int i = 0; i < rowsCount; i++)
                    if (matrix[i, j] < 0)
                        result[j] += 1;

            return result;
        }

        private static void Main(string[] args)
        {
            //Matr.ReadInt32(Base.ReadInt32("N:"), Base.ReadInt32("M:"), "Элемент ({0}, {1})-ый:").Count().Numerate().MaxBy(x => x.Item).Index.Println();
            Base.Nullable.ReadInt32().Println();
        }
    }
}