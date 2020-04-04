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

        #region Read

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

        #endregion

        #region ReadTuple2

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
        /// Заполняет 2 массива значениями типа SByte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte[], sbyte[]> ReadSByteTuple2(int count)
        {
            return Tuple.Of(ReadSByte(count), ReadSByte(count));
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
        /// Заполняет 2 массива значениями типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<float[], float[]> ReadSingleTuple2(int count)
        {
            return Tuple.Of(ReadSingle(count), ReadSingle(count));
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
        /// Заполняет 2 массива значениями типа Uint32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint[], uint[]> ReadUint32Tuple2(int count)
        {
            return Tuple.Of(ReadUint32(count), ReadUint32(count));
        }
        /// <summary>
        /// Заполняет 2 массива значениями типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<long[], long[]> ReadInt64Tuple2(int count)
        {
            return Tuple.Of(ReadInt64(count), ReadInt64(count));
        }
        /// <summary>
        /// Заполняет 2 массива значениями типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong[], ulong[]> ReadUInt64Tuple2(int count)
        {
            return Tuple.Of(ReadUInt64(count), ReadUInt64(count));
        }
        /// <summary>
        /// Заполняет 2 массива значениями типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<short[], short[]> ReadInt16Tuple2(int count)
        {
            return Tuple.Of(ReadInt16(count), ReadInt16(count));
        }
        /// <summary>
        /// Заполняет 2 массива значениями типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort[], ushort[]> ReadUInt16Tuple2(int count)
        {
            return Tuple.Of(ReadUInt16(count), ReadUInt16(count));
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

        #endregion

        #region ReadTuple3

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
        /// Заполняет 3 массива значениями типа SByte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte[], sbyte[], sbyte[]> ReadSByteTuple3(int count)
        {
            return Tuple.Of(ReadSByte(count), ReadSByte(count), ReadSByte(count));
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
        /// Заполняет 3 массива значениями типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<float[], float[], float[]> ReadSingleTuple3(int count)
        {
            return Tuple.Of(ReadSingle(count), ReadSingle(count), ReadSingle(count));
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
        /// Заполняет 3 массива значениями типа Uint32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint[], uint[], uint[]> ReadUint32Tuple3(int count)
        {
            return Tuple.Of(ReadUint32(count), ReadUint32(count), ReadUint32(count));
        }
        /// <summary>
        /// Заполняет 3 массива значениями типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<long[], long[], long[]> ReadInt64Tuple3(int count)
        {
            return Tuple.Of(ReadInt64(count), ReadInt64(count), ReadInt64(count));
        }
        /// <summary>
        /// Заполняет 3 массива значениями типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong[], ulong[], ulong[]> ReadUInt64Tuple3(int count)
        {
            return Tuple.Of(ReadUInt64(count), ReadUInt64(count), ReadUInt64(count));
        }
        /// <summary>
        /// Заполняет 3 массива значениями типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<short[], short[], short[]> ReadInt16Tuple3(int count)
        {
            return Tuple.Of(ReadInt16(count), ReadInt16(count), ReadInt16(count));
        }
        /// <summary>
        /// Заполняет 3 массива значениями типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort[], ushort[], ushort[]> ReadUInt16Tuple3(int count)
        {
            return Tuple.Of(ReadUInt16(count), ReadUInt16(count), ReadUInt16(count));
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

        #endregion

        #region ReadTuple4

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
        /// Заполняет 4 массива значениями типа SByte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte[], sbyte[], sbyte[], sbyte[]> ReadSByteTuple4(int count)
        {
            return Tuple.Of(ReadSByte(count), ReadSByte(count), ReadSByte(count), ReadSByte(count));
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
        /// Заполняет 4 массива значениями типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<float[], float[], float[], float[]> ReadSingleTuple4(int count)
        {
            return Tuple.Of(ReadSingle(count), ReadSingle(count), ReadSingle(count), ReadSingle(count));
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
        /// Заполняет 4 массива значениями типа Uint32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint[], uint[], uint[], uint[]> ReadUint32Tuple4(int count)
        {
            return Tuple.Of(ReadUint32(count), ReadUint32(count), ReadUint32(count), ReadUint32(count));
        }
        /// <summary>
        /// Заполняет 4 массива значениями типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<long[], long[], long[], long[]> ReadInt64Tuple4(int count)
        {
            return Tuple.Of(ReadInt64(count), ReadInt64(count), ReadInt64(count), ReadInt64(count));
        }
        /// <summary>
        /// Заполняет 4 массива значениями типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong[], ulong[], ulong[], ulong[]> ReadUInt64Tuple4(int count)
        {
            return Tuple.Of(ReadUInt64(count), ReadUInt64(count), ReadUInt64(count), ReadUInt64(count));
        }
        /// <summary>
        /// Заполняет 4 массива значениями типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<short[], short[], short[], short[]> ReadInt16Tuple4(int count)
        {
            return Tuple.Of(ReadInt16(count), ReadInt16(count), ReadInt16(count), ReadInt16(count));
        }
        /// <summary>
        /// Заполняет 4 массива значениями типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort[], ushort[], ushort[], ushort[]> ReadUInt16Tuple4(int count)
        {
            return Tuple.Of(ReadUInt16(count), ReadUInt16(count), ReadUInt16(count), ReadUInt16(count));
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

        #endregion

        #region ReadTuple5

        /// <summary>
        /// Заполняет 5 массивов значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool[], bool[], bool[], bool[], bool[]> ReadBooleanTuple5(int count)
        {
            return Tuple.Of(ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count));
        }
        /// <summary>
        /// Заполняет 5 массивов значениями типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte[], byte[], byte[], byte[], byte[]> ReadByteTuple5(int count)
        {
            return Tuple.Of(ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count));
        }
        /// <summary>
        /// Заполняет 5 массивов значениями типа SByte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte[], sbyte[], sbyte[], sbyte[], sbyte[]> ReadSByteTuple5(int count)
        {
            return Tuple.Of(ReadSByte(count), ReadSByte(count), ReadSByte(count), ReadSByte(count), ReadSByte(count));
        }
        /// <summary>
        /// Заполняет 5 массивов значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<char[], char[], char[], char[], char[]> ReadCharTuple5(int count)
        {
            return Tuple.Of(ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count));
        }
        /// <summary>
        /// Заполняет 5 массивов значениями типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal[], decimal[], decimal[], decimal[], decimal[]> ReadDecimalTuple5(int count)
        {
            return Tuple.Of(ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count));
        }
        /// <summary>
        /// Заполняет 5 массивов значениями типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double[], double[], double[], double[], double[]> ReadDoubleTuple5(int count)
        {
            return Tuple.Of(ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count));
        }
        /// <summary>
        /// Заполняет 5 массивов значениями типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<float[], float[], float[], float[], float[]> ReadSingleTuple5(int count)
        {
            return Tuple.Of(ReadSingle(count), ReadSingle(count), ReadSingle(count), ReadSingle(count), ReadSingle(count));
        }
        /// <summary>
        /// Заполняет 5 массивов значениями типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[], int[], int[], int[], int[]> ReadInt32Tuple5(int count)
        {
            return Tuple.Of(ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count));
        }
        /// <summary>
        /// Заполняет 5 массивов значениями типа Uint32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint[], uint[], uint[], uint[], uint[]> ReadUint32Tuple5(int count)
        {
            return Tuple.Of(ReadUint32(count), ReadUint32(count), ReadUint32(count), ReadUint32(count), ReadUint32(count));
        }
        /// <summary>
        /// Заполняет 5 массивов значениями типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<long[], long[], long[], long[], long[]> ReadInt64Tuple5(int count)
        {
            return Tuple.Of(ReadInt64(count), ReadInt64(count), ReadInt64(count), ReadInt64(count), ReadInt64(count));
        }
        /// <summary>
        /// Заполняет 5 массивов значениями типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong[], ulong[], ulong[], ulong[], ulong[]> ReadUInt64Tuple5(int count)
        {
            return Tuple.Of(ReadUInt64(count), ReadUInt64(count), ReadUInt64(count), ReadUInt64(count), ReadUInt64(count));
        }
        /// <summary>
        /// Заполняет 5 массивов значениями типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<short[], short[], short[], short[], short[]> ReadInt16Tuple5(int count)
        {
            return Tuple.Of(ReadInt16(count), ReadInt16(count), ReadInt16(count), ReadInt16(count), ReadInt16(count));
        }
        /// <summary>
        /// Заполняет 5 массивов значениями типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort[], ushort[], ushort[], ushort[], ushort[]> ReadUInt16Tuple5(int count)
        {
            return Tuple.Of(ReadUInt16(count), ReadUInt16(count), ReadUInt16(count), ReadUInt16(count), ReadUInt16(count));
        }
        /// <summary>
        /// Заполняет 5 массивов значениями типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger[], BigInteger[], BigInteger[], BigInteger[], BigInteger[]> ReadBigIntegerTuple5(int count)
        {
            return Tuple.Of(ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count));
        }
        /// <summary>
        /// Заполняет 5 массивов значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<string[], string[], string[], string[], string[]> ReadStringTuple5(int count)
        {
            return Tuple.Of(ReadString(count), ReadString(count), ReadString(count), ReadString(count), ReadString(count));
        }

        #endregion

        #region ReadTuple6

        /// <summary>
        /// Заполняет 6 массивов значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool[], bool[], bool[], bool[], bool[], bool[]> ReadBooleanTuple6(int count)
        {
            return Tuple.Of(ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count));
        }
        /// <summary>
        /// Заполняет 6 массивов значениями типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte[], byte[], byte[], byte[], byte[], byte[]> ReadByteTuple6(int count)
        {
            return Tuple.Of(ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count));
        }
        /// <summary>
        /// Заполняет 6 массивов значениями типа SByte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte[], sbyte[], sbyte[], sbyte[], sbyte[], sbyte[]> ReadSByteTuple6(int count)
        {
            return Tuple.Of(ReadSByte(count), ReadSByte(count), ReadSByte(count), ReadSByte(count), ReadSByte(count), ReadSByte(count));
        }
        /// <summary>
        /// Заполняет 6 массивов значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<char[], char[], char[], char[], char[], char[]> ReadCharTuple6(int count)
        {
            return Tuple.Of(ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count));
        }
        /// <summary>
        /// Заполняет 6 массивов значениями типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal[], decimal[], decimal[], decimal[], decimal[], decimal[]> ReadDecimalTuple6(int count)
        {
            return Tuple.Of(ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count));
        }
        /// <summary>
        /// Заполняет 6 массивов значениями типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double[], double[], double[], double[], double[], double[]> ReadDoubleTuple6(int count)
        {
            return Tuple.Of(ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count));
        }
        /// <summary>
        /// Заполняет 6 массивов значениями типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<float[], float[], float[], float[], float[], float[]> ReadSingleTuple6(int count)
        {
            return Tuple.Of(ReadSingle(count), ReadSingle(count), ReadSingle(count), ReadSingle(count), ReadSingle(count), ReadSingle(count));
        }
        /// <summary>
        /// Заполняет 6 массивов значениями типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[], int[], int[], int[], int[], int[]> ReadInt32Tuple6(int count)
        {
            return Tuple.Of(ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count));
        }
        /// <summary>
        /// Заполняет 6 массивов значениями типа Uint32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint[], uint[], uint[], uint[], uint[], uint[]> ReadUint32Tuple6(int count)
        {
            return Tuple.Of(ReadUint32(count), ReadUint32(count), ReadUint32(count), ReadUint32(count), ReadUint32(count), ReadUint32(count));
        }
        /// <summary>
        /// Заполняет 6 массивов значениями типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<long[], long[], long[], long[], long[], long[]> ReadInt64Tuple6(int count)
        {
            return Tuple.Of(ReadInt64(count), ReadInt64(count), ReadInt64(count), ReadInt64(count), ReadInt64(count), ReadInt64(count));
        }
        /// <summary>
        /// Заполняет 6 массивов значениями типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong[], ulong[], ulong[], ulong[], ulong[], ulong[]> ReadUInt64Tuple6(int count)
        {
            return Tuple.Of(ReadUInt64(count), ReadUInt64(count), ReadUInt64(count), ReadUInt64(count), ReadUInt64(count), ReadUInt64(count));
        }
        /// <summary>
        /// Заполняет 6 массивов значениями типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<short[], short[], short[], short[], short[], short[]> ReadInt16Tuple6(int count)
        {
            return Tuple.Of(ReadInt16(count), ReadInt16(count), ReadInt16(count), ReadInt16(count), ReadInt16(count), ReadInt16(count));
        }
        /// <summary>
        /// Заполняет 6 массивов значениями типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort[], ushort[], ushort[], ushort[], ushort[], ushort[]> ReadUInt16Tuple6(int count)
        {
            return Tuple.Of(ReadUInt16(count), ReadUInt16(count), ReadUInt16(count), ReadUInt16(count), ReadUInt16(count), ReadUInt16(count));
        }
        /// <summary>
        /// Заполняет 6 массивов значениями типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger[], BigInteger[], BigInteger[], BigInteger[], BigInteger[], BigInteger[]> ReadBigIntegerTuple6(int count)
        {
            return Tuple.Of(ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count));
        }
        /// <summary>
        /// Заполняет 6 массивов значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<string[], string[], string[], string[], string[], string[]> ReadStringTuple6(int count)
        {
            return Tuple.Of(ReadString(count), ReadString(count), ReadString(count), ReadString(count), ReadString(count), ReadString(count));
        }

        #endregion

        #region ReadTuple7

        /// <summary>
        /// Заполняет 7 массивов значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool[], bool[], bool[], bool[], bool[], bool[], bool[]> ReadBooleanTuple7(int count)
        {
            return Tuple.Of(ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), Readbool(count), ReadBoolean(count));
        }
        /// <summary>
        /// Заполняет 7 массивов значениями типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte[], byte[], byte[], byte[], byte[], byte[], byte[]> ReadByteTuple7(int count)
        {
            return Tuple.Of(ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count), Readbyte(count), ReadByte(count));
        }
        /// <summary>
        /// Заполняет 7 массивов значениями типа SByte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte[], sbyte[], sbyte[], sbyte[], sbyte[], sbyte[], sbyte[]> ReadSByteTuple7(int count)
        {
            return Tuple.Of(ReadSByte(count), ReadSByte(count), ReadSByte(count), ReadSByte(count), ReadSByte(count), Readsbyte(count), ReadSByte(count));
        }
        /// <summary>
        /// Заполняет 7 массивов значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<char[], char[], char[], char[], char[], char[], char[]> ReadCharTuple7(int count)
        {
            return Tuple.Of(ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), Readchar(count), ReadChar(count));
        }
        /// <summary>
        /// Заполняет 7 массивов значениями типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal[], decimal[], decimal[], decimal[], decimal[], decimal[], decimal[]> ReadDecimalTuple7(int count)
        {
            return Tuple.Of(ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), Readdecimal(count), ReadDecimal(count));
        }
        /// <summary>
        /// Заполняет 7 массивов значениями типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double[], double[], double[], double[], double[], double[], double[]> ReadDoubleTuple7(int count)
        {
            return Tuple.Of(ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), Readdouble(count), ReadDouble(count));
        }
        /// <summary>
        /// Заполняет 7 массивов значениями типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<float[], float[], float[], float[], float[], float[], float[]> ReadSingleTuple7(int count)
        {
            return Tuple.Of(ReadSingle(count), ReadSingle(count), ReadSingle(count), ReadSingle(count), ReadSingle(count), Readfloat(count), ReadSingle(count));
        }
        /// <summary>
        /// Заполняет 7 массивов значениями типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[], int[], int[], int[], int[], int[], int[]> ReadInt32Tuple7(int count)
        {
            return Tuple.Of(ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), Readint(count), ReadInt32(count));
        }
        /// <summary>
        /// Заполняет 7 массивов значениями типа Uint32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint[], uint[], uint[], uint[], uint[], uint[], uint[]> ReadUint32Tuple7(int count)
        {
            return Tuple.Of(ReadUint32(count), ReadUint32(count), ReadUint32(count), ReadUint32(count), ReadUint32(count), Readuint(count), ReadUint32(count));
        }
        /// <summary>
        /// Заполняет 7 массивов значениями типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<long[], long[], long[], long[], long[], long[], long[]> ReadInt64Tuple7(int count)
        {
            return Tuple.Of(ReadInt64(count), ReadInt64(count), ReadInt64(count), ReadInt64(count), ReadInt64(count), Readlong(count), ReadInt64(count));
        }
        /// <summary>
        /// Заполняет 7 массивов значениями типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong[], ulong[], ulong[], ulong[], ulong[], ulong[], ulong[]> ReadUInt64Tuple7(int count)
        {
            return Tuple.Of(ReadUInt64(count), ReadUInt64(count), ReadUInt64(count), ReadUInt64(count), ReadUInt64(count), Readulong(count), ReadUInt64(count));
        }
        /// <summary>
        /// Заполняет 7 массивов значениями типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<short[], short[], short[], short[], short[], short[], short[]> ReadInt16Tuple7(int count)
        {
            return Tuple.Of(ReadInt16(count), ReadInt16(count), ReadInt16(count), ReadInt16(count), ReadInt16(count), Readshort(count), ReadInt16(count));
        }
        /// <summary>
        /// Заполняет 7 массивов значениями типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort[], ushort[], ushort[], ushort[], ushort[], ushort[], ushort[]> ReadUInt16Tuple7(int count)
        {
            return Tuple.Of(ReadUInt16(count), ReadUInt16(count), ReadUInt16(count), ReadUInt16(count), ReadUInt16(count), Readushort(count), ReadUInt16(count));
        }
        /// <summary>
        /// Заполняет 7 массивов значениями типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger[], BigInteger[], BigInteger[], BigInteger[], BigInteger[], BigInteger[], BigInteger[]> ReadBigIntegerTuple7(int count)
        {
            return Tuple.Of(ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count));
        }
        /// <summary>
        /// Заполняет 7 массивов значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<string[], string[], string[], string[], string[], string[], string[]> ReadStringTuple7(int count)
        {
            return Tuple.Of(ReadString(count), ReadString(count), ReadString(count), ReadString(count), ReadString(count), Readstring(count), ReadString(count));
        }

        #endregion

        #endregion public
    }
}
