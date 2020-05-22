using ABCNET.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ABCNET.Extensions
{
    /// <summary>
    /// Предоставляет функционал для работы с массивами.
    /// </summary>
    public static partial class ArrayE
    {
    	
    	public static partial class Nullable
    	{

        #region public

        /// <summary>
        /// Заполняет массив значениями типа Boolean?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this bool?[] array, string prompt = null)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            prompt = prompt ?? EmptyStringHelper.Empty;

            int i = 0;
            while (i < array.Length)
            {
                array[i] = Base.Nullable.ReadBoolean(string.Format(prompt, i));
                i++;
            }
        }

        /// <summary>
        /// Заполняет массив значениями типа Byte?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this byte?[] array, string prompt = null)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            prompt = prompt ?? EmptyStringHelper.Empty;

            int i = 0;
            while (i < array.Length)
            {
                array[i] = Base.Nullable.ReadByte(string.Format(prompt, i));
                i++;
            }
        }

        /// <summary>
        /// Заполняет массив значениями типа SByte?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this sbyte?[] array, string prompt = null)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            prompt = prompt ?? EmptyStringHelper.Empty;

            int i = 0;
            while (i < array.Length)
            {
                array[i] = Base.Nullable.ReadSByte(string.Format(prompt, i));
                i++;
            }
        }

        /// <summary>
        /// Заполняет массив значениями типа Char?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this char?[] array, string prompt = null)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            prompt = prompt ?? EmptyStringHelper.Empty;

            int i = 0;
            while (i < array.Length)
            {
                array[i] = Base.Nullable.ReadChar(string.Format(prompt, i));
                i++;
            }
        }

        /// <summary>
        /// Заполняет массив значениями типа Decimal?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this decimal?[] array, string prompt = null)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            prompt = prompt ?? EmptyStringHelper.Empty;

            int i = 0;
            while (i < array.Length)
            {
                array[i] = Base.Nullable.ReadDecimal(string.Format(prompt, i));
                i++;
            }
        }

        /// <summary>
        /// Заполняет массив значениями типа Double?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this double?[] array, string prompt = null)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            prompt = prompt ?? EmptyStringHelper.Empty;

            int i = 0;
            while (i < array.Length)
            {
                array[i] = Base.Nullable.ReadDouble(string.Format(prompt, i));
                i++;
            }
        }

        /// <summary>
        /// Заполняет массив значениями типа Single?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this float?[] array, string prompt = null)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            prompt = prompt ?? EmptyStringHelper.Empty;

            int i = 0;
            while (i < array.Length)
            {
                array[i] = Base.Nullable.ReadSingle(string.Format(prompt, i));
                i++;
            }
        }

        /// <summary>
        /// Заполняет массив значениями типа Int32?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this int?[] array, string prompt = null)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            prompt = prompt ?? EmptyStringHelper.Empty;

            int i = 0;
            while (i < array.Length)
            {
                array[i] = Base.Nullable.ReadInt32(string.Format(prompt, i));
                i++;
            }
        }

        /// <summary>
        /// Заполняет массив значениями типа UInt32?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this uint?[] array, string prompt = null)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            prompt = prompt ?? EmptyStringHelper.Empty;

            int i = 0;
            while (i < array.Length)
            {
                array[i] = Base.Nullable.ReadUInt32(string.Format(prompt, i));
                i++;
            }
        }

        /// <summary>
        /// Заполняет массив значениями типа Int64?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this long?[] array, string prompt = null)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            prompt = prompt ?? EmptyStringHelper.Empty;

            int i = 0;
            while (i < array.Length)
            {
                array[i] = Base.Nullable.ReadInt64(string.Format(prompt, i));
                i++;
            }
        }

        /// <summary>
        /// Заполняет массив значениями типа UInt64?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this ulong?[] array, string prompt = null)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            prompt = prompt ?? EmptyStringHelper.Empty;

            int i = 0;
            while (i < array.Length)
            {
                array[i] = Base.Nullable.ReadUInt64(string.Format(prompt, i));
                i++;
            }
        }

        /// <summary>
        /// Заполняет массив значениями типа Int16?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this short?[] array, string prompt = null)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            prompt = prompt ?? EmptyStringHelper.Empty;

            int i = 0;
            while (i < array.Length)
            {
                array[i] = Base.Nullable.ReadInt16(string.Format(prompt, i));
                i++;
            }
        }

        /// <summary>
        /// Заполняет массив значениями типа UInt16?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this ushort?[] array, string prompt = null)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            prompt = prompt ?? EmptyStringHelper.Empty;

            int i = 0;
            while (i < array.Length)
            {
                array[i] = Base.Nullable.ReadUInt16(string.Format(prompt, i));
                i++;
            }
        }

        /// <summary>
        /// Заполняет массив значениями типа BigInteger?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this BigInteger?[] array, string prompt = null)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            prompt = prompt ?? EmptyStringHelper.Empty;

            int i = 0;
            while (i < array.Length)
            {
                array[i] = Base.Nullable.ReadBigInteger(string.Format(prompt, i));
                i++;
            }
        }

        #endregion
    	}

    }
}
