using ABCNET.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ABCNET.Extensions
{
    /// <summary>
    /// Предоставляет функционал для работы с базовыми типами.
    /// </summary>
    public static partial class MatrixE
    {

        #region public

        /// <summary>
        /// Заполняет матрицу значениями типа Boolean?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this bool?[,] matrix, string prompt = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            prompt = prompt ?? EmptyStringHelper.Empty;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Base.Nullable.ReadBoolean(string.Format(prompt, i, j));
                }
            }
        }
 
        /// <summary>
        /// Заполняет матрицу значениями типа Byte?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this byte?[,] matrix, string prompt = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            prompt = prompt ?? EmptyStringHelper.Empty;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Base.Nullable.ReadByte(string.Format(prompt, i, j));
                }
            }
        }
 
        /// <summary>
        /// Заполняет матрицу значениями типа SByte?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this sbyte?[,] matrix, string prompt = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            prompt = prompt ?? EmptyStringHelper.Empty;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Base.Nullable.ReadSByte(string.Format(prompt, i, j));
                }
            }
        }
 
        /// <summary>
        /// Заполняет матрицу значениями типа Char?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this char?[,] matrix, string prompt = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            prompt = prompt ?? EmptyStringHelper.Empty;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Base.Nullable.ReadChar(string.Format(prompt, i, j));
                }
            }
        }
 
        /// <summary>
        /// Заполняет матрицу значениями типа Decimal?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this decimal?[,] matrix, string prompt = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            prompt = prompt ?? EmptyStringHelper.Empty;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Base.Nullable.ReadDecimal(string.Format(prompt, i, j));
                }
            }
        }
 
        /// <summary>
        /// Заполняет матрицу значениями типа Double?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this double?[,] matrix, string prompt = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            prompt = prompt ?? EmptyStringHelper.Empty;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Base.Nullable.ReadDouble(string.Format(prompt, i, j));
                }
            }
        }
 
        /// <summary>
        /// Заполняет матрицу значениями типа Single?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this float?[,] matrix, string prompt = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            prompt = prompt ?? EmptyStringHelper.Empty;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Base.Nullable.ReadSingle(string.Format(prompt, i, j));
                }
            }
        }
 
        /// <summary>
        /// Заполняет матрицу значениями типа Int32?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this int?[,] matrix, string prompt = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            prompt = prompt ?? EmptyStringHelper.Empty;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Base.Nullable.ReadInt32(string.Format(prompt, i, j));
                }
            }
        }
 
        /// <summary>
        /// Заполняет матрицу значениями типа UInt32?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this uint?[,] matrix, string prompt = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            prompt = prompt ?? EmptyStringHelper.Empty;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Base.Nullable.ReadUInt32(string.Format(prompt, i, j));
                }
            }
        }
 
        /// <summary>
        /// Заполняет матрицу значениями типа Int64?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this long?[,] matrix, string prompt = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            prompt = prompt ?? EmptyStringHelper.Empty;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Base.Nullable.ReadInt64(string.Format(prompt, i, j));
                }
            }
        }
 
        /// <summary>
        /// Заполняет матрицу значениями типа UInt64?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this ulong?[,] matrix, string prompt = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            prompt = prompt ?? EmptyStringHelper.Empty;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Base.Nullable.ReadUInt64(string.Format(prompt, i, j));
                }
            }
        }
 
        /// <summary>
        /// Заполняет матрицу значениями типа Int16?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this short?[,] matrix, string prompt = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            prompt = prompt ?? EmptyStringHelper.Empty;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Base.Nullable.ReadInt16(string.Format(prompt, i, j));
                }
            }
        }
 
        /// <summary>
        /// Заполняет матрицу значениями типа UInt16?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this ushort?[,] matrix, string prompt = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            prompt = prompt ?? EmptyStringHelper.Empty;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Base.Nullable.ReadUInt16(string.Format(prompt, i, j));
                }
            }
        }
 
        /// <summary>
        /// Заполняет матрицу значениями типа BigInteger?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this BigInteger?[,] matrix, string prompt = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            prompt = prompt ?? EmptyStringHelper.Empty;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Base.Nullable.ReadBigInteger(string.Format(prompt, i, j));
                }
            }
        }

        #endregion

    }
}
