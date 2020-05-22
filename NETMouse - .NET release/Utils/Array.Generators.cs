using System;

namespace ABCNET.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы с массивами.
    /// </summary>
    public static partial class Array
    {

        #region public

        /// <summary>
        /// Создаёт массив из указанных значений.
        /// </summary>
        /// <param name="values">Значения.</param>
        /// <returns>Массив.</returns>
        public static T[] Of<T>(params T[] values)
        {
            if (values == null)
                throw new ArgumentNullException(nameof(values));

            return values;
        }

        /// <summary>
        /// Создаёт массив на основе функции селектора.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <param name="firstIndex">Начальный индекс.</param>
        /// <returns>Массив.</returns>
        public static T[] By<T>(int count, Func<int, T> selector, int firstIndex = 0)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            T[] source = new T[count];
            for (int i = 0; i < source.Length; i++)
                source[i] = selector(i + firstIndex);

            return source;
        }

        /// <summary>
        /// Создаёт массив на основе функции селектора.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="first">Первый элемент.</param>
        /// <param name="next">Функция получения следующего элемента.</param>
        /// <returns>Массив.</returns>
        public static T[] By<T>(int count, T first, Func<T, T> next)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (next == null)
                throw new ArgumentNullException(nameof(next));

            T[] source = new T[count];
            source[0] = first;
            for (int i = 1; i < source.Length; i++)
                source[i] = next(source[i - 1]);

            return source;
        }

        /// <summary>
        /// Создаёт массив случайных чисел типа Int32.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Массив.</returns>
        public static int[] Random(int count, int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (low > high)
                throw new ArgumentException(nameof(low));

            int[] source = new int[count];
            for (int i = 0; i < source.Length; i++)
                source[i] = Base.Random(low, high);

            return source;
        }

        /// <summary>
        /// Создаёт массив случайных чисел типа Double.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Массив.</returns>
        public static double[] Random(int count, double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (low > high)
                throw new ArgumentException(nameof(low));

            double[] source = new double[count];
            for (int i = 0; i < source.Length; i++)
                source[i] = Base.Random(low, high);

            return source;
        }

        /// <summary>
        /// Создаёт массив, заполненный указанным значением.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="value">Значение.</param>
        /// <returns>Массив.</returns>
        public static T[] Fill<T>(int count, T value)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            T[] source = new T[count];
            for (int i = 0; i < source.Length; i++)
                source[i] = value;

            return source;
        }

        #endregion public
    
    }
}
