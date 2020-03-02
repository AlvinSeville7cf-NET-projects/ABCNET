using System;
using ABCNET.Utils;

namespace ABCNET.Extensions
{
    /// <summary>
    /// Предоставляет функционал для работы с матрицами.
    /// </summary>
    public static partial class MatrExt
    {
        #region public
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
        #endregion public
    }
}
