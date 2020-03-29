using System;
using ABCNET.Utils;

namespace ABCNET.Extensions
{
    /// <summary>
    /// Предоставляет функционал для работы с матрицами.
    /// </summary>
    public static partial class MatrixE
    {
        #region public
        /// <summary>
        /// Заполняет матрицу на основе функции селектора.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <param name="rowFirstIndex">Начальный индекс строки.</param>
        /// <param name="columnFirstIndex">Начальный индекс столбца.</param>
        public static void Gen<T>(this T[,] matrix, Func<int, int, T> selector, int rowFirstIndex = 0, int columnFirstIndex = 0)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = selector(i + rowFirstIndex, j + columnFirstIndex);
        }

        /// <summary>
        /// Заполняет матрицу случайными числами типа Int32.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        public static void Rand(this int[,] matrix, int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));
            if (low > high)
                throw new ArgumentException(nameof(low));

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = Base.Rand(low, high);
        }

        /// <summary>
        /// Заполняет матрицу случайными числами типа Double.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        public static void Rand(this double[,] matrix, double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));
            if (low > high)
                throw new ArgumentException(nameof(low));

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = Base.Rand(low, high);
        }

        /// <summary>
        /// Заполняет матрицу указанным значением.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="value">Значение.</param>
        /// <returns>Массив.</returns>
        public static void Fill<T>(this T[,] matrix, T value)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = value;
        }
        #endregion public
    }
}
