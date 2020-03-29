using System;

namespace ABCNET.Extensions
{
    /// <summary>
    /// Предоставляет функционал для работы с матрицами.
    /// </summary>
    public static partial class MatrixE
    {
        #region public

        /// <summary>
        /// Выводит матрицу.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="delimiter">Разделитель.</param>
        /// <param name="start">Первый выводимый символ строки.</param>
        /// <param name="end">Последний выводимый символ строки.</param>
        public static T[,] Print<T>(this T[,] matrix, string delimiter = DefaultDelimiterHelper.Delimiter, string start = EmptyStringHelper.Empty, string end = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            return matrix.InternalPrint(delimiter, start, end);
        }

        /// <summary>
        /// Выводит матрицу и переходит на новую строку.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="delimiter">Разделитель.</param>
        /// <param name="start">Первый выводимый символ строки.</param>
        /// <param name="end">Последний выводимый символ строки.</param>
        public static T[,] Println<T>(this T[,] matrix, string delimiter = DefaultDelimiterHelper.Delimiter, string start = EmptyStringHelper.Empty, string end = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            matrix.Print(delimiter, start, end);
            Console.WriteLine();
            return matrix;
        }

        /// <summary>
        /// Выводит матрицу.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <param name="delimiter">Разделитель.</param>
        /// <param name="start">Первый выводимый символ строки.</param>
        /// <param name="end">Последний выводимый символ строки.</param>
        public static T[,] PrintBy<T, TOutput>(this T[,] matrix, Func<T, TOutput> selector, string delimiter = DefaultDelimiterHelper.Delimiter, string start = EmptyStringHelper.Empty, string end = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return matrix.InternalPrintBy(selector, delimiter, start, end);
        }

        /// <summary>
        /// Выводит матрицу и переходит на новую строку.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <param name="delimiter">Разделитель.</param>
        /// <param name="start">Первый выводимый символ строки.</param>
        /// <param name="end">Последний выводимый символ строки.</param>
        public static T[,] PrintlnBy<T, TOutput>(this T[,] matrix, Func<T, TOutput> selector, string delimiter = DefaultDelimiterHelper.Delimiter, string start = EmptyStringHelper.Empty, string end = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            matrix.PrintBy(selector, delimiter, start, end);
            Console.WriteLine();
            return matrix;
        }

        #endregion public

        #region private
        private static T[,] InternalPrint<T>(this T[,] matrix, string delimiter = DefaultDelimiterHelper.Delimiter, string start = EmptyStringHelper.Empty, string end = EmptyStringHelper.Empty)
        {
            int rowsCount = matrix.GetLength(0);
            int columnsCount = matrix.GetLength(1);
            int[] lengths = new int[columnsCount];

            for (int j = 0; j < columnsCount; j++)
                for (int i = 0; i < rowsCount; i++)
                {
                    int itemLength = matrix[i, j].ToString().Length;
                    if (itemLength > lengths[j])
                        lengths[j] = itemLength;
                }

            for (int i = 0; i < rowsCount - 1; i++)
            {
                Console.Write(start);
                for (int j = 0; j < columnsCount; j++)
                    Console.Write(string.Format("{0}{1}", matrix[i, j].NilOrString().PadLeft(lengths[j]), j < columnsCount - 1 ? delimiter : string.Empty));
                Console.WriteLine(end);
            }
            Console.Write(start);
            for (int j = 0; j < columnsCount; j++)
                Console.Write(string.Format("{0}{1}", matrix[rowsCount - 1, j].NilOrString().PadLeft(lengths[j]), j < columnsCount - 1 ? delimiter : string.Empty));
            Console.Write(end);

            return matrix;
        }

        private static T[,] InternalPrintBy<T, TOutput>(this T[,] matrix, Func<T, TOutput> selector, string delimiter = DefaultDelimiterHelper.Delimiter, string start = EmptyStringHelper.Empty, string end = EmptyStringHelper.Empty)
        {
            int rowsCount = matrix.GetLength(0);
            int columnsCount = matrix.GetLength(1);
            int[] lengths = new int[columnsCount];

            for (int j = 0; j < columnsCount; j++)
                for (int i = 0; i < rowsCount; i++)
                {
                    int itemLength = selector(matrix[i, j]).ToString().Length;
                    if (itemLength > lengths[j])
                        lengths[j] = itemLength;
                }

            for (int i = 0; i < rowsCount - 1; i++)
            {
                Console.Write(start);
                for (int j = 0; j < columnsCount; j++)
                    Console.Write(string.Format("{0}{1}", selector(matrix[i, j]).NilOrString().PadLeft(lengths[j]), j < columnsCount - 1 ? delimiter : string.Empty));
                Console.WriteLine(end);
            }
            Console.Write(start);
            for (int j = 0; j < columnsCount; j++)
                Console.Write(string.Format("{0}{1}", selector(matrix[rowsCount - 1, j]).NilOrString().PadLeft(lengths[j]), j < columnsCount - 1 ? delimiter : string.Empty));
            Console.Write(end);

            return matrix;
        }

        #endregion private
    }
}
