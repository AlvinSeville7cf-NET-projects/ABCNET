using System;

namespace ABCNET.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы с матрицами.
    /// </summary>
    public static class Matr
    {

        #region Read2

        /// <summary>
        /// Заполняет 2 массива значениями типа Bool. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public static Tuple<bool[,], bool[,]> ReadBool2(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public static Tuple<char[,], char[,]> ReadChar2(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа Integer. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public static Tuple<int[,], int[,]> ReadInteger2(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа Real. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public static Tuple<double[,], double[,]> ReadReal2(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public static Tuple<string[,], string[,]> ReadString2(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadString(rows, cols), Matr.ReadString(rows, cols));
        }

        #endregion

        #region Read3

        /// <summary>
        /// Заполняет 3 массива значениями типа Bool. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public static Tuple<bool[,], bool[,], bool[,]> ReadBool3(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public static Tuple<char[,], char[,], char[,]> ReadChar3(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа Integer. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public static Tuple<int[,], int[,], int[,]> ReadInteger3(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа Real. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public static Tuple<double[,], double[,], double[,]> ReadReal3(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public static Tuple<string[,], string[,], string[,]> ReadString3(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadString(rows, cols), Matr.ReadString(rows, cols), Matr.ReadString(rows, cols));
        }

        #endregion

        #region Read4

        /// <summary>
        /// Заполняет 4 массива значениями типа Bool. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public static Tuple<bool[,], bool[,], bool[,], bool[,]> ReadBool4(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public static Tuple<char[,], char[,], char[,], char[,]> ReadChar4(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа Integer. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public static Tuple<int[,], int[,], int[,], int[,]> ReadInteger4(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа Real. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public static Tuple<double[,], double[,], double[,], double[,]> ReadReal4(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public static Tuple<string[,], string[,], string[,], string[,]> ReadString4(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadString(rows, cols), Matr.ReadString(rows, cols), Matr.ReadString(rows, cols), Matr.ReadString(rows, cols));
        }

        #endregion

        #region Read5

        /// <summary>
        /// Заполняет 5 массива значениями типа Bool. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public static Tuple<bool[,], bool[,], bool[,], bool[,], bool[,]> ReadBool5(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public static Tuple<char[,], char[,], char[,], char[,], char[,]> ReadChar5(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа Integer. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public static Tuple<int[,], int[,], int[,], int[,], int[,]> ReadInteger5(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа Real. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public static Tuple<double[,], double[,], double[,], double[,], double[,]> ReadReal5(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public static Tuple<string[,], string[,], string[,], string[,], string[,]> ReadString5(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadString(rows, cols), Matr.ReadString(rows, cols), Matr.ReadString(rows, cols), Matr.ReadString(rows, cols), Matr.ReadString(rows, cols));
        }

        #endregion

        #region Read6

        /// <summary>
        /// Заполняет 6 массива значениями типа Bool. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public static Tuple<bool[,], bool[,], bool[,], bool[,], bool[,], bool[,]> ReadBool6(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public static Tuple<char[,], char[,], char[,], char[,], char[,], char[,]> ReadChar6(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа Integer. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public static Tuple<int[,], int[,], int[,], int[,], int[,], int[,]> ReadInteger6(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа Real. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public static Tuple<double[,], double[,], double[,], double[,], double[,], double[,]> ReadReal6(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public static Tuple<string[,], string[,], string[,], string[,], string[,], string[,]> ReadString6(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadString(rows, cols), Matr.ReadString(rows, cols), Matr.ReadString(rows, cols), Matr.ReadString(rows, cols), Matr.ReadString(rows, cols), Matr.ReadString(rows, cols));
        }

        #endregion

        #region Read7

        /// <summary>
        /// Заполняет 6 массива значениями типа Bool. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public static Tuple<bool[,], bool[,], bool[,], bool[,], bool[,], bool[,], bool[,]> ReadBool7(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols));
        }

        /// <summary>
        /// Заполняет 7 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public static Tuple<char[,], char[,], char[,], char[,], char[,], char[,], char[,]> ReadChar7(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols));
        }

        /// <summary>
        /// Заполняет 7 массива значениями типа Integer. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public static Tuple<int[,], int[,], int[,], int[,], int[,], int[,], int[,]> ReadInteger7(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols));
        }

        /// <summary>
        /// Заполняет 7 массива значениями типа Real. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public static Tuple<double[,], double[,], double[,], double[,], double[,], double[,], double[,]> ReadReal7(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public static Tuple<string[,], string[,], string[,], string[,], string[,], string[,], string[,]> ReadString7(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadString(rows, cols), Matr.ReadString(rows, cols), Matr.ReadString(rows, cols), Matr.ReadString(rows, cols), Matr.ReadString(rows, cols), Matr.ReadString(rows, cols), Matr.ReadString(rows, cols));
        }

        #endregion

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
        /// Читает матрицу значений типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET].
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
        /// Читает матрицу значений типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET].
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
        /// Читает матрицу значений типа Real. [Не работает при запуске из под оболочки в IDE PascalABC.NET].
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
        /// Читает матрицу значений типа Integer. [Не работает при запуске из под оболочки в IDE PascalABC.NET].
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
        /// Читает матрицу значений типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET].
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