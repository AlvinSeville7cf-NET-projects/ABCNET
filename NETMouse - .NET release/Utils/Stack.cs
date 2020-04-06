using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABCNET.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы со стеками.
    /// </summary>
    public static class Stack
    {
        #region public

        /// <summary>
        /// Создаёт стек из указанных значений.
        /// </summary>
        /// <param name="values">Значения.</param>
        /// <returns>Стек.</returns>
        public static Stack<T> Of<T>(params T[] values)
        {
            if (values is null)
                throw new ArgumentNullException(nameof(values));

            return new Stack<T>(values);
        }

        /// <summary>
        /// Создаёт стек на основе функции селектора.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <param name="firstIndex">Начальный индекс.</param>
        /// <returns>Стек.</returns>
        public static Stack<T> By<T>(int count, Func<int, T> selector, int firstIndex = 0)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (selector is null)
                throw new ArgumentNullException(nameof(selector));

            Stack<T> result = new Stack<T>();
            for (int i = 0; i < count; i++)
                result.Push(selector(i + firstIndex));

            return result;
        }

        /// <summary>
        /// Создаёт стек на основе функции селектора.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="first">Первый элемент.</param>
        /// <param name="next">Функция получения следующего элемента.</param>
        /// <returns>Стек.</returns>
        public static Stack<T> By<T>(int count, T first, Func<T, T> next)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (next is null)
                throw new ArgumentNullException(nameof(next));

            Stack<T> result = new Stack<T>();
            result.Push(first);

            T previus = first;
            for (int i = 1; i < count; i++)
            {
                T current = next(previus);
                result.Push(current);
                previus = current;
            }

            return result;
        }

        /// <summary>
        /// Создаёт стек случайных чисел типа Int32.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Стек.</returns>
        public static Stack<int> Random(int count, int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (low > high)
                throw new ArgumentException(nameof(low));

            Stack<int> result = new Stack<int>();
            for (int i = 0; i < count; i++)
                result.Push(Base.Random(low, high));

            return result;
        }

        /// <summary>
        /// Создаёт стек случайных чисел типа Double.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Стек.</returns>
        public static Stack<double> Random(int count, double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (low > high)
                throw new ArgumentException(nameof(low));

            Stack<double> result = new Stack<double>();
            for (int i = 0; i < count; i++)
                result.Push(Base.Random(low, high));

            return result;
        }

        /// <summary>
        /// Создаёт стек, заполненный указанным значением.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="value">Значение.</param>
        /// <returns>Стек.</returns>
        public static Stack<T> Fill<T>(int count, T value)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            Stack<T> result = new Stack<T>();
            for (int i = 0; i < count; i++)
                result.Push(value);

            return result;
        }

        #endregion public
    }
}
