using ABCNET.Extensions;
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
        public static Tuple<bool, bool> ReadBooleanTuple2(string prompt = EmptyStringHelper.Empty)
        {
            bool a = default;
            bool b = default;

            ReadBooleanTupleItem(ref a, 0, prompt);
            ReadBooleanTupleItem(ref b, 1, prompt);

            return Of(a, b);
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool, bool, bool> ReadBooleanTuple3(string prompt = EmptyStringHelper.Empty)
        {
            bool a = default;
            bool b = default;
            bool c = default;

            ReadBooleanTupleItem(ref a, 0, prompt);
            ReadBooleanTupleItem(ref b, 1, prompt);
            ReadBooleanTupleItem(ref c, 2, prompt);

            return Of(a, b, c);
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool, bool, bool, bool> ReadBooleanTuple4(string prompt = EmptyStringHelper.Empty)
        {
            bool a = default;
            bool b = default;
            bool c = default;
            bool d = default;

            ReadBooleanTupleItem(ref a, 0, prompt);
            ReadBooleanTupleItem(ref b, 1, prompt);
            ReadBooleanTupleItem(ref c, 2, prompt);
            ReadBooleanTupleItem(ref d, 3, prompt);

            return Of(a, b, c, d);
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool, bool, bool, bool, bool> ReadBooleanTuple5(string prompt = EmptyStringHelper.Empty)
        {
            bool a = default;
            bool b = default;
            bool c = default;
            bool d = default;
            bool e = default;

            ReadBooleanTupleItem(ref a, 0, prompt);
            ReadBooleanTupleItem(ref b, 1, prompt);
            ReadBooleanTupleItem(ref c, 2, prompt);
            ReadBooleanTupleItem(ref d, 3, prompt);
            ReadBooleanTupleItem(ref e, 4, prompt);

            return Of(a, b, c, d, e);
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool, bool, bool, bool, bool, bool> ReadBooleanTuple6(string prompt = EmptyStringHelper.Empty)
        {
            bool a = default;
            bool b = default;
            bool c = default;
            bool d = default;
            bool e = default;
            bool f = default;

            ReadBooleanTupleItem(ref a, 0, prompt);
            ReadBooleanTupleItem(ref b, 1, prompt);
            ReadBooleanTupleItem(ref c, 2, prompt);
            ReadBooleanTupleItem(ref d, 3, prompt);
            ReadBooleanTupleItem(ref e, 4, prompt);
            ReadBooleanTupleItem(ref f, 5, prompt);

            return Of(a, b, c, d, e, f);
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool, bool, bool, bool, bool, bool, bool> ReadBooleanTuple7(string prompt = EmptyStringHelper.Empty)
        {
            bool a = default;
            bool b = default;
            bool c = default;
            bool d = default;
            bool e = default;
            bool f = default;
            bool g = default;

            ReadBooleanTupleItem(ref a, 0, prompt);
            ReadBooleanTupleItem(ref b, 1, prompt);
            ReadBooleanTupleItem(ref c, 2, prompt);
            ReadBooleanTupleItem(ref d, 3, prompt);
            ReadBooleanTupleItem(ref e, 4, prompt);
            ReadBooleanTupleItem(ref f, 5, prompt);
            ReadBooleanTupleItem(ref g, 6, prompt);

            return Of(a, b, c, d, e, f, g);
        }

        #endregion

        #region ReadByte

        /// <summary>
        /// Читает кортеж из двух значений типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte, byte> ReadByteTuple2(string prompt = EmptyStringHelper.Empty)
        {
            byte a = default;
            byte b = default;

            ReadByteTupleItem(ref a, 0, prompt);
            ReadByteTupleItem(ref b, 1, prompt);

            return Of(a, b);
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte, byte, byte> ReadByteTuple3(string prompt = EmptyStringHelper.Empty)
        {
            byte a = default;
            byte b = default;
            byte c = default;

            ReadByteTupleItem(ref a, 0, prompt);
            ReadByteTupleItem(ref b, 1, prompt);
            ReadByteTupleItem(ref c, 2, prompt);

            return Of(a, b, c);
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte, byte, byte, byte> ReadByteTuple4(string prompt = EmptyStringHelper.Empty)
        {
            byte a = default;
            byte b = default;
            byte c = default;
            byte d = default;

            ReadByteTupleItem(ref a, 0, prompt);
            ReadByteTupleItem(ref b, 1, prompt);
            ReadByteTupleItem(ref c, 2, prompt);
            ReadByteTupleItem(ref d, 3, prompt);

            return Of(a, b, c, d);
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte, byte, byte, byte, byte> ReadByteTuple5(string prompt = EmptyStringHelper.Empty)
        {
            byte a = default;
            byte b = default;
            byte c = default;
            byte d = default;
            byte e = default;

            ReadByteTupleItem(ref a, 0, prompt);
            ReadByteTupleItem(ref b, 1, prompt);
            ReadByteTupleItem(ref c, 2, prompt);
            ReadByteTupleItem(ref d, 3, prompt);
            ReadByteTupleItem(ref e, 4, prompt);

            return Of(a, b, c, d, e);
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte, byte, byte, byte, byte, byte> ReadByteTuple6(string prompt = EmptyStringHelper.Empty)
        {
            byte a = default;
            byte b = default;
            byte c = default;
            byte d = default;
            byte e = default;
            byte f = default;

            ReadByteTupleItem(ref a, 0, prompt);
            ReadByteTupleItem(ref b, 1, prompt);
            ReadByteTupleItem(ref c, 2, prompt);
            ReadByteTupleItem(ref d, 3, prompt);
            ReadByteTupleItem(ref e, 4, prompt);
            ReadByteTupleItem(ref f, 5, prompt);

            return Of(a, b, c, d, e, f);
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte, byte, byte, byte, byte, byte, byte> ReadByteTuple7(string prompt = EmptyStringHelper.Empty)
        {
            byte a = default;
            byte b = default;
            byte c = default;
            byte d = default;
            byte e = default;
            byte f = default;
            byte g = default;

            ReadByteTupleItem(ref a, 0, prompt);
            ReadByteTupleItem(ref b, 1, prompt);
            ReadByteTupleItem(ref c, 2, prompt);
            ReadByteTupleItem(ref d, 3, prompt);
            ReadByteTupleItem(ref e, 4, prompt);
            ReadByteTupleItem(ref f, 5, prompt);
            ReadByteTupleItem(ref g, 6, prompt);

            return Of(a, b, c, d, e, f, g);
        }

        #endregion

        #region ReadSbyte

        /// <summary>
        /// Читает кортеж из двух значений типа Sbyte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte, sbyte> ReadSbyteTuple2(string prompt = EmptyStringHelper.Empty)
        {
            sbyte a = default;
            sbyte b = default;

            ReadSbyteTupleItem(ref a, 0, prompt);
            ReadSbyteTupleItem(ref b, 1, prompt);

            return Of(a, b);
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Sbyte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte, sbyte, sbyte> ReadSbyteTuple3(string prompt = EmptyStringHelper.Empty)
        {
            sbyte a = default;
            sbyte b = default;
            sbyte c = default;

            ReadSbyteTupleItem(ref a, 0, prompt);
            ReadSbyteTupleItem(ref b, 1, prompt);
            ReadSbyteTupleItem(ref c, 2, prompt);

            return Of(a, b, c);
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Sbyte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte, sbyte, sbyte, sbyte> ReadSbyteTuple4(string prompt = EmptyStringHelper.Empty)
        {
            sbyte a = default;
            sbyte b = default;
            sbyte c = default;
            sbyte d = default;

            ReadSbyteTupleItem(ref a, 0, prompt);
            ReadSbyteTupleItem(ref b, 1, prompt);
            ReadSbyteTupleItem(ref c, 2, prompt);
            ReadSbyteTupleItem(ref d, 3, prompt);

            return Of(a, b, c, d);
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Sbyte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte, sbyte, sbyte, sbyte, sbyte> ReadSbyteTuple5(string prompt = EmptyStringHelper.Empty)
        {
            sbyte a = default;
            sbyte b = default;
            sbyte c = default;
            sbyte d = default;
            sbyte e = default;

            ReadSbyteTupleItem(ref a, 0, prompt);
            ReadSbyteTupleItem(ref b, 1, prompt);
            ReadSbyteTupleItem(ref c, 2, prompt);
            ReadSbyteTupleItem(ref d, 3, prompt);
            ReadSbyteTupleItem(ref e, 4, prompt);

            return Of(a, b, c, d, e);
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Sbyte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte, sbyte, sbyte, sbyte, sbyte, sbyte> ReadSbyteTuple6(string prompt = EmptyStringHelper.Empty)
        {
            sbyte a = default;
            sbyte b = default;
            sbyte c = default;
            sbyte d = default;
            sbyte e = default;
            sbyte f = default;

            ReadSbyteTupleItem(ref a, 0, prompt);
            ReadSbyteTupleItem(ref b, 1, prompt);
            ReadSbyteTupleItem(ref c, 2, prompt);
            ReadSbyteTupleItem(ref d, 3, prompt);
            ReadSbyteTupleItem(ref e, 4, prompt);
            ReadSbyteTupleItem(ref f, 5, prompt);

            return Of(a, b, c, d, e, f);
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Sbyte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte, sbyte, sbyte, sbyte, sbyte, sbyte, sbyte> ReadSbyteTuple7(string prompt = EmptyStringHelper.Empty)
        {
            sbyte a = default;
            sbyte b = default;
            sbyte c = default;
            sbyte d = default;
            sbyte e = default;
            sbyte f = default;
            sbyte g = default;

            ReadSbyteTupleItem(ref a, 0, prompt);
            ReadSbyteTupleItem(ref b, 1, prompt);
            ReadSbyteTupleItem(ref c, 2, prompt);
            ReadSbyteTupleItem(ref d, 3, prompt);
            ReadSbyteTupleItem(ref e, 4, prompt);
            ReadSbyteTupleItem(ref f, 5, prompt);
            ReadSbyteTupleItem(ref g, 6, prompt);

            return Of(a, b, c, d, e, f, g);
        }

        #endregion

        #region ReadChar

        /// <summary>
        /// Читает кортеж из двух значений типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<char, char> ReadCharTuple2(string prompt = EmptyStringHelper.Empty)
        {
            char a = default;
            char b = default;

            ReadCharTupleItem(ref a, 0, prompt);
            ReadCharTupleItem(ref b, 1, prompt);

            return Of(a, b);
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<char, char, char> ReadCharTuple3(string prompt = EmptyStringHelper.Empty)
        {
            char a = default;
            char b = default;
            char c = default;

            ReadCharTupleItem(ref a, 0, prompt);
            ReadCharTupleItem(ref b, 1, prompt);
            ReadCharTupleItem(ref c, 2, prompt);

            return Of(a, b, c);
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<char, char, char, char> ReadCharTuple4(string prompt = EmptyStringHelper.Empty)
        {
            char a = default;
            char b = default;
            char c = default;
            char d = default;

            ReadCharTupleItem(ref a, 0, prompt);
            ReadCharTupleItem(ref b, 1, prompt);
            ReadCharTupleItem(ref c, 2, prompt);
            ReadCharTupleItem(ref d, 3, prompt);

            return Of(a, b, c, d);
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<char, char, char, char, char> ReadCharTuple5(string prompt = EmptyStringHelper.Empty)
        {
            char a = default;
            char b = default;
            char c = default;
            char d = default;
            char e = default;

            ReadCharTupleItem(ref a, 0, prompt);
            ReadCharTupleItem(ref b, 1, prompt);
            ReadCharTupleItem(ref c, 2, prompt);
            ReadCharTupleItem(ref d, 3, prompt);
            ReadCharTupleItem(ref e, 4, prompt);

            return Of(a, b, c, d, e);
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<char, char, char, char, char, char> ReadCharTuple6(string prompt = EmptyStringHelper.Empty)
        {
            char a = default;
            char b = default;
            char c = default;
            char d = default;
            char e = default;
            char f = default;

            ReadCharTupleItem(ref a, 0, prompt);
            ReadCharTupleItem(ref b, 1, prompt);
            ReadCharTupleItem(ref c, 2, prompt);
            ReadCharTupleItem(ref d, 3, prompt);
            ReadCharTupleItem(ref e, 4, prompt);
            ReadCharTupleItem(ref f, 5, prompt);

            return Of(a, b, c, d, e, f);
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<char, char, char, char, char, char, char> ReadCharTuple7(string prompt = EmptyStringHelper.Empty)
        {
            char a = default;
            char b = default;
            char c = default;
            char d = default;
            char e = default;
            char f = default;
            char g = default;

            ReadCharTupleItem(ref a, 0, prompt);
            ReadCharTupleItem(ref b, 1, prompt);
            ReadCharTupleItem(ref c, 2, prompt);
            ReadCharTupleItem(ref d, 3, prompt);
            ReadCharTupleItem(ref e, 4, prompt);
            ReadCharTupleItem(ref f, 5, prompt);
            ReadCharTupleItem(ref g, 6, prompt);

            return Of(a, b, c, d, e, f, g);
        }

        #endregion

        #region ReadDecimal

        /// <summary>
        /// Читает кортеж из двух значений типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal, decimal> ReadDecimalTuple2(string prompt = EmptyStringHelper.Empty)
        {
            decimal a = default;
            decimal b = default;

            ReadDecimalTupleItem(ref a, 0, prompt);
            ReadDecimalTupleItem(ref b, 1, prompt);

            return Of(a, b);
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal, decimal, decimal> ReadDecimalTuple3(string prompt = EmptyStringHelper.Empty)
        {
            decimal a = default;
            decimal b = default;
            decimal c = default;

            ReadDecimalTupleItem(ref a, 0, prompt);
            ReadDecimalTupleItem(ref b, 1, prompt);
            ReadDecimalTupleItem(ref c, 2, prompt);

            return Of(a, b, c);
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal, decimal, decimal, decimal> ReadDecimalTuple4(string prompt = EmptyStringHelper.Empty)
        {
            decimal a = default;
            decimal b = default;
            decimal c = default;
            decimal d = default;

            ReadDecimalTupleItem(ref a, 0, prompt);
            ReadDecimalTupleItem(ref b, 1, prompt);
            ReadDecimalTupleItem(ref c, 2, prompt);
            ReadDecimalTupleItem(ref d, 3, prompt);

            return Of(a, b, c, d);
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal, decimal, decimal, decimal, decimal> ReadDecimalTuple5(string prompt = EmptyStringHelper.Empty)
        {
            decimal a = default;
            decimal b = default;
            decimal c = default;
            decimal d = default;
            decimal e = default;

            ReadDecimalTupleItem(ref a, 0, prompt);
            ReadDecimalTupleItem(ref b, 1, prompt);
            ReadDecimalTupleItem(ref c, 2, prompt);
            ReadDecimalTupleItem(ref d, 3, prompt);
            ReadDecimalTupleItem(ref e, 4, prompt);

            return Of(a, b, c, d, e);
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal, decimal, decimal, decimal, decimal, decimal> ReadDecimalTuple6(string prompt = EmptyStringHelper.Empty)
        {
            decimal a = default;
            decimal b = default;
            decimal c = default;
            decimal d = default;
            decimal e = default;
            decimal f = default;

            ReadDecimalTupleItem(ref a, 0, prompt);
            ReadDecimalTupleItem(ref b, 1, prompt);
            ReadDecimalTupleItem(ref c, 2, prompt);
            ReadDecimalTupleItem(ref d, 3, prompt);
            ReadDecimalTupleItem(ref e, 4, prompt);
            ReadDecimalTupleItem(ref f, 5, prompt);

            return Of(a, b, c, d, e, f);
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal> ReadDecimalTuple7(string prompt = EmptyStringHelper.Empty)
        {
            decimal a = default;
            decimal b = default;
            decimal c = default;
            decimal d = default;
            decimal e = default;
            decimal f = default;
            decimal g = default;

            ReadDecimalTupleItem(ref a, 0, prompt);
            ReadDecimalTupleItem(ref b, 1, prompt);
            ReadDecimalTupleItem(ref c, 2, prompt);
            ReadDecimalTupleItem(ref d, 3, prompt);
            ReadDecimalTupleItem(ref e, 4, prompt);
            ReadDecimalTupleItem(ref f, 5, prompt);
            ReadDecimalTupleItem(ref g, 6, prompt);

            return Of(a, b, c, d, e, f, g);
        }

        #endregion

        #region ReadDouble

        /// <summary>
        /// Читает кортеж из двух значений типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double> ReadDoubleTuple2(string prompt = EmptyStringHelper.Empty)
        {
            double a = default;
            double b = default;

            ReadDoubleTupleItem(ref a, 0, prompt);
            ReadDoubleTupleItem(ref b, 1, prompt);

            return Of(a, b);
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double, double> ReadDoubleTuple3(string prompt = EmptyStringHelper.Empty)
        {
            double a = default;
            double b = default;
            double c = default;

            ReadDoubleTupleItem(ref a, 0, prompt);
            ReadDoubleTupleItem(ref b, 1, prompt);
            ReadDoubleTupleItem(ref c, 2, prompt);

            return Of(a, b, c);
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double, double, double> ReadDoubleTuple4(string prompt = EmptyStringHelper.Empty)
        {
            double a = default;
            double b = default;
            double c = default;
            double d = default;

            ReadDoubleTupleItem(ref a, 0, prompt);
            ReadDoubleTupleItem(ref b, 1, prompt);
            ReadDoubleTupleItem(ref c, 2, prompt);
            ReadDoubleTupleItem(ref d, 3, prompt);

            return Of(a, b, c, d);
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double, double, double, double> ReadDoubleTuple5(string prompt = EmptyStringHelper.Empty)
        {
            double a = default;
            double b = default;
            double c = default;
            double d = default;
            double e = default;

            ReadDoubleTupleItem(ref a, 0, prompt);
            ReadDoubleTupleItem(ref b, 1, prompt);
            ReadDoubleTupleItem(ref c, 2, prompt);
            ReadDoubleTupleItem(ref d, 3, prompt);
            ReadDoubleTupleItem(ref e, 4, prompt);

            return Of(a, b, c, d, e);
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double, double, double, double, double> ReadDoubleTuple6(string prompt = EmptyStringHelper.Empty)
        {
            double a = default;
            double b = default;
            double c = default;
            double d = default;
            double e = default;
            double f = default;

            ReadDoubleTupleItem(ref a, 0, prompt);
            ReadDoubleTupleItem(ref b, 1, prompt);
            ReadDoubleTupleItem(ref c, 2, prompt);
            ReadDoubleTupleItem(ref d, 3, prompt);
            ReadDoubleTupleItem(ref e, 4, prompt);
            ReadDoubleTupleItem(ref f, 5, prompt);

            return Of(a, b, c, d, e, f);
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double, double, double, double, double, double> ReadDoubleTuple7(string prompt = EmptyStringHelper.Empty)
        {
            double a = default;
            double b = default;
            double c = default;
            double d = default;
            double e = default;
            double f = default;
            double g = default;

            ReadDoubleTupleItem(ref a, 0, prompt);
            ReadDoubleTupleItem(ref b, 1, prompt);
            ReadDoubleTupleItem(ref c, 2, prompt);
            ReadDoubleTupleItem(ref d, 3, prompt);
            ReadDoubleTupleItem(ref e, 4, prompt);
            ReadDoubleTupleItem(ref f, 5, prompt);
            ReadDoubleTupleItem(ref g, 6, prompt);

            return Of(a, b, c, d, e, f, g);
        }

        #endregion

        #region ReadFloat

        /// <summary>
        /// Читает кортеж из двух значений типа Float. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<float, float> ReadFloatTuple2(string prompt = EmptyStringHelper.Empty)
        {
            float a = default;
            float b = default;

            ReadFloatTupleItem(ref a, 0, prompt);
            ReadFloatTupleItem(ref b, 1, prompt);

            return Of(a, b);
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Float. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<float, float, float> ReadFloatTuple3(string prompt = EmptyStringHelper.Empty)
        {
            float a = default;
            float b = default;
            float c = default;

            ReadFloatTupleItem(ref a, 0, prompt);
            ReadFloatTupleItem(ref b, 1, prompt);
            ReadFloatTupleItem(ref c, 2, prompt);

            return Of(a, b, c);
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Float. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<float, float, float, float> ReadFloatTuple4(string prompt = EmptyStringHelper.Empty)
        {
            float a = default;
            float b = default;
            float c = default;
            float d = default;

            ReadFloatTupleItem(ref a, 0, prompt);
            ReadFloatTupleItem(ref b, 1, prompt);
            ReadFloatTupleItem(ref c, 2, prompt);
            ReadFloatTupleItem(ref d, 3, prompt);

            return Of(a, b, c, d);
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Float. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<float, float, float, float, float> ReadFloatTuple5(string prompt = EmptyStringHelper.Empty)
        {
            float a = default;
            float b = default;
            float c = default;
            float d = default;
            float e = default;

            ReadFloatTupleItem(ref a, 0, prompt);
            ReadFloatTupleItem(ref b, 1, prompt);
            ReadFloatTupleItem(ref c, 2, prompt);
            ReadFloatTupleItem(ref d, 3, prompt);
            ReadFloatTupleItem(ref e, 4, prompt);

            return Of(a, b, c, d, e);
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Float. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<float, float, float, float, float, float> ReadFloatTuple6(string prompt = EmptyStringHelper.Empty)
        {
            float a = default;
            float b = default;
            float c = default;
            float d = default;
            float e = default;
            float f = default;

            ReadFloatTupleItem(ref a, 0, prompt);
            ReadFloatTupleItem(ref b, 1, prompt);
            ReadFloatTupleItem(ref c, 2, prompt);
            ReadFloatTupleItem(ref d, 3, prompt);
            ReadFloatTupleItem(ref e, 4, prompt);
            ReadFloatTupleItem(ref f, 5, prompt);

            return Of(a, b, c, d, e, f);
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Float. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<float, float, float, float, float, float, float> ReadFloatTuple7(string prompt = EmptyStringHelper.Empty)
        {
            float a = default;
            float b = default;
            float c = default;
            float d = default;
            float e = default;
            float f = default;
            float g = default;

            ReadFloatTupleItem(ref a, 0, prompt);
            ReadFloatTupleItem(ref b, 1, prompt);
            ReadFloatTupleItem(ref c, 2, prompt);
            ReadFloatTupleItem(ref d, 3, prompt);
            ReadFloatTupleItem(ref e, 4, prompt);
            ReadFloatTupleItem(ref f, 5, prompt);
            ReadFloatTupleItem(ref g, 6, prompt);

            return Of(a, b, c, d, e, f, g);
        }

        #endregion

        #region ReadInt

        /// <summary>
        /// Читает кортеж из двух значений типа Int. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int> ReadIntTuple2(string prompt = EmptyStringHelper.Empty)
        {
            int a = default;
            int b = default;

            ReadIntTupleItem(ref a, 0, prompt);
            ReadIntTupleItem(ref b, 1, prompt);

            return Of(a, b);
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Int. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int, int> ReadIntTuple3(string prompt = EmptyStringHelper.Empty)
        {
            int a = default;
            int b = default;
            int c = default;

            ReadIntTupleItem(ref a, 0, prompt);
            ReadIntTupleItem(ref b, 1, prompt);
            ReadIntTupleItem(ref c, 2, prompt);

            return Of(a, b, c);
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Int. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int, int, int> ReadIntTuple4(string prompt = EmptyStringHelper.Empty)
        {
            int a = default;
            int b = default;
            int c = default;
            int d = default;

            ReadIntTupleItem(ref a, 0, prompt);
            ReadIntTupleItem(ref b, 1, prompt);
            ReadIntTupleItem(ref c, 2, prompt);
            ReadIntTupleItem(ref d, 3, prompt);

            return Of(a, b, c, d);
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Int. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int, int, int, int> ReadIntTuple5(string prompt = EmptyStringHelper.Empty)
        {
            int a = default;
            int b = default;
            int c = default;
            int d = default;
            int e = default;

            ReadIntTupleItem(ref a, 0, prompt);
            ReadIntTupleItem(ref b, 1, prompt);
            ReadIntTupleItem(ref c, 2, prompt);
            ReadIntTupleItem(ref d, 3, prompt);
            ReadIntTupleItem(ref e, 4, prompt);

            return Of(a, b, c, d, e);
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Int. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int, int, int, int, int> ReadIntTuple6(string prompt = EmptyStringHelper.Empty)
        {
            int a = default;
            int b = default;
            int c = default;
            int d = default;
            int e = default;
            int f = default;

            ReadIntTupleItem(ref a, 0, prompt);
            ReadIntTupleItem(ref b, 1, prompt);
            ReadIntTupleItem(ref c, 2, prompt);
            ReadIntTupleItem(ref d, 3, prompt);
            ReadIntTupleItem(ref e, 4, prompt);
            ReadIntTupleItem(ref f, 5, prompt);

            return Of(a, b, c, d, e, f);
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Int. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int, int, int, int, int, int> ReadIntTuple7(string prompt = EmptyStringHelper.Empty)
        {
            int a = default;
            int b = default;
            int c = default;
            int d = default;
            int e = default;
            int f = default;
            int g = default;

            ReadIntTupleItem(ref a, 0, prompt);
            ReadIntTupleItem(ref b, 1, prompt);
            ReadIntTupleItem(ref c, 2, prompt);
            ReadIntTupleItem(ref d, 3, prompt);
            ReadIntTupleItem(ref e, 4, prompt);
            ReadIntTupleItem(ref f, 5, prompt);
            ReadIntTupleItem(ref g, 6, prompt);

            return Of(a, b, c, d, e, f, g);
        }

        #endregion

        #region ReadUint

        /// <summary>
        /// Читает кортеж из двух значений типа Uint. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint, uint> ReadUintTuple2(string prompt = EmptyStringHelper.Empty)
        {
            uint a = default;
            uint b = default;

            ReadUintTupleItem(ref a, 0, prompt);
            ReadUintTupleItem(ref b, 1, prompt);

            return Of(a, b);
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Uint. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint, uint, uint> ReadUintTuple3(string prompt = EmptyStringHelper.Empty)
        {
            uint a = default;
            uint b = default;
            uint c = default;

            ReadUintTupleItem(ref a, 0, prompt);
            ReadUintTupleItem(ref b, 1, prompt);
            ReadUintTupleItem(ref c, 2, prompt);

            return Of(a, b, c);
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Uint. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint, uint, uint, uint> ReadUintTuple4(string prompt = EmptyStringHelper.Empty)
        {
            uint a = default;
            uint b = default;
            uint c = default;
            uint d = default;

            ReadUintTupleItem(ref a, 0, prompt);
            ReadUintTupleItem(ref b, 1, prompt);
            ReadUintTupleItem(ref c, 2, prompt);
            ReadUintTupleItem(ref d, 3, prompt);

            return Of(a, b, c, d);
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Uint. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint, uint, uint, uint, uint> ReadUintTuple5(string prompt = EmptyStringHelper.Empty)
        {
            uint a = default;
            uint b = default;
            uint c = default;
            uint d = default;
            uint e = default;

            ReadUintTupleItem(ref a, 0, prompt);
            ReadUintTupleItem(ref b, 1, prompt);
            ReadUintTupleItem(ref c, 2, prompt);
            ReadUintTupleItem(ref d, 3, prompt);
            ReadUintTupleItem(ref e, 4, prompt);

            return Of(a, b, c, d, e);
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Uint. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint, uint, uint, uint, uint, uint> ReadUintTuple6(string prompt = EmptyStringHelper.Empty)
        {
            uint a = default;
            uint b = default;
            uint c = default;
            uint d = default;
            uint e = default;
            uint f = default;

            ReadUintTupleItem(ref a, 0, prompt);
            ReadUintTupleItem(ref b, 1, prompt);
            ReadUintTupleItem(ref c, 2, prompt);
            ReadUintTupleItem(ref d, 3, prompt);
            ReadUintTupleItem(ref e, 4, prompt);
            ReadUintTupleItem(ref f, 5, prompt);

            return Of(a, b, c, d, e, f);
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Uint. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint, uint, uint, uint, uint, uint, uint> ReadUintTuple7(string prompt = EmptyStringHelper.Empty)
        {
            uint a = default;
            uint b = default;
            uint c = default;
            uint d = default;
            uint e = default;
            uint f = default;
            uint g = default;

            ReadUintTupleItem(ref a, 0, prompt);
            ReadUintTupleItem(ref b, 1, prompt);
            ReadUintTupleItem(ref c, 2, prompt);
            ReadUintTupleItem(ref d, 3, prompt);
            ReadUintTupleItem(ref e, 4, prompt);
            ReadUintTupleItem(ref f, 5, prompt);
            ReadUintTupleItem(ref g, 6, prompt);

            return Of(a, b, c, d, e, f, g);
        }

        #endregion

        #region ReadLong

        /// <summary>
        /// Читает кортеж из двух значений типа Long. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<long, long> ReadLongTuple2(string prompt = EmptyStringHelper.Empty)
        {
            long a = default;
            long b = default;

            ReadLongTupleItem(ref a, 0, prompt);
            ReadLongTupleItem(ref b, 1, prompt);

            return Of(a, b);
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Long. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<long, long, long> ReadLongTuple3(string prompt = EmptyStringHelper.Empty)
        {
            long a = default;
            long b = default;
            long c = default;

            ReadLongTupleItem(ref a, 0, prompt);
            ReadLongTupleItem(ref b, 1, prompt);
            ReadLongTupleItem(ref c, 2, prompt);

            return Of(a, b, c);
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Long. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<long, long, long, long> ReadLongTuple4(string prompt = EmptyStringHelper.Empty)
        {
            long a = default;
            long b = default;
            long c = default;
            long d = default;

            ReadLongTupleItem(ref a, 0, prompt);
            ReadLongTupleItem(ref b, 1, prompt);
            ReadLongTupleItem(ref c, 2, prompt);
            ReadLongTupleItem(ref d, 3, prompt);

            return Of(a, b, c, d);
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Long. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<long, long, long, long, long> ReadLongTuple5(string prompt = EmptyStringHelper.Empty)
        {
            long a = default;
            long b = default;
            long c = default;
            long d = default;
            long e = default;

            ReadLongTupleItem(ref a, 0, prompt);
            ReadLongTupleItem(ref b, 1, prompt);
            ReadLongTupleItem(ref c, 2, prompt);
            ReadLongTupleItem(ref d, 3, prompt);
            ReadLongTupleItem(ref e, 4, prompt);

            return Of(a, b, c, d, e);
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Long. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<long, long, long, long, long, long> ReadLongTuple6(string prompt = EmptyStringHelper.Empty)
        {
            long a = default;
            long b = default;
            long c = default;
            long d = default;
            long e = default;
            long f = default;

            ReadLongTupleItem(ref a, 0, prompt);
            ReadLongTupleItem(ref b, 1, prompt);
            ReadLongTupleItem(ref c, 2, prompt);
            ReadLongTupleItem(ref d, 3, prompt);
            ReadLongTupleItem(ref e, 4, prompt);
            ReadLongTupleItem(ref f, 5, prompt);

            return Of(a, b, c, d, e, f);
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Long. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<long, long, long, long, long, long, long> ReadLongTuple7(string prompt = EmptyStringHelper.Empty)
        {
            long a = default;
            long b = default;
            long c = default;
            long d = default;
            long e = default;
            long f = default;
            long g = default;

            ReadLongTupleItem(ref a, 0, prompt);
            ReadLongTupleItem(ref b, 1, prompt);
            ReadLongTupleItem(ref c, 2, prompt);
            ReadLongTupleItem(ref d, 3, prompt);
            ReadLongTupleItem(ref e, 4, prompt);
            ReadLongTupleItem(ref f, 5, prompt);
            ReadLongTupleItem(ref g, 6, prompt);

            return Of(a, b, c, d, e, f, g);
        }

        #endregion

        #region ReadUlong

        /// <summary>
        /// Читает кортеж из двух значений типа Ulong. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong, ulong> ReadUlongTuple2(string prompt = EmptyStringHelper.Empty)
        {
            ulong a = default;
            ulong b = default;

            ReadUlongTupleItem(ref a, 0, prompt);
            ReadUlongTupleItem(ref b, 1, prompt);

            return Of(a, b);
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Ulong. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong, ulong, ulong> ReadUlongTuple3(string prompt = EmptyStringHelper.Empty)
        {
            ulong a = default;
            ulong b = default;
            ulong c = default;

            ReadUlongTupleItem(ref a, 0, prompt);
            ReadUlongTupleItem(ref b, 1, prompt);
            ReadUlongTupleItem(ref c, 2, prompt);

            return Of(a, b, c);
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Ulong. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong, ulong, ulong, ulong> ReadUlongTuple4(string prompt = EmptyStringHelper.Empty)
        {
            ulong a = default;
            ulong b = default;
            ulong c = default;
            ulong d = default;

            ReadUlongTupleItem(ref a, 0, prompt);
            ReadUlongTupleItem(ref b, 1, prompt);
            ReadUlongTupleItem(ref c, 2, prompt);
            ReadUlongTupleItem(ref d, 3, prompt);

            return Of(a, b, c, d);
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Ulong. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong, ulong, ulong, ulong, ulong> ReadUlongTuple5(string prompt = EmptyStringHelper.Empty)
        {
            ulong a = default;
            ulong b = default;
            ulong c = default;
            ulong d = default;
            ulong e = default;

            ReadUlongTupleItem(ref a, 0, prompt);
            ReadUlongTupleItem(ref b, 1, prompt);
            ReadUlongTupleItem(ref c, 2, prompt);
            ReadUlongTupleItem(ref d, 3, prompt);
            ReadUlongTupleItem(ref e, 4, prompt);

            return Of(a, b, c, d, e);
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Ulong. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong, ulong, ulong, ulong, ulong, ulong> ReadUlongTuple6(string prompt = EmptyStringHelper.Empty)
        {
            ulong a = default;
            ulong b = default;
            ulong c = default;
            ulong d = default;
            ulong e = default;
            ulong f = default;

            ReadUlongTupleItem(ref a, 0, prompt);
            ReadUlongTupleItem(ref b, 1, prompt);
            ReadUlongTupleItem(ref c, 2, prompt);
            ReadUlongTupleItem(ref d, 3, prompt);
            ReadUlongTupleItem(ref e, 4, prompt);
            ReadUlongTupleItem(ref f, 5, prompt);

            return Of(a, b, c, d, e, f);
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Ulong. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong, ulong, ulong, ulong, ulong, ulong, ulong> ReadUlongTuple7(string prompt = EmptyStringHelper.Empty)
        {
            ulong a = default;
            ulong b = default;
            ulong c = default;
            ulong d = default;
            ulong e = default;
            ulong f = default;
            ulong g = default;

            ReadUlongTupleItem(ref a, 0, prompt);
            ReadUlongTupleItem(ref b, 1, prompt);
            ReadUlongTupleItem(ref c, 2, prompt);
            ReadUlongTupleItem(ref d, 3, prompt);
            ReadUlongTupleItem(ref e, 4, prompt);
            ReadUlongTupleItem(ref f, 5, prompt);
            ReadUlongTupleItem(ref g, 6, prompt);

            return Of(a, b, c, d, e, f, g);
        }

        #endregion

        #region ReadShort

        /// <summary>
        /// Читает кортеж из двух значений типа Short. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<short, short> ReadShortTuple2(string prompt = EmptyStringHelper.Empty)
        {
            short a = default;
            short b = default;

            ReadShortTupleItem(ref a, 0, prompt);
            ReadShortTupleItem(ref b, 1, prompt);

            return Of(a, b);
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Short. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<short, short, short> ReadShortTuple3(string prompt = EmptyStringHelper.Empty)
        {
            short a = default;
            short b = default;
            short c = default;

            ReadShortTupleItem(ref a, 0, prompt);
            ReadShortTupleItem(ref b, 1, prompt);
            ReadShortTupleItem(ref c, 2, prompt);

            return Of(a, b, c);
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Short. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<short, short, short, short> ReadShortTuple4(string prompt = EmptyStringHelper.Empty)
        {
            short a = default;
            short b = default;
            short c = default;
            short d = default;

            ReadShortTupleItem(ref a, 0, prompt);
            ReadShortTupleItem(ref b, 1, prompt);
            ReadShortTupleItem(ref c, 2, prompt);
            ReadShortTupleItem(ref d, 3, prompt);

            return Of(a, b, c, d);
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Short. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<short, short, short, short, short> ReadShortTuple5(string prompt = EmptyStringHelper.Empty)
        {
            short a = default;
            short b = default;
            short c = default;
            short d = default;
            short e = default;

            ReadShortTupleItem(ref a, 0, prompt);
            ReadShortTupleItem(ref b, 1, prompt);
            ReadShortTupleItem(ref c, 2, prompt);
            ReadShortTupleItem(ref d, 3, prompt);
            ReadShortTupleItem(ref e, 4, prompt);

            return Of(a, b, c, d, e);
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Short. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<short, short, short, short, short, short> ReadShortTuple6(string prompt = EmptyStringHelper.Empty)
        {
            short a = default;
            short b = default;
            short c = default;
            short d = default;
            short e = default;
            short f = default;

            ReadShortTupleItem(ref a, 0, prompt);
            ReadShortTupleItem(ref b, 1, prompt);
            ReadShortTupleItem(ref c, 2, prompt);
            ReadShortTupleItem(ref d, 3, prompt);
            ReadShortTupleItem(ref e, 4, prompt);
            ReadShortTupleItem(ref f, 5, prompt);

            return Of(a, b, c, d, e, f);
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Short. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<short, short, short, short, short, short, short> ReadShortTuple7(string prompt = EmptyStringHelper.Empty)
        {
            short a = default;
            short b = default;
            short c = default;
            short d = default;
            short e = default;
            short f = default;
            short g = default;

            ReadShortTupleItem(ref a, 0, prompt);
            ReadShortTupleItem(ref b, 1, prompt);
            ReadShortTupleItem(ref c, 2, prompt);
            ReadShortTupleItem(ref d, 3, prompt);
            ReadShortTupleItem(ref e, 4, prompt);
            ReadShortTupleItem(ref f, 5, prompt);
            ReadShortTupleItem(ref g, 6, prompt);

            return Of(a, b, c, d, e, f, g);
        }

        #endregion

        #region ReadUshort

        /// <summary>
        /// Читает кортеж из двух значений типа Ushort. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort, ushort> ReadUshortTuple2(string prompt = EmptyStringHelper.Empty)
        {
            ushort a = default;
            ushort b = default;

            ReadUshortTupleItem(ref a, 0, prompt);
            ReadUshortTupleItem(ref b, 1, prompt);

            return Of(a, b);
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Ushort. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort, ushort, ushort> ReadUshortTuple3(string prompt = EmptyStringHelper.Empty)
        {
            ushort a = default;
            ushort b = default;
            ushort c = default;

            ReadUshortTupleItem(ref a, 0, prompt);
            ReadUshortTupleItem(ref b, 1, prompt);
            ReadUshortTupleItem(ref c, 2, prompt);

            return Of(a, b, c);
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Ushort. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort, ushort, ushort, ushort> ReadUshortTuple4(string prompt = EmptyStringHelper.Empty)
        {
            ushort a = default;
            ushort b = default;
            ushort c = default;
            ushort d = default;

            ReadUshortTupleItem(ref a, 0, prompt);
            ReadUshortTupleItem(ref b, 1, prompt);
            ReadUshortTupleItem(ref c, 2, prompt);
            ReadUshortTupleItem(ref d, 3, prompt);

            return Of(a, b, c, d);
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Ushort. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort, ushort, ushort, ushort, ushort> ReadUshortTuple5(string prompt = EmptyStringHelper.Empty)
        {
            ushort a = default;
            ushort b = default;
            ushort c = default;
            ushort d = default;
            ushort e = default;

            ReadUshortTupleItem(ref a, 0, prompt);
            ReadUshortTupleItem(ref b, 1, prompt);
            ReadUshortTupleItem(ref c, 2, prompt);
            ReadUshortTupleItem(ref d, 3, prompt);
            ReadUshortTupleItem(ref e, 4, prompt);

            return Of(a, b, c, d, e);
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Ushort. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort, ushort, ushort, ushort, ushort, ushort> ReadUshortTuple6(string prompt = EmptyStringHelper.Empty)
        {
            ushort a = default;
            ushort b = default;
            ushort c = default;
            ushort d = default;
            ushort e = default;
            ushort f = default;

            ReadUshortTupleItem(ref a, 0, prompt);
            ReadUshortTupleItem(ref b, 1, prompt);
            ReadUshortTupleItem(ref c, 2, prompt);
            ReadUshortTupleItem(ref d, 3, prompt);
            ReadUshortTupleItem(ref e, 4, prompt);
            ReadUshortTupleItem(ref f, 5, prompt);

            return Of(a, b, c, d, e, f);
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Ushort. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort, ushort, ushort, ushort, ushort, ushort, ushort> ReadUshortTuple7(string prompt = EmptyStringHelper.Empty)
        {
            ushort a = default;
            ushort b = default;
            ushort c = default;
            ushort d = default;
            ushort e = default;
            ushort f = default;
            ushort g = default;

            ReadUshortTupleItem(ref a, 0, prompt);
            ReadUshortTupleItem(ref b, 1, prompt);
            ReadUshortTupleItem(ref c, 2, prompt);
            ReadUshortTupleItem(ref d, 3, prompt);
            ReadUshortTupleItem(ref e, 4, prompt);
            ReadUshortTupleItem(ref f, 5, prompt);
            ReadUshortTupleItem(ref g, 6, prompt);

            return Of(a, b, c, d, e, f, g);
        }

        #endregion

        #region ReadBiginteger

        /// <summary>
        /// Читает кортеж из двух значений типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger, BigInteger> ReadBigIntegerTuple2(string prompt = EmptyStringHelper.Empty)
        {
            BigInteger a = default;
            BigInteger b = default;

            ReadBigIntegerTupleItem(ref a, 0, prompt);
            ReadBigIntegerTupleItem(ref b, 1, prompt);

            return Of(a, b);
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger, BigInteger, BigInteger> ReadBigIntegerTuple3(string prompt = EmptyStringHelper.Empty)
        {
            BigInteger a = default;
            BigInteger b = default;
            BigInteger c = default;

            ReadBigIntegerTupleItem(ref a, 0, prompt);
            ReadBigIntegerTupleItem(ref b, 1, prompt);
            ReadBigIntegerTupleItem(ref c, 2, prompt);

            return Of(a, b, c);
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger, BigInteger, BigInteger, BigInteger> ReadBigIntegerTuple4(string prompt = EmptyStringHelper.Empty)
        {
            BigInteger a = default;
            BigInteger b = default;
            BigInteger c = default;
            BigInteger d = default;

            ReadBigIntegerTupleItem(ref a, 0, prompt);
            ReadBigIntegerTupleItem(ref b, 1, prompt);
            ReadBigIntegerTupleItem(ref c, 2, prompt);
            ReadBigIntegerTupleItem(ref d, 3, prompt);

            return Of(a, b, c, d);
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger, BigInteger, BigInteger, BigInteger, BigInteger> ReadBigIntegerTuple5(string prompt = EmptyStringHelper.Empty)
        {
            BigInteger a = default;
            BigInteger b = default;
            BigInteger c = default;
            BigInteger d = default;
            BigInteger e = default;

            ReadBigIntegerTupleItem(ref a, 0, prompt);
            ReadBigIntegerTupleItem(ref b, 1, prompt);
            ReadBigIntegerTupleItem(ref c, 2, prompt);
            ReadBigIntegerTupleItem(ref d, 3, prompt);
            ReadBigIntegerTupleItem(ref e, 4, prompt);

            return Of(a, b, c, d, e);
        }

        /// <summary>
        /// Читает кортеж из шести значений типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger, BigInteger, BigInteger, BigInteger, BigInteger, BigInteger> ReadBigIntegerTuple6(string prompt = EmptyStringHelper.Empty)
        {
            BigInteger a = default;
            BigInteger b = default;
            BigInteger c = default;
            BigInteger d = default;
            BigInteger e = default;
            BigInteger f = default;

            ReadBigIntegerTupleItem(ref a, 0, prompt);
            ReadBigIntegerTupleItem(ref b, 1, prompt);
            ReadBigIntegerTupleItem(ref c, 2, prompt);
            ReadBigIntegerTupleItem(ref d, 3, prompt);
            ReadBigIntegerTupleItem(ref e, 4, prompt);
            ReadBigIntegerTupleItem(ref f, 5, prompt);

            return Of(a, b, c, d, e, f);
        }

        /// <summary>
        /// Читает кортеж из семи значений типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger, BigInteger, BigInteger, BigInteger, BigInteger, BigInteger, BigInteger> ReadBigIntegerTuple7(string prompt = EmptyStringHelper.Empty)
        {
            BigInteger a = default;
            BigInteger b = default;
            BigInteger c = default;
            BigInteger d = default;
            BigInteger e = default;
            BigInteger f = default;
            BigInteger g = default;

            ReadBigIntegerTupleItem(ref a, 0, prompt);
            ReadBigIntegerTupleItem(ref b, 1, prompt);
            ReadBigIntegerTupleItem(ref c, 2, prompt);
            ReadBigIntegerTupleItem(ref d, 3, prompt);
            ReadBigIntegerTupleItem(ref e, 4, prompt);
            ReadBigIntegerTupleItem(ref f, 5, prompt);
            ReadBigIntegerTupleItem(ref g, 6, prompt);

            return Of(a, b, c, d, e, f, g);
        }

        #endregion

        #region ReadString

        /// <summary>
        /// Читает кортеж из двух значений типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<string, string> ReadStringTuple2(string prompt = EmptyStringHelper.Empty)
        {
            string a = default;
            string b = default;

            ReadStringTupleItem(ref a, 0, prompt);
            ReadStringTupleItem(ref b, 1, prompt);

            return Of(a, b);
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<string, string, string> ReadStringTuple3(string prompt = EmptyStringHelper.Empty)
        {
            string a = default;
            string b = default;
            string c = default;

            ReadStringTupleItem(ref a, 0, prompt);
            ReadStringTupleItem(ref b, 1, prompt);
            ReadStringTupleItem(ref c, 2, prompt);

            return Of(a, b, c);
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<string, string, string, string> ReadStringTuple4(string prompt = EmptyStringHelper.Empty)
        {
            string a = default;
            string b = default;
            string c = default;
            string d = default;

            ReadStringTupleItem(ref a, 0, prompt);
            ReadStringTupleItem(ref b, 1, prompt);
            ReadStringTupleItem(ref c, 2, prompt);
            ReadStringTupleItem(ref d, 3, prompt);

            return Of(a, b, c, d);
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<string, string, string, string, string> ReadStringTuple5(string prompt = EmptyStringHelper.Empty)
        {
            string a = default;
            string b = default;
            string c = default;
            string d = default;
            string e = default;

            ReadStringTupleItem(ref a, 0, prompt);
            ReadStringTupleItem(ref b, 1, prompt);
            ReadStringTupleItem(ref c, 2, prompt);
            ReadStringTupleItem(ref d, 3, prompt);
            ReadStringTupleItem(ref e, 4, prompt);

            return Of(a, b, c, d, e);
        }

        /// <summary>
        /// Читает кортеж из шести значений типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<string, string, string, string, string, string> ReadStringTuple6(string prompt = EmptyStringHelper.Empty)
        {
            string a = default;
            string b = default;
            string c = default;
            string d = default;
            string e = default;
            string f = default;

            ReadStringTupleItem(ref a, 0, prompt);
            ReadStringTupleItem(ref b, 1, prompt);
            ReadStringTupleItem(ref c, 2, prompt);
            ReadStringTupleItem(ref d, 3, prompt);
            ReadStringTupleItem(ref e, 4, prompt);
            ReadStringTupleItem(ref f, 5, prompt);

            return Of(a, b, c, d, e, f);
        }

        /// <summary>
        /// Читает кортеж из семи значений типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<string, string, string, string, string, string, string> ReadStringTuple7(string prompt = EmptyStringHelper.Empty)
        {
            string a = default;
            string b = default;
            string c = default;
            string d = default;
            string e = default;
            string f = default;
            string g = default;

            ReadStringTupleItem(ref a, 0, prompt);
            ReadStringTupleItem(ref b, 1, prompt);
            ReadStringTupleItem(ref c, 2, prompt);
            ReadStringTupleItem(ref d, 3, prompt);
            ReadStringTupleItem(ref e, 4, prompt);
            ReadStringTupleItem(ref f, 5, prompt);
            ReadStringTupleItem(ref g, 6, prompt);

            return Of(a, b, c, d, e, f, g);
        }

        #endregion

        #endregion public

        #region private

        private static void ReadBooleanTupleItem(ref bool field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = Base.ReadBoolean(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, index));
                    return;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        private static void ReadByteTupleItem(ref byte field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = Base.ReadByte(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, index));
                    return;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        private static void ReadSbyteTupleItem(ref sbyte field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = Base.ReadSbyte(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, index));
                    return;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        private static void ReadCharTupleItem(ref char field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, index));
                    return;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        private static void ReadDecimalTupleItem(ref decimal field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = Base.ReadDecimal(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, index));
                    return;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        private static void ReadDoubleTupleItem(ref double field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = Base.ReadDouble(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, index));
                    return;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        private static void ReadFloatTupleItem(ref float field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = Base.ReadFloat(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, index));
                    return;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        private static void ReadIntTupleItem(ref int field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = Base.ReadInt(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, index));
                    return;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        private static void ReadUintTupleItem(ref uint field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = Base.ReadUint(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, index));
                    return;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        private static void ReadLongTupleItem(ref long field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = Base.ReadLong(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, index));
                    return;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        private static void ReadUlongTupleItem(ref ulong field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = Base.ReadUlong(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, index));
                    return;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        private static void ReadShortTupleItem(ref short field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = Base.ReadShort(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, index));
                    return;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        private static void ReadUshortTupleItem(ref ushort field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = Base.ReadUshort(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, index));
                    return;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        private static void ReadBigIntegerTupleItem(ref BigInteger field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = Base.ReadBigInteger(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, index));
                    return;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        private static void ReadStringTupleItem(ref string field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, index));
                    return;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        #endregion private
    }
}
