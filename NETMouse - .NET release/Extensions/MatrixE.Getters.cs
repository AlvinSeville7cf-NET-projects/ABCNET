using System;
using System.Collections.Generic;
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
        /// Получает столбец матрицы.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="index">Индекс столбца.</param>
        /// <returns>Столбец.</returns>
        public static T[] Column<T>(this T[,] matrix, int index)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            return matrix.InternalGetCol(index);
        }

        /// <summary>
        /// Получает столбец матрицы.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="index">Индекс столбца.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <returns>Столбец.</returns>
        public static TOutput[] Column<T, TOutput>(this T[,] matrix, int index, Func<T, TOutput> selector)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            return matrix.InternalGetCol(index, selector);
        }

        /// <summary>
        /// Получает строку матрицы.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="index">Индекс строки.</param>
        /// <returns>Строка.</returns>
        public static T[] Row<T>(this T[,] matrix, int index)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            return matrix.InternalGetRow(index);
        }

        /// <summary>
        /// Получает строку матрицы.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="index">Индекс строки.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <returns>Строка.</returns>
        public static TOutput[] Row<T, TOutput>(this T[,] matrix, int index, Func<T, TOutput> selector)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            return matrix.InternalGetRow(index, selector);
        }

        /// <summary>
        /// Меняет местами два столбца матрицы.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="firstIndex">Индекс первого столбца.</param>
        /// <param name="secondIndex">Индекс второго столбца.</param>
        /// <returns>Матрица.</returns>
        public static T[,] SwapColumns<T>(this T[,] matrix, int firstIndex, int secondIndex)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            return matrix.InternalSwapCols(firstIndex, secondIndex);
        }

        /// <summary>
        /// Меняет местами два столбца матрицы.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="firstIndex">Индекс первого столбца.</param>
        /// <param name="secondIndex">Индекс второго столбца.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <returns>Матрица.</returns>
        public static T[,] SwapColumns<T>(this T[,] matrix, int firstIndex, int secondIndex, Func<T, T> selector)
        {
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            return matrix.InternalSwapCols(firstIndex, secondIndex, selector);
        }

        /// <summary>
        /// Меняет местами две строки матрицы.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="firstIndex">Индекс первой строки.</param>
        /// <param name="secondIndex">Индекс второй строки.</param>
        /// <returns>Матрица.</returns>
        public static T[,] SwapRows<T>(this T[,] matrix, int firstIndex, int secondIndex)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            return matrix.InternalSwapRows(firstIndex, secondIndex);
        }

        /// <summary>
        /// Меняет местами две строки матрицы.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="firstIndex">Индекс первой строки.</param>
        /// <param name="secondIndex">Индекс второй строки.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <returns>Матрица.</returns>
        public static T[,] SwapRows<T>(this T[,] matrix, int firstIndex, int secondIndex, Func<T, T> selector)
        {
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            return matrix.InternalSwapRows(firstIndex, secondIndex, selector);
        }

        /// <summary>
        /// Изменяет строку матрицы.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// /// <param name="row">Строка.</param>
        /// <param name="index">Индекс строки.</param>
        /// <returns>Матрица.</returns>
        public static T[,] SetColumn<T>(this T[,] matrix, T[] row, int index)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));
            if (matrix.GetLength(0) != row.Length)
                throw new ArgumentException(nameof(row));

            T[,] matrixRes = (T[,])matrix.Clone();

            for (int i = 0; i < matrixRes.GetLength(1); i++)
                matrixRes[i, index] = row[i];

            return matrixRes;
        }

        /// <summary>
        /// Изменяет столбец матрицы.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="col">Столбец.</param>
        /// <param name="index">Индекс столбца.</param>
        /// <returns>Матрица.</returns>
        public static T[,] SetRow<T>(this T[,] matrix, T[] col, int index)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));
            if (matrix.GetLength(1) != col.Length)
                throw new ArgumentException(nameof(col));

            T[,] matrixRes = (T[,])matrix.Clone();

            for (int i = 0; i < matrixRes.GetLength(1); i++)
                matrixRes[index, i] = col[i];

            return matrixRes;
        }

        /// <summary>
        /// Возвращает последовательность строк матрицы.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <returns>Строки.</returns>
        public static IEnumerable<T[]> Columns<T>(this T[,] matrix)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                yield return matrix.InternalGetCol(i);
            }
        }

        /// <summary>
        /// Возвращает последовательность столбцов матрицы.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <returns>Столбцы.</returns>
        public static IEnumerable<T[]> Rows<T>(this T[,] matrix)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                yield return matrix.InternalGetRow(j);
            }
        }

        #endregion public

        #region private
        private static T[] InternalGetCol<T>(this T[,] matrix, int index)
        {
            int length = matrix.GetLength(0);
            if (!index.IsBetween(0, length - 1))
                throw new IndexOutOfRangeException(nameof(matrix));

            T[] column = new T[length];
            for (int i = 0; i < column.Length; i++)
                column[i] = matrix[i, index];

            return column;
        }

        private static TOutput[] InternalGetCol<T, TOutput>(this T[,] matrix, int index, Func<T, TOutput> selector)
        {
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            int length = matrix.GetLength(0);
            if (!index.IsBetween(0, length - 1))
                throw new IndexOutOfRangeException(nameof(index));

            TOutput[] column = new TOutput[length];
            for (int i = 0; i < column.Length; i++)
                column[i] = selector(matrix[i, index]);

            return column;
        }

        private static T[] InternalGetRow<T>(this T[,] matrix, int index)
        {
            int length = matrix.GetLength(1);
            if (!index.IsBetween(0, length - 1))
                throw new IndexOutOfRangeException(nameof(index));

            T[] row = new T[length];
            for (int i = 0; i < row.Length; i++)
                row[i] = matrix[index, i];

            return row;
        }

        private static TOutput[] InternalGetRow<T, TOutput>(this T[,] matrix, int index, Func<T, TOutput> selector)
        {
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            int length = matrix.GetLength(1);
            if (!index.IsBetween(0, length - 1))
                throw new IndexOutOfRangeException(nameof(index));

            TOutput[] row = new TOutput[length];
            for (int i = 0; i < row.Length; i++)
                row[i] = selector(matrix[index, i]);

            return row;
        }

        private static T[,] InternalSwapRows<T>(this T[,] matrix, int firstIndex, int secondIndex)
        {
            int lastRowIndex = matrix.GetLength(0) - 1;
            if (!firstIndex.IsBetween(0, lastRowIndex))
                throw new ArgumentOutOfRangeException(nameof(firstIndex));
            if (!secondIndex.IsBetween(0, lastRowIndex))
                throw new ArgumentOutOfRangeException(nameof(secondIndex));

            T[,] newMatrix = (T[,])matrix.Clone();

            int columnsCount = newMatrix.GetLength(1);
            for (int j = 0; j < columnsCount; j++)
                Base.Swap(ref newMatrix[firstIndex, j], ref newMatrix[secondIndex, j]);
            return newMatrix;
        }

        private static T[,] InternalSwapRows<T>(this T[,] matrix, int firstIndex, int secondIndex, Func<T, T> selector)
        {
            int lastRowIndex = matrix.GetLength(0) - 1;
            if (!firstIndex.IsBetween(0, lastRowIndex))
                throw new ArgumentOutOfRangeException(nameof(firstIndex));
            if (!secondIndex.IsBetween(0, lastRowIndex))
                throw new ArgumentOutOfRangeException(nameof(secondIndex));

            T[,] newMatrix = (T[,])matrix.Clone();

            int columnsCount = newMatrix.GetLength(1);
            for (int j = 0; j < columnsCount; j++)
            {
                newMatrix[firstIndex, j] = selector(newMatrix[firstIndex, j]);
                newMatrix[secondIndex, j] = selector(newMatrix[secondIndex, j]);
                Base.Swap(ref newMatrix[firstIndex, j], ref newMatrix[secondIndex, j]);
            }

            return newMatrix;
        }

        private static T[,] InternalSwapCols<T>(this T[,] matrix, int firstIndex, int secondIndex)
        {
            int lastColumnIndex = matrix.GetLength(1) - 1;
            if (!firstIndex.IsBetween(0, lastColumnIndex))
                throw new ArgumentOutOfRangeException(nameof(firstIndex));
            if (!secondIndex.IsBetween(0, lastColumnIndex))
                throw new ArgumentOutOfRangeException(nameof(secondIndex));

            T[,] newMatrix = (T[,])matrix.Clone();

            int rowsCount = newMatrix.GetLength(0);
            for (int i = 0; i < rowsCount; i++)
                Base.Swap(ref newMatrix[i, firstIndex], ref newMatrix[i, secondIndex]);
            return newMatrix;
        }

        private static T[,] InternalSwapCols<T>(this T[,] matrix, int firstIndex, int secondIndex, Func<T, T> selector)
        {
            int lastColumnIndex = matrix.GetLength(1) - 1;
            if (!firstIndex.IsBetween(0, lastColumnIndex))
                throw new ArgumentOutOfRangeException(nameof(firstIndex));
            if (!secondIndex.IsBetween(0, lastColumnIndex))
                throw new ArgumentOutOfRangeException(nameof(secondIndex));

            T[,] newMatrix = (T[,])matrix.Clone();

            int rowsCount = newMatrix.GetLength(0);
            for (int i = 0; i < rowsCount; i++)
            {
                newMatrix[i, firstIndex] = selector(newMatrix[i, firstIndex]);
                newMatrix[i, secondIndex] = selector(newMatrix[i, secondIndex]);
                Base.Swap(ref newMatrix[i, firstIndex], ref newMatrix[i, secondIndex]);
            }

            return newMatrix;
        }

        #endregion private
    }
}
