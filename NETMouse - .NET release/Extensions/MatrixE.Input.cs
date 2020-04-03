using System;
using System.Numerics;
using ABCNET.Utils;

namespace ABCNET.Extensions
{
    /// <summary>
    /// Предоставляет функционал для работы с матрицами.
    /// </summary>
    public static partial class MatrixE
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
        /// Заполняет матрицу значениями типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this byte[,] matrix, string prompt = EmptyStringHelper.Empty)
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
                        matrix[i, j] = Base.ReadByte(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
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
        /// Заполняет матрицу значениями типа Sbyte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this sbyte[,] matrix, string prompt = EmptyStringHelper.Empty)
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
                        matrix[i, j] = Base.ReadSbyte(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
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

            int i = 0;
            int j = 0;

            while (i < matrix.GetLength(0))
            {
                while (j < matrix.GetLength(1))
                    try
                    {
                        matrix[i, j] = Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
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
        /// Заполняет матрицу значениями типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this decimal[,] matrix, string prompt = EmptyStringHelper.Empty)
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
                        matrix[i, j] = Base.ReadDecimal(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
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
        /// Заполняет матрицу значениями типа Float. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this float[,] matrix, string prompt = EmptyStringHelper.Empty)
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
                        matrix[i, j] = Base.ReadFloat(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
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
        /// Заполняет матрицу значениями типа Int. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
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
                        matrix[i, j] = Base.ReadInt(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
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
        /// Заполняет матрицу значениями типа Uint. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this uint[,] matrix, string prompt = EmptyStringHelper.Empty)
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
                        matrix[i, j] = Base.ReadUint(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
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
        /// Заполняет матрицу значениями типа Long. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this long[,] matrix, string prompt = EmptyStringHelper.Empty)
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
                        matrix[i, j] = Base.ReadLong(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
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
        /// Заполняет матрицу значениями типа Ulong. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this ulong[,] matrix, string prompt = EmptyStringHelper.Empty)
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
                        matrix[i, j] = Base.ReadUlong(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
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
        /// Заполняет матрицу значениями типа Short. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this short[,] matrix, string prompt = EmptyStringHelper.Empty)
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
                        matrix[i, j] = Base.ReadShort(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
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
        /// Заполняет матрицу значениями типа Ushort. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this ushort[,] matrix, string prompt = EmptyStringHelper.Empty)
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
                        matrix[i, j] = Base.ReadUshort(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
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
        /// Заполняет матрицу значениями типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this BigInteger[,] matrix, string prompt = EmptyStringHelper.Empty)
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
                        matrix[i, j] = Base.ReadBigInteger(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
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

            int i = 0;
            int j = 0;

            while (i < matrix.GetLength(0))
            {
                while (j < matrix.GetLength(1))
                    try
                    {
                        matrix[i, j] = Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
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

        #endregion public
    }
}
