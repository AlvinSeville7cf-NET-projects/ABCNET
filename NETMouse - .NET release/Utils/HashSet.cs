using System;
using System.Collections.Generic;

namespace ABCNET.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы с множествами.
    /// </summary>
    public static class HashSet
    {
        #region public

        /// <summary>
        /// Создаёт множество из указанных значений.
        /// </summary>
        /// <param name="values">Значения.</param>
        /// <returns>Множество.</returns>
        public static HashSet<T> Of<T>(params T[] values)
        {
            if (values is null)
                throw new ArgumentNullException(nameof(values));
            
            return new HashSet<T>(values);
        }

        /// <summary>
        /// Создаёт множество на основе функции селектора.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <param name="firstIndex">Начальный индекс.</param>
        /// <returns>Множество.</returns>
        public static HashSet<T> By<T>(int count, Func<int, T> selector, int firstIndex = 0)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (selector is null)
                throw new ArgumentNullException(nameof(selector));

            HashSet<T> result = new HashSet<T>();
            for (int i = 0; i < count; i++)
                result.Add(selector(i + firstIndex));

            return result;
        }

        /// <summary>
        /// Создаёт множество на основе функции селектора.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="first">Первый элемент.</param>
        /// <param name="next">Функция получения следующего элемента.</param>
        /// <returns>Множество.</returns>
        public static HashSet<T> By<T>(int count, T first, Func<T, T> next)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (next is null)
                throw new ArgumentNullException(nameof(next));

            HashSet<T> result = new HashSet<T>();
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
        /// Создаёт множество случайных чисел типа Int32.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Множество.</returns>
        public static HashSet<int> Random(int count, int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (low > high)
                throw new ArgumentException(nameof(low));

            HashSet<int> result = new HashSet<int>();
            for (int i = 0; i < count; i++)
                result.Add(Base.Random(low, high));

            return result;
        }

        /// <summary>
        /// Создаёт множество случайных чисел типа Double.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Множество.</returns>
        public static HashSet<double> Random(int count, double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (low > high)
                throw new ArgumentException(nameof(low));

            HashSet<double> result = new HashSet<double>();
            for (int i = 0; i < count; i++)
                result.Add(Base.Random(low, high));

            return result;
        }

        #endregion public
    }
}
