using System;
using System.Collections.Generic;

namespace ABCNET.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы с очередями.
    /// </summary>
    public static class Queue
    {
        #region public

        /// <summary>
        /// Создаёт очередь из указанных значений.
        /// </summary>
        /// <param name="values">Значения.</param>
        /// <returns>Список.</returns>
        public static Queue<T> Of<T>(params T[] values)
        {
            if (values is null)
                throw new ArgumentNullException(nameof(values));

            return new Queue<T>(values);
        }

        /// <summary>
        /// Создаёт очередь на основе функции селектора.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <param name="firstIndex">Начальный индекс.</param>
        /// <returns>Список.</returns>
        public static Queue<T> By<T>(int count, Func<int, T> selector, int firstIndex = 0)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (selector is null)
                throw new ArgumentNullException(nameof(selector));

            Queue<T> result = new Queue<T>();
            for (int i = 0; i < count; i++)
                result.Enqueue(selector(i + firstIndex));

            return result;
        }

        /// <summary>
        /// Создаёт очередь на основе функции селектора.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="first">Первый элемент.</param>
        /// <param name="next">Функция получения следующего элемента.</param>
        /// <returns>Список.</returns>
        public static Queue<T> By<T>(int count, T first, Func<T, T> next)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (next is null)
                throw new ArgumentNullException(nameof(next));

            Queue<T> result = new Queue<T>();
            result.Enqueue(first);

            T previus = first;
            for (int i = 1; i < count; i++)
            {
                T current = next(previus);
                result.Enqueue(current);
                previus = current;
            }

            return result;
        }

        /// <summary>
        /// Создаёт очередь случайных чисел типа Int32.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Список.</returns>
        public static Queue<int> Random(int count, int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (low > high)
                throw new ArgumentException(nameof(low));

            Queue<int> result = new Queue<int>();
            for (int i = 0; i < count; i++)
                result.Enqueue(Base.Random(low, high));

            return result;
        }

        /// <summary>
        /// Создаёт очередь случайных чисел типа Double.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Список.</returns>
        public static Queue<double> Random(int count, double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (low > high)
                throw new ArgumentException(nameof(low));

            Queue<double> result = new Queue<double>();
            for (int i = 0; i < count; i++)
                result.Enqueue(Base.Random(low, high));

            return result;
        }

        /// <summary>
        /// Создаёт очередь, заполненный указанным значением.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="value">Значение.</param>
        /// <returns>Список.</returns>
        public static Queue<T> Fill<T>(int count, T value)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            Queue<T> result = new Queue<T>();
            for (int i = 0; i < count; i++)
                result.Enqueue(value);

            return result;
        }

        #endregion public
    }
}
