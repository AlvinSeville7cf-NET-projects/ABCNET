using ABCNET.Extensions;
using System;

namespace ABCNET.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы с матрицами.
    /// </summary>
    public static partial class Matr
    {
        #region public

        /// <summary>
        /// Читает матрицу значений типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Матрица.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadBoolean")]
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
                        InputErrorHelper.Message.Println();
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
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadChar")]
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
        /// Читает матрицу значений типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Матрица.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadDouble")]
        public static double[,] ReadDouble(int rowsCount, int colsCount, string prompt = EmptyStringHelper.Empty)
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
                        source[i, j] = Base.ReadDouble(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
                        j++;
                    }
                    catch (Exception)
                    {
                        InputErrorHelper.Message.Println();
                    }

                i++;
                j = 0;
            }

            return source;
        }

        /// <summary>
        /// Читает матрицу значений типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Матрица.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadInt32")]
        public static int[,] ReadInt32(int rowsCount, int colsCount, string prompt = EmptyStringHelper.Empty)
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
                        source[i, j] = Base.ReadInt32(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
                        j++;
                    }
                    catch (Exception)
                    {
                        InputErrorHelper.Message.Println();
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
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadString")]
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
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadBooleanTuple2")]
        public static Tuple<bool[,], bool[,]> ReadBooleanTup2(int rowsCount, int colsCount)
        {
            return Tup.New(ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadCharTuple2")]
        public static Tuple<char[,], char[,]> ReadCharTup2(int rowsCount, int colsCount)
        {
            return Tup.New(ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadInt32Tuple2")]
        public static Tuple<int[,], int[,]> ReadInt32Tup2(int rowsCount, int colsCount)
        {
            return Tup.New(ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadDoubleTuple2")]
        public static Tuple<double[,], double[,]> ReadDoubleTup2(int rowsCount, int colsCount)
        {
            return Tup.New(ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadStringTuple2")]
        public static Tuple<string[,], string[,]> ReadStringTup2(int rowsCount, int colsCount)
        {
            return Tup.New(ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadBooleanTuple3")]
        public static Tuple<bool[,], bool[,], bool[,]> ReadBooleanTup3(int rowsCount, int colsCount)
        {
            return Tup.New(ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadCharTuple3")]
        public static Tuple<char[,], char[,], char[,]> ReadCharTup3(int rowsCount, int colsCount)
        {
            return Tup.New(ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadInt32Tuple3")]
        public static Tuple<int[,], int[,], int[,]> ReadInt32Tup3(int rowsCount, int colsCount)
        {
            return Tup.New(ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadDoubleTuple3")]
        public static Tuple<double[,], double[,], double[,]> ReadDoubleTup3(int rowsCount, int colsCount)
        {
            return Tup.New(ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadStringTuple3")]
        public static Tuple<string[,], string[,], string[,]> ReadStringTup3(int rowsCount, int colsCount)
        {
            return Tup.New(ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadBooleanTuple4")]
        public static Tuple<bool[,], bool[,], bool[,], bool[,]> ReadBooleanTup4(int rowsCount, int colsCount)
        {
            return Tup.New(ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadCharTuple4")]
        public static Tuple<char[,], char[,], char[,], char[,]> ReadCharTup4(int rowsCount, int colsCount)
        {
            return Tup.New(ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadInt32Tuple4")]
        public static Tuple<int[,], int[,], int[,], int[,]> ReadInt32Tup4(int rowsCount, int colsCount)
        {
            return Tup.New(ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadDoubleTuple4")]
        public static Tuple<double[,], double[,], double[,], double[,]> ReadDoubleTup4(int rowsCount, int colsCount)
        {
            return Tup.New(ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadStringTuple4")]
        public static Tuple<string[,], string[,], string[,], string[,]> ReadStringTup4(int rowsCount, int colsCount)
        {
            return Tup.New(ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadBooleanTuple5")]
        public static Tuple<bool[,], bool[,], bool[,], bool[,], bool[,]> ReadBooleanTup5(int rowsCount, int colsCount)
        {
            return Tup.New(ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadCharTuple5")]
        public static Tuple<char[,], char[,], char[,], char[,], char[,]> ReadCharTup5(int rowsCount, int colsCount)
        {
            return Tup.New(ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadInt32Tuple5")]
        public static Tuple<int[,], int[,], int[,], int[,], int[,]> ReadInt32Tup5(int rowsCount, int colsCount)
        {
            return Tup.New(ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadDoubleTuple5")]
        public static Tuple<double[,], double[,], double[,], double[,], double[,]> ReadDoubleTup5(int rowsCount, int colsCount)
        {
            return Tup.New(ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadStringTuple5")]
        public static Tuple<string[,], string[,], string[,], string[,], string[,]> ReadStringTup5(int rowsCount, int colsCount)
        {
            return Tup.New(ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadBooleanTuple6")]
        public static Tuple<bool[,], bool[,], bool[,], bool[,], bool[,], bool[,]> ReadBooleanTup6(int rowsCount, int colsCount)
        {
            return Tup.New(ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadCharTuple6")]
        public static Tuple<char[,], char[,], char[,], char[,], char[,], char[,]> ReadCharTup6(int rowsCount, int colsCount)
        {
            return Tup.New(ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadInt32Tuple6")]
        public static Tuple<int[,], int[,], int[,], int[,], int[,], int[,]> ReadInt32Tup6(int rowsCount, int colsCount)
        {
            return Tup.New(ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadDoubleTuple6")]
        public static Tuple<double[,], double[,], double[,], double[,], double[,], double[,]> ReadDoubleTup6(int rowsCount, int colsCount)
        {
            return Tup.New(ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadStringTuple6")]
        public static Tuple<string[,], string[,], string[,], string[,], string[,], string[,]> ReadStringTup6(int rowsCount, int colsCount)
        {
            return Tup.New(ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadBooleanTuple7")]
        public static Tuple<bool[,], bool[,], bool[,], bool[,], bool[,], bool[,], bool[,]> ReadBooleanTup7(int rowsCount, int colsCount)
        {
            return Tup.New(ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 7 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadCharTuple7")]
        public static Tuple<char[,], char[,], char[,], char[,], char[,], char[,], char[,]> ReadCharTup7(int rowsCount, int colsCount)
        {
            return Tup.New(ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 7 массива значениями типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadInt32Tuple7")]
        public static Tuple<int[,], int[,], int[,], int[,], int[,], int[,], int[,]> ReadInt32Tup7(int rowsCount, int colsCount)
        {
            return Tup.New(ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 7 массива значениями типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matrix.ReadDoubleTuple7")]
        public static Tuple<double[,], double[,], double[,], double[,], double[,], double[,], double[,]> ReadDoubleTup7(int rowsCount, int colsCount)
        {
            return Tup.New(ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matr.ReadStringTuple7")]
        public static Tuple<string[,], string[,], string[,], string[,], string[,], string[,], string[,]> ReadStringTup7(int rowsCount, int colsCount)
        {
            return Tup.New(ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount));
        }

        #endregion public
    }
}
