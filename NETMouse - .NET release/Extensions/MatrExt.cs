using ABCNET.Utils;
using System;

namespace ABCNET.Extensions
{
    /// <summary>
    /// Предоставляет функционал для работы с матрицами.
    /// </summary>
    public static class MatrExt
    {
        /// <summary>
        /// Получает столбец матрицы.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="index">Индекс столбца.</param>
        /// <returns>Столбец.</returns>
        public static T[] Col<T>(this T[,] matrix, int index)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            return matrix.InternalGetColumn(index);
        }

        /// <summary>
        /// Получает столбец матрицы.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="index">Индекс столбца.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <returns>Столбец.</returns>
        public static TOutput[] Col<T, TOutput>(this T[,] matrix, int index, Func<T, TOutput> selector)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            return matrix.InternalGetColumnSelected(index, selector);
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
                throw new ArgumentNullException("matrix");

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
                throw new ArgumentNullException("matrix");

            return matrix.InternalGetRowSelected(index, selector);
        }

        /// <summary>
        /// Выводит матрицу и переходит на новую строку.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="delimiter">Разделитель.</param>

        public static T[,] Print<T>(this T[,] matrix, string delimiter = DefaultDelimiterHelper.Delimiter)
        {
        	if (matrix == null)
        		throw new ArgumentNullException("matrix");
        	
        	return matrix.InternalPrintAsMatrix(delimiter);
        }

        /// <summary>
        /// Выводит матрицу и переходит на новую строку.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <param name="delimiter">Разделитель.</param>

        public static T[,] PrintBy<T, TOutput>(this T[,] matrix, Func<T, TOutput> selector, string delimiter = DefaultDelimiterHelper.Delimiter)
        {
        	if (matrix == null)
        		throw new ArgumentNullException("matrix");
            if (selector == null)
                throw new ArgumentNullException("selector");
        	
        	return matrix.InternalPrintByAsMatrix(selector, delimiter);
        }

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
                throw new ArgumentNullException("matrix");
            if (selector == null)
                throw new ArgumentNullException("selector");

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = selector(i + rowFirstIndex, j + columnFirstIndex);
        }

        /// <summary>
        /// Заполняет матрицу случайными числами типа Integer.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        public static void Rand(this int[,] matrix, int low = IntegerBordersHelper.Low, int high = IntegerBordersHelper.High)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");
            if (low > high)
                throw new ArgumentException("low");

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = Base.Rand(low, high);
        }

        /// <summary>
        /// Заполняет матрицу случайными числами типа Real.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        public static void Rand(this double[,] matrix, double low = RealBordersHelper.Low, double high = RealBordersHelper.High)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");
            if (low > high)
                throw new ArgumentException("low");

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
                throw new ArgumentNullException("matrix");

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = value;
        }

        /// <summary>
        /// Заполняет матрицу значениями типа Boolean.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void ReadBoolean(this bool[,] matrix, string prompt = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            int i = 0;
            int j = 0;

            while (i < matrix.GetLength(0))
            {
                while (j < matrix.GetLength(1))
                    try
                    {
                        matrix[i, j] = Base.ReadBoolean(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
                        j++;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(InputErrorHelper.Message);
                    }

                i++;
                j = 0;
            }
        }

        /// <summary>
        /// Заполняет матрицу значениями типа Char.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void ReadChar(this char[,] matrix, string prompt = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
        }

        /// <summary>
        /// Заполняет матрицу значениями типа Real.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void ReadReal(this double[,] matrix, string prompt = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            int i = 0;
            int j = 0;

            while (i < matrix.GetLength(0))
            {
                while (j < matrix.GetLength(1))
                    try
                    {
                        matrix[i, j] = Base.ReadReal(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
                        j++;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(InputErrorHelper.Message);
                    }

                i++;
                j = 0;
            }
        }

        /// <summary>
        /// Заполняет матрицу значениями типа Integer.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void ReadInteger(this int[,] matrix, string prompt = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            int i = 0;
            int j = 0;

            while (i < matrix.GetLength(0))
            {
                while (j < matrix.GetLength(1))
                    try
                    {
                        matrix[i, j] = Base.ReadInteger(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
                        j++;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(InputErrorHelper.Message);
                    }

                i++;
                j = 0;
            }
        }

        /// <summary>
        /// Заполняет матрицу значениями типа String.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        public static void ReadString(this string[,] matrix, string prompt = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
        }


        private static T[] InternalGetColumn<T>(this T[,] matrix, int index)
        {
            int length = matrix.GetLength(0);
            if (!index.IsBetween(0, length - 1))
                throw new IndexOutOfRangeException("index");
            
            T[] column = new T[length];
            for (int i = 0; i < column.Length; i++)
                column[i] = matrix[i, index];

            return column;
        }
        
        private static TOutput[] InternalGetColumnSelected<T, TOutput>(this T[,] matrix, int index, Func<T, TOutput> selector)
        {
            if (selector == null)
                throw new ArgumentNullException("selector");

            int length = matrix.GetLength(0);
            if (!index.IsBetween(0, length - 1))
                throw new IndexOutOfRangeException("index");
            
            TOutput[] column = new TOutput[length];
            for (int i = 0; i < column.Length; i++)
                column[i] = selector(matrix[i, index]);

            return column;
        }
        
        private static T[] InternalGetRow<T>(this T[,] matrix, int index)
        {
            int length = matrix.GetLength(1);
            if (!index.IsBetween(0, length - 1))
                throw new IndexOutOfRangeException("index");
            
            T[] row = new T[length];
            for (int i = 0; i < row.Length; i++)
                row[i] = matrix[index, i];

            return row;
        }
        
        private static TOutput[] InternalGetRowSelected<T, TOutput>(this T[,] matrix, int index, Func<T, TOutput> selector)
        {
            if (selector == null)
                throw new ArgumentNullException("selector");

            int length = matrix.GetLength(1);
            if (!index.IsBetween(0, length - 1))
                throw new IndexOutOfRangeException("index");
            
            TOutput[] row = new TOutput[length];
            for (int i = 0; i < row.Length; i++)
                row[i] = selector(matrix[index, i]);

            return row;
        }
        
        private static T[,] InternalPrintAsMatrix<T>(this T[,] matrix, string delimiter = DefaultDelimiterHelper.Delimiter)
        {
        	int rowsCount = matrix.GetLength(0);
        	int columnsCount = matrix.GetLength(1);
        	int[] lengths = new int[columnsCount];
        	
			for (int j = 0; j < columnsCount; j++)
				for (int i = 0; i < rowsCount; i++)
				{
					int itemLength = matrix[i, j].ToString().Length;
					if (itemLength > lengths[j])
						lengths[j] = itemLength;
				}
			
			for (int i = 0; i < rowsCount; i++)
			{
				for (int j = 0; j < columnsCount; j++)
					Console.Write(string.Format("{0}{1}", matrix[i, j].ToString().PadLeft(lengths[j]), delimiter));
				Console.WriteLine();
			}
			
			return matrix;
        }
        
        private static T[,] InternalPrintByAsMatrix<T, TOutput>(this T[,] matrix, Func<T, TOutput> selector, string delimiter = DefaultDelimiterHelper.Delimiter)
        {
        	int rowsCount = matrix.GetLength(0);
        	int columnsCount = matrix.GetLength(1);
        	int[] lengths = new int[columnsCount];
        	
			for (int j = 0; j < columnsCount; j++)
				for (int i = 0; i < rowsCount; i++)
				{
					int itemLength = selector(matrix[i, j]).ToString().Length;
					if (itemLength > lengths[j])
						lengths[j] = itemLength;
				}
			
			for (int i = 0; i < rowsCount; i++)
			{
				for (int j = 0; j < columnsCount; j++)
					Console.Write(string.Format("{0}{1}", selector(matrix[i, j]).ToString().PadLeft(lengths[j]), delimiter));
				Console.WriteLine();
			}
			
			return matrix;
        }
    }
}