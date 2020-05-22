using System;
using System.Numerics;

namespace ABCNET.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы с ссылочными кортежами.
    /// </summary>
    public static partial class Tuple
    {

        #region public

        #region ReadBoolean

        /// <summary>
        /// Читает кортеж из двух значений типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool, bool> ReadBooleanTuple2(string prompt = null)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadBoolean(string.Format(prompt, 0)),
                      Base.ReadBoolean(string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool, bool, bool> ReadBooleanTuple3(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadBoolean(string.Format(prompt, 0)),
                      Base.ReadBoolean(string.Format(prompt, 1)),
                      Base.ReadBoolean(string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool, bool, bool, bool> ReadBooleanTuple4(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadBoolean(string.Format(prompt, 0)),
                      Base.ReadBoolean(string.Format(prompt, 1)),
                      Base.ReadBoolean(string.Format(prompt, 2)),
                      Base.ReadBoolean(string.Format(prompt, 3)));
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool, bool, bool, bool, bool> ReadBooleanTuple5(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadBoolean(string.Format(prompt, 0)),
                      Base.ReadBoolean(string.Format(prompt, 1)),
                      Base.ReadBoolean(string.Format(prompt, 2)),
                      Base.ReadBoolean(string.Format(prompt, 3)),
                      Base.ReadBoolean(string.Format(prompt, 4)));
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool, bool, bool, bool, bool, bool> ReadBooleanTuple6(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadBoolean(string.Format(prompt, 0)),
                      Base.ReadBoolean(string.Format(prompt, 1)),
                      Base.ReadBoolean(string.Format(prompt, 2)),
                      Base.ReadBoolean(string.Format(prompt, 3)),
                      Base.ReadBoolean(string.Format(prompt, 4)),
                      Base.ReadBoolean(string.Format(prompt, 5)));
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool, bool, bool, bool, bool, bool, bool> ReadBooleanTuple7(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadBoolean(string.Format(prompt, 0)),
                      Base.ReadBoolean(string.Format(prompt, 1)),
                      Base.ReadBoolean(string.Format(prompt, 2)),
                      Base.ReadBoolean(string.Format(prompt, 3)),
                      Base.ReadBoolean(string.Format(prompt, 4)),
                      Base.ReadBoolean(string.Format(prompt, 5)),
                      Base.ReadBoolean(string.Format(prompt, 6)));
        }

        #endregion

        #region ReadByte

        /// <summary>
        /// Читает кортеж из двух значений типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte, byte> ReadByteTuple2(string prompt = null)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadByte(string.Format(prompt, 0)),
                      Base.ReadByte(string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte, byte, byte> ReadByteTuple3(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadByte(string.Format(prompt, 0)),
                      Base.ReadByte(string.Format(prompt, 1)),
                      Base.ReadByte(string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte, byte, byte, byte> ReadByteTuple4(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadByte(string.Format(prompt, 0)),
                      Base.ReadByte(string.Format(prompt, 1)),
                      Base.ReadByte(string.Format(prompt, 2)),
                      Base.ReadByte(string.Format(prompt, 3)));
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte, byte, byte, byte, byte> ReadByteTuple5(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadByte(string.Format(prompt, 0)),
                      Base.ReadByte(string.Format(prompt, 1)),
                      Base.ReadByte(string.Format(prompt, 2)),
                      Base.ReadByte(string.Format(prompt, 3)),
                      Base.ReadByte(string.Format(prompt, 4)));
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte, byte, byte, byte, byte, byte> ReadByteTuple6(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadByte(string.Format(prompt, 0)),
                      Base.ReadByte(string.Format(prompt, 1)),
                      Base.ReadByte(string.Format(prompt, 2)),
                      Base.ReadByte(string.Format(prompt, 3)),
                      Base.ReadByte(string.Format(prompt, 4)),
                      Base.ReadByte(string.Format(prompt, 5)));
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte, byte, byte, byte, byte, byte, byte> ReadByteTuple7(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadByte(string.Format(prompt, 0)),
                      Base.ReadByte(string.Format(prompt, 1)),
                      Base.ReadByte(string.Format(prompt, 2)),
                      Base.ReadByte(string.Format(prompt, 3)),
                      Base.ReadByte(string.Format(prompt, 4)),
                      Base.ReadByte(string.Format(prompt, 5)),
                      Base.ReadByte(string.Format(prompt, 6)));
        }

        #endregion

        #region ReadSByte

        /// <summary>
        /// Читает кортеж из двух значений типа SByte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte, sbyte> ReadSByteTuple2(string prompt = null)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadSByte(string.Format(prompt, 0)),
                      Base.ReadSByte(string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа SByte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte, sbyte, sbyte> ReadSByteTuple3(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadSByte(string.Format(prompt, 0)),
                      Base.ReadSByte(string.Format(prompt, 1)),
                      Base.ReadSByte(string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа SByte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte, sbyte, sbyte, sbyte> ReadSByteTuple4(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadSByte(string.Format(prompt, 0)),
                      Base.ReadSByte(string.Format(prompt, 1)),
                      Base.ReadSByte(string.Format(prompt, 2)),
                      Base.ReadSByte(string.Format(prompt, 3)));
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа SByte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte, sbyte, sbyte, sbyte, sbyte> ReadSByteTuple5(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadSByte(string.Format(prompt, 0)),
                      Base.ReadSByte(string.Format(prompt, 1)),
                      Base.ReadSByte(string.Format(prompt, 2)),
                      Base.ReadSByte(string.Format(prompt, 3)),
                      Base.ReadSByte(string.Format(prompt, 4)));
        }

        /// <summary>
        /// Читает кортеж из шести значений типа SByte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte, sbyte, sbyte, sbyte, sbyte, sbyte> ReadSByteTuple6(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadSByte(string.Format(prompt, 0)),
                      Base.ReadSByte(string.Format(prompt, 1)),
                      Base.ReadSByte(string.Format(prompt, 2)),
                      Base.ReadSByte(string.Format(prompt, 3)),
                      Base.ReadSByte(string.Format(prompt, 4)),
                      Base.ReadSByte(string.Format(prompt, 5)));
        }

        /// <summary>
        /// Читает кортеж из семи значений типа SByte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte, sbyte, sbyte, sbyte, sbyte, sbyte, sbyte> ReadSByteTuple7(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadSByte(string.Format(prompt, 0)),
                      Base.ReadSByte(string.Format(prompt, 1)),
                      Base.ReadSByte(string.Format(prompt, 2)),
                      Base.ReadSByte(string.Format(prompt, 3)),
                      Base.ReadSByte(string.Format(prompt, 4)),
                      Base.ReadSByte(string.Format(prompt, 5)),
                      Base.ReadSByte(string.Format(prompt, 6)));
        }

        #endregion

        #region ReadChar

        /// <summary>
        /// Читает кортеж из двух значений типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<char, char> ReadCharTuple2(string prompt = null)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadChar(string.Format(prompt, 0)),
                      Base.ReadChar(string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<char, char, char> ReadCharTuple3(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadChar(string.Format(prompt, 0)),
                      Base.ReadChar(string.Format(prompt, 1)),
                      Base.ReadChar(string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<char, char, char, char> ReadCharTuple4(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadChar(string.Format(prompt, 0)),
                      Base.ReadChar(string.Format(prompt, 1)),
                      Base.ReadChar(string.Format(prompt, 2)),
                      Base.ReadChar(string.Format(prompt, 3)));
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<char, char, char, char, char> ReadCharTuple5(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadChar(string.Format(prompt, 0)),
                      Base.ReadChar(string.Format(prompt, 1)),
                      Base.ReadChar(string.Format(prompt, 2)),
                      Base.ReadChar(string.Format(prompt, 3)),
                      Base.ReadChar(string.Format(prompt, 4)));
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<char, char, char, char, char, char> ReadCharTuple6(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadChar(string.Format(prompt, 0)),
                      Base.ReadChar(string.Format(prompt, 1)),
                      Base.ReadChar(string.Format(prompt, 2)),
                      Base.ReadChar(string.Format(prompt, 3)),
                      Base.ReadChar(string.Format(prompt, 4)),
                      Base.ReadChar(string.Format(prompt, 5)));
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<char, char, char, char, char, char, char> ReadCharTuple7(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadChar(string.Format(prompt, 0)),
                      Base.ReadChar(string.Format(prompt, 1)),
                      Base.ReadChar(string.Format(prompt, 2)),
                      Base.ReadChar(string.Format(prompt, 3)),
                      Base.ReadChar(string.Format(prompt, 4)),
                      Base.ReadChar(string.Format(prompt, 5)),
                      Base.ReadChar(string.Format(prompt, 6)));
        }

        #endregion

        #region ReadDecimal

        /// <summary>
        /// Читает кортеж из двух значений типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal, decimal> ReadDecimalTuple2(string prompt = null)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadDecimal(string.Format(prompt, 0)),
                      Base.ReadDecimal(string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal, decimal, decimal> ReadDecimalTuple3(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadDecimal(string.Format(prompt, 0)),
                      Base.ReadDecimal(string.Format(prompt, 1)),
                      Base.ReadDecimal(string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal, decimal, decimal, decimal> ReadDecimalTuple4(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadDecimal(string.Format(prompt, 0)),
                      Base.ReadDecimal(string.Format(prompt, 1)),
                      Base.ReadDecimal(string.Format(prompt, 2)),
                      Base.ReadDecimal(string.Format(prompt, 3)));
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal, decimal, decimal, decimal, decimal> ReadDecimalTuple5(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadDecimal(string.Format(prompt, 0)),
                      Base.ReadDecimal(string.Format(prompt, 1)),
                      Base.ReadDecimal(string.Format(prompt, 2)),
                      Base.ReadDecimal(string.Format(prompt, 3)),
                      Base.ReadDecimal(string.Format(prompt, 4)));
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal, decimal, decimal, decimal, decimal, decimal> ReadDecimalTuple6(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadDecimal(string.Format(prompt, 0)),
                      Base.ReadDecimal(string.Format(prompt, 1)),
                      Base.ReadDecimal(string.Format(prompt, 2)),
                      Base.ReadDecimal(string.Format(prompt, 3)),
                      Base.ReadDecimal(string.Format(prompt, 4)),
                      Base.ReadDecimal(string.Format(prompt, 5)));
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal> ReadDecimalTuple7(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadDecimal(string.Format(prompt, 0)),
                      Base.ReadDecimal(string.Format(prompt, 1)),
                      Base.ReadDecimal(string.Format(prompt, 2)),
                      Base.ReadDecimal(string.Format(prompt, 3)),
                      Base.ReadDecimal(string.Format(prompt, 4)),
                      Base.ReadDecimal(string.Format(prompt, 5)),
                      Base.ReadDecimal(string.Format(prompt, 6)));
        }

        #endregion

        #region ReadDouble

        /// <summary>
        /// Читает кортеж из двух значений типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double> ReadDoubleTuple2(string prompt = null)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadDouble(string.Format(prompt, 0)),
                      Base.ReadDouble(string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double, double> ReadDoubleTuple3(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadDouble(string.Format(prompt, 0)),
                      Base.ReadDouble(string.Format(prompt, 1)),
                      Base.ReadDouble(string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double, double, double> ReadDoubleTuple4(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadDouble(string.Format(prompt, 0)),
                      Base.ReadDouble(string.Format(prompt, 1)),
                      Base.ReadDouble(string.Format(prompt, 2)),
                      Base.ReadDouble(string.Format(prompt, 3)));
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double, double, double, double> ReadDoubleTuple5(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadDouble(string.Format(prompt, 0)),
                      Base.ReadDouble(string.Format(prompt, 1)),
                      Base.ReadDouble(string.Format(prompt, 2)),
                      Base.ReadDouble(string.Format(prompt, 3)),
                      Base.ReadDouble(string.Format(prompt, 4)));
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double, double, double, double, double> ReadDoubleTuple6(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadDouble(string.Format(prompt, 0)),
                      Base.ReadDouble(string.Format(prompt, 1)),
                      Base.ReadDouble(string.Format(prompt, 2)),
                      Base.ReadDouble(string.Format(prompt, 3)),
                      Base.ReadDouble(string.Format(prompt, 4)),
                      Base.ReadDouble(string.Format(prompt, 5)));
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double, double, double, double, double, double> ReadDoubleTuple7(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadDouble(string.Format(prompt, 0)),
                      Base.ReadDouble(string.Format(prompt, 1)),
                      Base.ReadDouble(string.Format(prompt, 2)),
                      Base.ReadDouble(string.Format(prompt, 3)),
                      Base.ReadDouble(string.Format(prompt, 4)),
                      Base.ReadDouble(string.Format(prompt, 5)),
                      Base.ReadDouble(string.Format(prompt, 6)));
        }

        #endregion

        #region ReadSingle

        /// <summary>
        /// Читает кортеж из двух значений типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<float, float> ReadSingleTuple2(string prompt = null)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadSingle(string.Format(prompt, 0)),
                      Base.ReadSingle(string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<float, float, float> ReadSingleTuple3(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadSingle(string.Format(prompt, 0)),
                      Base.ReadSingle(string.Format(prompt, 1)),
                      Base.ReadSingle(string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<float, float, float, float> ReadSingleTuple4(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadSingle(string.Format(prompt, 0)),
                      Base.ReadSingle(string.Format(prompt, 1)),
                      Base.ReadSingle(string.Format(prompt, 2)),
                      Base.ReadSingle(string.Format(prompt, 3)));
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<float, float, float, float, float> ReadSingleTuple5(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadSingle(string.Format(prompt, 0)),
                      Base.ReadSingle(string.Format(prompt, 1)),
                      Base.ReadSingle(string.Format(prompt, 2)),
                      Base.ReadSingle(string.Format(prompt, 3)),
                      Base.ReadSingle(string.Format(prompt, 4)));
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<float, float, float, float, float, float> ReadSingleTuple6(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadSingle(string.Format(prompt, 0)),
                      Base.ReadSingle(string.Format(prompt, 1)),
                      Base.ReadSingle(string.Format(prompt, 2)),
                      Base.ReadSingle(string.Format(prompt, 3)),
                      Base.ReadSingle(string.Format(prompt, 4)),
                      Base.ReadSingle(string.Format(prompt, 5)));
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<float, float, float, float, float, float, float> ReadSingleTuple7(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadSingle(string.Format(prompt, 0)),
                      Base.ReadSingle(string.Format(prompt, 1)),
                      Base.ReadSingle(string.Format(prompt, 2)),
                      Base.ReadSingle(string.Format(prompt, 3)),
                      Base.ReadSingle(string.Format(prompt, 4)),
                      Base.ReadSingle(string.Format(prompt, 5)),
                      Base.ReadSingle(string.Format(prompt, 6)));
        }

        #endregion

        #region ReadInt32

        /// <summary>
        /// Читает кортеж из двух значений типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int> ReadInt32Tuple2(string prompt = null)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadInt32(string.Format(prompt, 0)),
                      Base.ReadInt32(string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int, int> ReadInt32Tuple3(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadInt32(string.Format(prompt, 0)),
                      Base.ReadInt32(string.Format(prompt, 1)),
                      Base.ReadInt32(string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int, int, int> ReadInt32Tuple4(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadInt32(string.Format(prompt, 0)),
                      Base.ReadInt32(string.Format(prompt, 1)),
                      Base.ReadInt32(string.Format(prompt, 2)),
                      Base.ReadInt32(string.Format(prompt, 3)));
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int, int, int, int> ReadInt32Tuple5(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadInt32(string.Format(prompt, 0)),
                      Base.ReadInt32(string.Format(prompt, 1)),
                      Base.ReadInt32(string.Format(prompt, 2)),
                      Base.ReadInt32(string.Format(prompt, 3)),
                      Base.ReadInt32(string.Format(prompt, 4)));
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int, int, int, int, int> ReadInt32Tuple6(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadInt32(string.Format(prompt, 0)),
                      Base.ReadInt32(string.Format(prompt, 1)),
                      Base.ReadInt32(string.Format(prompt, 2)),
                      Base.ReadInt32(string.Format(prompt, 3)),
                      Base.ReadInt32(string.Format(prompt, 4)),
                      Base.ReadInt32(string.Format(prompt, 5)));
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int, int, int, int, int, int> ReadInt32Tuple7(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadInt32(string.Format(prompt, 0)),
                      Base.ReadInt32(string.Format(prompt, 1)),
                      Base.ReadInt32(string.Format(prompt, 2)),
                      Base.ReadInt32(string.Format(prompt, 3)),
                      Base.ReadInt32(string.Format(prompt, 4)),
                      Base.ReadInt32(string.Format(prompt, 5)),
                      Base.ReadInt32(string.Format(prompt, 6)));
        }

        #endregion

        #region ReadUInt32

        /// <summary>
        /// Читает кортеж из двух значений типа UInt32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint, uint> ReadUInt32Tuple2(string prompt = null)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadUInt32(string.Format(prompt, 0)),
                      Base.ReadUInt32(string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа UInt32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint, uint, uint> ReadUInt32Tuple3(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadUInt32(string.Format(prompt, 0)),
                      Base.ReadUInt32(string.Format(prompt, 1)),
                      Base.ReadUInt32(string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа UInt32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint, uint, uint, uint> ReadUInt32Tuple4(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadUInt32(string.Format(prompt, 0)),
                      Base.ReadUInt32(string.Format(prompt, 1)),
                      Base.ReadUInt32(string.Format(prompt, 2)),
                      Base.ReadUInt32(string.Format(prompt, 3)));
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа UInt32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint, uint, uint, uint, uint> ReadUInt32Tuple5(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadUInt32(string.Format(prompt, 0)),
                      Base.ReadUInt32(string.Format(prompt, 1)),
                      Base.ReadUInt32(string.Format(prompt, 2)),
                      Base.ReadUInt32(string.Format(prompt, 3)),
                      Base.ReadUInt32(string.Format(prompt, 4)));
        }

        /// <summary>
        /// Читает кортеж из шести значений типа UInt32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint, uint, uint, uint, uint, uint> ReadUInt32Tuple6(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadUInt32(string.Format(prompt, 0)),
                      Base.ReadUInt32(string.Format(prompt, 1)),
                      Base.ReadUInt32(string.Format(prompt, 2)),
                      Base.ReadUInt32(string.Format(prompt, 3)),
                      Base.ReadUInt32(string.Format(prompt, 4)),
                      Base.ReadUInt32(string.Format(prompt, 5)));
        }

        /// <summary>
        /// Читает кортеж из семи значений типа UInt32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint, uint, uint, uint, uint, uint, uint> ReadUInt32Tuple7(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadUInt32(string.Format(prompt, 0)),
                      Base.ReadUInt32(string.Format(prompt, 1)),
                      Base.ReadUInt32(string.Format(prompt, 2)),
                      Base.ReadUInt32(string.Format(prompt, 3)),
                      Base.ReadUInt32(string.Format(prompt, 4)),
                      Base.ReadUInt32(string.Format(prompt, 5)),
                      Base.ReadUInt32(string.Format(prompt, 6)));
        }

        #endregion

        #region ReadInt64

        /// <summary>
        /// Читает кортеж из двух значений типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<long, long> ReadInt64Tuple2(string prompt = null)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadInt64(string.Format(prompt, 0)),
                      Base.ReadInt64(string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<long, long, long> ReadInt64Tuple3(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadInt64(string.Format(prompt, 0)),
                      Base.ReadInt64(string.Format(prompt, 1)),
                      Base.ReadInt64(string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<long, long, long, long> ReadInt64Tuple4(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadInt64(string.Format(prompt, 0)),
                      Base.ReadInt64(string.Format(prompt, 1)),
                      Base.ReadInt64(string.Format(prompt, 2)),
                      Base.ReadInt64(string.Format(prompt, 3)));
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<long, long, long, long, long> ReadInt64Tuple5(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadInt64(string.Format(prompt, 0)),
                      Base.ReadInt64(string.Format(prompt, 1)),
                      Base.ReadInt64(string.Format(prompt, 2)),
                      Base.ReadInt64(string.Format(prompt, 3)),
                      Base.ReadInt64(string.Format(prompt, 4)));
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<long, long, long, long, long, long> ReadInt64Tuple6(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadInt64(string.Format(prompt, 0)),
                      Base.ReadInt64(string.Format(prompt, 1)),
                      Base.ReadInt64(string.Format(prompt, 2)),
                      Base.ReadInt64(string.Format(prompt, 3)),
                      Base.ReadInt64(string.Format(prompt, 4)),
                      Base.ReadInt64(string.Format(prompt, 5)));
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<long, long, long, long, long, long, long> ReadInt64Tuple7(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadInt64(string.Format(prompt, 0)),
                      Base.ReadInt64(string.Format(prompt, 1)),
                      Base.ReadInt64(string.Format(prompt, 2)),
                      Base.ReadInt64(string.Format(prompt, 3)),
                      Base.ReadInt64(string.Format(prompt, 4)),
                      Base.ReadInt64(string.Format(prompt, 5)),
                      Base.ReadInt64(string.Format(prompt, 6)));
        }

        #endregion

        #region ReadUInt64

        /// <summary>
        /// Читает кортеж из двух значений типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong, ulong> ReadUInt64Tuple2(string prompt = null)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadUInt64(string.Format(prompt, 0)),
                      Base.ReadUInt64(string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong, ulong, ulong> ReadUInt64Tuple3(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadUInt64(string.Format(prompt, 0)),
                      Base.ReadUInt64(string.Format(prompt, 1)),
                      Base.ReadUInt64(string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong, ulong, ulong, ulong> ReadUInt64Tuple4(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadUInt64(string.Format(prompt, 0)),
                      Base.ReadUInt64(string.Format(prompt, 1)),
                      Base.ReadUInt64(string.Format(prompt, 2)),
                      Base.ReadUInt64(string.Format(prompt, 3)));
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong, ulong, ulong, ulong, ulong> ReadUInt64Tuple5(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadUInt64(string.Format(prompt, 0)),
                      Base.ReadUInt64(string.Format(prompt, 1)),
                      Base.ReadUInt64(string.Format(prompt, 2)),
                      Base.ReadUInt64(string.Format(prompt, 3)),
                      Base.ReadUInt64(string.Format(prompt, 4)));
        }

        /// <summary>
        /// Читает кортеж из шести значений типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong, ulong, ulong, ulong, ulong, ulong> ReadUInt64Tuple6(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadUInt64(string.Format(prompt, 0)),
                      Base.ReadUInt64(string.Format(prompt, 1)),
                      Base.ReadUInt64(string.Format(prompt, 2)),
                      Base.ReadUInt64(string.Format(prompt, 3)),
                      Base.ReadUInt64(string.Format(prompt, 4)),
                      Base.ReadUInt64(string.Format(prompt, 5)));
        }

        /// <summary>
        /// Читает кортеж из семи значений типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong, ulong, ulong, ulong, ulong, ulong, ulong> ReadUInt64Tuple7(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadUInt64(string.Format(prompt, 0)),
                      Base.ReadUInt64(string.Format(prompt, 1)),
                      Base.ReadUInt64(string.Format(prompt, 2)),
                      Base.ReadUInt64(string.Format(prompt, 3)),
                      Base.ReadUInt64(string.Format(prompt, 4)),
                      Base.ReadUInt64(string.Format(prompt, 5)),
                      Base.ReadUInt64(string.Format(prompt, 6)));
        }

        #endregion

        #region ReadInt16

        /// <summary>
        /// Читает кортеж из двух значений типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<short, short> ReadInt16Tuple2(string prompt = null)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadInt16(string.Format(prompt, 0)),
                      Base.ReadInt16(string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<short, short, short> ReadInt16Tuple3(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadInt16(string.Format(prompt, 0)),
                      Base.ReadInt16(string.Format(prompt, 1)),
                      Base.ReadInt16(string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<short, short, short, short> ReadInt16Tuple4(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadInt16(string.Format(prompt, 0)),
                      Base.ReadInt16(string.Format(prompt, 1)),
                      Base.ReadInt16(string.Format(prompt, 2)),
                      Base.ReadInt16(string.Format(prompt, 3)));
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<short, short, short, short, short> ReadInt16Tuple5(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadInt16(string.Format(prompt, 0)),
                      Base.ReadInt16(string.Format(prompt, 1)),
                      Base.ReadInt16(string.Format(prompt, 2)),
                      Base.ReadInt16(string.Format(prompt, 3)),
                      Base.ReadInt16(string.Format(prompt, 4)));
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<short, short, short, short, short, short> ReadInt16Tuple6(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadInt16(string.Format(prompt, 0)),
                      Base.ReadInt16(string.Format(prompt, 1)),
                      Base.ReadInt16(string.Format(prompt, 2)),
                      Base.ReadInt16(string.Format(prompt, 3)),
                      Base.ReadInt16(string.Format(prompt, 4)),
                      Base.ReadInt16(string.Format(prompt, 5)));
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<short, short, short, short, short, short, short> ReadInt16Tuple7(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadInt16(string.Format(prompt, 0)),
                      Base.ReadInt16(string.Format(prompt, 1)),
                      Base.ReadInt16(string.Format(prompt, 2)),
                      Base.ReadInt16(string.Format(prompt, 3)),
                      Base.ReadInt16(string.Format(prompt, 4)),
                      Base.ReadInt16(string.Format(prompt, 5)),
                      Base.ReadInt16(string.Format(prompt, 6)));
        }

        #endregion

        #region ReadUInt16

        /// <summary>
        /// Читает кортеж из двух значений типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort, ushort> ReadUInt16Tuple2(string prompt = null)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadUInt16(string.Format(prompt, 0)),
                      Base.ReadUInt16(string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort, ushort, ushort> ReadUInt16Tuple3(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadUInt16(string.Format(prompt, 0)),
                      Base.ReadUInt16(string.Format(prompt, 1)),
                      Base.ReadUInt16(string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort, ushort, ushort, ushort> ReadUInt16Tuple4(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadUInt16(string.Format(prompt, 0)),
                      Base.ReadUInt16(string.Format(prompt, 1)),
                      Base.ReadUInt16(string.Format(prompt, 2)),
                      Base.ReadUInt16(string.Format(prompt, 3)));
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort, ushort, ushort, ushort, ushort> ReadUInt16Tuple5(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadUInt16(string.Format(prompt, 0)),
                      Base.ReadUInt16(string.Format(prompt, 1)),
                      Base.ReadUInt16(string.Format(prompt, 2)),
                      Base.ReadUInt16(string.Format(prompt, 3)),
                      Base.ReadUInt16(string.Format(prompt, 4)));
        }

        /// <summary>
        /// Читает кортеж из шести значений типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort, ushort, ushort, ushort, ushort, ushort> ReadUInt16Tuple6(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadUInt16(string.Format(prompt, 0)),
                      Base.ReadUInt16(string.Format(prompt, 1)),
                      Base.ReadUInt16(string.Format(prompt, 2)),
                      Base.ReadUInt16(string.Format(prompt, 3)),
                      Base.ReadUInt16(string.Format(prompt, 4)),
                      Base.ReadUInt16(string.Format(prompt, 5)));
        }

        /// <summary>
        /// Читает кортеж из семи значений типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort, ushort, ushort, ushort, ushort, ushort, ushort> ReadUInt16Tuple7(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadUInt16(string.Format(prompt, 0)),
                      Base.ReadUInt16(string.Format(prompt, 1)),
                      Base.ReadUInt16(string.Format(prompt, 2)),
                      Base.ReadUInt16(string.Format(prompt, 3)),
                      Base.ReadUInt16(string.Format(prompt, 4)),
                      Base.ReadUInt16(string.Format(prompt, 5)),
                      Base.ReadUInt16(string.Format(prompt, 6)));
        }

        #endregion

        #region ReadBigInteger

        /// <summary>
        /// Читает кортеж из двух значений типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger, BigInteger> ReadBigIntegerTuple2(string prompt = null)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadBigInteger(string.Format(prompt, 0)),
                      Base.ReadBigInteger(string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger, BigInteger, BigInteger> ReadBigIntegerTuple3(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadBigInteger(string.Format(prompt, 0)),
                      Base.ReadBigInteger(string.Format(prompt, 1)),
                      Base.ReadBigInteger(string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger, BigInteger, BigInteger, BigInteger> ReadBigIntegerTuple4(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadBigInteger(string.Format(prompt, 0)),
                      Base.ReadBigInteger(string.Format(prompt, 1)),
                      Base.ReadBigInteger(string.Format(prompt, 2)),
                      Base.ReadBigInteger(string.Format(prompt, 3)));
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger, BigInteger, BigInteger, BigInteger, BigInteger> ReadBigIntegerTuple5(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadBigInteger(string.Format(prompt, 0)),
                      Base.ReadBigInteger(string.Format(prompt, 1)),
                      Base.ReadBigInteger(string.Format(prompt, 2)),
                      Base.ReadBigInteger(string.Format(prompt, 3)),
                      Base.ReadBigInteger(string.Format(prompt, 4)));
        }

        /// <summary>
        /// Читает кортеж из шести значений типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger, BigInteger, BigInteger, BigInteger, BigInteger, BigInteger> ReadBigIntegerTuple6(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadBigInteger(string.Format(prompt, 0)),
                      Base.ReadBigInteger(string.Format(prompt, 1)),
                      Base.ReadBigInteger(string.Format(prompt, 2)),
                      Base.ReadBigInteger(string.Format(prompt, 3)),
                      Base.ReadBigInteger(string.Format(prompt, 4)),
                      Base.ReadBigInteger(string.Format(prompt, 5)));
        }

        /// <summary>
        /// Читает кортеж из семи значений типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger, BigInteger, BigInteger, BigInteger, BigInteger, BigInteger, BigInteger> ReadBigIntegerTuple7(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadBigInteger(string.Format(prompt, 0)),
                      Base.ReadBigInteger(string.Format(prompt, 1)),
                      Base.ReadBigInteger(string.Format(prompt, 2)),
                      Base.ReadBigInteger(string.Format(prompt, 3)),
                      Base.ReadBigInteger(string.Format(prompt, 4)),
                      Base.ReadBigInteger(string.Format(prompt, 5)),
                      Base.ReadBigInteger(string.Format(prompt, 6)));
        }

        #endregion

        #region ReadString

        /// <summary>
        /// Читает кортеж из двух значений типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<string, string> ReadStringTuple2(string prompt = null)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadString(string.Format(prompt, 0)),
                      Base.ReadString(string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<string, string, string> ReadStringTuple3(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadString(string.Format(prompt, 0)),
                      Base.ReadString(string.Format(prompt, 1)),
                      Base.ReadString(string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<string, string, string, string> ReadStringTuple4(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadString(string.Format(prompt, 0)),
                      Base.ReadString(string.Format(prompt, 1)),
                      Base.ReadString(string.Format(prompt, 2)),
                      Base.ReadString(string.Format(prompt, 3)));
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<string, string, string, string, string> ReadStringTuple5(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadString(string.Format(prompt, 0)),
                      Base.ReadString(string.Format(prompt, 1)),
                      Base.ReadString(string.Format(prompt, 2)),
                      Base.ReadString(string.Format(prompt, 3)),
                      Base.ReadString(string.Format(prompt, 4)));
        }

        /// <summary>
        /// Читает кортеж из шести значений типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<string, string, string, string, string, string> ReadStringTuple6(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadString(string.Format(prompt, 0)),
                      Base.ReadString(string.Format(prompt, 1)),
                      Base.ReadString(string.Format(prompt, 2)),
                      Base.ReadString(string.Format(prompt, 3)),
                      Base.ReadString(string.Format(prompt, 4)),
                      Base.ReadString(string.Format(prompt, 5)));
        }

        /// <summary>
        /// Читает кортеж из семи значений типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<string, string, string, string, string, string, string> ReadStringTuple7(string prompt = EmptyStringHelper.Empty)
        {
            prompt = prompt ?? EmptyStringHelper.Empty;

            return Of(Base.ReadString(string.Format(prompt, 0)),
                      Base.ReadString(string.Format(prompt, 1)),
                      Base.ReadString(string.Format(prompt, 2)),
                      Base.ReadString(string.Format(prompt, 3)),
                      Base.ReadString(string.Format(prompt, 4)),
                      Base.ReadString(string.Format(prompt, 5)),
                      Base.ReadString(string.Format(prompt, 6)));
        }

        #endregion

        #endregion public

    }
}
