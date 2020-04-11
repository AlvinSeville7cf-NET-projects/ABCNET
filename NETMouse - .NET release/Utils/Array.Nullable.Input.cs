using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ABCNET.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы с массивами.
    /// </summary>
    public static partial class Array
    {
        /// <summary>
        /// Предоставляет функционал для работы с Nullable типами.
        /// </summary>
        public static partial class Nullable
        {
            #region public

            /// <summary>
            /// Читает массив значений типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="count">Количество элементов.</param>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Массив.</returns>
            public static bool?[] ReadBoolean(int count, string prompt = EmptyStringHelper.Empty)
            {
                if (count < 0)
                    throw new ArgumentOutOfRangeException(nameof(count));

                bool?[] array = new bool?[count];
                for (int i = 0; i < count; i++)
                    array[i] = Base.Nullable.ReadBoolean(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));

                return array;
            }

            /// <summary>
            /// Читает массив значений типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="count">Количество элементов.</param>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Массив.</returns>
            public static byte?[] ReadByte(int count, string prompt = EmptyStringHelper.Empty)
            {
                if (count < 0)
                    throw new ArgumentOutOfRangeException(nameof(count));

                byte?[] array = new byte?[count];
                for (int i = 0; i < count; i++)
                    array[i] = Base.Nullable.ReadByte(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));

                return array;
            }

            /// <summary>
            /// Читает массив значений типа SByte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="count">Количество элементов.</param>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Массив.</returns>
            public static sbyte?[] ReadSByte(int count, string prompt = EmptyStringHelper.Empty)
            {
                if (count < 0)
                    throw new ArgumentOutOfRangeException(nameof(count));

                sbyte?[] array = new sbyte?[count];
                for (int i = 0; i < count; i++)
                    array[i] = Base.Nullable.ReadSByte(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));

                return array;
            }

            /// <summary>
            /// Читает массив значений типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="count">Количество элементов.</param>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Массив.</returns>
            public static char?[] ReadChar(int count, string prompt = EmptyStringHelper.Empty)
            {
                if (count < 0)
                    throw new ArgumentOutOfRangeException(nameof(count));

                char?[] array = new char?[count];
                for (int i = 0; i < count; i++)
                    array[i] = Base.Nullable.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));

                return array;
            }

            /// <summary>
            /// Читает массив значений типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="count">Количество элементов.</param>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Массив.</returns>
            public static decimal?[] ReadDecimal(int count, string prompt = EmptyStringHelper.Empty)
            {
                if (count < 0)
                    throw new ArgumentOutOfRangeException(nameof(count));

                decimal?[] array = new decimal?[count];
                for (int i = 0; i < count; i++)
                    array[i] = Base.Nullable.ReadDecimal(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));

                return array;
            }

            /// <summary>
            /// Читает массив значений типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="count">Количество элементов.</param>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Массив.</returns>
            public static double?[] ReadDouble(int count, string prompt = EmptyStringHelper.Empty)
            {
                if (count < 0)
                    throw new ArgumentOutOfRangeException(nameof(count));

                double?[] array = new double?[count];
                for (int i = 0; i < count; i++)
                    array[i] = Base.Nullable.ReadDouble(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));

                return array;
            }

            /// <summary>
            /// Читает массив значений типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="count">Количество элементов.</param>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Массив.</returns>
            public static float?[] ReadSingle(int count, string prompt = EmptyStringHelper.Empty)
            {
                if (count < 0)
                    throw new ArgumentOutOfRangeException(nameof(count));

                float?[] array = new float?[count];
                for (int i = 0; i < count; i++)
                    array[i] = Base.Nullable.ReadSingle(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));

                return array;
            }

            /// <summary>
            /// Читает массив значений типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="count">Количество элементов.</param>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Массив.</returns>
            public static int?[] ReadInt32(int count, string prompt = EmptyStringHelper.Empty)
            {
                if (count < 0)
                    throw new ArgumentOutOfRangeException(nameof(count));

                int?[] array = new int?[count];
                for (int i = 0; i < count; i++)
                    array[i] = Base.Nullable.ReadInt32(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));

                return array;
            }

            /// <summary>
            /// Читает массив значений типа UInt32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="count">Количество элементов.</param>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Массив.</returns>
            public static uint?[] ReadUInt32(int count, string prompt = EmptyStringHelper.Empty)
            {
                if (count < 0)
                    throw new ArgumentOutOfRangeException(nameof(count));

                uint?[] array = new uint?[count];
                for (int i = 0; i < count; i++)
                    array[i] = Base.Nullable.ReadUInt32(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));

                return array;
            }

            /// <summary>
            /// Читает массив значений типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="count">Количество элементов.</param>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Массив.</returns>
            public static long?[] ReadInt64(int count, string prompt = EmptyStringHelper.Empty)
            {
                if (count < 0)
                    throw new ArgumentOutOfRangeException(nameof(count));

                long?[] array = new long?[count];
                for (int i = 0; i < count; i++)
                    array[i] = Base.Nullable.ReadInt64(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));

                return array;
            }

            /// <summary>
            /// Читает массив значений типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="count">Количество элементов.</param>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Массив.</returns>
            public static ulong?[] ReadUInt64(int count, string prompt = EmptyStringHelper.Empty)
            {
                if (count < 0)
                    throw new ArgumentOutOfRangeException(nameof(count));

                ulong?[] array = new ulong?[count];
                for (int i = 0; i < count; i++)
                    array[i] = Base.Nullable.ReadUInt64(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));

                return array;
            }

            /// <summary>
            /// Читает массив значений типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="count">Количество элементов.</param>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Массив.</returns>
            public static short?[] ReadInt16(int count, string prompt = EmptyStringHelper.Empty)
            {
                if (count < 0)
                    throw new ArgumentOutOfRangeException(nameof(count));

                short?[] array = new short?[count];
                for (int i = 0; i < count; i++)
                    array[i] = Base.Nullable.ReadInt16(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));

                return array;
            }

            /// <summary>
            /// Читает массив значений типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="count">Количество элементов.</param>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Массив.</returns>
            public static ushort?[] ReadUInt16(int count, string prompt = EmptyStringHelper.Empty)
            {
                if (count < 0)
                    throw new ArgumentOutOfRangeException(nameof(count));

                ushort?[] array = new ushort?[count];
                for (int i = 0; i < count; i++)
                    array[i] = Base.Nullable.ReadUInt16(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));

                return array;
            }

            /// <summary>
            /// Читает массив значений типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="count">Количество элементов.</param>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Массив.</returns>
            public static BigInteger?[] ReadBigInteger(int count, string prompt = EmptyStringHelper.Empty)
            {
                if (count < 0)
                    throw new ArgumentOutOfRangeException(nameof(count));

                BigInteger?[] array = new BigInteger?[count];
                for (int i = 0; i < count; i++)
                    array[i] = Base.Nullable.ReadBigInteger(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));

                return array;
            }

            #endregion
        }
    }
}
