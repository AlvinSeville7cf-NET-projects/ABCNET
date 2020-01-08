using System;

namespace ABCNET.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы с матрицами.
    /// </summary>
    public static class Matr
    {
        /// <summary>
        /// Создаёт матрицу из указанных значений.
        /// </summary>
        ///  <param name="rowsCount">Количество строк.</param>
        /// <param name="columnsCount">Количество столбцов.</param>
        /// <param name="values">Значения.</param>
        /// <returns>Матрица.</returns>
        public static T[,] New<T>(int rowsCount, int columnsCount, params T[] values)
        {
            if (values == null)
                throw new ArgumentNullException(nameof(values));
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (columnsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(columnsCount));
            if (rowsCount * columnsCount != values.Length)
                throw new ArgumentNullException(nameof(values));

            T[,] source = new T[rowsCount, columnsCount];
            int k = 0;
            for (int i = 0; i < rowsCount; i++)
                for (int j = 0; j < columnsCount; j++)
                {
                    source[i, j] = values[k];
                    k++;
                }

            return source;
        }

        /// <summary>
        /// Создаёт матрицу на основе функции селектора.
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="columnsCount">Количество столбцов.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <param name="rowFirstIndex">Начальный индекс строки.</param>
        /// <param name="columnFirstIndex">Начальный индекс столбца.</param>
        /// <returns>Матрица.</returns>
        public static T[,] Gen<T>(int rowsCount, int columnsCount, Func<int, int, T> selector, int rowFirstIndex = 0, int columnFirstIndex = 0)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (columnsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(columnsCount));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));
            
            T[,] source = new T[rowsCount, columnsCount];
            for (int i = 0; i < source.GetLength(0); i++)
                for (int j = 0; j < source.GetLength(1); j++)
                    source[i, j] = selector(i + rowFirstIndex, j + columnFirstIndex);

            return source;
        }

        /// <summary>
        /// Создаёт матрицу случайных чисел типа Integer.
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="columnsCount">Количество столбцов.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Матрица.</returns>
        public static int[,] Rand(int rowsCount, int columnsCount, int low = IntegerBordersHelper.Low, int high = IntegerBordersHelper.High)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (columnsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(columnsCount));
            if (low > high)
                throw new ArgumentException(nameof(low));

            int[,] source = new int[rowsCount, columnsCount];
            for (int i = 0; i < source.GetLength(0); i++)
                for (int j = 0; j < source.GetLength(1); j++)
                    source[i, j] = Base.Rand(low, high);

            return source;
        }

        /// <summary>
        /// Создаёт матрицу случайных чисел типа Real.
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="columnsCount">Количество столбцов.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Матрица.</returns>
        public static double[,] Rand(int rowsCount, int columnsCount, double low = RealBordersHelper.Low, double high = RealBordersHelper.High)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (columnsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(columnsCount));
            if (low > high)
                throw new ArgumentException(nameof(low));

            double[,] source = new double[rowsCount, columnsCount];
            for (int i = 0; i < source.GetLength(0); i++)
                for (int j = 0; j < source.GetLength(1); j++)
                    source[i, j] = Base.Rand(low, high);

            return source;
        }

        /// <summary>
        /// Создаёт матрицу, заполненную указанным значением.
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="columnsCount">Количество столбцов.</param>
        /// <param name="value">Значение.</param>
        /// <returns>Массив.</returns>
        public static T[,] Fill<T>(int rowsCount, int columnsCount, T value)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (columnsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(columnsCount));

            T[,] source = new T[rowsCount, columnsCount];
            for (int i = 0; i < source.GetLength(0); i++)
                for (int j = 0; j < source.GetLength(1); j++)
                    source[i, j] = value;

            return source;
        }

        /// <summary>
        /// Читает матрицу значений типа Boolean.
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="columnsCount">Количество столбцов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Матрица.</returns>
        public static bool[,] ReadBoolean(int rowsCount, int columnsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (columnsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(columnsCount));

            bool[,] source = new bool[rowsCount, columnsCount];
            int i = 0;
            int j = 0;

            while (i < rowsCount)
            {
                while (j < columnsCount)
                    try
                    {
                        source[i, j] = Base.ReadBoolean(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
                        j++;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(InputErrorHelper.Message);
                    }

                i++;
                j = 0;
            }

            return source;
        }

        /// <summary>
        /// Читает матрицу значений типа Char.
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="columnsCount">Количество столбцов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Матрица.</returns>
        public static char[,] ReadChar(int rowsCount, int columnsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (columnsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(columnsCount));

            char[,] source = new char[rowsCount, columnsCount];
            for (int i = 0; i < rowsCount; i++)
                for (int j = 0; j < columnsCount; j++)
                    source[i, j] = Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));

            return source;
        }

        /// <summary>
        /// Читает матрицу значений типа Real.
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="columnsCount">Количество столбцов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Матрица.</returns>
        public static double[,] ReadReal(int rowsCount, int columnsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (columnsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(columnsCount));

            double[,] source = new double[rowsCount, columnsCount];
            int i = 0;
            int j = 0;

            while (i < rowsCount)
            {
                while (j < columnsCount)
                    try
                    {
                        source[i, j] = Base.ReadReal(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
                        j++;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(InputErrorHelper.Message);
                    }

                i++;
                j = 0;
            }

            return source;
        }

        /// <summary>
        /// Читает матрицу значений типа Integer.
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="columnsCount">Количество столбцов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Матрица.</returns>
        public static int[,] ReadInteger(int rowsCount, int columnsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (columnsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(columnsCount));

            int[,] source = new int[rowsCount, columnsCount];
            int i = 0;
            int j = 0;

            while (i < rowsCount)
            {
                while (j < columnsCount)
                    try
                    {
                        source[i, j] = Base.ReadInteger(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
                        j++;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(InputErrorHelper.Message);
                    }

                i++;
                j = 0;
            }

            return source;
        }

        /// <summary>
        /// Читает матрицу значений типа String.
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="columnsCount">Количество столбцов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Матрица.</returns>
        public static string[,] ReadString(int rowsCount, int columnsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (columnsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(columnsCount));

            string[,] source = new string[rowsCount, columnsCount];
            for (int i = 0; i < rowsCount; i++)
                for (int j = 0; j < columnsCount; j++)
                    source[i, j] = Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));

            return source;
        }
    }
}