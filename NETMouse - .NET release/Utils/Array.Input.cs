using ABCNET.Extensions;
using System;
using System.Numerics;

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
            int i = 0;
            while (i < count)
                try
                {
                    array[i] = Base.ReadBoolean(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }

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
            int i = 0;
            while (i < count)
                try
                {
                    array[i] = Base.ReadByte(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }

            return array;
        }

        /// <summary>
        /// Читает массив значений типа Sbyte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Массив.</returns>
        public static sbyte[] ReadSbyte(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            sbyte[] array = new sbyte[count];
            int i = 0;
            while (i < count)
                try
                {
                    array[i] = Base.ReadSbyte(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
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
            int i = 0;
            while (i < count)
                try
                {
                    array[i] = Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }

            return array;
        }

        /// <summary>
        /// Читает массив значений типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Массив.</returns>
        public static decimal[] ReadDecimal(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            decimal[] array = new decimal[count];
            int i = 0;
            while (i < count)
                try
                {
                    array[i] = Base.ReadDecimal(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }

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
                    InputErrorHelper.Message.PrintLine();
                }

            return array;
        }

        /// <summary>
        /// Читает массив значений типа Float. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Массив.</returns>
        public static float[] ReadFloat(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            float[] array = new float[count];
            int i = 0;
            while (i < count)
                try
                {
                    array[i] = Base.ReadFloat(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }

            return array;
        }

        /// <summary>
        /// Читает массив значений типа Int. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Массив.</returns>
        public static int[] ReadInt(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            int[] array = new int[count];
            int i = 0;
            while (i < count)
                try
                {
                    array[i] = Base.ReadInt(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }

            return array;
        }

        /// <summary>
        /// Читает массив значений типа Uint. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Массив.</returns>
        public static uint[] ReadUint(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            uint[] array = new uint[count];
            int i = 0;
            while (i < count)
                try
                {
                    array[i] = Base.ReadUint(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }

            return array;
        }

        /// <summary>
        /// Читает массив значений типа Long. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Массив.</returns>
        public static long[] ReadLong(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            long[] array = new long[count];
            int i = 0;
            while (i < count)
                try
                {
                    array[i] = Base.ReadLong(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }

            return array;
        }

        /// <summary>
        /// Читает массив значений типа Ulong. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Массив.</returns>
        public static ulong[] ReadUlong(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            ulong[] array = new ulong[count];
            int i = 0;
            while (i < count)
                try
                {
                    array[i] = Base.ReadUlong(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }

            return array;
        }

        /// <summary>
        /// Читает массив значений типа Short. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Массив.</returns>
        public static short[] ReadShort(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            short[] array = new short[count];
            int i = 0;
            while (i < count)
                try
                {
                    array[i] = Base.ReadShort(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }

            return array;
        }

        /// <summary>
        /// Читает массив значений типа Ushort. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Массив.</returns>
        public static ushort[] ReadUshort(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            ushort[] array = new ushort[count];
            int i = 0;
            while (i < count)
                try
                {
                    array[i] = Base.ReadUshort(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }

            return array;
        }

        /// <summary>
        /// Читает массив значений типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Массив.</returns>
        public static BigInteger[] ReadBigInteger(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            BigInteger[] array = new BigInteger[count];
            int i = 0;
            while (i < count)
                try
                {
                    array[i] = Base.ReadBigInteger(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
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
        public static Tuple<bool[], bool[]> ReadBooleanTuple2(int count)
        {
            return Tuple.Of(ReadBoolean(count), ReadBoolean(count));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte[], byte[]> ReadByteTuple2(int count)
        {
            return Tuple.Of(ReadByte(count), ReadByte(count));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа Sbyte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte[], sbyte[]> ReadSbyteTuple2(int count)
        {
            return Tuple.Of(ReadSbyte(count), ReadSbyte(count));
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
        /// Заполняет 2 массива значениями типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal[], decimal[]> ReadDecimalTuple2(int count)
        {
            return Tuple.Of(ReadDecimal(count), ReadDecimal(count));
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
        /// Заполняет 2 массива значениями типа Float. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<float[], float[]> ReadFloatTuple2(int count)
        {
            return Tuple.Of(ReadFloat(count), ReadFloat(count));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа Int. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[], int[]> ReadIntTuple2(int count)
        {
            return Tuple.Of(ReadInt(count), ReadInt(count));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа Uint. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint[], uint[]> ReadUintTuple2(int count)
        {
            return Tuple.Of(ReadUint(count), ReadUint(count));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа Long. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<long[], long[]> ReadLongTuple2(int count)
        {
            return Tuple.Of(ReadLong(count), ReadLong(count));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа Ulong. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong[], ulong[]> ReadUlongTuple2(int count)
        {
            return Tuple.Of(ReadUlong(count), ReadUlong(count));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа Short. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<short[], short[]> ReadShortTuple2(int count)
        {
            return Tuple.Of(ReadShort(count), ReadShort(count));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа Ushort. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort[], ushort[]> ReadUshortTuple2(int count)
        {
            return Tuple.Of(ReadUshort(count), ReadUshort(count));
        }

        /// <summary>
        /// Заполняет 2 массива значениями типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger[], BigInteger[]> ReadBigIntegerTuple2(int count)
        {
            return Tuple.Of(ReadBigInteger(count), ReadBigInteger(count));
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
        /// Заполняет 3 массива значениями типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte[], byte[], byte[]> ReadByteTuple3(int count)
        {
            return Tuple.Of(ReadByte(count), ReadByte(count), ReadByte(count));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа Sbyte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte[], sbyte[], sbyte[]> ReadSbyteTuple3(int count)
        {
            return Tuple.Of(ReadSbyte(count), ReadSbyte(count), ReadSbyte(count));
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
        /// Заполняет 3 массива значениями типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal[], decimal[], decimal[]> ReadDecimalTuple3(int count)
        {
            return Tuple.Of(ReadDecimal(count), ReadDecimal(count), ReadDecimal(count));
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
        /// Заполняет 3 массива значениями типа Float. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<float[], float[], float[]> ReadFloatTuple3(int count)
        {
            return Tuple.Of(ReadFloat(count), ReadFloat(count), ReadFloat(count));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа Int. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[], int[], int[]> ReadIntTuple3(int count)
        {
            return Tuple.Of(ReadInt(count), ReadInt(count), ReadInt(count));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа Uint. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint[], uint[], uint[]> ReadUintTuple3(int count)
        {
            return Tuple.Of(ReadUint(count), ReadUint(count), ReadUint(count));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа Long. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<long[], long[], long[]> ReadLongTuple3(int count)
        {
            return Tuple.Of(ReadLong(count), ReadLong(count), ReadLong(count));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа Ulong. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong[], ulong[], ulong[]> ReadUlongTuple3(int count)
        {
            return Tuple.Of(ReadUlong(count), ReadUlong(count), ReadUlong(count));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа Short. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<short[], short[], short[]> ReadShortTuple3(int count)
        {
            return Tuple.Of(ReadShort(count), ReadShort(count), ReadShort(count));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа Ushort. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort[], ushort[], ushort[]> ReadUshortTuple3(int count)
        {
            return Tuple.Of(ReadUshort(count), ReadUshort(count), ReadUshort(count));
        }

        /// <summary>
        /// Заполняет 3 массива значениями типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger[], BigInteger[], BigInteger[]> ReadBigIntegerTuple3(int count)
        {
            return Tuple.Of(ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count));
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
        /// Заполняет 4 массива значениями типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte[], byte[], byte[], byte[]> ReadByteTuple4(int count)
        {
            return Tuple.Of(ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа Sbyte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte[], sbyte[], sbyte[], sbyte[]> ReadSbyteTuple4(int count)
        {
            return Tuple.Of(ReadSbyte(count), ReadSbyte(count), ReadSbyte(count), ReadSbyte(count));
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
        /// Заполняет 4 массива значениями типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal[], decimal[], decimal[], decimal[]> ReadDecimalTuple4(int count)
        {
            return Tuple.Of(ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count));
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
        /// Заполняет 4 массива значениями типа Float. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<float[], float[], float[], float[]> ReadFloatTuple4(int count)
        {
            return Tuple.Of(ReadFloat(count), ReadFloat(count), ReadFloat(count), ReadFloat(count));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа Int. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[], int[], int[], int[]> ReadIntTuple4(int count)
        {
            return Tuple.Of(ReadInt(count), ReadInt(count), ReadInt(count), ReadInt(count));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа Uint. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint[], uint[], uint[], uint[]> ReadUintTuple4(int count)
        {
            return Tuple.Of(ReadUint(count), ReadUint(count), ReadUint(count), ReadUint(count));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа Long. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<long[], long[], long[], long[]> ReadLongTuple4(int count)
        {
            return Tuple.Of(ReadLong(count), ReadLong(count), ReadLong(count), ReadLong(count));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа Ulong. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong[], ulong[], ulong[], ulong[]> ReadUlongTuple4(int count)
        {
            return Tuple.Of(ReadUlong(count), ReadUlong(count), ReadUlong(count), ReadUlong(count));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа Short. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<short[], short[], short[], short[]> ReadShortTuple4(int count)
        {
            return Tuple.Of(ReadShort(count), ReadShort(count), ReadShort(count), ReadShort(count));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа Ushort. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort[], ushort[], ushort[], ushort[]> ReadUshortTuple4(int count)
        {
            return Tuple.Of(ReadUshort(count), ReadUshort(count), ReadUshort(count), ReadUshort(count));
        }

        /// <summary>
        /// Заполняет 4 массива значениями типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger[], BigInteger[], BigInteger[], BigInteger[]> ReadBigIntegerTuple4(int count)
        {
            return Tuple.Of(ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count));
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
        /// Заполняет 5 массива значениями типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte[], byte[], byte[], byte[], byte[]> ReadByteTuple5(int count)
        {
            return Tuple.Of(ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа Sbyte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte[], sbyte[], sbyte[], sbyte[], sbyte[]> ReadSbyteTuple5(int count)
        {
            return Tuple.Of(ReadSbyte(count), ReadSbyte(count), ReadSbyte(count), ReadSbyte(count), ReadSbyte(count));
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
        /// Заполняет 5 массива значениями типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal[], decimal[], decimal[], decimal[], decimal[]> ReadDecimalTuple5(int count)
        {
            return Tuple.Of(ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count));
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
        /// Заполняет 5 массива значениями типа Float. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<float[], float[], float[], float[], float[]> ReadFloatTuple5(int count)
        {
            return Tuple.Of(ReadFloat(count), ReadFloat(count), ReadFloat(count), ReadFloat(count), ReadFloat(count));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа Int. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[], int[], int[], int[], int[]> ReadIntTuple5(int count)
        {
            return Tuple.Of(ReadInt(count), ReadInt(count), ReadInt(count), ReadInt(count), ReadInt(count));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа Uint. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint[], uint[], uint[], uint[], uint[]> ReadUintTuple5(int count)
        {
            return Tuple.Of(ReadUint(count), ReadUint(count), ReadUint(count), ReadUint(count), ReadUint(count));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа Long. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<long[], long[], long[], long[], long[]> ReadLongTuple5(int count)
        {
            return Tuple.Of(ReadLong(count), ReadLong(count), ReadLong(count), ReadLong(count), ReadLong(count));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа Ulong. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong[], ulong[], ulong[], ulong[], ulong[]> ReadUlongTuple5(int count)
        {
            return Tuple.Of(ReadUlong(count), ReadUlong(count), ReadUlong(count), ReadUlong(count), ReadUlong(count));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа Short. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<short[], short[], short[], short[], short[]> ReadShortTuple5(int count)
        {
            return Tuple.Of(ReadShort(count), ReadShort(count), ReadShort(count), ReadShort(count), ReadShort(count));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа Ushort. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort[], ushort[], ushort[], ushort[], ushort[]> ReadUshortTuple5(int count)
        {
            return Tuple.Of(ReadUshort(count), ReadUshort(count), ReadUshort(count), ReadUshort(count), ReadUshort(count));
        }

        /// <summary>
        /// Заполняет 5 массива значениями типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger[], BigInteger[], BigInteger[], BigInteger[], BigInteger[]> ReadBigIntegerTuple5(int count)
        {
            return Tuple.Of(ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count));
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
        /// Заполняет 6 массива значениями типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte[], byte[], byte[], byte[], byte[], byte[]> ReadByteTuple6(int count)
        {
            return Tuple.Of(ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа Sbyte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte[], sbyte[], sbyte[], sbyte[], sbyte[], sbyte[]> ReadSbyteTuple6(int count)
        {
            return Tuple.Of(ReadSbyte(count), ReadSbyte(count), ReadSbyte(count), ReadSbyte(count), ReadSbyte(count), ReadSbyte(count));
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
        /// Заполняет 6 массива значениями типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal[], decimal[], decimal[], decimal[], decimal[], decimal[]> ReadDecimalTuple6(int count)
        {
            return Tuple.Of(ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count));
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
        /// Заполняет 6 массива значениями типа Float. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<float[], float[], float[], float[], float[], float[]> ReadFloatTuple6(int count)
        {
            return Tuple.Of(ReadFloat(count), ReadFloat(count), ReadFloat(count), ReadFloat(count), ReadFloat(count), ReadFloat(count));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа Int. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[], int[], int[], int[], int[], int[]> ReadIntTuple6(int count)
        {
            return Tuple.Of(ReadInt(count), ReadInt(count), ReadInt(count), ReadInt(count), ReadInt(count), ReadInt(count));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа Uint. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint[], uint[], uint[], uint[], uint[], uint[]> ReadUintTuple6(int count)
        {
            return Tuple.Of(ReadUint(count), ReadUint(count), ReadUint(count), ReadUint(count), ReadUint(count), ReadUint(count));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа Long. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<long[], long[], long[], long[], long[], long[]> ReadLongTuple6(int count)
        {
            return Tuple.Of(ReadLong(count), ReadLong(count), ReadLong(count), ReadLong(count), ReadLong(count), ReadLong(count));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа Ulong. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong[], ulong[], ulong[], ulong[], ulong[], ulong[]> ReadUlongTuple6(int count)
        {
            return Tuple.Of(ReadUlong(count), ReadUlong(count), ReadUlong(count), ReadUlong(count), ReadUlong(count), ReadUlong(count));
        }
        /// <summary>
        /// Заполняет 6 массива значениями типа Short. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<short[], short[], short[], short[], short[], short[]> ReadShortTuple6(int count)
        {
            return Tuple.Of(ReadShort(count), ReadShort(count), ReadShort(count), ReadShort(count), ReadShort(count), ReadShort(count));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа Ushort. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort[], ushort[], ushort[], ushort[], ushort[], ushort[]> ReadUshortTuple6(int count)
        {
            return Tuple.Of(ReadUshort(count), ReadUshort(count), ReadUshort(count), ReadUshort(count), ReadUshort(count), ReadUshort(count));
        }

        /// <summary>
        /// Заполняет 6 массива значениями типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger[], BigInteger[], BigInteger[], BigInteger[], BigInteger[], BigInteger[]> ReadBigIntegerTuple6(int count)
        {
            return Tuple.Of(ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count));
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
        /// Заполняет 7 массива значениями типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte[], byte[], byte[], byte[], byte[], byte[], byte[]> ReadByteTuple7(int count)
        {
            return Tuple.Of(ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count));
        }

        /// <summary>
        /// Заполняет 7 массива значениями типа Sbyte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte[], sbyte[], sbyte[], sbyte[], sbyte[], sbyte[], sbyte[]> ReadSbyteTuple7(int count)
        {
            return Tuple.Of(ReadSbyte(count), ReadSbyte(count), ReadSbyte(count), ReadSbyte(count), ReadSbyte(count), ReadSbyte(count), ReadSbyte(count));
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
        /// Заполняет 7 массива значениями типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal[], decimal[], decimal[], decimal[], decimal[], decimal[], decimal[]> ReadDecimalTuple7(int count)
        {
            return Tuple.Of(ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count));
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
        /// Заполняет 7 массива значениями типа Float. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<float[], float[], float[], float[], float[], float[], float[]> ReadFloatTuple7(int count)
        {
            return Tuple.Of(ReadFloat(count), ReadFloat(count), ReadFloat(count), ReadFloat(count), ReadFloat(count), ReadFloat(count), ReadFloat(count));
        }

        /// <summary>
        /// Заполняет 7 массива значениями типа Int. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[], int[], int[], int[], int[], int[], int[]> ReadIntTuple7(int count)
        {
            return Tuple.Of(ReadInt(count), ReadInt(count), ReadInt(count), ReadInt(count), ReadInt(count), ReadInt(count), ReadInt(count));
        }
        /// <summary>
        /// Заполняет 7 массива значениями типа Uint. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint[], uint[], uint[], uint[], uint[], uint[], uint[]> ReadUintTuple7(int count)
        {
            return Tuple.Of(ReadUint(count), ReadUint(count), ReadUint(count), ReadUint(count), ReadUint(count), ReadUint(count), ReadUint(count));
        }

        /// <summary>
        /// Заполняет 7 массива значениями типа Long. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<long[], long[], long[], long[], long[], long[], long[]> ReadLongTuple7(int count)
        {
            return Tuple.Of(ReadLong(count), ReadLong(count), ReadLong(count), ReadLong(count), ReadLong(count), ReadLong(count), ReadLong(count));
        }

        /// <summary>
        /// Заполняет 7 массива значениями типа Ulong. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong[], ulong[], ulong[], ulong[], ulong[], ulong[], ulong[]> ReadUlongTuple7(int count)
        {
            return Tuple.Of(ReadUlong(count), ReadUlong(count), ReadUlong(count), ReadUlong(count), ReadUlong(count), ReadUlong(count), ReadUlong(count));
        }

        /// <summary>
        /// Заполняет 7 массива значениями типа Short. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<short[], short[], short[], short[], short[], short[], short[]> ReadShortTuple7(int count)
        {
            return Tuple.Of(ReadShort(count), ReadShort(count), ReadShort(count), ReadShort(count), ReadShort(count), ReadShort(count), ReadShort(count));
        }

        /// <summary>
        /// Заполняет 7 массива значениями типа Ushort. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort[], ushort[], ushort[], ushort[], ushort[], ushort[], ushort[]> ReadUshortTuple7(int count)
        {
            return Tuple.Of(ReadUshort(count), ReadUshort(count), ReadUshort(count), ReadUshort(count), ReadUshort(count), ReadUshort(count), ReadUshort(count));
        }

        /// <summary>
        /// Заполняет 7 массива значениями типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger[], BigInteger[], BigInteger[], BigInteger[], BigInteger[], BigInteger[], BigInteger[]> ReadBigIntegerTuple7(int count)
        {
            return Tuple.Of(ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count));
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
