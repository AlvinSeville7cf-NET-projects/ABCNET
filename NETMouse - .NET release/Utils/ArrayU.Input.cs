using System;
using System.Numerics;

namespace ABCNET.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы с массивами.
    /// </summary>
    public static partial class ArrayU
    {

        #region public
        
        #region Read1

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
            
            prompt = prompt ?? EmptyStringHelper.Empty;

            bool[] array = new bool[count];
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadBoolean(string.Format(prompt, i));

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
            
            prompt = prompt ?? EmptyStringHelper.Empty;

            byte[] array = new byte[count];
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadByte(string.Format(prompt, i));

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
            
            prompt = prompt ?? EmptyStringHelper.Empty;

            sbyte[] array = new sbyte[count];
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadSByte(string.Format(prompt, i));

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
            
            prompt = prompt ?? EmptyStringHelper.Empty;

            char[] array = new char[count];
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadChar(string.Format(prompt, i));

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
            
            prompt = prompt ?? EmptyStringHelper.Empty;

            decimal[] array = new decimal[count];
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadDecimal(string.Format(prompt, i));

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
            
            prompt = prompt ?? EmptyStringHelper.Empty;

            double[] array = new double[count];
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadDouble(string.Format(prompt, i));

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
            
            prompt = prompt ?? EmptyStringHelper.Empty;

            float[] array = new float[count];
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadSingle(string.Format(prompt, i));

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
            
            prompt = prompt ?? EmptyStringHelper.Empty;

            int[] array = new int[count];
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadInt32(string.Format(prompt, i));

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
            
            prompt = prompt ?? EmptyStringHelper.Empty;

            uint[] array = new uint[count];
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadUInt32(string.Format(prompt, i));

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
            
            prompt = prompt ?? EmptyStringHelper.Empty;

            long[] array = new long[count];
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadInt64(string.Format(prompt, i));

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
            
            prompt = prompt ?? EmptyStringHelper.Empty;

            ulong[] array = new ulong[count];
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadUInt64(string.Format(prompt, i));

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
            
            prompt = prompt ?? EmptyStringHelper.Empty;

            short[] array = new short[count];
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadInt16(string.Format(prompt, i));

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
            
            prompt = prompt ?? EmptyStringHelper.Empty;

            ushort[] array = new ushort[count];
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadUInt16(string.Format(prompt, i));

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
            
            prompt = prompt ?? EmptyStringHelper.Empty;

            string[] array = new string[count];
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadString(string.Format(prompt, i));

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
            
            prompt = prompt ?? EmptyStringHelper.Empty;

            BigInteger[] array = new BigInteger[count];
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadBigInteger(string.Format(prompt, i));

            return array;
        }
        
        #endregion
        
        #region Read2

        /// <summary>
        /// Читает 2 массива значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool[], bool[]> ReadBooleanTuple2(int count)
        {
            return Tuple.Of(ReadBoolean(count), ReadBoolean(count));
        }

        
        /// <summary>
        /// Читает 2 массива значениями типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte[], byte[]> ReadByteTuple2(int count)
        {
            return Tuple.Of(ReadByte(count), ReadByte(count));
        }

        
        /// <summary>
        /// Читает 2 массива значениями типа SByte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte[], sbyte[]> ReadSByteTuple2(int count)
        {
            return Tuple.Of(ReadSByte(count), ReadSByte(count));
        }

        
        /// <summary>
        /// Читает 2 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<char[], char[]> ReadCharTuple2(int count)
        {
            return Tuple.Of(ReadChar(count), ReadChar(count));
        }

        
        /// <summary>
        /// Читает 2 массива значениями типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal[], decimal[]> ReadDecimalTuple2(int count)
        {
            return Tuple.Of(ReadDecimal(count), ReadDecimal(count));
        }

        
        /// <summary>
        /// Читает 2 массива значениями типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double[], double[]> ReadDoubleTuple2(int count)
        {
            return Tuple.Of(ReadDouble(count), ReadDouble(count));
        }

        
        /// <summary>
        /// Читает 2 массива значениями типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<float[], float[]> ReadSingleTuple2(int count)
        {
            return Tuple.Of(ReadSingle(count), ReadSingle(count));
        }

        
        /// <summary>
        /// Читает 2 массива значениями типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[], int[]> ReadInt32Tuple2(int count)
        {
            return Tuple.Of(ReadInt32(count), ReadInt32(count));
        }

        
        /// <summary>
        /// Читает 2 массива значениями типа UInt32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint[], uint[]> ReadUInt32Tuple2(int count)
        {
            return Tuple.Of(ReadUInt32(count), ReadUInt32(count));
        }

        
        /// <summary>
        /// Читает 2 массива значениями типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<long[], long[]> ReadInt64Tuple2(int count)
        {
            return Tuple.Of(ReadInt64(count), ReadInt64(count));
        }

        
        /// <summary>
        /// Читает 2 массива значениями типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong[], ulong[]> ReadUInt64Tuple2(int count)
        {
            return Tuple.Of(ReadUInt64(count), ReadUInt64(count));
        }

        
        /// <summary>
        /// Читает 2 массива значениями типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<short[], short[]> ReadInt16Tuple2(int count)
        {
            return Tuple.Of(ReadInt16(count), ReadInt16(count));
        }

        
        /// <summary>
        /// Читает 2 массива значениями типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort[], ushort[]> ReadUInt16Tuple2(int count)
        {
            return Tuple.Of(ReadUInt16(count), ReadUInt16(count));
        }

        
        /// <summary>
        /// Читает 2 массива значениями типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger[], BigInteger[]> ReadBigIntegerTuple2(int count)
        {
            return Tuple.Of(ReadBigInteger(count), ReadBigInteger(count));
        }

        
        /// <summary>
        /// Читает 2 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<string[], string[]> ReadStringTuple2(int count)
        {
            return Tuple.Of(ReadString(count), ReadString(count));
        }

        #endregion
        
        #region Read3
        
        /// <summary>
        /// Читает 3 массива значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool[], bool[], bool[]> ReadBooleanTuple3(int count)
        {
            return Tuple.Of(ReadBoolean(count), ReadBoolean(count), ReadBoolean(count));
        }

        
        /// <summary>
        /// Читает 3 массива значениями типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte[], byte[], byte[]> ReadByteTuple3(int count)
        {
            return Tuple.Of(ReadByte(count), ReadByte(count), ReadByte(count));
        }

        
        /// <summary>
        /// Читает 3 массива значениями типа SByte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte[], sbyte[], sbyte[]> ReadSByteTuple3(int count)
        {
            return Tuple.Of(ReadSByte(count), ReadSByte(count), ReadSByte(count));
        }

        
        /// <summary>
        /// Читает 3 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<char[], char[], char[]> ReadCharTuple3(int count)
        {
            return Tuple.Of(ReadChar(count), ReadChar(count), ReadChar(count));
        }

        
        /// <summary>
        /// Читает 3 массива значениями типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal[], decimal[], decimal[]> ReadDecimalTuple3(int count)
        {
            return Tuple.Of(ReadDecimal(count), ReadDecimal(count), ReadDecimal(count));
        }

        
        /// <summary>
        /// Читает 3 массива значениями типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double[], double[], double[]> ReadDoubleTuple3(int count)
        {
            return Tuple.Of(ReadDouble(count), ReadDouble(count), ReadDouble(count));
        }

        
        /// <summary>
        /// Читает 3 массива значениями типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<float[], float[], float[]> ReadSingleTuple3(int count)
        {
            return Tuple.Of(ReadSingle(count), ReadSingle(count), ReadSingle(count));
        }

        
        /// <summary>
        /// Читает 3 массива значениями типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[], int[], int[]> ReadInt32Tuple3(int count)
        {
            return Tuple.Of(ReadInt32(count), ReadInt32(count), ReadInt32(count));
        }

        
        /// <summary>
        /// Читает 3 массива значениями типа UInt32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint[], uint[], uint[]> ReadUInt32Tuple3(int count)
        {
            return Tuple.Of(ReadUInt32(count), ReadUInt32(count), ReadUInt32(count));
        }

        
        /// <summary>
        /// Читает 3 массива значениями типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<long[], long[], long[]> ReadInt64Tuple3(int count)
        {
            return Tuple.Of(ReadInt64(count), ReadInt64(count), ReadInt64(count));
        }

        
        /// <summary>
        /// Читает 3 массива значениями типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong[], ulong[], ulong[]> ReadUInt64Tuple3(int count)
        {
            return Tuple.Of(ReadUInt64(count), ReadUInt64(count), ReadUInt64(count));
        }

        
        /// <summary>
        /// Читает 3 массива значениями типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<short[], short[], short[]> ReadInt16Tuple3(int count)
        {
            return Tuple.Of(ReadInt16(count), ReadInt16(count), ReadInt16(count));
        }

        
        /// <summary>
        /// Читает 3 массива значениями типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort[], ushort[], ushort[]> ReadUInt16Tuple3(int count)
        {
            return Tuple.Of(ReadUInt16(count), ReadUInt16(count), ReadUInt16(count));
        }

        
        /// <summary>
        /// Читает 3 массива значениями типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger[], BigInteger[], BigInteger[]> ReadBigIntegerTuple3(int count)
        {
            return Tuple.Of(ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count));
        }

        
        /// <summary>
        /// Читает 3 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<string[], string[], string[]> ReadStringTuple3(int count)
        {
            return Tuple.Of(ReadString(count), ReadString(count), ReadString(count));
        }
        
        #endregion
        
        #region Read4
        
        /// <summary>
        /// Читает 4 массива значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool[], bool[], bool[], bool[]> ReadBooleanTuple4(int count)
        {
            return Tuple.Of(ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count));
        }

        
        /// <summary>
        /// Читает 4 массива значениями типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte[], byte[], byte[], byte[]> ReadByteTuple4(int count)
        {
            return Tuple.Of(ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count));
        }

        
        /// <summary>
        /// Читает 4 массива значениями типа SByte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte[], sbyte[], sbyte[], sbyte[]> ReadSByteTuple4(int count)
        {
            return Tuple.Of(ReadSByte(count), ReadSByte(count), ReadSByte(count), ReadSByte(count));
        }

        
        /// <summary>
        /// Читает 4 массива значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<char[], char[], char[], char[]> ReadCharTuple4(int count)
        {
            return Tuple.Of(ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count));
        }

        
        /// <summary>
        /// Читает 4 массива значениями типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal[], decimal[], decimal[], decimal[]> ReadDecimalTuple4(int count)
        {
            return Tuple.Of(ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count));
        }

        
        /// <summary>
        /// Читает 4 массива значениями типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double[], double[], double[], double[]> ReadDoubleTuple4(int count)
        {
            return Tuple.Of(ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count));
        }

        
        /// <summary>
        /// Читает 4 массива значениями типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<float[], float[], float[], float[]> ReadSingleTuple4(int count)
        {
            return Tuple.Of(ReadSingle(count), ReadSingle(count), ReadSingle(count), ReadSingle(count));
        }

        
        /// <summary>
        /// Читает 4 массива значениями типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[], int[], int[], int[]> ReadInt32Tuple4(int count)
        {
            return Tuple.Of(ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count));
        }

        
        /// <summary>
        /// Читает 4 массива значениями типа UInt32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint[], uint[], uint[], uint[]> ReadUInt32Tuple4(int count)
        {
            return Tuple.Of(ReadUInt32(count), ReadUInt32(count), ReadUInt32(count), ReadUInt32(count));
        }

        
        /// <summary>
        /// Читает 4 массива значениями типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<long[], long[], long[], long[]> ReadInt64Tuple4(int count)
        {
            return Tuple.Of(ReadInt64(count), ReadInt64(count), ReadInt64(count), ReadInt64(count));
        }

        
        /// <summary>
        /// Читает 4 массива значениями типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong[], ulong[], ulong[], ulong[]> ReadUInt64Tuple4(int count)
        {
            return Tuple.Of(ReadUInt64(count), ReadUInt64(count), ReadUInt64(count), ReadUInt64(count));
        }

        
        /// <summary>
        /// Читает 4 массива значениями типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<short[], short[], short[], short[]> ReadInt16Tuple4(int count)
        {
            return Tuple.Of(ReadInt16(count), ReadInt16(count), ReadInt16(count), ReadInt16(count));
        }

        
        /// <summary>
        /// Читает 4 массива значениями типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort[], ushort[], ushort[], ushort[]> ReadUInt16Tuple4(int count)
        {
            return Tuple.Of(ReadUInt16(count), ReadUInt16(count), ReadUInt16(count), ReadUInt16(count));
        }

        
        /// <summary>
        /// Читает 4 массива значениями типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger[], BigInteger[], BigInteger[], BigInteger[]> ReadBigIntegerTuple4(int count)
        {
            return Tuple.Of(ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count));
        }

        
        /// <summary>
        /// Читает 4 массива значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<string[], string[], string[], string[]> ReadStringTuple4(int count)
        {
            return Tuple.Of(ReadString(count), ReadString(count), ReadString(count), ReadString(count));
        }
        
        #endregion
        
        #region Read5
        
        /// <summary>
        /// Читает 5 массивов значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool[], bool[], bool[], bool[], bool[]> ReadBooleanTuple5(int count)
        {
            return Tuple.Of(ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count));
        }

        
        /// <summary>
        /// Читает 5 массивов значениями типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte[], byte[], byte[], byte[], byte[]> ReadByteTuple5(int count)
        {
            return Tuple.Of(ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count));
        }

        
        /// <summary>
        /// Читает 5 массивов значениями типа SByte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte[], sbyte[], sbyte[], sbyte[], sbyte[]> ReadSByteTuple5(int count)
        {
            return Tuple.Of(ReadSByte(count), ReadSByte(count), ReadSByte(count), ReadSByte(count), ReadSByte(count));
        }

        
        /// <summary>
        /// Читает 5 массивов значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<char[], char[], char[], char[], char[]> ReadCharTuple5(int count)
        {
            return Tuple.Of(ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count));
        }

        
        /// <summary>
        /// Читает 5 массивов значениями типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal[], decimal[], decimal[], decimal[], decimal[]> ReadDecimalTuple5(int count)
        {
            return Tuple.Of(ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count));
        }

        
        /// <summary>
        /// Читает 5 массивов значениями типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double[], double[], double[], double[], double[]> ReadDoubleTuple5(int count)
        {
            return Tuple.Of(ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count));
        }

        
        /// <summary>
        /// Читает 5 массивов значениями типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<float[], float[], float[], float[], float[]> ReadSingleTuple5(int count)
        {
            return Tuple.Of(ReadSingle(count), ReadSingle(count), ReadSingle(count), ReadSingle(count), ReadSingle(count));
        }

        
        /// <summary>
        /// Читает 5 массивов значениями типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[], int[], int[], int[], int[]> ReadInt32Tuple5(int count)
        {
            return Tuple.Of(ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count));
        }

        
        /// <summary>
        /// Читает 5 массивов значениями типа UInt32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint[], uint[], uint[], uint[], uint[]> ReadUInt32Tuple5(int count)
        {
            return Tuple.Of(ReadUInt32(count), ReadUInt32(count), ReadUInt32(count), ReadUInt32(count), ReadUInt32(count));
        }

        
        /// <summary>
        /// Читает 5 массивов значениями типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<long[], long[], long[], long[], long[]> ReadInt64Tuple5(int count)
        {
            return Tuple.Of(ReadInt64(count), ReadInt64(count), ReadInt64(count), ReadInt64(count), ReadInt64(count));
        }

        
        /// <summary>
        /// Читает 5 массивов значениями типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong[], ulong[], ulong[], ulong[], ulong[]> ReadUInt64Tuple5(int count)
        {
            return Tuple.Of(ReadUInt64(count), ReadUInt64(count), ReadUInt64(count), ReadUInt64(count), ReadUInt64(count));
        }

        
        /// <summary>
        /// Читает 5 массивов значениями типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<short[], short[], short[], short[], short[]> ReadInt16Tuple5(int count)
        {
            return Tuple.Of(ReadInt16(count), ReadInt16(count), ReadInt16(count), ReadInt16(count), ReadInt16(count));
        }

        
        /// <summary>
        /// Читает 5 массивов значениями типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort[], ushort[], ushort[], ushort[], ushort[]> ReadUInt16Tuple5(int count)
        {
            return Tuple.Of(ReadUInt16(count), ReadUInt16(count), ReadUInt16(count), ReadUInt16(count), ReadUInt16(count));
        }

        
        /// <summary>
        /// Читает 5 массивов значениями типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger[], BigInteger[], BigInteger[], BigInteger[], BigInteger[]> ReadBigIntegerTuple5(int count)
        {
            return Tuple.Of(ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count));
        }

        
        /// <summary>
        /// Читает 5 массивов значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<string[], string[], string[], string[], string[]> ReadStringTuple5(int count)
        {
            return Tuple.Of(ReadString(count), ReadString(count), ReadString(count), ReadString(count), ReadString(count));
        }
        
        #endregion
        
        #region Read6
        
        /// <summary>
        /// Читает 6 массивов значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool[], bool[], bool[], bool[], bool[], bool[]> ReadBooleanTuple6(int count)
        {
            return Tuple.Of(ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count));
        }

        
        /// <summary>
        /// Читает 6 массивов значениями типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte[], byte[], byte[], byte[], byte[], byte[]> ReadByteTuple6(int count)
        {
            return Tuple.Of(ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count));
        }

        
        /// <summary>
        /// Читает 6 массивов значениями типа SByte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte[], sbyte[], sbyte[], sbyte[], sbyte[], sbyte[]> ReadSByteTuple6(int count)
        {
            return Tuple.Of(ReadSByte(count), ReadSByte(count), ReadSByte(count), ReadSByte(count), ReadSByte(count), ReadSByte(count));
        }

        
        /// <summary>
        /// Читает 6 массивов значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<char[], char[], char[], char[], char[], char[]> ReadCharTuple6(int count)
        {
            return Tuple.Of(ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count));
        }

        
        /// <summary>
        /// Читает 6 массивов значениями типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal[], decimal[], decimal[], decimal[], decimal[], decimal[]> ReadDecimalTuple6(int count)
        {
            return Tuple.Of(ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count));
        }

        
        /// <summary>
        /// Читает 6 массивов значениями типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double[], double[], double[], double[], double[], double[]> ReadDoubleTuple6(int count)
        {
            return Tuple.Of(ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count));
        }

        
        /// <summary>
        /// Читает 6 массивов значениями типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<float[], float[], float[], float[], float[], float[]> ReadSingleTuple6(int count)
        {
            return Tuple.Of(ReadSingle(count), ReadSingle(count), ReadSingle(count), ReadSingle(count), ReadSingle(count), ReadSingle(count));
        }

        
        /// <summary>
        /// Читает 6 массивов значениями типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[], int[], int[], int[], int[], int[]> ReadInt32Tuple6(int count)
        {
            return Tuple.Of(ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count));
        }

        
        /// <summary>
        /// Читает 6 массивов значениями типа UInt32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint[], uint[], uint[], uint[], uint[], uint[]> ReadUInt32Tuple6(int count)
        {
            return Tuple.Of(ReadUInt32(count), ReadUInt32(count), ReadUInt32(count), ReadUInt32(count), ReadUInt32(count), ReadUInt32(count));
        }

        
        /// <summary>
        /// Читает 6 массивов значениями типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<long[], long[], long[], long[], long[], long[]> ReadInt64Tuple6(int count)
        {
            return Tuple.Of(ReadInt64(count), ReadInt64(count), ReadInt64(count), ReadInt64(count), ReadInt64(count), ReadInt64(count));
        }

        
        /// <summary>
        /// Читает 6 массивов значениями типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong[], ulong[], ulong[], ulong[], ulong[], ulong[]> ReadUInt64Tuple6(int count)
        {
            return Tuple.Of(ReadUInt64(count), ReadUInt64(count), ReadUInt64(count), ReadUInt64(count), ReadUInt64(count), ReadUInt64(count));
        }

        
        /// <summary>
        /// Читает 6 массивов значениями типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<short[], short[], short[], short[], short[], short[]> ReadInt16Tuple6(int count)
        {
            return Tuple.Of(ReadInt16(count), ReadInt16(count), ReadInt16(count), ReadInt16(count), ReadInt16(count), ReadInt16(count));
        }

        
        /// <summary>
        /// Читает 6 массивов значениями типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort[], ushort[], ushort[], ushort[], ushort[], ushort[]> ReadUInt16Tuple6(int count)
        {
            return Tuple.Of(ReadUInt16(count), ReadUInt16(count), ReadUInt16(count), ReadUInt16(count), ReadUInt16(count), ReadUInt16(count));
        }

        
        /// <summary>
        /// Читает 6 массивов значениями типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger[], BigInteger[], BigInteger[], BigInteger[], BigInteger[], BigInteger[]> ReadBigIntegerTuple6(int count)
        {
            return Tuple.Of(ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count));
        }

        
        /// <summary>
        /// Читает 6 массивов значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<string[], string[], string[], string[], string[], string[]> ReadStringTuple6(int count)
        {
            return Tuple.Of(ReadString(count), ReadString(count), ReadString(count), ReadString(count), ReadString(count), ReadString(count));
        }
        
        #endregion
        
        #region Read7
        
        /// <summary>
        /// Читает 7 массивов значениями типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool[], bool[], bool[], bool[], bool[], bool[], bool[]> ReadBooleanTuple7(int count)
        {
            return Tuple.Of(ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count));
        }

        
        /// <summary>
        /// Читает 7 массивов значениями типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte[], byte[], byte[], byte[], byte[], byte[], byte[]> ReadByteTuple7(int count)
        {
            return Tuple.Of(ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count));
        }

        
        /// <summary>
        /// Читает 7 массивов значениями типа SByte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte[], sbyte[], sbyte[], sbyte[], sbyte[], sbyte[], sbyte[]> ReadSByteTuple7(int count)
        {
            return Tuple.Of(ReadSByte(count), ReadSByte(count), ReadSByte(count), ReadSByte(count), ReadSByte(count), ReadSByte(count), ReadSByte(count));
        }

        
        /// <summary>
        /// Читает 7 массивов значениями типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<char[], char[], char[], char[], char[], char[], char[]> ReadCharTuple7(int count)
        {
            return Tuple.Of(ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count));
        }

        
        /// <summary>
        /// Читает 7 массивов значениями типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal[], decimal[], decimal[], decimal[], decimal[], decimal[], decimal[]> ReadDecimalTuple7(int count)
        {
            return Tuple.Of(ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count));
        }

        
        /// <summary>
        /// Читает 7 массивов значениями типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double[], double[], double[], double[], double[], double[], double[]> ReadDoubleTuple7(int count)
        {
            return Tuple.Of(ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count));
        }

        
        /// <summary>
        /// Читает 7 массивов значениями типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<float[], float[], float[], float[], float[], float[], float[]> ReadSingleTuple7(int count)
        {
            return Tuple.Of(ReadSingle(count), ReadSingle(count), ReadSingle(count), ReadSingle(count), ReadSingle(count), ReadSingle(count), ReadSingle(count));
        }

        
        /// <summary>
        /// Читает 7 массивов значениями типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[], int[], int[], int[], int[], int[], int[]> ReadInt32Tuple7(int count)
        {
            return Tuple.Of(ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count));
        }

        
        /// <summary>
        /// Читает 7 массивов значениями типа UInt32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint[], uint[], uint[], uint[], uint[], uint[], uint[]> ReadUInt32Tuple7(int count)
        {
            return Tuple.Of(ReadUInt32(count), ReadUInt32(count), ReadUInt32(count), ReadUInt32(count), ReadUInt32(count), ReadUInt32(count), ReadUInt32(count));
        }

        
        /// <summary>
        /// Читает 7 массивов значениями типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<long[], long[], long[], long[], long[], long[], long[]> ReadInt64Tuple7(int count)
        {
            return Tuple.Of(ReadInt64(count), ReadInt64(count), ReadInt64(count), ReadInt64(count), ReadInt64(count), ReadInt64(count), ReadInt64(count));
        }

        
        /// <summary>
        /// Читает 7 массивов значениями типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong[], ulong[], ulong[], ulong[], ulong[], ulong[], ulong[]> ReadUInt64Tuple7(int count)
        {
            return Tuple.Of(ReadUInt64(count), ReadUInt64(count), ReadUInt64(count), ReadUInt64(count), ReadUInt64(count), ReadUInt64(count), ReadUInt64(count));
        }

        
        /// <summary>
        /// Читает 7 массивов значениями типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<short[], short[], short[], short[], short[], short[], short[]> ReadInt16Tuple7(int count)
        {
            return Tuple.Of(ReadInt16(count), ReadInt16(count), ReadInt16(count), ReadInt16(count), ReadInt16(count), ReadInt16(count), ReadInt16(count));
        }

        
        /// <summary>
        /// Читает 7 массивов значениями типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort[], ushort[], ushort[], ushort[], ushort[], ushort[], ushort[]> ReadUInt16Tuple7(int count)
        {
            return Tuple.Of(ReadUInt16(count), ReadUInt16(count), ReadUInt16(count), ReadUInt16(count), ReadUInt16(count), ReadUInt16(count), ReadUInt16(count));
        }

        
        /// <summary>
        /// Читает 7 массивов значениями типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger[], BigInteger[], BigInteger[], BigInteger[], BigInteger[], BigInteger[], BigInteger[]> ReadBigIntegerTuple7(int count)
        {
            return Tuple.Of(ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count));
        }

        
        /// <summary>
        /// Читает 7 массивов значениями типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">Размер массива.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<string[], string[], string[], string[], string[], string[], string[]> ReadStringTuple7(int count)
        {
            return Tuple.Of(ReadString(count), ReadString(count), ReadString(count), ReadString(count), ReadString(count), ReadString(count), ReadString(count));
        }
        
        #endregion

        #endregion public
    
    }
}
