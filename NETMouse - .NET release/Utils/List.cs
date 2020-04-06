using System;
using System.Collections.Generic;

namespace ABCNET.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы со списками.
    /// </summary>
    public static class List
    {
        #region public

        /// <summary>
        /// Создаёт список из указанных значений.
        /// </summary>
        /// <param name="values">Значения.</param>
        /// <returns>Список.</returns>
        public static List<T> Of<T>(params T[] values)
        {
            if (values is null)
                throw new ArgumentNullException(nameof(values));

            return new List<T>(values);
        }

        /// <summary>
        /// Создаёт список на основе функции селектора.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <param name="firstIndex">Начальный индекс.</param>
        /// <returns>Список.</returns>
        public static List<T> By<T>(int count, Func<int, T> selector, int firstIndex = 0)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (selector is null)
                throw new ArgumentNullException(nameof(selector));

            List<T> result = new List<T>();
            for (int i = 0; i < result.Count; i++)
                result[i] = selector(i + firstIndex);

            return result;
        }

        /// <summary>
        /// Создаёт список на основе функции селектора.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="first">Первый элемент.</param>
        /// <param name="next">Функция получения следующего элемента.</param>
        /// <returns>Список.</returns>
        public static List<T> By<T>(int count, T first, Func<T, T> next)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (next is null)
                throw new ArgumentNullException(nameof(next));

            List<T> result = new List<T>();
            result[0] = first;
            for (int i = 1; i < result.Count; i++)
                result[i] = next(result[i - 1]);

            return result;
        }

        /// <summary>
        /// Создаёт список случайных чисел типа Int32.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Список.</returns>
        public static List<int> Random(int count, int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (low > high)
                throw new ArgumentException(nameof(low));

            List<int> result = new List<int>();
            for (int i = 0; i < result.Count; i++)
                result[i] = Base.Random(low, high);

            return result;
        }

        /// <summary>
        /// Создаёт список случайных чисел типа Double.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Список.</returns>
        public static List<double> Random(int count, double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (low > high)
                throw new ArgumentException(nameof(low));

            List<double> result = new List<double>();
            for (int i = 0; i < result.Count; i++)
                result[i] = Base.Random(low, high);

            return result;
        }

        /// <summary>
        /// Создаёт список, заполненный указанным значением.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="value">Значение.</param>
        /// <returns>Список.</returns>
        public static List<T> Fill<T>(int count, T value)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            List<T> result = new List<T>();
            for (int i = 0; i < result.Count; i++)
                result[i] = value;

            return result;
        }

        #endregion public
    }
}
