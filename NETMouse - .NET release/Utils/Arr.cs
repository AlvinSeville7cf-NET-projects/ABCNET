using System;

namespace ABCNET.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы с массивами.
    /// </summary>
    public static class Arr
    {
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
        /// Создаёт массив случайных чисел типа Int32.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Массив.</returns>
        public static int[] Rand(int count, int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
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
        /// Создаёт массив случайных чисел типа Double.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Массив.</returns>
        public static double[] Rand(int count, double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
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
        /// Читает массив значений типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Массив.</returns>
        public static double[] ReadDouble(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            double[] array = new double[count];
            int i = 0;
            while (i < count)
                try
                {
                    array[i] = Base.ReadDouble(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    Console.WriteLine(InputErrorHelper.Message);
                }

            return array;
        }

        /// <summary>
        /// Читает массив значений типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Массив.</returns>
        public static int[] ReadInt32(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            int[] array = new int[count];
            int i = 0;
            while (i < count)
                try
                {
                    array[i] = Base.ReadInt32(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
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

        /// <summary>
        /// Заполняет 2 массива значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool[], bool[]> ReadBooleanTup2(int count)
        {
            return Tuple.Create(ReadBoolean(count), ReadBoolean(count));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<char[], char[]> ReadCharTup2(int count)
        {
            return Tuple.Create(ReadChar(count), ReadChar(count));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[], int[]> ReadInt32Tup2(int count)
        {
            return Tuple.Create(ReadInt32(count), ReadInt32(count));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double[], double[]> ReadDoubleTup2(int count)
        {
            return Tuple.Create(ReadDouble(count), ReadDouble(count));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<string[], string[]> ReadStringTup2(int count)
        {
            return Tuple.Create(ReadString(count), ReadString(count));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool[], bool[], bool[]> ReadBooleanTup3(int count)
        {
            return Tuple.Create(ReadBoolean(count), ReadBoolean(count), ReadBoolean(count));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<char[], char[], char[]> ReadCharTup3(int count)
        {
            return Tuple.Create(ReadChar(count), ReadChar(count), ReadChar(count));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[], int[], int[]> ReadInt32Tup3(int count)
        {
            return Tuple.Create(ReadInt32(count), ReadInt32(count), ReadInt32(count));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double[], double[], double[]> ReadDoubleTup3(int count)
        {
            return Tuple.Create(ReadDouble(count), ReadDouble(count), ReadDouble(count));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<string[], string[], string[]> ReadStringTup3(int count)
        {
            return Tuple.Create(ReadString(count), ReadString(count), ReadString(count));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool[], bool[], bool[], bool[]> ReadBooleanTup4(int count)
        {
            return Tuple.Create(ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<char[], char[], char[], char[]> ReadCharTup4(int count)
        {
            return Tuple.Create(ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[], int[], int[], int[]> ReadInt32Tup4(int count)
        {
            return Tuple.Create(ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double[], double[], double[], double[]> ReadDoubleTup4(int count)
        {
            return Tuple.Create(ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<string[], string[], string[], string[]> ReadStringTup4(int count)
        {
            return Tuple.Create(ReadString(count), ReadString(count), ReadString(count), ReadString(count));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool[], bool[], bool[], bool[], bool[]> ReadBooleanTup5(int count)
        {
            return Tuple.Create(ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<char[], char[], char[], char[], char[]> ReadCharTup5(int count)
        {
            return Tuple.Create(ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[], int[], int[], int[], int[]> ReadInt32Tup5(int count)
        {
            return Tuple.Create(ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double[], double[], double[], double[], double[]> ReadDoubleTup5(int count)
        {
            return Tuple.Create(ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<string[], string[], string[], string[], string[]> ReadStringTup5(int count)
        {
            return Tuple.Create(ReadString(count), ReadString(count), ReadString(count), ReadString(count), ReadString(count));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool[], bool[], bool[], bool[], bool[], bool[]> ReadBooleanTup6(int count)
        {
            return Tuple.Create(ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<char[], char[], char[], char[], char[], char[]> ReadCharTup6(int count)
        {
            return Tuple.Create(ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[], int[], int[], int[], int[], int[]> ReadInt32Tup6(int count)
        {
            return Tuple.Create(ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double[], double[], double[], double[], double[], double[]> ReadDoubleTup6(int count)
        {
            return Tuple.Create(ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<string[], string[], string[], string[], string[], string[]> ReadStringTup6(int count)
        {
            return Tuple.Create(ReadString(count), ReadString(count), ReadString(count), ReadString(count), ReadString(count), ReadString(count));
        }

        /// <summary>
        /// Заполняет 7 массива значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool[], bool[], bool[], bool[], bool[], bool[], bool[]> ReadBooleanTup7(int count)
        {
            return Tuple.Create(ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count));
        }

        /// <summary>
        /// Заполняет 7 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<char[], char[], char[], char[], char[], char[], char[]> ReadCharTup7(int count)
        {
            return Tuple.Create(ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count));
        }

        /// <summary>
        /// Заполняет 7 массива значениями типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[], int[], int[], int[], int[], int[], int[]> ReadInt32Tup7(int count)
        {
            return Tuple.Create(ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count));
        }

        /// <summary>
        /// Заполняет 7 массива значениями типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double[], double[], double[], double[], double[], double[], double[]> ReadDoubleTup7(int count)
        {
            return Tuple.Create(ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count));
        }

        /// <summary>
        /// Заполняет 7 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<string[], string[], string[], string[], string[], string[], string[]> ReadStringTup7(int count)
        {
            return Tuple.Create(ReadString(count), ReadString(count), ReadString(count), ReadString(count), ReadString(count), ReadString(count), ReadString(count));
        }
    }
}