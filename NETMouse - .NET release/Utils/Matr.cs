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
        /// <param name="colsCount">Количество столбцов.</param>
        /// <param name="values">Значения.</param>
        /// <returns>Матрица.</returns>
        public static T[,] New<T>(int rowsCount, int colsCount, params T[] values)
        {
            if (values == null)
                throw new ArgumentNullException(nameof(values));
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));
            if (rowsCount * colsCount != values.Length)
                throw new ArgumentNullException(nameof(values));

            T[,] source = new T[rowsCount, colsCount];
            int k = 0;
            for (int i = 0; i < rowsCount; i++)
                for (int j = 0; j < colsCount; j++)
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
        /// <param name="colsCount">Количество столбцов.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <param name="rowFirstIndex">Начальный индекс строки.</param>
        /// <param name="columnFirstIndex">Начальный индекс столбца.</param>
        /// <returns>Матрица.</returns>
        public static T[,] Gen<T>(int rowsCount, int colsCount, Func<int, int, T> selector, int rowFirstIndex = 0, int columnFirstIndex = 0)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));
            
            T[,] source = new T[rowsCount, colsCount];
            for (int i = 0; i < source.GetLength(0); i++)
                for (int j = 0; j < source.GetLength(1); j++)
                    source[i, j] = selector(i + rowFirstIndex, j + columnFirstIndex);

            return source;
        }

        /// <summary>
        /// Создаёт матрицу случайных чисел типа Integer.
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Матрица.</returns>
        public static int[,] Rand(int rowsCount, int colsCount, int low = IntegerBordersHelper.Low, int high = IntegerBordersHelper.High)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));
            if (low > high)
                throw new ArgumentException(nameof(low));

            int[,] source = new int[rowsCount, colsCount];
            for (int i = 0; i < source.GetLength(0); i++)
                for (int j = 0; j < source.GetLength(1); j++)
                    source[i, j] = Base.Rand(low, high);

            return source;
        }

        /// <summary>
        /// Создаёт матрицу случайных чисел типа Real.
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Матрица.</returns>
        public static double[,] Rand(int rowsCount, int colsCount, double low = RealBordersHelper.Low, double high = RealBordersHelper.High)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));
            if (low > high)
                throw new ArgumentException(nameof(low));

            double[,] source = new double[rowsCount, colsCount];
            for (int i = 0; i < source.GetLength(0); i++)
                for (int j = 0; j < source.GetLength(1); j++)
                    source[i, j] = Base.Rand(low, high);

            return source;
        }

        /// <summary>
        /// Создаёт матрицу, заполненную указанным значением.
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <param name="value">Значение.</param>
        /// <returns>Массив.</returns>
        public static T[,] Fill<T>(int rowsCount, int colsCount, T value)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));

            T[,] source = new T[rowsCount, colsCount];
            for (int i = 0; i < source.GetLength(0); i++)
                for (int j = 0; j < source.GetLength(1); j++)
                    source[i, j] = value;

            return source;
        }

        /// <summary>
        /// Читает матрицу значений типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Матрица.</returns>
        public static bool[,] ReadBoolean(int rowsCount, int colsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));

            bool[,] source = new bool[rowsCount, colsCount];
            int i = 0;
            int j = 0;

            while (i < rowsCount)
            {
                while (j < colsCount)
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
        /// Читает матрицу значений типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Матрица.</returns>
        public static char[,] ReadChar(int rowsCount, int colsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));

            char[,] source = new char[rowsCount, colsCount];
            for (int i = 0; i < rowsCount; i++)
                for (int j = 0; j < colsCount; j++)
                    source[i, j] = Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));

            return source;
        }

        /// <summary>
        /// Читает матрицу значений типа Real. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Матрица.</returns>
        public static double[,] ReadReal(int rowsCount, int colsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));

            double[,] source = new double[rowsCount, colsCount];
            int i = 0;
            int j = 0;

            while (i < rowsCount)
            {
                while (j < colsCount)
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
        /// Читает матрицу значений типа Integer. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Матрица.</returns>
        public static int[,] ReadInteger(int rowsCount, int colsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));

            int[,] source = new int[rowsCount, colsCount];
            int i = 0;
            int j = 0;

            while (i < rowsCount)
            {
                while (j < colsCount)
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
        /// Читает матрицу значений типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Матрица.</returns>
        public static string[,] ReadString(int rowsCount, int colsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));

            string[,] source = new string[rowsCount, colsCount];
            for (int i = 0; i < rowsCount; i++)
                for (int j = 0; j < colsCount; j++)
                    source[i, j] = Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));

            return source;
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        public static Tuple<bool[,], bool[,]> ReadBoolean2(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        public static Tuple<char[,], char[,]> ReadChar2(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа Integer. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        public static Tuple<int[,], int[,]> ReadInteger2(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadInteger(rowsCount, colsCount), ReadInteger(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа Real. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        public static Tuple<double[,], double[,]> ReadReal2(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadReal(rowsCount, colsCount), ReadReal(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        public static Tuple<string[,], string[,]> ReadString2(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        public static Tuple<bool[,], bool[,], bool[,]> ReadBoolean3(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        public static Tuple<char[,], char[,], char[,]> ReadChar3(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа Integer. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        public static Tuple<int[,], int[,], int[,]> ReadInteger3(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadInteger(rowsCount, colsCount), ReadInteger(rowsCount, colsCount), ReadInteger(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа Real. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        public static Tuple<double[,], double[,], double[,]> ReadReal3(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadReal(rowsCount, colsCount), ReadReal(rowsCount, colsCount), ReadReal(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        public static Tuple<string[,], string[,], string[,]> ReadString3(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        public static Tuple<bool[,], bool[,], bool[,], bool[,]> ReadBoolean4(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        public static Tuple<char[,], char[,], char[,], char[,]> ReadChar4(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа Integer. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        public static Tuple<int[,], int[,], int[,], int[,]> ReadInteger4(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadInteger(rowsCount, colsCount), ReadInteger(rowsCount, colsCount), ReadInteger(rowsCount, colsCount), ReadInteger(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа Real. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        public static Tuple<double[,], double[,], double[,], double[,]> ReadReal4(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadReal(rowsCount, colsCount), ReadReal(rowsCount, colsCount), ReadReal(rowsCount, colsCount), ReadReal(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        public static Tuple<string[,], string[,], string[,], string[,]> ReadString4(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        public static Tuple<bool[,], bool[,], bool[,], bool[,], bool[,]> ReadBoolean5(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        public static Tuple<char[,], char[,], char[,], char[,], char[,]> ReadChar5(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа Integer. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        public static Tuple<int[,], int[,], int[,], int[,], int[,]> ReadInteger5(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadInteger(rowsCount, colsCount), ReadInteger(rowsCount, colsCount), ReadInteger(rowsCount, colsCount), ReadInteger(rowsCount, colsCount), ReadInteger(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа Real. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        public static Tuple<double[,], double[,], double[,], double[,], double[,]> ReadReal5(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadReal(rowsCount, colsCount), ReadReal(rowsCount, colsCount), ReadReal(rowsCount, colsCount), ReadReal(rowsCount, colsCount), ReadReal(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        public static Tuple<string[,], string[,], string[,], string[,], string[,]> ReadString5(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        public static Tuple<bool[,], bool[,], bool[,], bool[,], bool[,], bool[,]> ReadBoolean6(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        public static Tuple<char[,], char[,], char[,], char[,], char[,], char[,]> ReadChar6(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа Integer. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        public static Tuple<int[,], int[,], int[,], int[,], int[,], int[,]> ReadInteger6(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadInteger(rowsCount, colsCount), ReadInteger(rowsCount, colsCount), ReadInteger(rowsCount, colsCount), ReadInteger(rowsCount, colsCount), ReadInteger(rowsCount, colsCount), ReadInteger(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа Real. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        public static Tuple<double[,], double[,], double[,], double[,], double[,], double[,]> ReadReal6(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadReal(rowsCount, colsCount), ReadReal(rowsCount, colsCount), ReadReal(rowsCount, colsCount), ReadReal(rowsCount, colsCount), ReadReal(rowsCount, colsCount), ReadReal(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        public static Tuple<string[,], string[,], string[,], string[,], string[,], string[,]> ReadString6(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        public static Tuple<bool[,], bool[,], bool[,], bool[,], bool[,], bool[,], bool[,]> ReadBoolean7(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 7 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        public static Tuple<char[,], char[,], char[,], char[,], char[,], char[,], char[,]> ReadChar7(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 7 массива значениями типа Integer. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        public static Tuple<int[,], int[,], int[,], int[,], int[,], int[,], int[,]> ReadInteger7(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadInteger(rowsCount, colsCount), ReadInteger(rowsCount, colsCount), ReadInteger(rowsCount, colsCount), ReadInteger(rowsCount, colsCount), ReadInteger(rowsCount, colsCount), ReadInteger(rowsCount, colsCount), ReadInteger(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 7 массива значениями типа Real. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        public static Tuple<double[,], double[,], double[,], double[,], double[,], double[,], double[,]> ReadReal7(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadReal(rowsCount, colsCount), ReadReal(rowsCount, colsCount), ReadReal(rowsCount, colsCount), ReadReal(rowsCount, colsCount), ReadReal(rowsCount, colsCount), ReadReal(rowsCount, colsCount), ReadReal(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        public static Tuple<string[,], string[,], string[,], string[,], string[,], string[,], string[,]> ReadString7(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount));
        }
    }
}