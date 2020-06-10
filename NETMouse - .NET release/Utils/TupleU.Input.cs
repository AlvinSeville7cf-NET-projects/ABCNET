using System;
using System.Numerics;

namespace ABCNET.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы с ссылочными кортежами.
    /// </summary>
    public static partial class TupleU
    {

        #region public

        /// <summary>
        /// Читает кортеж из двух значений типа BigInteger.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger, BigInteger> ReadBigIntegerTuple2(string prompt = null)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadBigInteger(string.Format(prompt, 0)),
                      BaseU.ReadBigInteger(string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа BigInteger.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger, BigInteger, BigInteger> ReadBigIntegerTuple3(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadBigInteger(string.Format(prompt, 0)),
                      BaseU.ReadBigInteger(string.Format(prompt, 1)),
                      BaseU.ReadBigInteger(string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа BigInteger.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger, BigInteger, BigInteger, BigInteger> ReadBigIntegerTuple4(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadBigInteger(string.Format(prompt, 0)),
                      BaseU.ReadBigInteger(string.Format(prompt, 1)),
                      BaseU.ReadBigInteger(string.Format(prompt, 2)),
                      BaseU.ReadBigInteger(string.Format(prompt, 3)));
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа BigInteger.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger, BigInteger, BigInteger, BigInteger, BigInteger> ReadBigIntegerTuple5(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadBigInteger(string.Format(prompt, 0)),
                      BaseU.ReadBigInteger(string.Format(prompt, 1)),
                      BaseU.ReadBigInteger(string.Format(prompt, 2)),
                      BaseU.ReadBigInteger(string.Format(prompt, 3)),
                      BaseU.ReadBigInteger(string.Format(prompt, 4)));
        }

        /// <summary>
        /// Читает кортеж из шести значений типа BigInteger.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger, BigInteger, BigInteger, BigInteger, BigInteger, BigInteger> ReadBigIntegerTuple6(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadBigInteger(string.Format(prompt, 0)),
                      BaseU.ReadBigInteger(string.Format(prompt, 1)),
                      BaseU.ReadBigInteger(string.Format(prompt, 2)),
                      BaseU.ReadBigInteger(string.Format(prompt, 3)),
                      BaseU.ReadBigInteger(string.Format(prompt, 4)),
                      BaseU.ReadBigInteger(string.Format(prompt, 5)));
        }

        /// <summary>
        /// Читает кортеж из семи значений типа BigInteger.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger, BigInteger, BigInteger, BigInteger, BigInteger, BigInteger, BigInteger> ReadBigIntegerTuple7(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadBigInteger(string.Format(prompt, 0)),
                      BaseU.ReadBigInteger(string.Format(prompt, 1)),
                      BaseU.ReadBigInteger(string.Format(prompt, 2)),
                      BaseU.ReadBigInteger(string.Format(prompt, 3)),
                      BaseU.ReadBigInteger(string.Format(prompt, 4)),
                      BaseU.ReadBigInteger(string.Format(prompt, 5)),
                      BaseU.ReadBigInteger(string.Format(prompt, 6)));
        }

        /// <summary>
        /// Читает кортеж из двух значений типа Boolean.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool, bool> ReadBooleanTuple2(string prompt = null)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadBoolean(string.Format(prompt, 0)),
                      BaseU.ReadBoolean(string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Boolean.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool, bool, bool> ReadBooleanTuple3(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadBoolean(string.Format(prompt, 0)),
                      BaseU.ReadBoolean(string.Format(prompt, 1)),
                      BaseU.ReadBoolean(string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Boolean.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool, bool, bool, bool> ReadBooleanTuple4(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadBoolean(string.Format(prompt, 0)),
                      BaseU.ReadBoolean(string.Format(prompt, 1)),
                      BaseU.ReadBoolean(string.Format(prompt, 2)),
                      BaseU.ReadBoolean(string.Format(prompt, 3)));
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Boolean.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool, bool, bool, bool, bool> ReadBooleanTuple5(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadBoolean(string.Format(prompt, 0)),
                      BaseU.ReadBoolean(string.Format(prompt, 1)),
                      BaseU.ReadBoolean(string.Format(prompt, 2)),
                      BaseU.ReadBoolean(string.Format(prompt, 3)),
                      BaseU.ReadBoolean(string.Format(prompt, 4)));
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Boolean.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool, bool, bool, bool, bool, bool> ReadBooleanTuple6(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadBoolean(string.Format(prompt, 0)),
                      BaseU.ReadBoolean(string.Format(prompt, 1)),
                      BaseU.ReadBoolean(string.Format(prompt, 2)),
                      BaseU.ReadBoolean(string.Format(prompt, 3)),
                      BaseU.ReadBoolean(string.Format(prompt, 4)),
                      BaseU.ReadBoolean(string.Format(prompt, 5)));
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Boolean.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool, bool, bool, bool, bool, bool, bool> ReadBooleanTuple7(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadBoolean(string.Format(prompt, 0)),
                      BaseU.ReadBoolean(string.Format(prompt, 1)),
                      BaseU.ReadBoolean(string.Format(prompt, 2)),
                      BaseU.ReadBoolean(string.Format(prompt, 3)),
                      BaseU.ReadBoolean(string.Format(prompt, 4)),
                      BaseU.ReadBoolean(string.Format(prompt, 5)),
                      BaseU.ReadBoolean(string.Format(prompt, 6)));
        }

        /// <summary>
        /// Читает кортеж из двух значений типа Byte.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte, byte> ReadByteTuple2(string prompt = null)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadByte(string.Format(prompt, 0)),
                      BaseU.ReadByte(string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Byte.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte, byte, byte> ReadByteTuple3(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadByte(string.Format(prompt, 0)),
                      BaseU.ReadByte(string.Format(prompt, 1)),
                      BaseU.ReadByte(string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Byte.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte, byte, byte, byte> ReadByteTuple4(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadByte(string.Format(prompt, 0)),
                      BaseU.ReadByte(string.Format(prompt, 1)),
                      BaseU.ReadByte(string.Format(prompt, 2)),
                      BaseU.ReadByte(string.Format(prompt, 3)));
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Byte.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte, byte, byte, byte, byte> ReadByteTuple5(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadByte(string.Format(prompt, 0)),
                      BaseU.ReadByte(string.Format(prompt, 1)),
                      BaseU.ReadByte(string.Format(prompt, 2)),
                      BaseU.ReadByte(string.Format(prompt, 3)),
                      BaseU.ReadByte(string.Format(prompt, 4)));
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Byte.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte, byte, byte, byte, byte, byte> ReadByteTuple6(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadByte(string.Format(prompt, 0)),
                      BaseU.ReadByte(string.Format(prompt, 1)),
                      BaseU.ReadByte(string.Format(prompt, 2)),
                      BaseU.ReadByte(string.Format(prompt, 3)),
                      BaseU.ReadByte(string.Format(prompt, 4)),
                      BaseU.ReadByte(string.Format(prompt, 5)));
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Byte.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte, byte, byte, byte, byte, byte, byte> ReadByteTuple7(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadByte(string.Format(prompt, 0)),
                      BaseU.ReadByte(string.Format(prompt, 1)),
                      BaseU.ReadByte(string.Format(prompt, 2)),
                      BaseU.ReadByte(string.Format(prompt, 3)),
                      BaseU.ReadByte(string.Format(prompt, 4)),
                      BaseU.ReadByte(string.Format(prompt, 5)),
                      BaseU.ReadByte(string.Format(prompt, 6)));
        }

        /// <summary>
        /// Читает кортеж из двух значений типа Char.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<char, char> ReadCharTuple2(string prompt = null)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadChar(string.Format(prompt, 0)),
                      BaseU.ReadChar(string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Char.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<char, char, char> ReadCharTuple3(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadChar(string.Format(prompt, 0)),
                      BaseU.ReadChar(string.Format(prompt, 1)),
                      BaseU.ReadChar(string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Char.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<char, char, char, char> ReadCharTuple4(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadChar(string.Format(prompt, 0)),
                      BaseU.ReadChar(string.Format(prompt, 1)),
                      BaseU.ReadChar(string.Format(prompt, 2)),
                      BaseU.ReadChar(string.Format(prompt, 3)));
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Char.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<char, char, char, char, char> ReadCharTuple5(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadChar(string.Format(prompt, 0)),
                      BaseU.ReadChar(string.Format(prompt, 1)),
                      BaseU.ReadChar(string.Format(prompt, 2)),
                      BaseU.ReadChar(string.Format(prompt, 3)),
                      BaseU.ReadChar(string.Format(prompt, 4)));
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Char.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<char, char, char, char, char, char> ReadCharTuple6(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadChar(string.Format(prompt, 0)),
                      BaseU.ReadChar(string.Format(prompt, 1)),
                      BaseU.ReadChar(string.Format(prompt, 2)),
                      BaseU.ReadChar(string.Format(prompt, 3)),
                      BaseU.ReadChar(string.Format(prompt, 4)),
                      BaseU.ReadChar(string.Format(prompt, 5)));
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Char.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<char, char, char, char, char, char, char> ReadCharTuple7(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadChar(string.Format(prompt, 0)),
                      BaseU.ReadChar(string.Format(prompt, 1)),
                      BaseU.ReadChar(string.Format(prompt, 2)),
                      BaseU.ReadChar(string.Format(prompt, 3)),
                      BaseU.ReadChar(string.Format(prompt, 4)),
                      BaseU.ReadChar(string.Format(prompt, 5)),
                      BaseU.ReadChar(string.Format(prompt, 6)));
        }

        /// <summary>
        /// Читает кортеж из двух значений типа Decimal.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal, decimal> ReadDecimalTuple2(string prompt = null)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadDecimal(string.Format(prompt, 0)),
                      BaseU.ReadDecimal(string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Decimal.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal, decimal, decimal> ReadDecimalTuple3(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadDecimal(string.Format(prompt, 0)),
                      BaseU.ReadDecimal(string.Format(prompt, 1)),
                      BaseU.ReadDecimal(string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Decimal.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal, decimal, decimal, decimal> ReadDecimalTuple4(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadDecimal(string.Format(prompt, 0)),
                      BaseU.ReadDecimal(string.Format(prompt, 1)),
                      BaseU.ReadDecimal(string.Format(prompt, 2)),
                      BaseU.ReadDecimal(string.Format(prompt, 3)));
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Decimal.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal, decimal, decimal, decimal, decimal> ReadDecimalTuple5(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadDecimal(string.Format(prompt, 0)),
                      BaseU.ReadDecimal(string.Format(prompt, 1)),
                      BaseU.ReadDecimal(string.Format(prompt, 2)),
                      BaseU.ReadDecimal(string.Format(prompt, 3)),
                      BaseU.ReadDecimal(string.Format(prompt, 4)));
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Decimal.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal, decimal, decimal, decimal, decimal, decimal> ReadDecimalTuple6(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadDecimal(string.Format(prompt, 0)),
                      BaseU.ReadDecimal(string.Format(prompt, 1)),
                      BaseU.ReadDecimal(string.Format(prompt, 2)),
                      BaseU.ReadDecimal(string.Format(prompt, 3)),
                      BaseU.ReadDecimal(string.Format(prompt, 4)),
                      BaseU.ReadDecimal(string.Format(prompt, 5)));
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Decimal.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal> ReadDecimalTuple7(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadDecimal(string.Format(prompt, 0)),
                      BaseU.ReadDecimal(string.Format(prompt, 1)),
                      BaseU.ReadDecimal(string.Format(prompt, 2)),
                      BaseU.ReadDecimal(string.Format(prompt, 3)),
                      BaseU.ReadDecimal(string.Format(prompt, 4)),
                      BaseU.ReadDecimal(string.Format(prompt, 5)),
                      BaseU.ReadDecimal(string.Format(prompt, 6)));
        }

        /// <summary>
        /// Читает кортеж из двух значений типа Double.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double> ReadDoubleTuple2(string prompt = null)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadDouble(string.Format(prompt, 0)),
                      BaseU.ReadDouble(string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Double.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double, double> ReadDoubleTuple3(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadDouble(string.Format(prompt, 0)),
                      BaseU.ReadDouble(string.Format(prompt, 1)),
                      BaseU.ReadDouble(string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Double.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double, double, double> ReadDoubleTuple4(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadDouble(string.Format(prompt, 0)),
                      BaseU.ReadDouble(string.Format(prompt, 1)),
                      BaseU.ReadDouble(string.Format(prompt, 2)),
                      BaseU.ReadDouble(string.Format(prompt, 3)));
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Double.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double, double, double, double> ReadDoubleTuple5(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadDouble(string.Format(prompt, 0)),
                      BaseU.ReadDouble(string.Format(prompt, 1)),
                      BaseU.ReadDouble(string.Format(prompt, 2)),
                      BaseU.ReadDouble(string.Format(prompt, 3)),
                      BaseU.ReadDouble(string.Format(prompt, 4)));
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Double.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double, double, double, double, double> ReadDoubleTuple6(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadDouble(string.Format(prompt, 0)),
                      BaseU.ReadDouble(string.Format(prompt, 1)),
                      BaseU.ReadDouble(string.Format(prompt, 2)),
                      BaseU.ReadDouble(string.Format(prompt, 3)),
                      BaseU.ReadDouble(string.Format(prompt, 4)),
                      BaseU.ReadDouble(string.Format(prompt, 5)));
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Double.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double, double, double, double, double, double> ReadDoubleTuple7(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadDouble(string.Format(prompt, 0)),
                      BaseU.ReadDouble(string.Format(prompt, 1)),
                      BaseU.ReadDouble(string.Format(prompt, 2)),
                      BaseU.ReadDouble(string.Format(prompt, 3)),
                      BaseU.ReadDouble(string.Format(prompt, 4)),
                      BaseU.ReadDouble(string.Format(prompt, 5)),
                      BaseU.ReadDouble(string.Format(prompt, 6)));
        }

        /// <summary>
        /// Читает кортеж из двух значений типа Int16.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<short, short> ReadInt16Tuple2(string prompt = null)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadInt16(string.Format(prompt, 0)),
                      BaseU.ReadInt16(string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Int16.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<short, short, short> ReadInt16Tuple3(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadInt16(string.Format(prompt, 0)),
                      BaseU.ReadInt16(string.Format(prompt, 1)),
                      BaseU.ReadInt16(string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Int16.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<short, short, short, short> ReadInt16Tuple4(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadInt16(string.Format(prompt, 0)),
                      BaseU.ReadInt16(string.Format(prompt, 1)),
                      BaseU.ReadInt16(string.Format(prompt, 2)),
                      BaseU.ReadInt16(string.Format(prompt, 3)));
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Int16.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<short, short, short, short, short> ReadInt16Tuple5(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadInt16(string.Format(prompt, 0)),
                      BaseU.ReadInt16(string.Format(prompt, 1)),
                      BaseU.ReadInt16(string.Format(prompt, 2)),
                      BaseU.ReadInt16(string.Format(prompt, 3)),
                      BaseU.ReadInt16(string.Format(prompt, 4)));
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Int16.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<short, short, short, short, short, short> ReadInt16Tuple6(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadInt16(string.Format(prompt, 0)),
                      BaseU.ReadInt16(string.Format(prompt, 1)),
                      BaseU.ReadInt16(string.Format(prompt, 2)),
                      BaseU.ReadInt16(string.Format(prompt, 3)),
                      BaseU.ReadInt16(string.Format(prompt, 4)),
                      BaseU.ReadInt16(string.Format(prompt, 5)));
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Int16.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<short, short, short, short, short, short, short> ReadInt16Tuple7(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadInt16(string.Format(prompt, 0)),
                      BaseU.ReadInt16(string.Format(prompt, 1)),
                      BaseU.ReadInt16(string.Format(prompt, 2)),
                      BaseU.ReadInt16(string.Format(prompt, 3)),
                      BaseU.ReadInt16(string.Format(prompt, 4)),
                      BaseU.ReadInt16(string.Format(prompt, 5)),
                      BaseU.ReadInt16(string.Format(prompt, 6)));
        }

        /// <summary>
        /// Читает кортеж из двух значений типа Int32.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int> ReadInt32Tuple2(string prompt = null)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadInt32(string.Format(prompt, 0)),
                      BaseU.ReadInt32(string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Int32.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int, int> ReadInt32Tuple3(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadInt32(string.Format(prompt, 0)),
                      BaseU.ReadInt32(string.Format(prompt, 1)),
                      BaseU.ReadInt32(string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Int32.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int, int, int> ReadInt32Tuple4(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadInt32(string.Format(prompt, 0)),
                      BaseU.ReadInt32(string.Format(prompt, 1)),
                      BaseU.ReadInt32(string.Format(prompt, 2)),
                      BaseU.ReadInt32(string.Format(prompt, 3)));
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Int32.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int, int, int, int> ReadInt32Tuple5(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadInt32(string.Format(prompt, 0)),
                      BaseU.ReadInt32(string.Format(prompt, 1)),
                      BaseU.ReadInt32(string.Format(prompt, 2)),
                      BaseU.ReadInt32(string.Format(prompt, 3)),
                      BaseU.ReadInt32(string.Format(prompt, 4)));
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Int32.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int, int, int, int, int> ReadInt32Tuple6(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadInt32(string.Format(prompt, 0)),
                      BaseU.ReadInt32(string.Format(prompt, 1)),
                      BaseU.ReadInt32(string.Format(prompt, 2)),
                      BaseU.ReadInt32(string.Format(prompt, 3)),
                      BaseU.ReadInt32(string.Format(prompt, 4)),
                      BaseU.ReadInt32(string.Format(prompt, 5)));
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Int32.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int, int, int, int, int, int> ReadInt32Tuple7(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadInt32(string.Format(prompt, 0)),
                      BaseU.ReadInt32(string.Format(prompt, 1)),
                      BaseU.ReadInt32(string.Format(prompt, 2)),
                      BaseU.ReadInt32(string.Format(prompt, 3)),
                      BaseU.ReadInt32(string.Format(prompt, 4)),
                      BaseU.ReadInt32(string.Format(prompt, 5)),
                      BaseU.ReadInt32(string.Format(prompt, 6)));
        }

        /// <summary>
        /// Читает кортеж из двух значений типа Int64.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<long, long> ReadInt64Tuple2(string prompt = null)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadInt64(string.Format(prompt, 0)),
                      BaseU.ReadInt64(string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Int64.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<long, long, long> ReadInt64Tuple3(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadInt64(string.Format(prompt, 0)),
                      BaseU.ReadInt64(string.Format(prompt, 1)),
                      BaseU.ReadInt64(string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Int64.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<long, long, long, long> ReadInt64Tuple4(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadInt64(string.Format(prompt, 0)),
                      BaseU.ReadInt64(string.Format(prompt, 1)),
                      BaseU.ReadInt64(string.Format(prompt, 2)),
                      BaseU.ReadInt64(string.Format(prompt, 3)));
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Int64.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<long, long, long, long, long> ReadInt64Tuple5(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadInt64(string.Format(prompt, 0)),
                      BaseU.ReadInt64(string.Format(prompt, 1)),
                      BaseU.ReadInt64(string.Format(prompt, 2)),
                      BaseU.ReadInt64(string.Format(prompt, 3)),
                      BaseU.ReadInt64(string.Format(prompt, 4)));
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Int64.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<long, long, long, long, long, long> ReadInt64Tuple6(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadInt64(string.Format(prompt, 0)),
                      BaseU.ReadInt64(string.Format(prompt, 1)),
                      BaseU.ReadInt64(string.Format(prompt, 2)),
                      BaseU.ReadInt64(string.Format(prompt, 3)),
                      BaseU.ReadInt64(string.Format(prompt, 4)),
                      BaseU.ReadInt64(string.Format(prompt, 5)));
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Int64.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<long, long, long, long, long, long, long> ReadInt64Tuple7(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadInt64(string.Format(prompt, 0)),
                      BaseU.ReadInt64(string.Format(prompt, 1)),
                      BaseU.ReadInt64(string.Format(prompt, 2)),
                      BaseU.ReadInt64(string.Format(prompt, 3)),
                      BaseU.ReadInt64(string.Format(prompt, 4)),
                      BaseU.ReadInt64(string.Format(prompt, 5)),
                      BaseU.ReadInt64(string.Format(prompt, 6)));
        }

        /// <summary>
        /// Читает кортеж из двух значений типа SByte.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte, sbyte> ReadSByteTuple2(string prompt = null)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadSByte(string.Format(prompt, 0)),
                      BaseU.ReadSByte(string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа SByte.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte, sbyte, sbyte> ReadSByteTuple3(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadSByte(string.Format(prompt, 0)),
                      BaseU.ReadSByte(string.Format(prompt, 1)),
                      BaseU.ReadSByte(string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа SByte.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte, sbyte, sbyte, sbyte> ReadSByteTuple4(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadSByte(string.Format(prompt, 0)),
                      BaseU.ReadSByte(string.Format(prompt, 1)),
                      BaseU.ReadSByte(string.Format(prompt, 2)),
                      BaseU.ReadSByte(string.Format(prompt, 3)));
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа SByte.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte, sbyte, sbyte, sbyte, sbyte> ReadSByteTuple5(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadSByte(string.Format(prompt, 0)),
                      BaseU.ReadSByte(string.Format(prompt, 1)),
                      BaseU.ReadSByte(string.Format(prompt, 2)),
                      BaseU.ReadSByte(string.Format(prompt, 3)),
                      BaseU.ReadSByte(string.Format(prompt, 4)));
        }

        /// <summary>
        /// Читает кортеж из шести значений типа SByte.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte, sbyte, sbyte, sbyte, sbyte, sbyte> ReadSByteTuple6(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadSByte(string.Format(prompt, 0)),
                      BaseU.ReadSByte(string.Format(prompt, 1)),
                      BaseU.ReadSByte(string.Format(prompt, 2)),
                      BaseU.ReadSByte(string.Format(prompt, 3)),
                      BaseU.ReadSByte(string.Format(prompt, 4)),
                      BaseU.ReadSByte(string.Format(prompt, 5)));
        }

        /// <summary>
        /// Читает кортеж из семи значений типа SByte.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte, sbyte, sbyte, sbyte, sbyte, sbyte, sbyte> ReadSByteTuple7(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadSByte(string.Format(prompt, 0)),
                      BaseU.ReadSByte(string.Format(prompt, 1)),
                      BaseU.ReadSByte(string.Format(prompt, 2)),
                      BaseU.ReadSByte(string.Format(prompt, 3)),
                      BaseU.ReadSByte(string.Format(prompt, 4)),
                      BaseU.ReadSByte(string.Format(prompt, 5)),
                      BaseU.ReadSByte(string.Format(prompt, 6)));
        }

        /// <summary>
        /// Читает кортеж из двух значений типа Single.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<float, float> ReadSingleTuple2(string prompt = null)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadSingle(string.Format(prompt, 0)),
                      BaseU.ReadSingle(string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Single.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<float, float, float> ReadSingleTuple3(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadSingle(string.Format(prompt, 0)),
                      BaseU.ReadSingle(string.Format(prompt, 1)),
                      BaseU.ReadSingle(string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Single.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<float, float, float, float> ReadSingleTuple4(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadSingle(string.Format(prompt, 0)),
                      BaseU.ReadSingle(string.Format(prompt, 1)),
                      BaseU.ReadSingle(string.Format(prompt, 2)),
                      BaseU.ReadSingle(string.Format(prompt, 3)));
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Single.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<float, float, float, float, float> ReadSingleTuple5(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadSingle(string.Format(prompt, 0)),
                      BaseU.ReadSingle(string.Format(prompt, 1)),
                      BaseU.ReadSingle(string.Format(prompt, 2)),
                      BaseU.ReadSingle(string.Format(prompt, 3)),
                      BaseU.ReadSingle(string.Format(prompt, 4)));
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Single.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<float, float, float, float, float, float> ReadSingleTuple6(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadSingle(string.Format(prompt, 0)),
                      BaseU.ReadSingle(string.Format(prompt, 1)),
                      BaseU.ReadSingle(string.Format(prompt, 2)),
                      BaseU.ReadSingle(string.Format(prompt, 3)),
                      BaseU.ReadSingle(string.Format(prompt, 4)),
                      BaseU.ReadSingle(string.Format(prompt, 5)));
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Single.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<float, float, float, float, float, float, float> ReadSingleTuple7(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadSingle(string.Format(prompt, 0)),
                      BaseU.ReadSingle(string.Format(prompt, 1)),
                      BaseU.ReadSingle(string.Format(prompt, 2)),
                      BaseU.ReadSingle(string.Format(prompt, 3)),
                      BaseU.ReadSingle(string.Format(prompt, 4)),
                      BaseU.ReadSingle(string.Format(prompt, 5)),
                      BaseU.ReadSingle(string.Format(prompt, 6)));
        }

        /// <summary>
        /// Читает кортеж из двух значений типа String.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<string, string> ReadStringTuple2(string prompt = null)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadString(string.Format(prompt, 0)),
                      BaseU.ReadString(string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа String.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<string, string, string> ReadStringTuple3(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadString(string.Format(prompt, 0)),
                      BaseU.ReadString(string.Format(prompt, 1)),
                      BaseU.ReadString(string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа String.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<string, string, string, string> ReadStringTuple4(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadString(string.Format(prompt, 0)),
                      BaseU.ReadString(string.Format(prompt, 1)),
                      BaseU.ReadString(string.Format(prompt, 2)),
                      BaseU.ReadString(string.Format(prompt, 3)));
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа String.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<string, string, string, string, string> ReadStringTuple5(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadString(string.Format(prompt, 0)),
                      BaseU.ReadString(string.Format(prompt, 1)),
                      BaseU.ReadString(string.Format(prompt, 2)),
                      BaseU.ReadString(string.Format(prompt, 3)),
                      BaseU.ReadString(string.Format(prompt, 4)));
        }

        /// <summary>
        /// Читает кортеж из шести значений типа String.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<string, string, string, string, string, string> ReadStringTuple6(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadString(string.Format(prompt, 0)),
                      BaseU.ReadString(string.Format(prompt, 1)),
                      BaseU.ReadString(string.Format(prompt, 2)),
                      BaseU.ReadString(string.Format(prompt, 3)),
                      BaseU.ReadString(string.Format(prompt, 4)),
                      BaseU.ReadString(string.Format(prompt, 5)));
        }

        /// <summary>
        /// Читает кортеж из семи значений типа String.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<string, string, string, string, string, string, string> ReadStringTuple7(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadString(string.Format(prompt, 0)),
                      BaseU.ReadString(string.Format(prompt, 1)),
                      BaseU.ReadString(string.Format(prompt, 2)),
                      BaseU.ReadString(string.Format(prompt, 3)),
                      BaseU.ReadString(string.Format(prompt, 4)),
                      BaseU.ReadString(string.Format(prompt, 5)),
                      BaseU.ReadString(string.Format(prompt, 6)));
        }

        /// <summary>
        /// Читает кортеж из двух значений типа UInt16.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort, ushort> ReadUInt16Tuple2(string prompt = null)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadUInt16(string.Format(prompt, 0)),
                      BaseU.ReadUInt16(string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа UInt16.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort, ushort, ushort> ReadUInt16Tuple3(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadUInt16(string.Format(prompt, 0)),
                      BaseU.ReadUInt16(string.Format(prompt, 1)),
                      BaseU.ReadUInt16(string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа UInt16.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort, ushort, ushort, ushort> ReadUInt16Tuple4(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadUInt16(string.Format(prompt, 0)),
                      BaseU.ReadUInt16(string.Format(prompt, 1)),
                      BaseU.ReadUInt16(string.Format(prompt, 2)),
                      BaseU.ReadUInt16(string.Format(prompt, 3)));
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа UInt16.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort, ushort, ushort, ushort, ushort> ReadUInt16Tuple5(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadUInt16(string.Format(prompt, 0)),
                      BaseU.ReadUInt16(string.Format(prompt, 1)),
                      BaseU.ReadUInt16(string.Format(prompt, 2)),
                      BaseU.ReadUInt16(string.Format(prompt, 3)),
                      BaseU.ReadUInt16(string.Format(prompt, 4)));
        }

        /// <summary>
        /// Читает кортеж из шести значений типа UInt16.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort, ushort, ushort, ushort, ushort, ushort> ReadUInt16Tuple6(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadUInt16(string.Format(prompt, 0)),
                      BaseU.ReadUInt16(string.Format(prompt, 1)),
                      BaseU.ReadUInt16(string.Format(prompt, 2)),
                      BaseU.ReadUInt16(string.Format(prompt, 3)),
                      BaseU.ReadUInt16(string.Format(prompt, 4)),
                      BaseU.ReadUInt16(string.Format(prompt, 5)));
        }

        /// <summary>
        /// Читает кортеж из семи значений типа UInt16.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort, ushort, ushort, ushort, ushort, ushort, ushort> ReadUInt16Tuple7(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadUInt16(string.Format(prompt, 0)),
                      BaseU.ReadUInt16(string.Format(prompt, 1)),
                      BaseU.ReadUInt16(string.Format(prompt, 2)),
                      BaseU.ReadUInt16(string.Format(prompt, 3)),
                      BaseU.ReadUInt16(string.Format(prompt, 4)),
                      BaseU.ReadUInt16(string.Format(prompt, 5)),
                      BaseU.ReadUInt16(string.Format(prompt, 6)));
        }

        /// <summary>
        /// Читает кортеж из двух значений типа UInt32.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint, uint> ReadUInt32Tuple2(string prompt = null)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadUInt32(string.Format(prompt, 0)),
                      BaseU.ReadUInt32(string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа UInt32.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint, uint, uint> ReadUInt32Tuple3(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadUInt32(string.Format(prompt, 0)),
                      BaseU.ReadUInt32(string.Format(prompt, 1)),
                      BaseU.ReadUInt32(string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа UInt32.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint, uint, uint, uint> ReadUInt32Tuple4(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadUInt32(string.Format(prompt, 0)),
                      BaseU.ReadUInt32(string.Format(prompt, 1)),
                      BaseU.ReadUInt32(string.Format(prompt, 2)),
                      BaseU.ReadUInt32(string.Format(prompt, 3)));
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа UInt32.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint, uint, uint, uint, uint> ReadUInt32Tuple5(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadUInt32(string.Format(prompt, 0)),
                      BaseU.ReadUInt32(string.Format(prompt, 1)),
                      BaseU.ReadUInt32(string.Format(prompt, 2)),
                      BaseU.ReadUInt32(string.Format(prompt, 3)),
                      BaseU.ReadUInt32(string.Format(prompt, 4)));
        }

        /// <summary>
        /// Читает кортеж из шести значений типа UInt32.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint, uint, uint, uint, uint, uint> ReadUInt32Tuple6(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadUInt32(string.Format(prompt, 0)),
                      BaseU.ReadUInt32(string.Format(prompt, 1)),
                      BaseU.ReadUInt32(string.Format(prompt, 2)),
                      BaseU.ReadUInt32(string.Format(prompt, 3)),
                      BaseU.ReadUInt32(string.Format(prompt, 4)),
                      BaseU.ReadUInt32(string.Format(prompt, 5)));
        }

        /// <summary>
        /// Читает кортеж из семи значений типа UInt32.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint, uint, uint, uint, uint, uint, uint> ReadUInt32Tuple7(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadUInt32(string.Format(prompt, 0)),
                      BaseU.ReadUInt32(string.Format(prompt, 1)),
                      BaseU.ReadUInt32(string.Format(prompt, 2)),
                      BaseU.ReadUInt32(string.Format(prompt, 3)),
                      BaseU.ReadUInt32(string.Format(prompt, 4)),
                      BaseU.ReadUInt32(string.Format(prompt, 5)),
                      BaseU.ReadUInt32(string.Format(prompt, 6)));
        }

        /// <summary>
        /// Читает кортеж из двух значений типа UInt64.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong, ulong> ReadUInt64Tuple2(string prompt = null)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadUInt64(string.Format(prompt, 0)),
                      BaseU.ReadUInt64(string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа UInt64.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong, ulong, ulong> ReadUInt64Tuple3(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadUInt64(string.Format(prompt, 0)),
                      BaseU.ReadUInt64(string.Format(prompt, 1)),
                      BaseU.ReadUInt64(string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа UInt64.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong, ulong, ulong, ulong> ReadUInt64Tuple4(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadUInt64(string.Format(prompt, 0)),
                      BaseU.ReadUInt64(string.Format(prompt, 1)),
                      BaseU.ReadUInt64(string.Format(prompt, 2)),
                      BaseU.ReadUInt64(string.Format(prompt, 3)));
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа UInt64.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong, ulong, ulong, ulong, ulong> ReadUInt64Tuple5(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadUInt64(string.Format(prompt, 0)),
                      BaseU.ReadUInt64(string.Format(prompt, 1)),
                      BaseU.ReadUInt64(string.Format(prompt, 2)),
                      BaseU.ReadUInt64(string.Format(prompt, 3)),
                      BaseU.ReadUInt64(string.Format(prompt, 4)));
        }

        /// <summary>
        /// Читает кортеж из шести значений типа UInt64.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong, ulong, ulong, ulong, ulong, ulong> ReadUInt64Tuple6(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadUInt64(string.Format(prompt, 0)),
                      BaseU.ReadUInt64(string.Format(prompt, 1)),
                      BaseU.ReadUInt64(string.Format(prompt, 2)),
                      BaseU.ReadUInt64(string.Format(prompt, 3)),
                      BaseU.ReadUInt64(string.Format(prompt, 4)),
                      BaseU.ReadUInt64(string.Format(prompt, 5)));
        }

        /// <summary>
        /// Читает кортеж из семи значений типа UInt64.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong, ulong, ulong, ulong, ulong, ulong, ulong> ReadUInt64Tuple7(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(BaseU.ReadUInt64(string.Format(prompt, 0)),
                      BaseU.ReadUInt64(string.Format(prompt, 1)),
                      BaseU.ReadUInt64(string.Format(prompt, 2)),
                      BaseU.ReadUInt64(string.Format(prompt, 3)),
                      BaseU.ReadUInt64(string.Format(prompt, 4)),
                      BaseU.ReadUInt64(string.Format(prompt, 5)),
                      BaseU.ReadUInt64(string.Format(prompt, 6)));
        }

        #endregion public

    }
}