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
        /// Заполняет массив значениями типа Sbyte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
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
                    array[i] = Base.ReadSbyte(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
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
        /// Заполняет массив значениями типа Float. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
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
                    array[i] = Base.ReadFloat(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        /// <summary>
        /// Заполняет массив значениями типа Int. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
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
                    array[i] = Base.ReadInt(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        /// <summary>
        /// Заполняет массив значениями типа Uint. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
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
                    array[i] = Base.ReadUint(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        /// <summary>
        /// Заполняет массив значениями типа Long. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
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
                    array[i] = Base.ReadLong(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        /// <summary>
        /// Заполняет массив значениями типа Ulong. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
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
                    array[i] = Base.ReadUlong(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        /// <summary>
        /// Заполняет массив значениями типа Short. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
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
                    array[i] = Base.ReadShort(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        /// <summary>
        /// Заполняет массив значениями типа Ushort. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
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
                    array[i] = Base.ReadUshort(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
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
