using System;
using System.Numerics;

namespace ABCNET.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы с массивами.
    /// </summary>
    public static partial class Array
    {
        /// <summary>
        /// Предоставляет функционал для работы с Nullable типами.
        /// </summary>
        public static partial class Nullable
        {
            #region public

            #region one-array

            /// <summary>
            /// Читает массив значений типа Boolean?.
            /// </summary>
            /// <param name="count">Количество элементов.</param>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Массив.</returns>
            public static bool?[] ReadBoolean(int count, string prompt = EmptyStringHelper.Empty)
            {
                if (count < 0)
                    throw new ArgumentOutOfRangeException(nameof(count));

                prompt = prompt ?? EmptyStringHelper.Empty;

                bool?[] array = new bool?[count];
                for (int i = 0; i < count; i++)
                    array[i] = Base.Nullable.ReadBoolean(string.Format(prompt, i));

                return array;
            }

            /// <summary>
            /// Читает массив значений типа Byte?.
            /// </summary>
            /// <param name="count">Количество элементов.</param>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Массив.</returns>
            public static byte?[] ReadByte(int count, string prompt = EmptyStringHelper.Empty)
            {
                if (count < 0)
                    throw new ArgumentOutOfRangeException(nameof(count));

                prompt = prompt ?? EmptyStringHelper.Empty;

                byte?[] array = new byte?[count];
                for (int i = 0; i < count; i++)
                    array[i] = Base.Nullable.ReadByte(string.Format(prompt, i));

                return array;
            }

            /// <summary>
            /// Читает массив значений типа SByte?.
            /// </summary>
            /// <param name="count">Количество элементов.</param>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Массив.</returns>
            public static sbyte?[] ReadSByte(int count, string prompt = EmptyStringHelper.Empty)
            {
                if (count < 0)
                    throw new ArgumentOutOfRangeException(nameof(count));

                prompt = prompt ?? EmptyStringHelper.Empty;

                sbyte?[] array = new sbyte?[count];
                for (int i = 0; i < count; i++)
                    array[i] = Base.Nullable.ReadSByte(string.Format(prompt, i));

                return array;
            }

            /// <summary>
            /// Читает массив значений типа Char?.
            /// </summary>
            /// <param name="count">Количество элементов.</param>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Массив.</returns>
            public static char?[] ReadChar(int count, string prompt = EmptyStringHelper.Empty)
            {
                if (count < 0)
                    throw new ArgumentOutOfRangeException(nameof(count));

                prompt = prompt ?? EmptyStringHelper.Empty;

                char?[] array = new char?[count];
                for (int i = 0; i < count; i++)
                    array[i] = Base.Nullable.ReadChar(string.Format(prompt, i));

                return array;
            }

            /// <summary>
            /// Читает массив значений типа Decimal?.
            /// </summary>
            /// <param name="count">Количество элементов.</param>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Массив.</returns>
            public static decimal?[] ReadDecimal(int count, string prompt = EmptyStringHelper.Empty)
            {
                if (count < 0)
                    throw new ArgumentOutOfRangeException(nameof(count));

                prompt = prompt ?? EmptyStringHelper.Empty;

                decimal?[] array = new decimal?[count];
                for (int i = 0; i < count; i++)
                    array[i] = Base.Nullable.ReadDecimal(string.Format(prompt, i));

                return array;
            }

            /// <summary>
            /// Читает массив значений типа Double?.
            /// </summary>
            /// <param name="count">Количество элементов.</param>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Массив.</returns>
            public static double?[] ReadDouble(int count, string prompt = EmptyStringHelper.Empty)
            {
                if (count < 0)
                    throw new ArgumentOutOfRangeException(nameof(count));

                prompt = prompt ?? EmptyStringHelper.Empty;

                double?[] array = new double?[count];
                for (int i = 0; i < count; i++)
                    array[i] = Base.Nullable.ReadDouble(string.Format(prompt, i));

                return array;
            }

            /// <summary>
            /// Читает массив значений типа Single?.
            /// </summary>
            /// <param name="count">Количество элементов.</param>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Массив.</returns>
            public static float?[] ReadSingle(int count, string prompt = EmptyStringHelper.Empty)
            {
                if (count < 0)
                    throw new ArgumentOutOfRangeException(nameof(count));

                prompt = prompt ?? EmptyStringHelper.Empty;

                float?[] array = new float?[count];
                for (int i = 0; i < count; i++)
                    array[i] = Base.Nullable.ReadSingle(string.Format(prompt, i));

                return array;
            }

            /// <summary>
            /// Читает массив значений типа Int32?.
            /// </summary>
            /// <param name="count">Количество элементов.</param>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Массив.</returns>
            public static int?[] ReadInt32(int count, string prompt = EmptyStringHelper.Empty)
            {
                if (count < 0)
                    throw new ArgumentOutOfRangeException(nameof(count));

                prompt = prompt ?? EmptyStringHelper.Empty;

                int?[] array = new int?[count];
                for (int i = 0; i < count; i++)
                    array[i] = Base.Nullable.ReadInt32(string.Format(prompt, i));

                return array;
            }

            /// <summary>
            /// Читает массив значений типа UInt32?.
            /// </summary>
            /// <param name="count">Количество элементов.</param>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Массив.</returns>
            public static uint?[] ReadUInt32(int count, string prompt = EmptyStringHelper.Empty)
            {
                if (count < 0)
                    throw new ArgumentOutOfRangeException(nameof(count));

                prompt = prompt ?? EmptyStringHelper.Empty;

                uint?[] array = new uint?[count];
                for (int i = 0; i < count; i++)
                    array[i] = Base.Nullable.ReadUInt32(string.Format(prompt, i));

                return array;
            }

            /// <summary>
            /// Читает массив значений типа Int64?.
            /// </summary>
            /// <param name="count">Количество элементов.</param>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Массив.</returns>
            public static long?[] ReadInt64(int count, string prompt = EmptyStringHelper.Empty)
            {
                if (count < 0)
                    throw new ArgumentOutOfRangeException(nameof(count));

                prompt = prompt ?? EmptyStringHelper.Empty;

                long?[] array = new long?[count];
                for (int i = 0; i < count; i++)
                    array[i] = Base.Nullable.ReadInt64(string.Format(prompt, i));

                return array;
            }

            /// <summary>
            /// Читает массив значений типа UInt64?.
            /// </summary>
            /// <param name="count">Количество элементов.</param>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Массив.</returns>
            public static ulong?[] ReadUInt64(int count, string prompt = EmptyStringHelper.Empty)
            {
                if (count < 0)
                    throw new ArgumentOutOfRangeException(nameof(count));

                prompt = prompt ?? EmptyStringHelper.Empty;

                ulong?[] array = new ulong?[count];
                for (int i = 0; i < count; i++)
                    array[i] = Base.Nullable.ReadUInt64(string.Format(prompt, i));

                return array;
            }

            /// <summary>
            /// Читает массив значений типа Int16?.
            /// </summary>
            /// <param name="count">Количество элементов.</param>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Массив.</returns>
            public static short?[] ReadInt16(int count, string prompt = EmptyStringHelper.Empty)
            {
                if (count < 0)
                    throw new ArgumentOutOfRangeException(nameof(count));

                prompt = prompt ?? EmptyStringHelper.Empty;

                short?[] array = new short?[count];
                for (int i = 0; i < count; i++)
                    array[i] = Base.Nullable.ReadInt16(string.Format(prompt, i));

                return array;
            }

            /// <summary>
            /// Читает массив значений типа UInt16?.
            /// </summary>
            /// <param name="count">Количество элементов.</param>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Массив.</returns>
            public static ushort?[] ReadUInt16(int count, string prompt = EmptyStringHelper.Empty)
            {
                if (count < 0)
                    throw new ArgumentOutOfRangeException(nameof(count));

                prompt = prompt ?? EmptyStringHelper.Empty;

                ushort?[] array = new ushort?[count];
                for (int i = 0; i < count; i++)
                    array[i] = Base.Nullable.ReadUInt16(string.Format(prompt, i));

                return array;
            }

            /// <summary>
            /// Читает массив значений типа BigInteger?.
            /// </summary>
            /// <param name="count">Количество элементов.</param>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Массив.</returns>
            public static BigInteger?[] ReadBigInteger(int count, string prompt = EmptyStringHelper.Empty)
            {
                if (count < 0)
                    throw new ArgumentOutOfRangeException(nameof(count));

                prompt = prompt ?? EmptyStringHelper.Empty;

                BigInteger?[] array = new BigInteger?[count];
                for (int i = 0; i < count; i++)
                    array[i] = Base.Nullable.ReadBigInteger(string.Format(prompt, i));

                return array;
            }

            #endregion one-array

            #region two-arrays

            /// <summary>
            /// Читает 2 массива значений типа Boolean?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<bool?[], bool?[]> ReadBooleanTuple2(int count)
            {
                return Tuple.Of(ReadBoolean(count), ReadBoolean(count));
            }

            /// <summary>
            /// Читает 2 массива значений типа Byte?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<byte?[], byte?[]> ReadByteTuple2(int count)
            {
                return Tuple.Of(ReadByte(count), ReadByte(count));
            }

            /// <summary>
            /// Читает 2 массива значений типа SByte?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<sbyte?[], sbyte?[]> ReadSByteTuple2(int count)
            {
                return Tuple.Of(ReadSByte(count), ReadSByte(count));
            }

            /// <summary>
            /// Читает 2 массива значений типа Char?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<char?[], char?[]> ReadCharTuple2(int count)
            {
                return Tuple.Of(ReadChar(count), ReadChar(count));
            }

            /// <summary>
            /// Читает 2 массива значений типа Decimal?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<decimal?[], decimal?[]> ReadDecimalTuple2(int count)
            {
                return Tuple.Of(ReadDecimal(count), ReadDecimal(count));
            }

            /// <summary>
            /// Читает 2 массива значений типа Double?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<double?[], double?[]> ReadDoubleTuple2(int count)
            {
                return Tuple.Of(ReadDouble(count), ReadDouble(count));
            }

            /// <summary>
            /// Читает 2 массива значений типа Single?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<float?[], float?[]> ReadSingleTuple2(int count)
            {
                return Tuple.Of(ReadSingle(count), ReadSingle(count));
            }

            /// <summary>
            /// Читает 2 массива значений типа Int32?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<int?[], int?[]> ReadInt32Tuple2(int count)
            {
                return Tuple.Of(ReadInt32(count), ReadInt32(count));
            }

            /// <summary>
            /// Читает 2 массива значений типа UInt32?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<uint?[], uint?[]> ReadUInt32Tuple2(int count)
            {
                return Tuple.Of(ReadUInt32(count), ReadUInt32(count));
            }

            /// <summary>
            /// Читает 2 массива значений типа Int64?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<long?[], long?[]> ReadInt64Tuple2(int count)
            {
                return Tuple.Of(ReadInt64(count), ReadInt64(count));
            }

            /// <summary>
            /// Читает 2 массива значений типа UInt64?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<ulong?[], ulong?[]> ReadUInt64Tuple2(int count)
            {
                return Tuple.Of(ReadUInt64(count), ReadUInt64(count));
            }

            /// <summary>
            /// Читает 2 массива значений типа Int16?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<short?[], short?[]> ReadInt16Tuple2(int count)
            {
                return Tuple.Of(ReadInt16(count), ReadInt16(count));
            }

            /// <summary>
            /// Читает 2 массива значений типа UInt16?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<ushort?[], ushort?[]> ReadUInt16Tuple2(int count)
            {
                return Tuple.Of(ReadUInt16(count), ReadUInt16(count));
            }

            /// <summary>
            /// Читает 2 массива значений типа BigInteger?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<BigInteger?[], BigInteger?[]> ReadBigIntegerTuple2(int count)
            {
                return Tuple.Of(ReadBigInteger(count), ReadBigInteger(count));
            }

            #endregion two-arrays

            #region three-arrays

            /// <summary>
            /// Читает 3 массива значений типа Boolean?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<bool?[], bool?[], bool?[]> ReadBooleanTuple3(int count)
            {
                return Tuple.Of(ReadBoolean(count), ReadBoolean(count), ReadBoolean(count));
            }

            /// <summary>
            /// Читает 3 массива значений типа Byte?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<byte?[], byte?[], byte?[]> ReadByteTuple3(int count)
            {
                return Tuple.Of(ReadByte(count), ReadByte(count), ReadByte(count));
            }

            /// <summary>
            /// Читает 3 массива значений типа SByte?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<sbyte?[], sbyte?[], sbyte?[]> ReadSByteTuple3(int count)
            {
                return Tuple.Of(ReadSByte(count), ReadSByte(count), ReadSByte(count));
            }

            /// <summary>
            /// Читает 3 массива значений типа Char?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<char?[], char?[], char?[]> ReadCharTuple3(int count)
            {
                return Tuple.Of(ReadChar(count), ReadChar(count), ReadChar(count));
            }

            /// <summary>
            /// Читает 3 массива значений типа Decimal?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<decimal?[], decimal?[], decimal?[]> ReadDecimalTuple3(int count)
            {
                return Tuple.Of(ReadDecimal(count), ReadDecimal(count), ReadDecimal(count));
            }

            /// <summary>
            /// Читает 3 массива значений типа Double?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<double?[], double?[], double?[]> ReadDoubleTuple3(int count)
            {
                return Tuple.Of(ReadDouble(count), ReadDouble(count), ReadDouble(count));
            }

            /// <summary>
            /// Читает 3 массива значений типа Single?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<float?[], float?[], float?[]> ReadSingleTuple3(int count)
            {
                return Tuple.Of(ReadSingle(count), ReadSingle(count), ReadSingle(count));
            }

            /// <summary>
            /// Читает 3 массива значений типа Int32?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<int?[], int?[], int?[]> ReadInt32Tuple3(int count)
            {
                return Tuple.Of(ReadInt32(count), ReadInt32(count), ReadInt32(count));
            }

            /// <summary>
            /// Читает 3 массива значений типа UInt32?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<uint?[], uint?[], uint?[]> ReadUInt32Tuple3(int count)
            {
                return Tuple.Of(ReadUInt32(count), ReadUInt32(count), ReadUInt32(count));
            }

            /// <summary>
            /// Читает 3 массива значений типа Int64?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<long?[], long?[], long?[]> ReadInt64Tuple3(int count)
            {
                return Tuple.Of(ReadInt64(count), ReadInt64(count), ReadInt64(count));
            }

            /// <summary>
            /// Читает 3 массива значений типа UInt64?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<ulong?[], ulong?[], ulong?[]> ReadUInt64Tuple3(int count)
            {
                return Tuple.Of(ReadUInt64(count), ReadUInt64(count), ReadUInt64(count));
            }

            /// <summary>
            /// Читает 3 массива значений типа Int16?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<short?[], short?[], short?[]> ReadInt16Tuple3(int count)
            {
                return Tuple.Of(ReadInt16(count), ReadInt16(count), ReadInt16(count));
            }

            /// <summary>
            /// Читает 3 массива значений типа UInt16?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<ushort?[], ushort?[], ushort?[]> ReadUInt16Tuple3(int count)
            {
                return Tuple.Of(ReadUInt16(count), ReadUInt16(count), ReadUInt16(count));
            }

            /// <summary>
            /// Читает 3 массива значений типа BigInteger?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<BigInteger?[], BigInteger?[], BigInteger?[]> ReadBigIntegerTuple3(int count)
            {
                return Tuple.Of(ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count));
            }

            #endregion three-arrays

            #region four-arrays

            /// <summary>
            /// Читает 4 массива значений типа Boolean?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<bool?[], bool?[], bool?[], bool?[]> ReadBooleanTuple4(int count)
            {
                return Tuple.Of(ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count));
            }

            /// <summary>
            /// Читает 4 массива значений типа Byte?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<byte?[], byte?[], byte?[], byte?[]> ReadByteTuple4(int count)
            {
                return Tuple.Of(ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count));
            }

            /// <summary>
            /// Читает 4 массива значений типа SByte?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<sbyte?[], sbyte?[], sbyte?[], sbyte?[]> ReadSByteTuple4(int count)
            {
                return Tuple.Of(ReadSByte(count), ReadSByte(count), ReadSByte(count), ReadSByte(count));
            }

            /// <summary>
            /// Читает 4 массива значений типа Char?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<char?[], char?[], char?[], char?[]> ReadCharTuple4(int count)
            {
                return Tuple.Of(ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count));
            }

            /// <summary>
            /// Читает 4 массива значений типа Decimal?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<decimal?[], decimal?[], decimal?[], decimal?[]> ReadDecimalTuple4(int count)
            {
                return Tuple.Of(ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count));
            }

            /// <summary>
            /// Читает 4 массива значений типа Double?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<double?[], double?[], double?[], double?[]> ReadDoubleTuple4(int count)
            {
                return Tuple.Of(ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count));
            }

            /// <summary>
            /// Читает 4 массива значений типа Single?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<float?[], float?[], float?[], float?[]> ReadSingleTuple4(int count)
            {
                return Tuple.Of(ReadSingle(count), ReadSingle(count), ReadSingle(count), ReadSingle(count));
            }

            /// <summary>
            /// Читает 4 массива значений типа Int32?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<int?[], int?[], int?[], int?[]> ReadInt32Tuple4(int count)
            {
                return Tuple.Of(ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count));
            }

            /// <summary>
            /// Читает 4 массива значений типа UInt32?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<uint?[], uint?[], uint?[], uint?[]> ReadUInt32Tuple4(int count)
            {
                return Tuple.Of(ReadUInt32(count), ReadUInt32(count), ReadUInt32(count), ReadUInt32(count));
            }

            /// <summary>
            /// Читает 4 массива значений типа Int64?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<long?[], long?[], long?[], long?[]> ReadInt64Tuple4(int count)
            {
                return Tuple.Of(ReadInt64(count), ReadInt64(count), ReadInt64(count), ReadInt64(count));
            }

            /// <summary>
            /// Читает 4 массива значений типа UInt64?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<ulong?[], ulong?[], ulong?[], ulong?[]> ReadUInt64Tuple4(int count)
            {
                return Tuple.Of(ReadUInt64(count), ReadUInt64(count), ReadUInt64(count), ReadUInt64(count));
            }

            /// <summary>
            /// Читает 4 массива значений типа Int16?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<short?[], short?[], short?[], short?[]> ReadInt16Tuple4(int count)
            {
                return Tuple.Of(ReadInt16(count), ReadInt16(count), ReadInt16(count), ReadInt16(count));
            }

            /// <summary>
            /// Читает 4 массива значений типа UInt16?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<ushort?[], ushort?[], ushort?[], ushort?[]> ReadUInt16Tuple4(int count)
            {
                return Tuple.Of(ReadUInt16(count), ReadUInt16(count), ReadUInt16(count), ReadUInt16(count));
            }

            /// <summary>
            /// Читает 4 массива значений типа BigInteger?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<BigInteger?[], BigInteger?[], BigInteger?[], BigInteger?[]> ReadBigIntegerTuple4(int count)
            {
                return Tuple.Of(ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count));
            }

            #endregion four-arrays

            #region five-arrays

            /// <summary>
            /// Читает 5 массивов значений типа Boolean?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<bool?[], bool?[], bool?[], bool?[], bool?[]> ReadBooleanTuple5(int count)
            {
                return Tuple.Of(ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count));
            }

            /// <summary>
            /// Читает 5 массивов значений типа Byte?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<byte?[], byte?[], byte?[], byte?[], byte?[]> ReadByteTuple5(int count)
            {
                return Tuple.Of(ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count));
            }

            /// <summary>
            /// Читает 5 массивов значений типа SByte?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<sbyte?[], sbyte?[], sbyte?[], sbyte?[], sbyte?[]> ReadSByteTuple5(int count)
            {
                return Tuple.Of(ReadSByte(count), ReadSByte(count), ReadSByte(count), ReadSByte(count), ReadSByte(count));
            }

            /// <summary>
            /// Читает 5 массивов значений типа Char?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<char?[], char?[], char?[], char?[], char?[]> ReadCharTuple5(int count)
            {
                return Tuple.Of(ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count));
            }

            /// <summary>
            /// Читает 5 массивов значений типа Decimal?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<decimal?[], decimal?[], decimal?[], decimal?[], decimal?[]> ReadDecimalTuple5(int count)
            {
                return Tuple.Of(ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count));
            }

            /// <summary>
            /// Читает 5 массивов значений типа Double?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<double?[], double?[], double?[], double?[], double?[]> ReadDoubleTuple5(int count)
            {
                return Tuple.Of(ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count));
            }

            /// <summary>
            /// Читает 5 массивов значений типа Single?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<float?[], float?[], float?[], float?[], float?[]> ReadSingleTuple5(int count)
            {
                return Tuple.Of(ReadSingle(count), ReadSingle(count), ReadSingle(count), ReadSingle(count), ReadSingle(count));
            }

            /// <summary>
            /// Читает 5 массивов значений типа Int32?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<int?[], int?[], int?[], int?[], int?[]> ReadInt32Tuple5(int count)
            {
                return Tuple.Of(ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count));
            }

            /// <summary>
            /// Читает 5 массивов значений типа UInt32?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<uint?[], uint?[], uint?[], uint?[], uint?[]> ReadUInt32Tuple5(int count)
            {
                return Tuple.Of(ReadUInt32(count), ReadUInt32(count), ReadUInt32(count), ReadUInt32(count), ReadUInt32(count));
            }

            /// <summary>
            /// Читает 5 массивов значений типа Int64?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<long?[], long?[], long?[], long?[], long?[]> ReadInt64Tuple5(int count)
            {
                return Tuple.Of(ReadInt64(count), ReadInt64(count), ReadInt64(count), ReadInt64(count), ReadInt64(count));
            }

            /// <summary>
            /// Читает 5 массивов значений типа UInt64?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<ulong?[], ulong?[], ulong?[], ulong?[], ulong?[]> ReadUInt64Tuple5(int count)
            {
                return Tuple.Of(ReadUInt64(count), ReadUInt64(count), ReadUInt64(count), ReadUInt64(count), ReadUInt64(count));
            }

            /// <summary>
            /// Читает 5 массивов значений типа Int16?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<short?[], short?[], short?[], short?[], short?[]> ReadInt16Tuple5(int count)
            {
                return Tuple.Of(ReadInt16(count), ReadInt16(count), ReadInt16(count), ReadInt16(count), ReadInt16(count));
            }

            /// <summary>
            /// Читает 5 массивов значений типа UInt16?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<ushort?[], ushort?[], ushort?[], ushort?[], ushort?[]> ReadUInt16Tuple5(int count)
            {
                return Tuple.Of(ReadUInt16(count), ReadUInt16(count), ReadUInt16(count), ReadUInt16(count), ReadUInt16(count));
            }

            /// <summary>
            /// Читает 5 массивов значений типа BigInteger?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<BigInteger?[], BigInteger?[], BigInteger?[], BigInteger?[], BigInteger?[]> ReadBigIntegerTuple5(int count)
            {
                return Tuple.Of(ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count));
            }

            #endregion five-arrays

            #region six-arrays

            /// <summary>
            /// Читает 6 массивов значений типа Boolean?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<bool?[], bool?[], bool?[], bool?[], bool?[], bool?[]> ReadBooleanTuple6(int count)
            {
                return Tuple.Of(ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count));
            }

            /// <summary>
            /// Читает 6 массивов значений типа Byte?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<byte?[], byte?[], byte?[], byte?[], byte?[], byte?[]> ReadByteTuple6(int count)
            {
                return Tuple.Of(ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count));
            }

            /// <summary>
            /// Читает 6 массивов значений типа SByte?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<sbyte?[], sbyte?[], sbyte?[], sbyte?[], sbyte?[], sbyte?[]> ReadSByteTuple6(int count)
            {
                return Tuple.Of(ReadSByte(count), ReadSByte(count), ReadSByte(count), ReadSByte(count), ReadSByte(count), ReadSByte(count));
            }

            /// <summary>
            /// Читает 6 массивов значений типа Char?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<char?[], char?[], char?[], char?[], char?[], char?[]> ReadCharTuple6(int count)
            {
                return Tuple.Of(ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count));
            }

            /// <summary>
            /// Читает 6 массивов значений типа Decimal?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<decimal?[], decimal?[], decimal?[], decimal?[], decimal?[], decimal?[]> ReadDecimalTuple6(int count)
            {
                return Tuple.Of(ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count));
            }

            /// <summary>
            /// Читает 6 массивов значений типа Double?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<double?[], double?[], double?[], double?[], double?[], double?[]> ReadDoubleTuple6(int count)
            {
                return Tuple.Of(ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count));
            }

            /// <summary>
            /// Читает 6 массивов значений типа Single?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<float?[], float?[], float?[], float?[], float?[], float?[]> ReadSingleTuple6(int count)
            {
                return Tuple.Of(ReadSingle(count), ReadSingle(count), ReadSingle(count), ReadSingle(count), ReadSingle(count), ReadSingle(count));
            }

            /// <summary>
            /// Читает 6 массивов значений типа Int32?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<int?[], int?[], int?[], int?[], int?[], int?[]> ReadInt32Tuple6(int count)
            {
                return Tuple.Of(ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count));
            }

            /// <summary>
            /// Читает 6 массивов значений типа UInt32?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<uint?[], uint?[], uint?[], uint?[], uint?[], uint?[]> ReadUInt32Tuple6(int count)
            {
                return Tuple.Of(ReadUInt32(count), ReadUInt32(count), ReadUInt32(count), ReadUInt32(count), ReadUInt32(count), ReadUInt32(count));
            }

            /// <summary>
            /// Читает 6 массивов значений типа Int64?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<long?[], long?[], long?[], long?[], long?[], long?[]> ReadInt64Tuple6(int count)
            {
                return Tuple.Of(ReadInt64(count), ReadInt64(count), ReadInt64(count), ReadInt64(count), ReadInt64(count), ReadInt64(count));
            }

            /// <summary>
            /// Читает 6 массивов значений типа UInt64?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<ulong?[], ulong?[], ulong?[], ulong?[], ulong?[], ulong?[]> ReadUInt64Tuple6(int count)
            {
                return Tuple.Of(ReadUInt64(count), ReadUInt64(count), ReadUInt64(count), ReadUInt64(count), ReadUInt64(count), ReadUInt64(count));
            }

            /// <summary>
            /// Читает 6 массивов значений типа Int16?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<short?[], short?[], short?[], short?[], short?[], short?[]> ReadInt16Tuple6(int count)
            {
                return Tuple.Of(ReadInt16(count), ReadInt16(count), ReadInt16(count), ReadInt16(count), ReadInt16(count), ReadInt16(count));
            }

            /// <summary>
            /// Читает 6 массивов значений типа UInt16?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<ushort?[], ushort?[], ushort?[], ushort?[], ushort?[], ushort?[]> ReadUInt16Tuple6(int count)
            {
                return Tuple.Of(ReadUInt16(count), ReadUInt16(count), ReadUInt16(count), ReadUInt16(count), ReadUInt16(count), ReadUInt16(count));
            }

            /// <summary>
            /// Читает 6 массивов значений типа BigInteger?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<BigInteger?[], BigInteger?[], BigInteger?[], BigInteger?[], BigInteger?[], BigInteger?[]> ReadBigIntegerTuple6(int count)
            {
                return Tuple.Of(ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count));
            }

            #endregion six-arrays

            #region seven-arrays

            /// <summary>
            /// Читает 7 массивов значений типа Boolean?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<bool?[], bool?[], bool?[], bool?[], bool?[], bool?[], bool?[]> ReadBooleanTuple7(int count)
            {
                return Tuple.Of(ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count));
            }

            /// <summary>
            /// Читает 7 массивов значений типа Byte?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<byte?[], byte?[], byte?[], byte?[], byte?[], byte?[], byte?[]> ReadByteTuple7(int count)
            {
                return Tuple.Of(ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count), ReadByte(count));
            }

            /// <summary>
            /// Читает 7 массивов значений типа SByte?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<sbyte?[], sbyte?[], sbyte?[], sbyte?[], sbyte?[], sbyte?[], sbyte?[]> ReadSByteTuple7(int count)
            {
                return Tuple.Of(ReadSByte(count), ReadSByte(count), ReadSByte(count), ReadSByte(count), ReadSByte(count), ReadSByte(count), ReadSByte(count));
            }

            /// <summary>
            /// Читает 7 массивов значений типа Char?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<char?[], char?[], char?[], char?[], char?[], char?[], char?[]> ReadCharTuple7(int count)
            {
                return Tuple.Of(ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count));
            }

            /// <summary>
            /// Читает 7 массивов значений типа Decimal?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<decimal?[], decimal?[], decimal?[], decimal?[], decimal?[], decimal?[], decimal?[]> ReadDecimalTuple7(int count)
            {
                return Tuple.Of(ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count), ReadDecimal(count));
            }

            /// <summary>
            /// Читает 7 массивов значений типа Double?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<double?[], double?[], double?[], double?[], double?[], double?[], double?[]> ReadDoubleTuple7(int count)
            {
                return Tuple.Of(ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count));
            }

            /// <summary>
            /// Читает 7 массивов значений типа Single?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<float?[], float?[], float?[], float?[], float?[], float?[], float?[]> ReadSingleTuple7(int count)
            {
                return Tuple.Of(ReadSingle(count), ReadSingle(count), ReadSingle(count), ReadSingle(count), ReadSingle(count), ReadSingle(count), ReadSingle(count));
            }

            /// <summary>
            /// Читает 7 массивов значений типа Int32?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<int?[], int?[], int?[], int?[], int?[], int?[], int?[]> ReadInt32Tuple7(int count)
            {
                return Tuple.Of(ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count));
            }

            /// <summary>
            /// Читает 7 массивов значений типа UInt32?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<uint?[], uint?[], uint?[], uint?[], uint?[], uint?[], uint?[]> ReadUInt32Tuple7(int count)
            {
                return Tuple.Of(ReadUInt32(count), ReadUInt32(count), ReadUInt32(count), ReadUInt32(count), ReadUInt32(count), ReadUInt32(count), ReadUInt32(count));
            }

            /// <summary>
            /// Читает 7 массивов значений типа Int64?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<long?[], long?[], long?[], long?[], long?[], long?[], long?[]> ReadInt64Tuple7(int count)
            {
                return Tuple.Of(ReadInt64(count), ReadInt64(count), ReadInt64(count), ReadInt64(count), ReadInt64(count), ReadInt64(count), ReadInt64(count));
            }

            /// <summary>
            /// Читает 7 массивов значений типа UInt64?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<ulong?[], ulong?[], ulong?[], ulong?[], ulong?[], ulong?[], ulong?[]> ReadUInt64Tuple7(int count)
            {
                return Tuple.Of(ReadUInt64(count), ReadUInt64(count), ReadUInt64(count), ReadUInt64(count), ReadUInt64(count), ReadUInt64(count), ReadUInt64(count));
            }

            /// <summary>
            /// Читает 7 массивов значений типа Int16?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<short?[], short?[], short?[], short?[], short?[], short?[], short?[]> ReadInt16Tuple7(int count)
            {
                return Tuple.Of(ReadInt16(count), ReadInt16(count), ReadInt16(count), ReadInt16(count), ReadInt16(count), ReadInt16(count), ReadInt16(count));
            }

            /// <summary>
            /// Читает 7 массивов значений типа UInt16?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<ushort?[], ushort?[], ushort?[], ushort?[], ushort?[], ushort?[], ushort?[]> ReadUInt16Tuple7(int count)
            {
                return Tuple.Of(ReadUInt16(count), ReadUInt16(count), ReadUInt16(count), ReadUInt16(count), ReadUInt16(count), ReadUInt16(count), ReadUInt16(count));
            }

            /// <summary>
            /// Читает 7 массивов значений типа BigInteger?.
            /// </summary>
            /// <param name="count">Размер массива.</param>
            /// <returns>Кортеж.</returns>
            public static Tuple<BigInteger?[], BigInteger?[], BigInteger?[], BigInteger?[], BigInteger?[], BigInteger?[], BigInteger?[]> ReadBigIntegerTuple7(int count)
            {
                return Tuple.Of(ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count), ReadBigInteger(count));
            }

            #endregion seven-arrays

            #endregion
        }
    }
}
