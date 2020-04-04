using System;
using System.Numerics;
using ABCNET.Utils;

namespace ABCNET.Extensions
{
    /// <summary>
    /// Предоставляет функционал для работы с массивами.
    /// </summary>
    public static partial class ArrayE
    {
        #region public

        /// <summary>
        /// Заполняет массив значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this bool[] array, string prompt = EmptyStringHelper.Empty)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            int i = 0;
            while (i < array.Length)
                try
                {
                    array[i] = Base.ReadBoolean(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        /// <summary>
        /// Заполняет массив значениями типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this byte[] array, string prompt = EmptyStringHelper.Empty)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            int i = 0;
            while (i < array.Length)
                try
                {
                    array[i] = Base.ReadByte(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        /// <summary>
        /// Заполняет массив значениями типа SByte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this sbyte[] array, string prompt = EmptyStringHelper.Empty)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            int i = 0;
            while (i < array.Length)
                try
                {
                    array[i] = Base.ReadSByte(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        /// <summary>
        /// Заполняет массив значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this char[] array, string prompt = EmptyStringHelper.Empty)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            int i = 0;
            while (i < array.Length)
                try
                {
                    array[i] = Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        /// <summary>
        /// Заполняет массив значениями типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this decimal[] array, string prompt = EmptyStringHelper.Empty)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            int i = 0;
            while (i < array.Length)
                try
                {
                    array[i] = Base.ReadDecimal(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        /// <summary>
        /// Заполняет массив значениями типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this double[] array, string prompt = EmptyStringHelper.Empty)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            int i = 0;
            while (i < array.Length)
                try
                {
                    array[i] = Base.ReadDouble(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        /// <summary>
        /// Заполняет массив значениями типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this float[] array, string prompt = EmptyStringHelper.Empty)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            int i = 0;
            while (i < array.Length)
                try
                {
                    array[i] = Base.ReadSingle(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        /// <summary>
        /// Заполняет массив значениями типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this int[] array, string prompt = EmptyStringHelper.Empty)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            int i = 0;
            while (i < array.Length)
                try
                {
                    array[i] = Base.ReadInt32(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        /// <summary>
        /// Заполняет массив значениями типа Uint32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this uint[] array, string prompt = EmptyStringHelper.Empty)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            int i = 0;
            while (i < array.Length)
                try
                {
                    array[i] = Base.ReadUint32(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        /// <summary>
        /// Заполняет массив значениями типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this long[] array, string prompt = EmptyStringHelper.Empty)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            int i = 0;
            while (i < array.Length)
                try
                {
                    array[i] = Base.ReadInt64(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        /// <summary>
        /// Заполняет массив значениями типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this ulong[] array, string prompt = EmptyStringHelper.Empty)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            int i = 0;
            while (i < array.Length)
                try
                {
                    array[i] = Base.ReadUInt64(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        /// <summary>
        /// Заполняет массив значениями типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this short[] array, string prompt = EmptyStringHelper.Empty)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            int i = 0;
            while (i < array.Length)
                try
                {
                    array[i] = Base.ReadInt16(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        /// <summary>
        /// Заполняет массив значениями типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this ushort[] array, string prompt = EmptyStringHelper.Empty)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            int i = 0;
            while (i < array.Length)
                try
                {
                    array[i] = Base.ReadUInt16(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        /// <summary>
        /// Заполняет массив значениями типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this BigInteger[] array, string prompt = EmptyStringHelper.Empty)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            int i = 0;
            while (i < array.Length)
                try
                {
                    array[i] = Base.ReadBigInteger(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        /// <summary>
        /// Заполняет массив значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void Read(this string[] array, string prompt = EmptyStringHelper.Empty)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            int i = 0;
            while (i < array.Length)
                try
                {
                    array[i] = Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        #endregion public
    }
}
