using System;

namespace ABCNET.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы с массивами.
    /// </summary>
    public static class Arr
    {
        #region Read2

        /// <summary>
        /// Заполняет 2 массива значениями типа Bool. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">Размер массива.</param>
        public static Tuple<bool[], bool[]> ReadBool2(int size)
        {
            return Tuple.Create(Arr.ReadBoolean(size), Arr.ReadBoolean(size));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">Размер массива.</param>
        public static Tuple<char[], char[]> ReadChar2(int size)
        {
            return Tuple.Create(Arr.ReadChar(size), Arr.ReadChar(size));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа Integer. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">Размер массива.</param>
        public static Tuple<int[], int[]> ReadInteger2(int size)
        {
            return Tuple.Create(Arr.ReadInteger(size), Arr.ReadInteger(size));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа Real. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">Размер массива.</param>
        public static Tuple<double[], double[]> ReadReal2(int size)
        {
            return Tuple.Create(Arr.ReadReal(size), Arr.ReadReal(size));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">Размер массива.</param>
        public static Tuple<string[], string[]> ReadString2(int size)
        {
            return Tuple.Create(Arr.ReadString(size), Arr.ReadString(size));
        }

        #endregion

        #region Read3

        /// <summary>
        /// Заполняет 3 массива значениями типа Bool. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">Размер массива.</param>
        public static Tuple<bool[], bool[], bool[]> ReadBool3(int size)
        {
            return Tuple.Create(Arr.ReadBoolean(size), Arr.ReadBoolean(size), Arr.ReadBoolean(size));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">Размер массива.</param>
        public static Tuple<char[], char[], char[]> ReadChar3(int size)
        {
            return Tuple.Create(Arr.ReadChar(size), Arr.ReadChar(size), Arr.ReadChar(size));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа Integer. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">Размер массива.</param>
        public static Tuple<int[], int[], int[]> ReadInteger3(int size)
        {
            return Tuple.Create(Arr.ReadInteger(size), Arr.ReadInteger(size), Arr.ReadInteger(size));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа Real. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">Размер массива.</param>
        public static Tuple<double[], double[], double[]> ReadReal3(int size)
        {
            return Tuple.Create(Arr.ReadReal(size), Arr.ReadReal(size), Arr.ReadReal(size));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">Размер массива.</param>
        public static Tuple<string[], string[], string[]> ReadString3(int size)
        {
            return Tuple.Create(Arr.ReadString(size), Arr.ReadString(size), Arr.ReadString(size));
        }

        #endregion

        #region Read4

        /// <summary>
        /// Заполняет 4 массива значениями типа Bool. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">Размер массива.</param>
        public static Tuple<bool[], bool[], bool[], bool[]> ReadBool4(int size)
        {
            return Tuple.Create(Arr.ReadBoolean(size), Arr.ReadBoolean(size), Arr.ReadBoolean(size), Arr.ReadBoolean(size));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">Размер массива.</param>
        public static Tuple<char[], char[], char[], char[]> ReadChar4(int size)
        {
            return Tuple.Create(Arr.ReadChar(size), Arr.ReadChar(size), Arr.ReadChar(size), Arr.ReadChar(size));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа Integer. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">Размер массива.</param>
        public static Tuple<int[], int[], int[], int[]> ReadInteger4(int size)
        {
            return Tuple.Create(Arr.ReadInteger(size), Arr.ReadInteger(size), Arr.ReadInteger(size), Arr.ReadInteger(size));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа Real. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">Размер массива.</param>
        public static Tuple<double[], double[], double[], double[]> ReadReal4(int size)
        {
            return Tuple.Create(Arr.ReadReal(size), Arr.ReadReal(size), Arr.ReadReal(size), Arr.ReadReal(size));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">Размер массива.</param>
        public static Tuple<string[], string[], string[], string[]> ReadString4(int size)
        {
            return Tuple.Create(Arr.ReadString(size), Arr.ReadString(size), Arr.ReadString(size), Arr.ReadString(size));
        }

        #endregion

        #region Read5

        /// <summary>
        /// Заполняет 5 массива значениями типа Bool. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">Размер массива.</param>
        public static Tuple<bool[], bool[], bool[], bool[], bool[]> ReadBool5(int size)
        {
            return Tuple.Create(Arr.ReadBoolean(size), Arr.ReadBoolean(size), Arr.ReadBoolean(size), Arr.ReadBoolean(size), Arr.ReadBoolean(size));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">Размер массива.</param>
        public static Tuple<char[], char[], char[], char[], char[]> ReadChar5(int size)
        {
            return Tuple.Create(Arr.ReadChar(size), Arr.ReadChar(size), Arr.ReadChar(size), Arr.ReadChar(size), Arr.ReadChar(size));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа Integer. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">Размер массива.</param>
        public static Tuple<int[], int[], int[], int[], int[]> ReadInteger5(int size)
        {
            return Tuple.Create(Arr.ReadInteger(size), Arr.ReadInteger(size), Arr.ReadInteger(size), Arr.ReadInteger(size), Arr.ReadInteger(size));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа Real. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">Размер массива.</param>
        public static Tuple<double[], double[], double[], double[], double[]> ReadReal5(int size)
        {
            return Tuple.Create(Arr.ReadReal(size), Arr.ReadReal(size), Arr.ReadReal(size), Arr.ReadReal(size), Arr.ReadReal(size));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">Размер массива.</param>
        public static Tuple<string[], string[], string[], string[], string[]> ReadString5(int size)
        {
            return Tuple.Create(Arr.ReadString(size), Arr.ReadString(size), Arr.ReadString(size), Arr.ReadString(size), Arr.ReadString(size));
        }

        #endregion

        #region Read6

        /// <summary>
        /// Заполняет 6 массива значениями типа Bool. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">Размер массива.</param>
        public static Tuple<bool[], bool[], bool[], bool[], bool[], bool[]> ReadBool6(int size)
        {
            return Tuple.Create(Arr.ReadBoolean(size), Arr.ReadBoolean(size), Arr.ReadBoolean(size), Arr.ReadBoolean(size), Arr.ReadBoolean(size), Arr.ReadBoolean(size));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">Размер массива.</param>
        public static Tuple<char[], char[], char[], char[], char[], char[]> ReadChar6(int size)
        {
            return Tuple.Create(Arr.ReadChar(size), Arr.ReadChar(size), Arr.ReadChar(size), Arr.ReadChar(size), Arr.ReadChar(size), Arr.ReadChar(size));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа Integer. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">Размер массива.</param>
        public static Tuple<int[], int[], int[], int[], int[], int[]> ReadInteger6(int size)
        {
            return Tuple.Create(Arr.ReadInteger(size), Arr.ReadInteger(size), Arr.ReadInteger(size), Arr.ReadInteger(size), Arr.ReadInteger(size), Arr.ReadInteger(size));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа Real. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">Размер массива.</param>
        public static Tuple<double[], double[], double[], double[], double[], double[]> ReadReal6(int size)
        {
            return Tuple.Create(Arr.ReadReal(size), Arr.ReadReal(size), Arr.ReadReal(size), Arr.ReadReal(size), Arr.ReadReal(size), Arr.ReadReal(size));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">Размер массива.</param>
        public static Tuple<string[], string[], string[], string[], string[], string[]> ReadString6(int size)
        {
            return Tuple.Create(Arr.ReadString(size), Arr.ReadString(size), Arr.ReadString(size), Arr.ReadString(size), Arr.ReadString(size), Arr.ReadString(size));
        }

        #endregion

        #region Read7

        /// <summary>
        /// Заполняет 7 массива значениями типа Bool. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">Размер массива.</param>
        public static Tuple<bool[], bool[], bool[], bool[], bool[], bool[], bool[]> ReadBool7(int size)
        {
            return Tuple.Create(Arr.ReadBoolean(size), Arr.ReadBoolean(size), Arr.ReadBoolean(size), Arr.ReadBoolean(size), Arr.ReadBoolean(size), Arr.ReadBoolean(size), Arr.ReadBoolean(size));
        }

        /// <summary>
        /// Заполняет 7 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">Размер массива.</param>
        public static Tuple<char[], char[], char[], char[], char[], char[], char[]> ReadChar7(int size)
        {
            return Tuple.Create(Arr.ReadChar(size), Arr.ReadChar(size), Arr.ReadChar(size), Arr.ReadChar(size), Arr.ReadChar(size), Arr.ReadChar(size), Arr.ReadChar(size));
        }

        /// <summary>
        /// Заполняет 7 массива значениями типа Integer. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">Размер массива.</param>
        public static Tuple<int[], int[], int[], int[], int[], int[], int[]> ReadInteger7(int size)
        {
            return Tuple.Create(Arr.ReadInteger(size), Arr.ReadInteger(size), Arr.ReadInteger(size), Arr.ReadInteger(size), Arr.ReadInteger(size), Arr.ReadInteger(size), Arr.ReadInteger(size));
        }

        /// <summary>
        /// Заполняет 7 массива значениями типа Real. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">Размер массива.</param>
        public static Tuple<double[], double[], double[], double[], double[], double[], double[]> ReadReal7(int size)
        {
            return Tuple.Create(Arr.ReadReal(size), Arr.ReadReal(size), Arr.ReadReal(size), Arr.ReadReal(size), Arr.ReadReal(size), Arr.ReadReal(size), Arr.ReadReal(size));
        }

        /// <summary>
        /// Заполняет 7 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">Размер массива.</param>
        public static Tuple<string[], string[], string[], string[], string[], string[], string[]> ReadString7(int size)
        {
            return Tuple.Create(Arr.ReadString(size), Arr.ReadString(size), Arr.ReadString(size), Arr.ReadString(size), Arr.ReadString(size), Arr.ReadString(size), Arr.ReadString(size));
        }

        #endregion


        /// <summary>
        /// Создаёт массив из указанных значений.
        /// </summary>
        /// <param name="values">Значения.</param>
        /// <returns>Массив.</returns>
        public static T[] New<T>(params T[] values)
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
        public static T[] Gen<T>(int count, Func<int, T> selector, int firstIndex = 0)
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
        public static T[] Gen<T>(int count, T first, Func<T, T> next)
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
        /// Создаёт массив случайных чисел типа Integer.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Массив.</returns>
        public static int[] Rand(int count, int low = IntegerBordersHelper.Low, int high = IntegerBordersHelper.High)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (low > high)
                throw new ArgumentException(nameof(low));

            int[] source = new int[count];
            for (int i = 0; i < source.Length; i++)
                source[i] = Base.Rand(low, high);

            return source;
        }

        /// <summary>
        /// Создаёт массив случайных чисел типа Real.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Массив.</returns>
        public static double[] Rand(int count, double low = RealBordersHelper.Low, double high = RealBordersHelper.High)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (low > high)
                throw new ArgumentException(nameof(low));

            double[] source = new double[count];
            for (int i = 0; i < source.Length; i++)
                source[i] = Base.Rand(low, high);

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

        /// <summary>
        /// Читает массив значений типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Массив.</returns>
        public static bool[] ReadBoolean(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            bool[] array = new bool[count];
            int i = 0;
            while (i < count)
                try
                {
                    array[i] = Base.ReadBoolean(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    Console.WriteLine(InputErrorHelper.Message);
                }

            return array;
        }

        /// <summary>
        /// Читает массив значений типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Массив.</returns>
        public static char[] ReadChar(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            char[] array = new char[count];
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));

            return array;
        }

        /// <summary>
        /// Читает массив значений типа Real. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Массив.</returns>
        public static double[] ReadReal(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            double[] array = new double[count];
            int i = 0;
            while (i < count)
                try
                {
                    array[i] = Base.ReadReal(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    Console.WriteLine(InputErrorHelper.Message);
                }

            return array;
        }

        /// <summary>
        /// Читает массив значений типа Integer. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Массив.</returns>
        public static int[] ReadInteger(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            int[] array = new int[count];
            int i = 0;
            while (i < count)
                try
                {
                    array[i] = Base.ReadInteger(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    Console.WriteLine(InputErrorHelper.Message);
                }

            return array;
        }

        /// <summary>
        /// Читает массив значений типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Массив.</returns>
        public static string[] ReadString(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            string[] array = new string[count];
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
            return array;
        }
    }
}