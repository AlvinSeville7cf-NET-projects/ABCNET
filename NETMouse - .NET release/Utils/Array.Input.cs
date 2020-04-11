using ABCNET.Extensions;
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
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadBoolean(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));

            return array;
        }

        /// <summary>
        /// Читает массив значений типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Массив.</returns>
        public static byte[] ReadByte(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            byte[] array = new byte[count];
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadByte(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));

            return array;
        }

        /// <summary>
        /// Читает массив значений типа SByte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Массив.</returns>
        public static sbyte[] ReadSByte(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            sbyte[] array = new sbyte[count];
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadSByte(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));

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
        /// Читает массив значений типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Массив.</returns>
        public static decimal[] ReadDecimal(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            decimal[] array = new decimal[count];
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadDecimal(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));

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
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadDouble(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));

            return array;
        }

        /// <summary>
        /// Читает массив значений типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Массив.</returns>
        public static float[] ReadSingle(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            float[] array = new float[count];
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadSingle(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));

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
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadInt32(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));

            return array;
        }

        /// <summary>
        /// Читает массив значений типа UInt32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Массив.</returns>
        public static uint[] ReadUInt32(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            uint[] array = new uint[count];
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadUInt32(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));

            return array;
        }

        /// <summary>
        /// Читает массив значений типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Массив.</returns>
        public static long[] ReadInt64(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            long[] array = new long[count];
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadInt64(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));

            return array;
        }

        /// <summary>
        /// Читает массив значений типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Массив.</returns>
        public static ulong[] ReadUInt64(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            ulong[] array = new ulong[count];
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadUInt64(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));

            return array;
        }

        /// <summary>
        /// Читает массив значений типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Массив.</returns>
        public static short[] ReadInt16(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            short[] array = new short[count];
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadInt16(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));

            return array;
        }

        /// <summary>
        /// Читает массив значений типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Массив.</returns>
        public static ushort[] ReadUInt16(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            ushort[] array = new ushort[count];
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadUInt64(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));

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
        public static Tuple<bool[], bool[]> ReadBooleanTuple2(int count)
        {
            return Tuple.Of(ReadBoolean(count), ReadBoolean(count));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<char[], char[]> ReadCharTuple2(int count)
        {
            return Tuple.Of(ReadChar(count), ReadChar(count));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[], int[]> ReadInt32Tuple2(int count)
        {
            return Tuple.Of(ReadInt32(count), ReadInt32(count));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double[], double[]> ReadDoubleTuple2(int count)
        {
            return Tuple.Of(ReadDouble(count), ReadDouble(count));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<string[], string[]> ReadStringTuple2(int count)
        {
            return Tuple.Of(ReadString(count), ReadString(count));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool[], bool[], bool[]> ReadBooleanTuple3(int count)
        {
            return Tuple.Of(ReadBoolean(count), ReadBoolean(count), ReadBoolean(count));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<char[], char[], char[]> ReadCharTuple3(int count)
        {
            return Tuple.Of(ReadChar(count), ReadChar(count), ReadChar(count));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[], int[], int[]> ReadInt32Tuple3(int count)
        {
            return Tuple.Of(ReadInt32(count), ReadInt32(count), ReadInt32(count));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double[], double[], double[]> ReadDoubleTuple3(int count)
        {
            return Tuple.Of(ReadDouble(count), ReadDouble(count), ReadDouble(count));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<string[], string[], string[]> ReadStringTuple3(int count)
        {
            return Tuple.Of(ReadString(count), ReadString(count), ReadString(count));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool[], bool[], bool[], bool[]> ReadBooleanTuple4(int count)
        {
            return Tuple.Of(ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<char[], char[], char[], char[]> ReadCharTuple4(int count)
        {
            return Tuple.Of(ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[], int[], int[], int[]> ReadInt32Tuple4(int count)
        {
            return Tuple.Of(ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double[], double[], double[], double[]> ReadDoubleTuple4(int count)
        {
            return Tuple.Of(ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<string[], string[], string[], string[]> ReadStringTuple4(int count)
        {
            return Tuple.Of(ReadString(count), ReadString(count), ReadString(count), ReadString(count));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool[], bool[], bool[], bool[], bool[]> ReadBooleanTuple5(int count)
        {
            return Tuple.Of(ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<char[], char[], char[], char[], char[]> ReadCharTuple5(int count)
        {
            return Tuple.Of(ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[], int[], int[], int[], int[]> ReadInt32Tuple5(int count)
        {
            return Tuple.Of(ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double[], double[], double[], double[], double[]> ReadDoubleTuple5(int count)
        {
            return Tuple.Of(ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<string[], string[], string[], string[], string[]> ReadStringTuple5(int count)
        {
            return Tuple.Of(ReadString(count), ReadString(count), ReadString(count), ReadString(count), ReadString(count));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool[], bool[], bool[], bool[], bool[], bool[]> ReadBooleanTuple6(int count)
        {
            return Tuple.Of(ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<char[], char[], char[], char[], char[], char[]> ReadCharTuple6(int count)
        {
            return Tuple.Of(ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[], int[], int[], int[], int[], int[]> ReadInt32Tuple6(int count)
        {
            return Tuple.Of(ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double[], double[], double[], double[], double[], double[]> ReadDoubleTuple6(int count)
        {
            return Tuple.Of(ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<string[], string[], string[], string[], string[], string[]> ReadStringTuple6(int count)
        {
            return Tuple.Of(ReadString(count), ReadString(count), ReadString(count), ReadString(count), ReadString(count), ReadString(count));
        }

        /// <summary>
        /// Заполняет 7 массива значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool[], bool[], bool[], bool[], bool[], bool[], bool[]> ReadBooleanTuple7(int count)
        {
            return Tuple.Of(ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count));
        }

        /// <summary>
        /// Заполняет 7 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<char[], char[], char[], char[], char[], char[], char[]> ReadCharTuple7(int count)
        {
            return Tuple.Of(ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count));
        }

        /// <summary>
        /// Заполняет 7 массива значениями типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[], int[], int[], int[], int[], int[], int[]> ReadInt32Tuple7(int count)
        {
            return Tuple.Of(ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count));
        }

        /// <summary>
        /// Заполняет 7 массива значениями типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double[], double[], double[], double[], double[], double[], double[]> ReadDoubleTuple7(int count)
        {
            return Tuple.Of(ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count));
        }

        /// <summary>
        /// Заполняет 7 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<string[], string[], string[], string[], string[], string[], string[]> ReadStringTuple7(int count)
        {
            return Tuple.Of(ReadString(count), ReadString(count), ReadString(count), ReadString(count), ReadString(count), ReadString(count), ReadString(count));
        }
        #endregion public
    }
}
