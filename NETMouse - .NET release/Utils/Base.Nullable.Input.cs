using ABCNET.Extensions;
using System;

namespace ABCNET.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы с базовыми типами.
    /// </summary>
    public static partial class Base
    {
        /// <summary>
        /// Предоставляет функционал для работы с Nullable типами.
        /// </summary>
        public static partial class Nullable
        {

            #region public

            /// <summary>
            /// Читает значение типа Boolean?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static bool? ReadBoolean(string prompt = EmptyStringHelper.Empty)
            {
                string result = InternalReadNull(prompt);
                return result == null ? null : new bool?(bool.Parse(result));
            }

            /// <summary>
            /// Читает значение типа Byte?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static byte? ReadByte(string prompt = EmptyStringHelper.Empty)
            {
                string result = InternalReadNull(prompt);
                return result == null ? null : new byte?(byte.Parse(result));
            }

            /// <summary>
            /// Читает значение типа Sbyte?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static sbyte? ReadSbyte(string prompt = EmptyStringHelper.Empty)
            {
                string result = InternalReadNull(prompt);
                return result == null ? null : new sbyte?(sbyte.Parse(result));
            }

            /// <summary>
            /// Читает значение типа Decimal?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static decimal? ReadDecimal(string prompt = EmptyStringHelper.Empty)
            {
                string result = InternalReadNull(prompt);
                return result == null ? null : new decimal?(decimal.Parse(result));
            }

            /// <summary>
            /// Читает значение типа Float?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static float? ReadFloat(string prompt = EmptyStringHelper.Empty)
            {
                string result = InternalReadNull(prompt);
                return result == null ? null : new float?(float.Parse(result));
            }

            /// <summary>
            /// Читает значение типа Uint?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static uint? ReadUint(string prompt = EmptyStringHelper.Empty)
            {
                string result = InternalReadNull(prompt);
                return result == null ? null : new uint?(uint.Parse(result));
            }

            /// <summary>
            /// Читает значение типа Long?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static long? ReadLong(string prompt = EmptyStringHelper.Empty)
            {
                string result = InternalReadNull(prompt);
                return result == null ? null : new long?(long.Parse(result));
            }

            /// <summary>
            /// Читает значение типа Ulong?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static ulong? ReadUlong(string prompt = EmptyStringHelper.Empty)
            {
                string result = InternalReadNull(prompt);
                return result == null ? null : new ulong?(ulong.Parse(result));
            }

            /// <summary>
            /// Читает значение типа Short?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static short? ReadShort(string prompt = EmptyStringHelper.Empty)
            {
                string result = InternalReadNull(prompt);
                return result == null ? null : new short?(short.Parse(result));
            }

            /// <summary>
            /// Читает значение типа Ushort?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static ushort? ReadUshort(string prompt = EmptyStringHelper.Empty)
            {
                string result = InternalReadNull(prompt);
                return result == null ? null : new ushort?(ushort.Parse(result));
            }

            /// <summary>
            /// Читает значение типа Char?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static char? ReadChar(string prompt = EmptyStringHelper.Empty)
            {
                string result = InternalReadNull(prompt);
                return result == null ? null : new char?(char.Parse(result));
            }

            /// <summary>
            /// Читает значение типа Double?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static double? ReadDouble(string prompt = EmptyStringHelper.Empty)
            {
                string result = InternalReadNull(prompt);
                return result == null ? null : new double?(double.Parse(result));
            }

            /// <summary>
            /// Читает значение типа Int32?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static int? ReadInt32(string prompt = EmptyStringHelper.Empty)
            {
                string result = InternalReadNull(prompt);
                return result == null ? null : new int?(int.Parse(result));
            }

            #endregion

            #region internal

            internal static string InternalReadNull(string prompt = EmptyStringHelper.Empty)
            {
                prompt.Print();
                string result = Console.ReadLine().Trim(new char[] { ' ' });
                return result.Trim(' ') == "null" ? null : result;
            }

            #endregion

        }

    }
}
