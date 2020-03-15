using ABCNET.Extensions;
using System;
using System.Numerics;

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
            /// Читает значение типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static bool? ReadBoolean(string prompt = EmptyStringHelper.Empty)
            {
                string result = InternalReadTrimmedString(prompt);
                return result == NilStringHelper.Nil ? null : new bool?(bool.Parse(result));
            }

            /// <summary>
            /// Читает значение типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static byte? ReadByte(string prompt = EmptyStringHelper.Empty)
            {
                string result = InternalReadTrimmedString(prompt);
                return result == NilStringHelper.Nil ? null : new byte?(byte.Parse(result));
            }

            /// <summary>
            /// Читает значение типа SByte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static sbyte? ReadSByte(string prompt = EmptyStringHelper.Empty)
            {
                string result = InternalReadTrimmedString(prompt);
                return result == NilStringHelper.Nil ? null : new sbyte?(sbyte.Parse(result));
            }

            /// <summary>
            /// Читает значение типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static char? ReadChar(string prompt = EmptyStringHelper.Empty)
            {
                string result = InternalReadTrimmedString(prompt);
                return result == NilStringHelper.Nil ? null : new char?(char.Parse(result));
            }

            /// <summary>
            /// Читает значение типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static decimal? ReadDecimal(string prompt = EmptyStringHelper.Empty)
            {
                string result = InternalReadTrimmedString(prompt);
                return result == NilStringHelper.Nil ? null : new decimal?(decimal.Parse(result));
            }

            /// <summary>
            /// Читает значение типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static double? ReadDouble(string prompt = EmptyStringHelper.Empty)
            {
                string result = InternalReadTrimmedString(prompt);
                return result == NilStringHelper.Nil ? null : new double?(double.Parse(result));
            }

            /// <summary>
            /// Читает значение типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static float? ReadSingle(string prompt = EmptyStringHelper.Empty)
            {
                string result = InternalReadTrimmedString(prompt);
                return result == NilStringHelper.Nil ? null : new float?(float.Parse(result));
            }

            /// <summary>
            /// Читает значение типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static int? ReadInt32(string prompt = EmptyStringHelper.Empty)
            {
                string result = InternalReadTrimmedString(prompt);
                return result == NilStringHelper.Nil ? null : new int?(int.Parse(result));
            }

            /// <summary>
            /// Читает значение типа UInt32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static uint? ReadUInt32(string prompt = EmptyStringHelper.Empty)
            {
                string result = InternalReadTrimmedString(prompt);
                return result == NilStringHelper.Nil ? null : new uint?(uint.Parse(result));
            }

            /// <summary>
            /// Читает значение типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static long? ReadInt64(string prompt = EmptyStringHelper.Empty)
            {
                string result = InternalReadTrimmedString(prompt);
                return result == NilStringHelper.Nil ? null : new long?(long.Parse(result));
            }

            /// <summary>
            /// Читает значение типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static ulong? ReadUInt64(string prompt = EmptyStringHelper.Empty)
            {
                string result = InternalReadTrimmedString(prompt);
                return result == NilStringHelper.Nil ? null : new ulong?(ulong.Parse(result));
            }

            /// <summary>
            /// Читает значение типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static short? ReadInt16(string prompt = EmptyStringHelper.Empty)
            {
                string result = InternalReadTrimmedString(prompt);
                return result == NilStringHelper.Nil ? null : new short?(short.Parse(result));
            }

            /// <summary>
            /// Читает значение типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static ushort? ReadUInt16(string prompt = EmptyStringHelper.Empty)
            {
                string result = InternalReadTrimmedString(prompt);
                return result == NilStringHelper.Nil ? null : new ushort?(ushort.Parse(result));
            }

            /// <summary>
            /// Читает значение типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static BigInteger? ReadBigInteger(string prompt = EmptyStringHelper.Empty)
            {
                string result = InternalReadTrimmedString(prompt);
                return result == NilStringHelper.Nil ? null : new BigInteger?(BigInteger.Parse(result));
            }
            #endregion

            #region private
            private static string InternalReadTrimmedString(string prompt)
            {
                return ReadString(prompt).Trim().ToLower();
            }
            #endregion private
        }
    }
}
