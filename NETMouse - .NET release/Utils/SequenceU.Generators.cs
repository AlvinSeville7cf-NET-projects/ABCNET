using System;
using System.Collections.Generic;

namespace ABCNET.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы с последовательностями.
    /// </summary>
    public static partial class SequenceU
    {

        #region public

        /// <summary>
        /// Создаёт последовательность на основе функции селектора.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <param name="firstIndex">Начальный индекс.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<T> By<T>(int count, Func<int, T> selector, int firstIndex = 0)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

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
        public static IEnumerable<int> Random(int count, int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (low > high)
                throw new ArgumentException(nameof(low));

            for (int i = 0; i < count; i++)
                yield return BaseU.Random(low, high);
        }

        /// <summary>
        /// Создаёт последовательность случайных чисел типа Double.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<double> Random(int count, double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (low > high)
                throw new ArgumentException(nameof(low));

            for (int i = 0; i < count; i++)
                yield return BaseU.Random(low, high);
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
                throw new ArgumentOutOfRangeException(nameof(count));

            for (int i = 0; i < count; i++)
                yield return value;
        }

        #endregion public

    }
}