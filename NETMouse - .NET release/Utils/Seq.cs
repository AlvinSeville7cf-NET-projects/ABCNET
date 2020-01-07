using NETMouse.Extensions;
using System;
using System.Collections.Generic;

namespace NETMouse.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы с последовательностями.
    /// </summary>
    public static class Seq
    {
        /// <summary>
        /// Создаёт последовательность на основе функции селектора.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <param name="firstIndex">Начальный индекс.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<T> Gen<T>(int count, Func<int, T> selector, int firstIndex = 0)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if (selector == null)
                throw new ArgumentNullException("selector");

            for (int i = 0; i < count; i++)
                yield return selector(i + firstIndex);
        }

        /// <summary>
        /// Создаёт последовательность случайных чисел типа Integer.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<int> Rand(int count, int low = IntegerBordersHelper.Low, int high = IntegerBordersHelper.High)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if (low > high)
                throw new ArgumentException("low");

            for (int i = 0; i < count; i++)
                yield return Base.Rand(low, high);
        }

        /// <summary>
        /// Создаёт последовательность случайных чисел типа Real.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<double> Rand(int count, double low = RealBordersHelper.Low, double high = RealBordersHelper.High)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if (low > high)
                throw new ArgumentException("low");

            for (int i = 0; i < count; i++)
                yield return Base.Rand(low, high);
        }

        /// <summary>
        /// Создаёт последовательность, заполненную указанным значением.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="value">Значение.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<T> Fill<T>(int count, T value)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");

            for (int i = 0; i < count; i++)
                yield return value;
        }
    }
}