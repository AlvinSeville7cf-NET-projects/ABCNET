using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ABCNET.Utils;

namespace ABCNET.Extensions
{
    public static class Output1
    {
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

            matrix.InternalPrint(delimiter, start, end);
            Console.WriteLine();
            return matrix;
        }

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

            matrix.InternalPrintBy(selector, delimiter, start, end);
            Console.WriteLine();
            return matrix;
        }



        /// <summary>
        /// Заполняет матрицу значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this bool[,] matrix, string prompt = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            int i = 0;
            int j = 0;

            while (i < matrix.GetLength(0))
            {
                while (j < matrix.GetLength(1))
                    try
                    {
                        matrix[i, j] = Base.ReadBoolean(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
                        j++;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(InputErrorHelper.Message);
                    }

                i++;
                j = 0;
            }
        }

        /// <summary>
        /// Заполняет матрицу значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this char[,] matrix, string prompt = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
        }

        /// <summary>
        /// Заполняет матрицу значениями типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this double[,] matrix, string prompt = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            int i = 0;
            int j = 0;

            while (i < matrix.GetLength(0))
            {
                while (j < matrix.GetLength(1))
                    try
                    {
                        matrix[i, j] = Base.ReadDouble(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
                        j++;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(InputErrorHelper.Message);
                    }

                i++;
                j = 0;
            }
        }

        /// <summary>
        /// Заполняет матрицу значениями типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this int[,] matrix, string prompt = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            int i = 0;
            int j = 0;

            while (i < matrix.GetLength(0))
            {
                while (j < matrix.GetLength(1))
                    try
                    {
                        matrix[i, j] = Base.ReadInt32(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
                        j++;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(InputErrorHelper.Message);
                    }

                i++;
                j = 0;
            }
        }

        /// <summary>
        /// Заполняет матрицу значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this string[,] matrix, string prompt = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
        }

        #region Internal

        private static T[,] InternalPrintln<T>(this T[,] matrix, string delimiter = DefaultDelimiterHelper.Delimiter, string start = EmptyStringHelper.Empty, string end = EmptyStringHelper.Empty)
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

            for (int i = 0; i < rowsCount; i++)
            {
                Console.Write(start);
                for (int j = 0; j < columnsCount; j++)
                    Console.Write(string.Format("{0}{1}", matrix[i, j].NilOrString().PadLeft(lengths[j]), j < columnsCount - 1 ? delimiter : string.Empty));
                Console.WriteLine(end);
            }

            return matrix;
        }

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
                {
                    Console.Write(string.Format("{0}{1}", matrix[i, j].NilOrString().PadLeft(lengths[j]), j < columnsCount - 1 ? delimiter : string.Empty));
                    Console.WriteLine(end);
                }
            }
            for (int j = 0; j < columnsCount; j++)
            {
                Console.Write(string.Format("{0}{1}", matrix[rowsCount, j].NilOrString().PadLeft(lengths[j]), j < columnsCount - 1 ? delimiter : string.Empty));
            }
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

            for (int i = 0; i < rowsCount; i++)
            {
                Console.Write(start);
                for (int j = 0; j < columnsCount - 1; j++)
                {
                    Console.Write(string.Format("{0}{1}", selector(matrix[i, j]).NilOrString().PadLeft(lengths[j]), j < columnsCount - 1 ? delimiter : string.Empty));
                    Console.WriteLine(end);
                }
            }
            for (int j = 0; j < columnsCount; j++)
            {
                Console.Write(string.Format("{0}{1}", selector(matrix[rowsCount, j]).NilOrString().PadLeft(lengths[j]), j < columnsCount - 1 ? delimiter : string.Empty));
            }
            Console.Write(end);

            return matrix;
        }

        private static T[,] InternalPrintlnBy<T, TOutput>(this T[,] matrix, Func<T, TOutput> selector, string delimiter = DefaultDelimiterHelper.Delimiter, string start = EmptyStringHelper.Empty, string end = EmptyStringHelper.Empty)
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

            for (int i = 0; i < rowsCount; i++)
            {
                Console.Write(start);
                for (int j = 0; j < columnsCount; j++)
                    Console.Write(string.Format("{0}{1}", selector(matrix[i, j]).NilOrString().PadLeft(lengths[j]), j < columnsCount - 1 ? delimiter : string.Empty));
                Console.WriteLine(end);
            }

            return matrix;
        }

#endregion

    }
}
