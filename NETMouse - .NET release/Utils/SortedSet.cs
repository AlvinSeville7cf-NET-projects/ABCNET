using System;
using System.Collections.Generic;

namespace ABCNET.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы с отсортированными множествами.
    /// </summary>
    public static class SortedSet
    {
        #region public

        /// <summary>
        /// Создаёт отсортированное множество из указанных значений.
        /// </summary>
        /// <param name="values">Значения.</param>
        /// <returns>Отсортированное множество.</returns>
        public static SortedSet<T> Of<T>(params T[] values)
        {
            if (values is null)
                throw new ArgumentNullException(nameof(values));

            return new SortedSet<T>(values);
        }

        /// <summary>
        /// Создаёт отсортированное множество на основе функции селектора.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <param name="firstIndex">Начальный индекс.</param>
        /// <returns>Отсортированное множество.</returns>
        public static SortedSet<T> By<T>(int count, Func<int, T> selector, int firstIndex = 0)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (selector is null)
                throw new ArgumentNullException(nameof(selector));

            SortedSet<T> result = new SortedSet<T>();
            for (int i = 0; i < count; i++)
                result.Add(selector(i + firstIndex));

            return result;
        }

        /// <summary>
        /// Создаёт отсортированное множество на основе функции селектора.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="first">Первый элемент.</param>
        /// <param name="next">Функция получения следующего элемента.</param>
        /// <returns>Отсортированное множество.</returns>
        public static SortedSet<T> By<T>(int count, T first, Func<T, T> next)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (next is null)
                throw new ArgumentNullException(nameof(next));

            SortedSet<T> result = new SortedSet<T>();
            result.Add(first);

            T previus = first;
            for (int i = 1; i < count; i++)
            {
                T current = next(previus);
                result.Add(current);
                previus = current;
            }

            return result;
        }

        /// <summary>
        /// Создаёт отсортированное множество случайных чисел типа Int32.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Отсортированное множество.</returns>
        public static SortedSet<int> Random(int count, int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (low > high)
                throw new ArgumentException(nameof(low));

            SortedSet<int> result = new SortedSet<int>();
            for (int i = 0; i < count; i++)
                result.Add(Base.Random(low, high));

            return result;
        }

        /// <summary>
        /// Создаёт отсортированное множество случайных чисел типа Double.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Отсортированное множество.</returns>
        public static SortedSet<double> Random(int count, double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (low > high)
                throw new ArgumentException(nameof(low));

            SortedSet<double> result = new SortedSet<double>();
            for (int i = 0; i < count; i++)
                result.Add(Base.Random(low, high));

            return result;
        }

        #endregion public
    }
}
