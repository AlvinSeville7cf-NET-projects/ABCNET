using System;
using System.Collections.Generic;
using System.Numerics;

namespace ABCNET.Utils
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public static partial class Sequence
	{

        #region public

        #region Read1

        /// <summary>
        /// Читает последовательность типа Boolean с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<bool> ReadBoolean(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            prompt = prompt ?? EmptyStringHelper.Empty;

            bool[] result = new bool[count];
            for (int i = 0; i < count; i++)
                result[i] = Base.ReadBoolean(string.Format(prompt, i));

            return result;
        }

        /// <summary>
        /// Читает последовательность типа Byte с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<byte> ReadByte(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            prompt = prompt ?? EmptyStringHelper.Empty;

            byte[] result = new byte[count];
            for (int i = 0; i < count; i++)
                result[i] = Base.ReadByte(string.Format(prompt, i));

            return result;
        }

        /// <summary>
        /// Читает последовательность типа SByte с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<sbyte> ReadSByte(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            prompt = prompt ?? EmptyStringHelper.Empty;

            sbyte[] result = new sbyte[count];
            for (int i = 0; i < count; i++)
                result[i] = Base.ReadSByte(string.Format(prompt, i));

            return result;
        }

        /// <summary>
        /// Читает последовательность типа Char с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<char> ReadChar(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            prompt = prompt ?? EmptyStringHelper.Empty;

            char[] result = new char[count];
            for (int i = 0; i < count; i++)
                result[i] = Base.ReadChar(string.Format(prompt, i));

            return result;
        }

        /// <summary>
        /// Читает последовательность типа Decimal с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<decimal> ReadDecimal(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            prompt = prompt ?? EmptyStringHelper.Empty;

            decimal[] result = new decimal[count];
            for (int i = 0; i < count; i++)
                result[i] = Base.ReadDecimal(string.Format(prompt, i));

            return result;
        }

        /// <summary>
        /// Читает последовательность типа Double с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<double> ReadDouble(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            prompt = prompt ?? EmptyStringHelper.Empty;

            double[] result = new double[count];
            for (int i = 0; i < count; i++)
                result[i] = Base.ReadDouble(string.Format(prompt, i));

            return result;
        }

        /// <summary>
        /// Читает последовательность типа Single с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<float> ReadSingle(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            prompt = prompt ?? EmptyStringHelper.Empty;

            float[] result = new float[count];
            for (int i = 0; i < count; i++)
                result[i] = Base.ReadSingle(string.Format(prompt, i));

            return result;
        }

        /// <summary>
        /// Читает последовательность типа Int32 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<int> ReadInt32(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            prompt = prompt ?? EmptyStringHelper.Empty;

            int[] result = new int[count];
            for (int i = 0; i < count; i++)
                result[i] = Base.ReadInt32(string.Format(prompt, i));

            return result;
        }

        /// <summary>
        /// Читает последовательность типа UInt32 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<uint> ReadUInt32(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            prompt = prompt ?? EmptyStringHelper.Empty;

            uint[] result = new uint[count];
            for (int i = 0; i < count; i++)
                result[i] = Base.ReadUInt32(string.Format(prompt, i));

            return result;
        }

        /// <summary>
        /// Читает последовательность типа Int64 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<long> ReadInt64(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            prompt = prompt ?? EmptyStringHelper.Empty;

            long[] result = new long[count];
            for (int i = 0; i < count; i++)
                result[i] = Base.ReadInt64(string.Format(prompt, i));

            return result;
        }

        /// <summary>
        /// Читает последовательность типа UInt64 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<ulong> ReadUInt64(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            prompt = prompt ?? EmptyStringHelper.Empty;

            ulong[] result = new ulong[count];
            for (int i = 0; i < count; i++)
                result[i] = Base.ReadUInt64(string.Format(prompt, i));

            return result;
        }

        /// <summary>
        /// Читает последовательность типа Int16 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<short> ReadInt16(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            prompt = prompt ?? EmptyStringHelper.Empty;

            short[] result = new short[count];
            for (int i = 0; i < count; i++)
                result[i] = Base.ReadInt16(string.Format(prompt, i));

            return result;
        }

        /// <summary>
        /// Читает последовательность типа UInt16 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<ushort> ReadUInt16(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            prompt = prompt ?? EmptyStringHelper.Empty;

            ushort[] result = new ushort[count];
            for (int i = 0; i < count; i++)
                result[i] = Base.ReadUInt16(string.Format(prompt, i));

            return result;
        }

        /// <summary>
        /// Читает последовательность типа BigInteger с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<BigInteger> ReadBigInteger(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            prompt = prompt ?? EmptyStringHelper.Empty;

            BigInteger[] result = new BigInteger[count];
            for (int i = 0; i < count; i++)
                result[i] = Base.ReadBigInteger(string.Format(prompt, i));

            return result;
        }

        /// <summary>
        /// Читает последовательность типа String с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<string> ReadString(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            prompt = prompt ?? EmptyStringHelper.Empty;

            string[] result = new string[count];
            for (int i = 0; i < count; i++)
                result[i] = Base.ReadString(string.Format(prompt, i));

            return result;
        }

        #endregion

        #region Read2

        /// <summary>
        /// Читает 2 последовательности типа Boolean с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<bool>, IEnumerable<bool>> ReadBooleanTuple2(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadBoolean(count, prompt), ReadBoolean(count, prompt));
        }
 
        /// <summary>
        /// Читает 2 последовательности типа Byte с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<byte>, IEnumerable<byte>> ReadByteTuple2(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadByte(count, prompt), ReadByte(count, prompt));
        }
 
        /// <summary>
        /// Читает 2 последовательности типа SByte с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<sbyte>, IEnumerable<sbyte>> ReadSByteTuple2(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadSByte(count, prompt), ReadSByte(count, prompt));
        }
 
        /// <summary>
        /// Читает 2 последовательности типа Char с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<char>, IEnumerable<char>> ReadCharTuple2(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadChar(count, prompt), ReadChar(count, prompt));
        }
 
        /// <summary>
        /// Читает 2 последовательности типа Decimal с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<decimal>, IEnumerable<decimal>> ReadDecimalTuple2(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadDecimal(count, prompt), ReadDecimal(count, prompt));
        }
 
        /// <summary>
        /// Читает 2 последовательности типа Double с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<double>, IEnumerable<double>> ReadDoubleTuple2(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadDouble(count, prompt), ReadDouble(count, prompt));
        }
 
        /// <summary>
        /// Читает 2 последовательности типа Single с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<float>, IEnumerable<float>> ReadSingleTuple2(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadSingle(count, prompt), ReadSingle(count, prompt));
        }
 
        /// <summary>
        /// Читает 2 последовательности типа Int32 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<int>, IEnumerable<int>> ReadInt32Tuple2(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadInt32(count, prompt), ReadInt32(count, prompt));
        }
 
        /// <summary>
        /// Читает 2 последовательности типа UInt32 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<uint>, IEnumerable<uint>> ReadUInt32Tuple2(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadUInt32(count, prompt), ReadUInt32(count, prompt));
        }
 
        /// <summary>
        /// Читает 2 последовательности типа Int64 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<long>, IEnumerable<long>> ReadInt64Tuple2(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadInt64(count, prompt), ReadInt64(count, prompt));
        }
 
        /// <summary>
        /// Читает 2 последовательности типа UInt64 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<ulong>, IEnumerable<ulong>> ReadUInt64Tuple2(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadUInt64(count, prompt), ReadUInt64(count, prompt));
        }
 
        /// <summary>
        /// Читает 2 последовательности типа Int16 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<short>, IEnumerable<short>> ReadInt16Tuple2(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadInt16(count, prompt), ReadInt16(count, prompt));
        }
 
        /// <summary>
        /// Читает 2 последовательности типа UInt16 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<ushort>, IEnumerable<ushort>> ReadUInt16Tuple2(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadUInt16(count, prompt), ReadUInt16(count, prompt));
        }
 
        /// <summary>
        /// Читает 2 последовательности типа BigInteger с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<BigInteger>, IEnumerable<BigInteger>> ReadBigIntegerTuple2(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadBigInteger(count, prompt), ReadBigInteger(count, prompt));
        }
 
        /// <summary>
        /// Читает 2 последовательности типа String с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<string>, IEnumerable<string>> ReadStringTuple2(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadString(count, prompt), ReadString(count, prompt));
        }
        
        #endregion
        
        #region Read3
        
        /// <summary>
        /// Читает 3 последовательности типа Boolean с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<bool>, IEnumerable<bool>, IEnumerable<bool>> ReadBooleanTuple3(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadBoolean(count, prompt), ReadBoolean(count, prompt), ReadBoolean(count, prompt));
        }
 
        /// <summary>
        /// Читает 3 последовательности типа Byte с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<byte>, IEnumerable<byte>, IEnumerable<byte>> ReadByteTuple3(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadByte(count, prompt), ReadByte(count, prompt), ReadByte(count, prompt));
        }
 
        /// <summary>
        /// Читает 3 последовательности типа SByte с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<sbyte>, IEnumerable<sbyte>, IEnumerable<sbyte>> ReadSByteTuple3(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadSByte(count, prompt), ReadSByte(count, prompt), ReadSByte(count, prompt));
        }
 
        /// <summary>
        /// Читает 3 последовательности типа Char с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<char>, IEnumerable<char>, IEnumerable<char>> ReadCharTuple3(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadChar(count, prompt), ReadChar(count, prompt), ReadChar(count, prompt));
        }
 
        /// <summary>
        /// Читает 3 последовательности типа Decimal с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<decimal>, IEnumerable<decimal>, IEnumerable<decimal>> ReadDecimalTuple3(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadDecimal(count, prompt), ReadDecimal(count, prompt), ReadDecimal(count, prompt));
        }
 
        /// <summary>
        /// Читает 3 последовательности типа Double с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<double>, IEnumerable<double>, IEnumerable<double>> ReadDoubleTuple3(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadDouble(count, prompt), ReadDouble(count, prompt), ReadDouble(count, prompt));
        }
 
        /// <summary>
        /// Читает 3 последовательности типа Single с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<float>, IEnumerable<float>, IEnumerable<float>> ReadSingleTuple3(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadSingle(count, prompt), ReadSingle(count, prompt), ReadSingle(count, prompt));
        }
 
        /// <summary>
        /// Читает 3 последовательности типа Int32 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<int>, IEnumerable<int>, IEnumerable<int>> ReadInt32Tuple3(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadInt32(count, prompt), ReadInt32(count, prompt), ReadInt32(count, prompt));
        }
 
        /// <summary>
        /// Читает 3 последовательности типа UInt32 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<uint>, IEnumerable<uint>, IEnumerable<uint>> ReadUInt32Tuple3(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadUInt32(count, prompt), ReadUInt32(count, prompt), ReadUInt32(count, prompt));
        }
 
        /// <summary>
        /// Читает 3 последовательности типа Int64 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<long>, IEnumerable<long>, IEnumerable<long>> ReadInt64Tuple3(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadInt64(count, prompt), ReadInt64(count, prompt), ReadInt64(count, prompt));
        }
 
        /// <summary>
        /// Читает 3 последовательности типа UInt64 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<ulong>, IEnumerable<ulong>, IEnumerable<ulong>> ReadUInt64Tuple3(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadUInt64(count, prompt), ReadUInt64(count, prompt), ReadUInt64(count, prompt));
        }
 
        /// <summary>
        /// Читает 3 последовательности типа Int16 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<short>, IEnumerable<short>, IEnumerable<short>> ReadInt16Tuple3(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadInt16(count, prompt), ReadInt16(count, prompt), ReadInt16(count, prompt));
        }
 
        /// <summary>
        /// Читает 3 последовательности типа UInt16 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<ushort>, IEnumerable<ushort>, IEnumerable<ushort>> ReadUInt16Tuple3(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadUInt16(count, prompt), ReadUInt16(count, prompt), ReadUInt16(count, prompt));
        }
 
        /// <summary>
        /// Читает 3 последовательности типа BigInteger с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<BigInteger>, IEnumerable<BigInteger>, IEnumerable<BigInteger>> ReadBigIntegerTuple3(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadBigInteger(count, prompt), ReadBigInteger(count, prompt), ReadBigInteger(count, prompt));
        }
 
        /// <summary>
        /// Читает 3 последовательности типа String с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<string>, IEnumerable<string>, IEnumerable<string>> ReadStringTuple3(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadString(count, prompt), ReadString(count, prompt), ReadString(count, prompt));
        }
        
        #endregion
        
        #region Read4
        
        /// <summary>
        /// Читает 4 последовательности типа Boolean с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<bool>, IEnumerable<bool>, IEnumerable<bool>, IEnumerable<bool>> ReadBooleanTuple4(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadBoolean(count, prompt), ReadBoolean(count, prompt), ReadBoolean(count, prompt), ReadBoolean(count, prompt));
        }
 
        /// <summary>
        /// Читает 4 последовательности типа Byte с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<byte>, IEnumerable<byte>, IEnumerable<byte>, IEnumerable<byte>> ReadByteTuple4(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadByte(count, prompt), ReadByte(count, prompt), ReadByte(count, prompt), ReadByte(count, prompt));
        }
 
        /// <summary>
        /// Читает 4 последовательности типа SByte с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<sbyte>, IEnumerable<sbyte>, IEnumerable<sbyte>, IEnumerable<sbyte>> ReadSByteTuple4(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadSByte(count, prompt), ReadSByte(count, prompt), ReadSByte(count, prompt), ReadSByte(count, prompt));
        }
 
        /// <summary>
        /// Читает 4 последовательности типа Char с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<char>, IEnumerable<char>, IEnumerable<char>, IEnumerable<char>> ReadCharTuple4(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadChar(count, prompt), ReadChar(count, prompt), ReadChar(count, prompt), ReadChar(count, prompt));
        }
 
        /// <summary>
        /// Читает 4 последовательности типа Decimal с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<decimal>, IEnumerable<decimal>, IEnumerable<decimal>, IEnumerable<decimal>> ReadDecimalTuple4(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadDecimal(count, prompt), ReadDecimal(count, prompt), ReadDecimal(count, prompt), ReadDecimal(count, prompt));
        }
 
        /// <summary>
        /// Читает 4 последовательности типа Double с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<double>, IEnumerable<double>, IEnumerable<double>, IEnumerable<double>> ReadDoubleTuple4(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadDouble(count, prompt), ReadDouble(count, prompt), ReadDouble(count, prompt), ReadDouble(count, prompt));
        }
 
        /// <summary>
        /// Читает 4 последовательности типа Single с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<float>, IEnumerable<float>, IEnumerable<float>, IEnumerable<float>> ReadSingleTuple4(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadSingle(count, prompt), ReadSingle(count, prompt), ReadSingle(count, prompt), ReadSingle(count, prompt));
        }
 
        /// <summary>
        /// Читает 4 последовательности типа Int32 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<int>, IEnumerable<int>, IEnumerable<int>, IEnumerable<int>> ReadInt32Tuple4(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadInt32(count, prompt), ReadInt32(count, prompt), ReadInt32(count, prompt), ReadInt32(count, prompt));
        }
 
        /// <summary>
        /// Читает 4 последовательности типа UInt32 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<uint>, IEnumerable<uint>, IEnumerable<uint>, IEnumerable<uint>> ReadUInt32Tuple4(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadUInt32(count, prompt), ReadUInt32(count, prompt), ReadUInt32(count, prompt), ReadUInt32(count, prompt));
        }
 
        /// <summary>
        /// Читает 4 последовательности типа Int64 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<long>, IEnumerable<long>, IEnumerable<long>, IEnumerable<long>> ReadInt64Tuple4(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadInt64(count, prompt), ReadInt64(count, prompt), ReadInt64(count, prompt), ReadInt64(count, prompt));
        }
 
        /// <summary>
        /// Читает 4 последовательности типа UInt64 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<ulong>, IEnumerable<ulong>, IEnumerable<ulong>, IEnumerable<ulong>> ReadUInt64Tuple4(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadUInt64(count, prompt), ReadUInt64(count, prompt), ReadUInt64(count, prompt), ReadUInt64(count, prompt));
        }
 
        /// <summary>
        /// Читает 4 последовательности типа Int16 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<short>, IEnumerable<short>, IEnumerable<short>, IEnumerable<short>> ReadInt16Tuple4(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadInt16(count, prompt), ReadInt16(count, prompt), ReadInt16(count, prompt), ReadInt16(count, prompt));
        }
 
        /// <summary>
        /// Читает 4 последовательности типа UInt16 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<ushort>, IEnumerable<ushort>, IEnumerable<ushort>, IEnumerable<ushort>> ReadUInt16Tuple4(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadUInt16(count, prompt), ReadUInt16(count, prompt), ReadUInt16(count, prompt), ReadUInt16(count, prompt));
        }
 
        /// <summary>
        /// Читает 4 последовательности типа BigInteger с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<BigInteger>, IEnumerable<BigInteger>, IEnumerable<BigInteger>, IEnumerable<BigInteger>> ReadBigIntegerTuple4(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadBigInteger(count, prompt), ReadBigInteger(count, prompt), ReadBigInteger(count, prompt), ReadBigInteger(count, prompt));
        }
 
        /// <summary>
        /// Читает 4 последовательности типа String с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<string>, IEnumerable<string>, IEnumerable<string>, IEnumerable<string>> ReadStringTuple4(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadString(count, prompt), ReadString(count, prompt), ReadString(count, prompt), ReadString(count, prompt));
        }
        
        #endregion
        
        #region Read5
        
        /// <summary>
        /// Читает 5 последовательностей типа Boolean с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<bool>, IEnumerable<bool>, IEnumerable<bool>, IEnumerable<bool>, IEnumerable<bool>> ReadBooleanTuple5(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadBoolean(count, prompt), ReadBoolean(count, prompt), ReadBoolean(count, prompt), ReadBoolean(count, prompt), ReadBoolean(count, prompt));
        }
 
        /// <summary>
        /// Читает 5 последовательностей типа Byte с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<byte>, IEnumerable<byte>, IEnumerable<byte>, IEnumerable<byte>, IEnumerable<byte>> ReadByteTuple5(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadByte(count, prompt), ReadByte(count, prompt), ReadByte(count, prompt), ReadByte(count, prompt), ReadByte(count, prompt));
        }
 
        /// <summary>
        /// Читает 5 последовательностей типа SByte с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<sbyte>, IEnumerable<sbyte>, IEnumerable<sbyte>, IEnumerable<sbyte>, IEnumerable<sbyte>> ReadSByteTuple5(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadSByte(count, prompt), ReadSByte(count, prompt), ReadSByte(count, prompt), ReadSByte(count, prompt), ReadSByte(count, prompt));
        }
 
        /// <summary>
        /// Читает 5 последовательностей типа Char с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<char>, IEnumerable<char>, IEnumerable<char>, IEnumerable<char>, IEnumerable<char>> ReadCharTuple5(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadChar(count, prompt), ReadChar(count, prompt), ReadChar(count, prompt), ReadChar(count, prompt), ReadChar(count, prompt));
        }
 
        /// <summary>
        /// Читает 5 последовательностей типа Decimal с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<decimal>, IEnumerable<decimal>, IEnumerable<decimal>, IEnumerable<decimal>, IEnumerable<decimal>> ReadDecimalTuple5(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadDecimal(count, prompt), ReadDecimal(count, prompt), ReadDecimal(count, prompt), ReadDecimal(count, prompt), ReadDecimal(count, prompt));
        }
 
        /// <summary>
        /// Читает 5 последовательностей типа Double с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<double>, IEnumerable<double>, IEnumerable<double>, IEnumerable<double>, IEnumerable<double>> ReadDoubleTuple5(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadDouble(count, prompt), ReadDouble(count, prompt), ReadDouble(count, prompt), ReadDouble(count, prompt), ReadDouble(count, prompt));
        }
 
        /// <summary>
        /// Читает 5 последовательностей типа Single с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<float>, IEnumerable<float>, IEnumerable<float>, IEnumerable<float>, IEnumerable<float>> ReadSingleTuple5(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadSingle(count, prompt), ReadSingle(count, prompt), ReadSingle(count, prompt), ReadSingle(count, prompt), ReadSingle(count, prompt));
        }
 
        /// <summary>
        /// Читает 5 последовательностей типа Int32 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<int>, IEnumerable<int>, IEnumerable<int>, IEnumerable<int>, IEnumerable<int>> ReadInt32Tuple5(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadInt32(count, prompt), ReadInt32(count, prompt), ReadInt32(count, prompt), ReadInt32(count, prompt), ReadInt32(count, prompt));
        }
 
        /// <summary>
        /// Читает 5 последовательностей типа UInt32 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<uint>, IEnumerable<uint>, IEnumerable<uint>, IEnumerable<uint>, IEnumerable<uint>> ReadUInt32Tuple5(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadUInt32(count, prompt), ReadUInt32(count, prompt), ReadUInt32(count, prompt), ReadUInt32(count, prompt), ReadUInt32(count, prompt));
        }
 
        /// <summary>
        /// Читает 5 последовательностей типа Int64 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<long>, IEnumerable<long>, IEnumerable<long>, IEnumerable<long>, IEnumerable<long>> ReadInt64Tuple5(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadInt64(count, prompt), ReadInt64(count, prompt), ReadInt64(count, prompt), ReadInt64(count, prompt), ReadInt64(count, prompt));
        }
 
        /// <summary>
        /// Читает 5 последовательностей типа UInt64 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<ulong>, IEnumerable<ulong>, IEnumerable<ulong>, IEnumerable<ulong>, IEnumerable<ulong>> ReadUInt64Tuple5(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadUInt64(count, prompt), ReadUInt64(count, prompt), ReadUInt64(count, prompt), ReadUInt64(count, prompt), ReadUInt64(count, prompt));
        }
 
        /// <summary>
        /// Читает 5 последовательностей типа Int16 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<short>, IEnumerable<short>, IEnumerable<short>, IEnumerable<short>, IEnumerable<short>> ReadInt16Tuple5(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadInt16(count, prompt), ReadInt16(count, prompt), ReadInt16(count, prompt), ReadInt16(count, prompt), ReadInt16(count, prompt));
        }
 
        /// <summary>
        /// Читает 5 последовательностей типа UInt16 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<ushort>, IEnumerable<ushort>, IEnumerable<ushort>, IEnumerable<ushort>, IEnumerable<ushort>> ReadUInt16Tuple5(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadUInt16(count, prompt), ReadUInt16(count, prompt), ReadUInt16(count, prompt), ReadUInt16(count, prompt), ReadUInt16(count, prompt));
        }
 
        /// <summary>
        /// Читает 5 последовательностей типа BigInteger с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<BigInteger>, IEnumerable<BigInteger>, IEnumerable<BigInteger>, IEnumerable<BigInteger>, IEnumerable<BigInteger>> ReadBigIntegerTuple5(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadBigInteger(count, prompt), ReadBigInteger(count, prompt), ReadBigInteger(count, prompt), ReadBigInteger(count, prompt), ReadBigInteger(count, prompt));
        }
 
        /// <summary>
        /// Читает 5 последовательностей типа String с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<string>, IEnumerable<string>, IEnumerable<string>, IEnumerable<string>, IEnumerable<string>> ReadStringTuple5(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadString(count, prompt), ReadString(count, prompt), ReadString(count, prompt), ReadString(count, prompt), ReadString(count, prompt));
        }
        
        #endregion
        
        #region Read6
        
        /// <summary>
        /// Читает 6 последовательностей типа Boolean с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<bool>, IEnumerable<bool>, IEnumerable<bool>, IEnumerable<bool>, IEnumerable<bool>, IEnumerable<bool>> ReadBooleanTuple6(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadBoolean(count, prompt), ReadBoolean(count, prompt), ReadBoolean(count, prompt), ReadBoolean(count, prompt), ReadBoolean(count, prompt), ReadBoolean(count, prompt));
        }
 
        /// <summary>
        /// Читает 6 последовательностей типа Byte с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<byte>, IEnumerable<byte>, IEnumerable<byte>, IEnumerable<byte>, IEnumerable<byte>, IEnumerable<byte>> ReadByteTuple6(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadByte(count, prompt), ReadByte(count, prompt), ReadByte(count, prompt), ReadByte(count, prompt), ReadByte(count, prompt), ReadByte(count, prompt));
        }
 
        /// <summary>
        /// Читает 6 последовательностей типа SByte с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<sbyte>, IEnumerable<sbyte>, IEnumerable<sbyte>, IEnumerable<sbyte>, IEnumerable<sbyte>, IEnumerable<sbyte>> ReadSByteTuple6(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadSByte(count, prompt), ReadSByte(count, prompt), ReadSByte(count, prompt), ReadSByte(count, prompt), ReadSByte(count, prompt), ReadSByte(count, prompt));
        }
 
        /// <summary>
        /// Читает 6 последовательностей типа Char с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<char>, IEnumerable<char>, IEnumerable<char>, IEnumerable<char>, IEnumerable<char>, IEnumerable<char>> ReadCharTuple6(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadChar(count, prompt), ReadChar(count, prompt), ReadChar(count, prompt), ReadChar(count, prompt), ReadChar(count, prompt), ReadChar(count, prompt));
        }
 
        /// <summary>
        /// Читает 6 последовательностей типа Decimal с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<decimal>, IEnumerable<decimal>, IEnumerable<decimal>, IEnumerable<decimal>, IEnumerable<decimal>, IEnumerable<decimal>> ReadDecimalTuple6(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadDecimal(count, prompt), ReadDecimal(count, prompt), ReadDecimal(count, prompt), ReadDecimal(count, prompt), ReadDecimal(count, prompt), ReadDecimal(count, prompt));
        }
 
        /// <summary>
        /// Читает 6 последовательностей типа Double с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<double>, IEnumerable<double>, IEnumerable<double>, IEnumerable<double>, IEnumerable<double>, IEnumerable<double>> ReadDoubleTuple6(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadDouble(count, prompt), ReadDouble(count, prompt), ReadDouble(count, prompt), ReadDouble(count, prompt), ReadDouble(count, prompt), ReadDouble(count, prompt));
        }
 
        /// <summary>
        /// Читает 6 последовательностей типа Single с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<float>, IEnumerable<float>, IEnumerable<float>, IEnumerable<float>, IEnumerable<float>, IEnumerable<float>> ReadSingleTuple6(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadSingle(count, prompt), ReadSingle(count, prompt), ReadSingle(count, prompt), ReadSingle(count, prompt), ReadSingle(count, prompt), ReadSingle(count, prompt));
        }
 
        /// <summary>
        /// Читает 6 последовательностей типа Int32 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<int>, IEnumerable<int>, IEnumerable<int>, IEnumerable<int>, IEnumerable<int>, IEnumerable<int>> ReadInt32Tuple6(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadInt32(count, prompt), ReadInt32(count, prompt), ReadInt32(count, prompt), ReadInt32(count, prompt), ReadInt32(count, prompt), ReadInt32(count, prompt));
        }
 
        /// <summary>
        /// Читает 6 последовательностей типа UInt32 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<uint>, IEnumerable<uint>, IEnumerable<uint>, IEnumerable<uint>, IEnumerable<uint>, IEnumerable<uint>> ReadUInt32Tuple6(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadUInt32(count, prompt), ReadUInt32(count, prompt), ReadUInt32(count, prompt), ReadUInt32(count, prompt), ReadUInt32(count, prompt), ReadUInt32(count, prompt));
        }
 
        /// <summary>
        /// Читает 6 последовательностей типа Int64 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<long>, IEnumerable<long>, IEnumerable<long>, IEnumerable<long>, IEnumerable<long>, IEnumerable<long>> ReadInt64Tuple6(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadInt64(count, prompt), ReadInt64(count, prompt), ReadInt64(count, prompt), ReadInt64(count, prompt), ReadInt64(count, prompt), ReadInt64(count, prompt));
        }
 
        /// <summary>
        /// Читает 6 последовательностей типа UInt64 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<ulong>, IEnumerable<ulong>, IEnumerable<ulong>, IEnumerable<ulong>, IEnumerable<ulong>, IEnumerable<ulong>> ReadUInt64Tuple6(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadUInt64(count, prompt), ReadUInt64(count, prompt), ReadUInt64(count, prompt), ReadUInt64(count, prompt), ReadUInt64(count, prompt), ReadUInt64(count, prompt));
        }
 
        /// <summary>
        /// Читает 6 последовательностей типа Int16 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<short>, IEnumerable<short>, IEnumerable<short>, IEnumerable<short>, IEnumerable<short>, IEnumerable<short>> ReadInt16Tuple6(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadInt16(count, prompt), ReadInt16(count, prompt), ReadInt16(count, prompt), ReadInt16(count, prompt), ReadInt16(count, prompt), ReadInt16(count, prompt));
        }
 
        /// <summary>
        /// Читает 6 последовательностей типа UInt16 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<ushort>, IEnumerable<ushort>, IEnumerable<ushort>, IEnumerable<ushort>, IEnumerable<ushort>, IEnumerable<ushort>> ReadUInt16Tuple6(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadUInt16(count, prompt), ReadUInt16(count, prompt), ReadUInt16(count, prompt), ReadUInt16(count, prompt), ReadUInt16(count, prompt), ReadUInt16(count, prompt));
        }
 
        /// <summary>
        /// Читает 6 последовательностей типа BigInteger с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<BigInteger>, IEnumerable<BigInteger>, IEnumerable<BigInteger>, IEnumerable<BigInteger>, IEnumerable<BigInteger>, IEnumerable<BigInteger>> ReadBigIntegerTuple6(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadBigInteger(count, prompt), ReadBigInteger(count, prompt), ReadBigInteger(count, prompt), ReadBigInteger(count, prompt), ReadBigInteger(count, prompt), ReadBigInteger(count, prompt));
        }
 
        /// <summary>
        /// Читает 6 последовательностей типа String с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<string>, IEnumerable<string>, IEnumerable<string>, IEnumerable<string>, IEnumerable<string>, IEnumerable<string>> ReadStringTuple6(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadString(count, prompt), ReadString(count, prompt), ReadString(count, prompt), ReadString(count, prompt), ReadString(count, prompt), ReadString(count, prompt));
        }
        
        #endregion
        
        #region Read7
        
        /// <summary>
        /// Читает 7 последовательностей типа Boolean с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<bool>, IEnumerable<bool>, IEnumerable<bool>, IEnumerable<bool>, IEnumerable<bool>, IEnumerable<bool>, IEnumerable<bool>> ReadBooleanTuple7(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadBoolean(count, prompt), ReadBoolean(count, prompt), ReadBoolean(count, prompt), ReadBoolean(count, prompt), ReadBoolean(count, prompt), ReadBoolean(count, prompt), ReadBoolean(count, prompt));
        }
 
        /// <summary>
        /// Читает 7 последовательностей типа Byte с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<byte>, IEnumerable<byte>, IEnumerable<byte>, IEnumerable<byte>, IEnumerable<byte>, IEnumerable<byte>, IEnumerable<byte>> ReadByteTuple7(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadByte(count, prompt), ReadByte(count, prompt), ReadByte(count, prompt), ReadByte(count, prompt), ReadByte(count, prompt), ReadByte(count, prompt), ReadByte(count, prompt));
        }
 
        /// <summary>
        /// Читает 7 последовательностей типа SByte с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<sbyte>, IEnumerable<sbyte>, IEnumerable<sbyte>, IEnumerable<sbyte>, IEnumerable<sbyte>, IEnumerable<sbyte>, IEnumerable<sbyte>> ReadSByteTuple7(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadSByte(count, prompt), ReadSByte(count, prompt), ReadSByte(count, prompt), ReadSByte(count, prompt), ReadSByte(count, prompt), ReadSByte(count, prompt), ReadSByte(count, prompt));
        }
 
        /// <summary>
        /// Читает 7 последовательностей типа Char с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<char>, IEnumerable<char>, IEnumerable<char>, IEnumerable<char>, IEnumerable<char>, IEnumerable<char>, IEnumerable<char>> ReadCharTuple7(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadChar(count, prompt), ReadChar(count, prompt), ReadChar(count, prompt), ReadChar(count, prompt), ReadChar(count, prompt), ReadChar(count, prompt), ReadChar(count, prompt));
        }
 
        /// <summary>
        /// Читает 7 последовательностей типа Decimal с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<decimal>, IEnumerable<decimal>, IEnumerable<decimal>, IEnumerable<decimal>, IEnumerable<decimal>, IEnumerable<decimal>, IEnumerable<decimal>> ReadDecimalTuple7(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadDecimal(count, prompt), ReadDecimal(count, prompt), ReadDecimal(count, prompt), ReadDecimal(count, prompt), ReadDecimal(count, prompt), ReadDecimal(count, prompt), ReadDecimal(count, prompt));
        }
 
        /// <summary>
        /// Читает 7 последовательностей типа Double с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<double>, IEnumerable<double>, IEnumerable<double>, IEnumerable<double>, IEnumerable<double>, IEnumerable<double>, IEnumerable<double>> ReadDoubleTuple7(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadDouble(count, prompt), ReadDouble(count, prompt), ReadDouble(count, prompt), ReadDouble(count, prompt), ReadDouble(count, prompt), ReadDouble(count, prompt), ReadDouble(count, prompt));
        }
 
        /// <summary>
        /// Читает 7 последовательностей типа Single с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<float>, IEnumerable<float>, IEnumerable<float>, IEnumerable<float>, IEnumerable<float>, IEnumerable<float>, IEnumerable<float>> ReadSingleTuple7(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadSingle(count, prompt), ReadSingle(count, prompt), ReadSingle(count, prompt), ReadSingle(count, prompt), ReadSingle(count, prompt), ReadSingle(count, prompt), ReadSingle(count, prompt));
        }
 
        /// <summary>
        /// Читает 7 последовательностей типа Int32 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<int>, IEnumerable<int>, IEnumerable<int>, IEnumerable<int>, IEnumerable<int>, IEnumerable<int>, IEnumerable<int>> ReadInt32Tuple7(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadInt32(count, prompt), ReadInt32(count, prompt), ReadInt32(count, prompt), ReadInt32(count, prompt), ReadInt32(count, prompt), ReadInt32(count, prompt), ReadInt32(count, prompt));
        }
 
        /// <summary>
        /// Читает 7 последовательностей типа UInt32 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<uint>, IEnumerable<uint>, IEnumerable<uint>, IEnumerable<uint>, IEnumerable<uint>, IEnumerable<uint>, IEnumerable<uint>> ReadUInt32Tuple7(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadUInt32(count, prompt), ReadUInt32(count, prompt), ReadUInt32(count, prompt), ReadUInt32(count, prompt), ReadUInt32(count, prompt), ReadUInt32(count, prompt), ReadUInt32(count, prompt));
        }
 
        /// <summary>
        /// Читает 7 последовательностей типа Int64 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<long>, IEnumerable<long>, IEnumerable<long>, IEnumerable<long>, IEnumerable<long>, IEnumerable<long>, IEnumerable<long>> ReadInt64Tuple7(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadInt64(count, prompt), ReadInt64(count, prompt), ReadInt64(count, prompt), ReadInt64(count, prompt), ReadInt64(count, prompt), ReadInt64(count, prompt), ReadInt64(count, prompt));
        }
 
        /// <summary>
        /// Читает 7 последовательностей типа UInt64 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<ulong>, IEnumerable<ulong>, IEnumerable<ulong>, IEnumerable<ulong>, IEnumerable<ulong>, IEnumerable<ulong>, IEnumerable<ulong>> ReadUInt64Tuple7(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadUInt64(count, prompt), ReadUInt64(count, prompt), ReadUInt64(count, prompt), ReadUInt64(count, prompt), ReadUInt64(count, prompt), ReadUInt64(count, prompt), ReadUInt64(count, prompt));
        }
 
        /// <summary>
        /// Читает 7 последовательностей типа Int16 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<short>, IEnumerable<short>, IEnumerable<short>, IEnumerable<short>, IEnumerable<short>, IEnumerable<short>, IEnumerable<short>> ReadInt16Tuple7(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadInt16(count, prompt), ReadInt16(count, prompt), ReadInt16(count, prompt), ReadInt16(count, prompt), ReadInt16(count, prompt), ReadInt16(count, prompt), ReadInt16(count, prompt));
        }
 
        /// <summary>
        /// Читает 7 последовательностей типа UInt16 с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<ushort>, IEnumerable<ushort>, IEnumerable<ushort>, IEnumerable<ushort>, IEnumerable<ushort>, IEnumerable<ushort>, IEnumerable<ushort>> ReadUInt16Tuple7(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadUInt16(count, prompt), ReadUInt16(count, prompt), ReadUInt16(count, prompt), ReadUInt16(count, prompt), ReadUInt16(count, prompt), ReadUInt16(count, prompt), ReadUInt16(count, prompt));
        }
 
        /// <summary>
        /// Читает 7 последовательностей типа BigInteger с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<BigInteger>, IEnumerable<BigInteger>, IEnumerable<BigInteger>, IEnumerable<BigInteger>, IEnumerable<BigInteger>, IEnumerable<BigInteger>, IEnumerable<BigInteger>> ReadBigIntegerTuple7(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadBigInteger(count, prompt), ReadBigInteger(count, prompt), ReadBigInteger(count, prompt), ReadBigInteger(count, prompt), ReadBigInteger(count, prompt), ReadBigInteger(count, prompt), ReadBigInteger(count, prompt));
        }
 
        /// <summary>
        /// Читает 7 последовательностей типа String с клавиатуры.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Последовательность.</returns>
        public static Tuple<IEnumerable<string>, IEnumerable<string>, IEnumerable<string>, IEnumerable<string>, IEnumerable<string>, IEnumerable<string>, IEnumerable<string>> ReadStringTuple7(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return Tuple.Of(ReadString(count, prompt), ReadString(count, prompt), ReadString(count, prompt), ReadString(count, prompt), ReadString(count, prompt), ReadString(count, prompt), ReadString(count, prompt));
        }
        
        #endregion
		
		#endregion
	
    }
}
