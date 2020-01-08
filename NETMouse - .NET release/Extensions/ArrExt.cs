using ABCNET.Utils;
using System;

namespace ABCNET.Extensions
{
    /// <summary>
    /// Предоставляет функционал для работы с массивами.
    /// </summary>
    public static class ArrExt
    {
        /// <summary>
        /// Заполняет массив на основе функции селектора.
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <param name="firstIndex">Начальный индекс.</param>
        public static void Gen<T>(this T[] array, Func<int, T> selector, int firstIndex = 0)
        {
            if (array == null)
                throw new ArgumentNullException("array");
            if (selector == null)
                throw new ArgumentNullException("selector");

            for (int i = 0; i < array.Length; i++)
                array[i] = selector(i + firstIndex);
        }

        /// <summary>
        /// Заполняет массив на основе функции селектора.
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="first">Первый элемент.</param>
        /// <param name="next">Функция получения следующего элемента.</param>
        public static void Gen<T>(this T[] array, T first, Func<T, T> next)
        {
            if (array == null)
                throw new ArgumentNullException("array");
            if (next == null)
                throw new ArgumentNullException("next");

            array[0] = first;
            for (int i = 1; i < array.Length; i++)
                array[i] = next(array[i - 1]);
        }

        /// <summary>
        /// Заполняет массив случайными числами типа Integer.
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        public static void Rand(this int[] array, int low = IntegerBordersHelper.Low, int high = IntegerBordersHelper.High)
        {
            if (array == null)
                throw new ArgumentNullException("array");
            if (low > high)
                throw new ArgumentException("low");

            for (int i = 0; i < array.Length; i++)
                array[i] = Base.Rand(low, high);
        }

        /// <summary>
        /// Заполняет массив случайными числами типа Real.
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        public static void Rand(this double[] array, double low = RealBordersHelper.Low, double high = RealBordersHelper.High)
        {
            if (array == null)
                throw new ArgumentNullException("array");
            if (low > high)
                throw new ArgumentException("low");

            for (int i = 0; i < array.Length; i++)
                array[i] = Base.Rand(low, high);
        }

        /// <summary>
        /// Заполняет массив указанным значением.
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="value">Значение.</param>
        public static void Fill<T>(this T[] array, T value)
        {
            if (array == null)
                throw new ArgumentNullException("array");

            for (int i = 0; i < array.Length; i++)
                array[i] = value;
        }

        /// <summary>
        /// Заполняет массив значениями типа Boolean.
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void ReadBoolean(this bool[] array, string prompt = EmptyStringHelper.Empty)
        {
            if (array == null)
                throw new ArgumentNullException("array");

            int i = 0;
            while (i < array.Length)
                try
                {
                    array[i] = Base.ReadBoolean(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    Console.WriteLine(InputErrorHelper.Message);
                }
        }

        /// <summary>
        /// Заполняет массив значениями типа Char.
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void ReadChar(this char[] array, string prompt = EmptyStringHelper.Empty)
        {
            if (array == null)
                throw new ArgumentNullException("array");

            for (int i = 0; i < array.Length; i++)
                array[i] = Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
        }

        /// <summary>
        /// Заполняет массив значениями типа Real.
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void ReadReal(this double[] array, string prompt = EmptyStringHelper.Empty)
        {
            if (array == null)
                throw new ArgumentNullException("array");

            int i = 0;
            while (i < array.Length)
                try
                {
                    array[i] = Base.ReadReal(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    Console.WriteLine(InputErrorHelper.Message);
                }
        }

        /// <summary>
        /// Заполняет массив значениями типа Integer.
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void ReadInteger(this int[] array, string prompt = EmptyStringHelper.Empty)
        {
            if (array == null)
                throw new ArgumentNullException("array");

            int i = 0;
            while (i < array.Length)
                try
                {
                    array[i] = Base.ReadInteger(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    Console.WriteLine(InputErrorHelper.Message);
                }
        }

        /// <summary>
        /// Заполняет массив значениями типа String.
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void ReadString(this string[] array, string prompt = EmptyStringHelper.Empty)
        {
            if (array == null)
                throw new ArgumentNullException("array");

            for (int i = 0; i < array.Length; i++)
                array[i] = Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
        }
    }
}
