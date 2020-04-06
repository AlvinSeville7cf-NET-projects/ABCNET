using System;
using System.Collections.Generic;

namespace ABCNET.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы со связными списками.
    /// </summary>
    public static class LinkedList
    {
        #region public

        /// <summary>
        /// Создаёт связный список из указанных значений.
        /// </summary>
        /// <param name="values">Значения.</param>
        /// <returns>Связный список.</returns>
        public static LinkedList<T> Of<T>(params T[] values)
        {
            if (values is null)
                throw new ArgumentNullException(nameof(values));

            return new LinkedList<T>(values);
        }

        /// <summary>
        /// Создаёт связный список на основе функции селектора.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <param name="firstIndex">Начальный индекс.</param>
        /// <returns>Связный список.</returns>
        public static LinkedList<T> By<T>(int count, Func<int, T> selector, int firstIndex = 0)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (selector is null)
                throw new ArgumentNullException(nameof(selector));

            LinkedList<T> result = new LinkedList<T>();
            for (int i = 0; i < count; i++)
                result.AddLast(selector(i + firstIndex));

            return result;
        }

        /// <summary>
        /// Создаёт связный список на основе функции селектора.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="first">Первый элемент.</param>
        /// <param name="next">Функция получения следующего элемента.</param>
        /// <returns>Связный список.</returns>
        public static LinkedList<T> By<T>(int count, T first, Func<T, T> next)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (next is null)
                throw new ArgumentNullException(nameof(next));

            LinkedList<T> result = new LinkedList<T>();
            result.AddLast(first);

            T previus = first;
            for (int i = 1; i < count; i++)
            {
                T current = next(previus);
                result.AddLast(current);
                previus = current;
            }

            return result;
        }

        /// <summary>
        /// Создаёт связный список случайных чисел типа Int32.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Связный список.</returns>
        public static LinkedList<int> Random(int count, int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (low > high)
                throw new ArgumentException(nameof(low));

            LinkedList<int> result = new LinkedList<int>();
            for (int i = 0; i < count; i++)
                result.AddLast(Base.Random(low, high));

            return result;
        }

        /// <summary>
        /// Создаёт связный список случайных чисел типа Double.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Связный список.</returns>
        public static LinkedList<double> Random(int count, double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (low > high)
                throw new ArgumentException(nameof(low));

            LinkedList<double> result = new LinkedList<double>();
            for (int i = 0; i < count; i++)
                result.AddLast(Base.Random(low, high));

            return result;
        }

        /// <summary>
        /// Создаёт связный список, заполненный указанным значением.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="value">Значение.</param>
        /// <returns>Связный список.</returns>
        public static LinkedList<T> Fill<T>(int count, T value)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            LinkedList<T> result = new LinkedList<T>();
            for (int i = 0; i < count; i++)
                result.AddLast(value);

            return result;
        }

        #endregion public
    }
}
