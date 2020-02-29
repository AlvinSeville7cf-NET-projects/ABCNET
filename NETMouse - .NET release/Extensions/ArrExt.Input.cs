using System;
using ABCNET.Utils;

namespace ABCNET.Extensions
{
    /// <summary>
    /// Предоставляет функционал для работы с массивами.
    /// </summary>
    public static partial class ArrExt
    {

        #region Public

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
                    InputErrorHelper.Message.Println();
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

            for (int i = 0; i < array.Length; i++)
                array[i] = Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
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
                    InputErrorHelper.Message.Println();
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
                    InputErrorHelper.Message.Println();
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

            for (int i = 0; i < array.Length; i++)
                array[i] = Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
        }

        #endregion

    }
}
