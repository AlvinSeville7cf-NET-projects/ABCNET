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

            ReadSByteTupleItem(ref a, 0, prompt);
            ReadSByteTupleItem(ref b, 1, prompt);

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

            ReadSByteTupleItem(ref a, 0, prompt);
            ReadSByteTupleItem(ref b, 1, prompt);
            ReadSByteTupleItem(ref c, 2, prompt);

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

            ReadSByteTupleItem(ref a, 0, prompt);
            ReadSByteTupleItem(ref b, 1, prompt);
            ReadSByteTupleItem(ref c, 2, prompt);
            ReadSByteTupleItem(ref d, 3, prompt);

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

            ReadSByteTupleItem(ref a, 0, prompt);
            ReadSByteTupleItem(ref b, 1, prompt);
            ReadSByteTupleItem(ref c, 2, prompt);
            ReadSByteTupleItem(ref d, 3, prompt);
            ReadSByteTupleItem(ref e, 4, prompt);

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

            ReadSByteTupleItem(ref a, 0, prompt);
            ReadSByteTupleItem(ref b, 1, prompt);
            ReadSByteTupleItem(ref c, 2, prompt);
            ReadSByteTupleItem(ref d, 3, prompt);
            ReadSByteTupleItem(ref e, 4, prompt);
            ReadSByteTupleItem(ref f, 5, prompt);

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

            ReadSByteTupleItem(ref a, 0, prompt);
            ReadSByteTupleItem(ref b, 1, prompt);
            ReadSByteTupleItem(ref c, 2, prompt);
            ReadSByteTupleItem(ref d, 3, prompt);
            ReadSByteTupleItem(ref e, 4, prompt);
            ReadSByteTupleItem(ref f, 5, prompt);
            ReadSByteTupleItem(ref g, 6, prompt);

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
        /// Читает кортеж из двух значений типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<float, float> ReadSingleTuple2(string prompt = EmptyStringHelper.Empty)
        {
            float a = default;
            float b = default;

            ReadSingleTupleItem(ref a, 0, prompt);
            ReadSingleTupleItem(ref b, 1, prompt);

            return Of(a, b);
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<float, float, float> ReadSingleTuple3(string prompt = EmptyStringHelper.Empty)
        {
            float a = default;
            float b = default;
            float c = default;

            ReadSingleTupleItem(ref a, 0, prompt);
            ReadSingleTupleItem(ref b, 1, prompt);
            ReadSingleTupleItem(ref c, 2, prompt);

            return Of(a, b, c);
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<float, float, float, float> ReadSingleTuple4(string prompt = EmptyStringHelper.Empty)
        {
            float a = default;
            float b = default;
            float c = default;
            float d = default;

            ReadSingleTupleItem(ref a, 0, prompt);
            ReadSingleTupleItem(ref b, 1, prompt);
            ReadSingleTupleItem(ref c, 2, prompt);
            ReadSingleTupleItem(ref d, 3, prompt);

            return Of(a, b, c, d);
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<float, float, float, float, float> ReadSingleTuple5(string prompt = EmptyStringHelper.Empty)
        {
            float a = default;
            float b = default;
            float c = default;
            float d = default;
            float e = default;

            ReadSingleTupleItem(ref a, 0, prompt);
            ReadSingleTupleItem(ref b, 1, prompt);
            ReadSingleTupleItem(ref c, 2, prompt);
            ReadSingleTupleItem(ref d, 3, prompt);
            ReadSingleTupleItem(ref e, 4, prompt);

            return Of(a, b, c, d, e);
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<float, float, float, float, float, float> ReadSingleTuple6(string prompt = EmptyStringHelper.Empty)
        {
            float a = default;
            float b = default;
            float c = default;
            float d = default;
            float e = default;
            float f = default;

            ReadSingleTupleItem(ref b, 1, prompt);
            ReadSingleTupleItem(ref c, 2, prompt);
            ReadSingleTupleItem(ref d, 3, prompt);
            ReadSingleTupleItem(ref e, 4, prompt);
            ReadSingleTupleItem(ref f, 5, prompt);

            return Of(a, b, c, d, e, f);
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<float, float, float, float, float, float, float> ReadSingleTuple7(string prompt = EmptyStringHelper.Empty)
        {
            float a = default;
            float b = default;
            float c = default;
            float d = default;
            float e = default;
            float f = default;
            float g = default;

            ReadSingleTupleItem(ref a, 0, prompt);
            ReadSingleTupleItem(ref b, 1, prompt);
            ReadSingleTupleItem(ref c, 2, prompt);
            ReadSingleTupleItem(ref d, 3, prompt);
            ReadSingleTupleItem(ref e, 4, prompt);
            ReadSingleTupleItem(ref f, 5, prompt);
            ReadSingleTupleItem(ref g, 6, prompt);

            return Of(a, b, c, d, e, f, g);
        }

        #endregion

        #region ReadInt32

        /// <summary>
        /// Читает кортеж из двух значений типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int> ReadInt32Tuple2(string prompt = EmptyStringHelper.Empty)
        {
            int a = default;
            int b = default;

            ReadInt32TupleItem(ref a, 0, prompt);
            ReadInt32TupleItem(ref b, 1, prompt);

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

            ReadInt32TupleItem(ref a, 0, prompt);
            ReadInt32TupleItem(ref b, 1, prompt);
            ReadInt32TupleItem(ref c, 2, prompt);

            return Of(a, b, c);
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int, int, int> ReadInt32Tuple4(string prompt = EmptyStringHelper.Empty)
        {
            int a = default;
            int b = default;
            int c = default;
            int d = default;

            ReadInt32TupleItem(ref a, 0, prompt);
            ReadInt32TupleItem(ref b, 1, prompt);
            ReadInt32TupleItem(ref c, 2, prompt);
            ReadInt32TupleItem(ref d, 3, prompt);

            return Of(a, b, c, d);
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int, int, int, int> ReadInt32Tuple5(string prompt = EmptyStringHelper.Empty)
        {
            int a = default;
            int b = default;
            int c = default;
            int d = default;
            int e = default;

            ReadInt32TupleItem(ref a, 0, prompt);
            ReadInt32TupleItem(ref b, 1, prompt);
            ReadInt32TupleItem(ref c, 2, prompt);
            ReadInt32TupleItem(ref d, 3, prompt);
            ReadInt32TupleItem(ref e, 4, prompt);

            return Of(a, b, c, d, e);
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int, int, int, int, int> ReadInt32Tuple6(string prompt = EmptyStringHelper.Empty)
        {
            int a = default;
            int b = default;
            int c = default;
            int d = default;
            int e = default;
            int f = default;

            ReadInt32TupleItem(ref a, 0, prompt);
            ReadInt32TupleItem(ref b, 1, prompt);
            ReadInt32TupleItem(ref c, 2, prompt);
            ReadInt32TupleItem(ref d, 3, prompt);
            ReadInt32TupleItem(ref e, 4, prompt);
            ReadInt32TupleItem(ref f, 5, prompt);

            return Of(a, b, c, d, e, f);
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int, int, int, int, int, int> ReadInt32Tuple7(string prompt = EmptyStringHelper.Empty)
        {
            int a = default;
            int b = default;
            int c = default;
            int d = default;
            int e = default;
            int f = default;
            int g = default;

            ReadInt32TupleItem(ref a, 0, prompt);
            ReadInt32TupleItem(ref b, 1, prompt);
            ReadInt32TupleItem(ref c, 2, prompt);
            ReadInt32TupleItem(ref d, 3, prompt);
            ReadInt32TupleItem(ref e, 4, prompt);
            ReadInt32TupleItem(ref f, 5, prompt);
            ReadInt32TupleItem(ref g, 6, prompt);

            return Of(a, b, c, d, e, f, g);
        }

        #endregion

        #region ReadUint32

        /// <summary>
        /// Читает кортеж из двух значений типа Uint32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint, uint> ReadUint32Tuple2(string prompt = EmptyStringHelper.Empty)
        {
            uint a = default;
            uint b = default;

            ReadUint32TupleItem(ref a, 0, prompt);
            ReadUint32TupleItem(ref b, 1, prompt);

            return Of(a, b);
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Uint32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint, uint, uint> ReadUint32Tuple3(string prompt = EmptyStringHelper.Empty)
        {
            uint a = default;
            uint b = default;
            uint c = default;

            ReadUint32TupleItem(ref a, 0, prompt);
            ReadUint32TupleItem(ref b, 1, prompt);
            ReadUint32TupleItem(ref c, 2, prompt);

            return Of(a, b, c);
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Uint32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint, uint, uint, uint> ReadUint32Tuple4(string prompt = EmptyStringHelper.Empty)
        {
            uint a = default;
            uint b = default;
            uint c = default;
            uint d = default;

            ReadUint32TupleItem(ref a, 0, prompt);
            ReadUint32TupleItem(ref b, 1, prompt);
            ReadUint32TupleItem(ref c, 2, prompt);
            ReadUint32TupleItem(ref d, 3, prompt);

            return Of(a, b, c, d);
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Uint32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint, uint, uint, uint, uint> ReadUint32Tuple5(string prompt = EmptyStringHelper.Empty)
        {
            uint a = default;
            uint b = default;
            uint c = default;
            uint d = default;
            uint e = default;

            ReadUint32TupleItem(ref a, 0, prompt);
            ReadUint32TupleItem(ref b, 1, prompt);
            ReadUint32TupleItem(ref c, 2, prompt);
            ReadUint32TupleItem(ref d, 3, prompt);
            ReadUint32TupleItem(ref e, 4, prompt);

            return Of(a, b, c, d, e);
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Uint32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint, uint, uint, uint, uint, uint> ReadUint32Tuple6(string prompt = EmptyStringHelper.Empty)
        {
            uint a = default;
            uint b = default;
            uint c = default;
            uint d = default;
            uint e = default;
            uint f = default;

            ReadUint32TupleItem(ref a, 0, prompt);
            ReadUint32TupleItem(ref b, 1, prompt);
            ReadUint32TupleItem(ref c, 2, prompt);
            ReadUint32TupleItem(ref d, 3, prompt);
            ReadUint32TupleItem(ref e, 4, prompt);
            ReadUint32TupleItem(ref f, 5, prompt);

            return Of(a, b, c, d, e, f);
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Uint32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint, uint, uint, uint, uint, uint, uint> ReadUint32Tuple7(string prompt = EmptyStringHelper.Empty)
        {
            uint a = default;
            uint b = default;
            uint c = default;
            uint d = default;
            uint e = default;
            uint f = default;
            uint g = default;

            ReadUint32TupleItem(ref a, 0, prompt);
            ReadUint32TupleItem(ref b, 1, prompt);
            ReadUint32TupleItem(ref c, 2, prompt);
            ReadUint32TupleItem(ref d, 3, prompt);
            ReadUint32TupleItem(ref e, 4, prompt);
            ReadUint32TupleItem(ref f, 5, prompt);
            ReadUint32TupleItem(ref g, 6, prompt);

            return Of(a, b, c, d, e, f, g);
        }

        #endregion

        #region ReadInt64

        /// <summary>
        /// Читает кортеж из двух значений типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<long, long> ReadInt64Tuple2(string prompt = EmptyStringHelper.Empty)
        {
            long a = default;
            long b = default;

            ReadInt64TupleItem(ref a, 0, prompt);
            ReadInt64TupleItem(ref b, 1, prompt);

            return Of(a, b);
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<long, long, long> ReadInt64Tuple3(string prompt = EmptyStringHelper.Empty)
        {
            long a = default;
            long b = default;
            long c = default;

            ReadInt64TupleItem(ref a, 0, prompt);
            ReadInt64TupleItem(ref b, 1, prompt);
            ReadInt64TupleItem(ref c, 2, prompt);

            return Of(a, b, c);
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<long, long, long, long> ReadInt64Tuple4(string prompt = EmptyStringHelper.Empty)
        {
            long a = default;
            long b = default;
            long c = default;
            long d = default;

            ReadInt64TupleItem(ref a, 0, prompt);
            ReadInt64TupleItem(ref b, 1, prompt);
            ReadInt64TupleItem(ref c, 2, prompt);
            ReadInt64TupleItem(ref d, 3, prompt);

            return Of(a, b, c, d);
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<long, long, long, long, long> ReadInt64Tuple5(string prompt = EmptyStringHelper.Empty)
        {
            long a = default;
            long b = default;
            long c = default;
            long d = default;
            long e = default;

            ReadInt64TupleItem(ref a, 0, prompt);
            ReadInt64TupleItem(ref b, 1, prompt);
            ReadInt64TupleItem(ref c, 2, prompt);
            ReadInt64TupleItem(ref d, 3, prompt);
            ReadInt64TupleItem(ref e, 4, prompt);

            return Of(a, b, c, d, e);
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<long, long, long, long, long, long> ReadInt64Tuple6(string prompt = EmptyStringHelper.Empty)
        {
            long a = default;
            long b = default;
            long c = default;
            long d = default;
            long e = default;
            long f = default;

            ReadInt64TupleItem(ref a, 0, prompt);
            ReadInt64TupleItem(ref b, 1, prompt);
            ReadInt64TupleItem(ref c, 2, prompt);
            ReadInt64TupleItem(ref d, 3, prompt);
            ReadInt64TupleItem(ref e, 4, prompt);
            ReadInt64TupleItem(ref f, 5, prompt);

            return Of(a, b, c, d, e, f);
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<long, long, long, long, long, long, long> ReadInt64Tuple7(string prompt = EmptyStringHelper.Empty)
        {
            long a = default;
            long b = default;
            long c = default;
            long d = default;
            long e = default;
            long f = default;
            long g = default;

            ReadInt64TupleItem(ref a, 0, prompt);
            ReadInt64TupleItem(ref b, 1, prompt);
            ReadInt64TupleItem(ref c, 2, prompt);
            ReadInt64TupleItem(ref d, 3, prompt);
            ReadInt64TupleItem(ref e, 4, prompt);
            ReadInt64TupleItem(ref f, 5, prompt);
            ReadInt64TupleItem(ref g, 6, prompt);

            return Of(a, b, c, d, e, f, g);
        }

        #endregion

        #region ReadUInt64

        /// <summary>
        /// Читает кортеж из двух значений типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong, ulong> ReadUInt64Tuple2(string prompt = EmptyStringHelper.Empty)
        {
            ulong a = default;
            ulong b = default;

            ReadUInt64TupleItem(ref a, 0, prompt);
            ReadUInt64TupleItem(ref b, 1, prompt);

            return Of(a, b);
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong, ulong, ulong> ReadUInt64Tuple3(string prompt = EmptyStringHelper.Empty)
        {
            ulong a = default;
            ulong b = default;
            ulong c = default;

            ReadUInt64TupleItem(ref a, 0, prompt);
            ReadUInt64TupleItem(ref b, 1, prompt);
            ReadUInt64TupleItem(ref c, 2, prompt);

            return Of(a, b, c);
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong, ulong, ulong, ulong> ReadUInt64Tuple4(string prompt = EmptyStringHelper.Empty)
        {
            ulong a = default;
            ulong b = default;
            ulong c = default;
            ulong d = default;

            ReadUInt64TupleItem(ref a, 0, prompt);
            ReadUInt64TupleItem(ref b, 1, prompt);
            ReadUInt64TupleItem(ref c, 2, prompt);
            ReadUInt64TupleItem(ref d, 3, prompt);

            return Of(a, b, c, d);
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong, ulong, ulong, ulong, ulong> ReadUInt64Tuple5(string prompt = EmptyStringHelper.Empty)
        {
            ulong a = default;
            ulong b = default;
            ulong c = default;
            ulong d = default;
            ulong e = default;

            ReadUInt64TupleItem(ref a, 0, prompt);
            ReadUInt64TupleItem(ref b, 1, prompt);
            ReadUInt64TupleItem(ref c, 2, prompt);
            ReadUInt64TupleItem(ref d, 3, prompt);
            ReadUInt64TupleItem(ref e, 4, prompt);

            return Of(a, b, c, d, e);
        }

        /// <summary>
        /// Читает кортеж из шести значений типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong, ulong, ulong, ulong, ulong, ulong> ReadUInt64Tuple6(string prompt = EmptyStringHelper.Empty)
        {
            ulong a = default;
            ulong b = default;
            ulong c = default;
            ulong d = default;
            ulong e = default;
            ulong f = default;

            ReadUInt64TupleItem(ref a, 0, prompt);
            ReadUInt64TupleItem(ref b, 1, prompt);
            ReadUInt64TupleItem(ref c, 2, prompt);
            ReadUInt64TupleItem(ref d, 3, prompt);
            ReadUInt64TupleItem(ref e, 4, prompt);
            ReadUInt64TupleItem(ref f, 5, prompt);

            return Of(a, b, c, d, e, f);
        }

        /// <summary>
        /// Читает кортеж из семи значений типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong, ulong, ulong, ulong, ulong, ulong, ulong> ReadUInt64Tuple7(string prompt = EmptyStringHelper.Empty)
        {
            ulong a = default;
            ulong b = default;
            ulong c = default;
            ulong d = default;
            ulong e = default;
            ulong f = default;
            ulong g = default;

            ReadUInt64TupleItem(ref a, 0, prompt);
            ReadUInt64TupleItem(ref b, 1, prompt);
            ReadUInt64TupleItem(ref c, 2, prompt);
            ReadUInt64TupleItem(ref d, 3, prompt);
            ReadUInt64TupleItem(ref e, 4, prompt);
            ReadUInt64TupleItem(ref f, 5, prompt);
            ReadUInt64TupleItem(ref g, 6, prompt);

            return Of(a, b, c, d, e, f, g);
        }

        #endregion

        #region ReadInt16

        /// <summary>
        /// Читает кортеж из двух значений типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<short, short> ReadInt16Tuple2(string prompt = EmptyStringHelper.Empty)
        {
            short a = default;
            short b = default;

            ReadInt16TupleItem(ref a, 0, prompt);
            ReadInt16TupleItem(ref b, 1, prompt);

            return Of(a, b);
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<short, short, short> ReadInt16Tuple3(string prompt = EmptyStringHelper.Empty)
        {
            short a = default;
            short b = default;
            short c = default;

            ReadInt16TupleItem(ref a, 0, prompt);
            ReadInt16TupleItem(ref b, 1, prompt);
            ReadInt16TupleItem(ref c, 2, prompt);

            return Of(a, b, c);
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<short, short, short, short> ReadInt16Tuple4(string prompt = EmptyStringHelper.Empty)
        {
            short a = default;
            short b = default;
            short c = default;
            short d = default;

            ReadInt16TupleItem(ref a, 0, prompt);
            ReadInt16TupleItem(ref b, 1, prompt);
            ReadInt16TupleItem(ref c, 2, prompt);
            ReadInt16TupleItem(ref d, 3, prompt);

            return Of(a, b, c, d);
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<short, short, short, short, short> ReadInt16Tuple5(string prompt = EmptyStringHelper.Empty)
        {
            short a = default;
            short b = default;
            short c = default;
            short d = default;
            short e = default;

            ReadInt16TupleItem(ref a, 0, prompt);
            ReadInt16TupleItem(ref b, 1, prompt);
            ReadInt16TupleItem(ref c, 2, prompt);
            ReadInt16TupleItem(ref d, 3, prompt);
            ReadInt16TupleItem(ref e, 4, prompt);

            return Of(a, b, c, d, e);
        }

        /// <summary>
        /// Читает кортеж из шести значений типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<short, short, short, short, short, short> ReadInt16Tuple6(string prompt = EmptyStringHelper.Empty)
        {
            short a = default;
            short b = default;
            short c = default;
            short d = default;
            short e = default;
            short f = default;

            ReadInt16TupleItem(ref a, 0, prompt);
            ReadInt16TupleItem(ref b, 1, prompt);
            ReadInt16TupleItem(ref c, 2, prompt);
            ReadInt16TupleItem(ref d, 3, prompt);
            ReadInt16TupleItem(ref e, 4, prompt);
            ReadInt16TupleItem(ref f, 5, prompt);

            return Of(a, b, c, d, e, f);
        }

        /// <summary>
        /// Читает кортеж из семи значений типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<short, short, short, short, short, short, short> ReadInt16Tuple7(string prompt = EmptyStringHelper.Empty)
        {
            short a = default;
            short b = default;
            short c = default;
            short d = default;
            short e = default;
            short f = default;
            short g = default;

            ReadInt16TupleItem(ref a, 0, prompt);
            ReadInt16TupleItem(ref b, 1, prompt);
            ReadInt16TupleItem(ref c, 2, prompt);
            ReadInt16TupleItem(ref d, 3, prompt);
            ReadInt16TupleItem(ref e, 4, prompt);
            ReadInt16TupleItem(ref f, 5, prompt);
            ReadInt16TupleItem(ref g, 6, prompt);

            return Of(a, b, c, d, e, f, g);
        }

        #endregion

        #region ReadUInt16

        /// <summary>
        /// Читает кортеж из двух значений типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort, ushort> ReadUInt16Tuple2(string prompt = EmptyStringHelper.Empty)
        {
            ushort a = default;
            ushort b = default;

            ReadUInt16TupleItem(ref a, 0, prompt);
            ReadUInt16TupleItem(ref b, 1, prompt);

            return Of(a, b);
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort, ushort, ushort> ReadUInt16Tuple3(string prompt = EmptyStringHelper.Empty)
        {
            ushort a = default;
            ushort b = default;
            ushort c = default;

            ReadUInt16TupleItem(ref a, 0, prompt);
            ReadUInt16TupleItem(ref b, 1, prompt);
            ReadUInt16TupleItem(ref c, 2, prompt);

            return Of(a, b, c);
        }

        /// <summary>
        /// Читает кортеж из четырёх значений типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort, ushort, ushort, ushort> ReadUInt16Tuple4(string prompt = EmptyStringHelper.Empty)
        {
            ushort a = default;
            ushort b = default;
            ushort c = default;
            ushort d = default;

            ReadUInt16TupleItem(ref a, 0, prompt);
            ReadUInt16TupleItem(ref b, 1, prompt);
            ReadUInt16TupleItem(ref c, 2, prompt);
            ReadUInt16TupleItem(ref d, 3, prompt);

            return Of(a, b, c, d);
        }

        /// <summary>
        /// Читает кортеж из пяти значений типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort, ushort, ushort, ushort, ushort> ReadUInt16Tuple5(string prompt = EmptyStringHelper.Empty)
        {
            ushort a = default;
            ushort b = default;
            ushort c = default;
            ushort d = default;
            ushort e = default;

            ReadUInt16TupleItem(ref a, 0, prompt);
            ReadUInt16TupleItem(ref b, 1, prompt);
            ReadUInt16TupleItem(ref c, 2, prompt);
            ReadUInt16TupleItem(ref d, 3, prompt);
            ReadUInt16TupleItem(ref e, 4, prompt);

            return Of(a, b, c, d, e);
        }

        /// <summary>
        /// Читает кортеж из шести значений типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort, ushort, ushort, ushort, ushort, ushort> ReadUInt16Tuple6(string prompt = EmptyStringHelper.Empty)
        {
            ushort a = default;
            ushort b = default;
            ushort c = default;
            ushort d = default;
            ushort e = default;
            ushort f = default;

            ReadUInt16TupleItem(ref a, 0, prompt);
            ReadUInt16TupleItem(ref b, 1, prompt);
            ReadUInt16TupleItem(ref c, 2, prompt);
            ReadUInt16TupleItem(ref d, 3, prompt);
            ReadUInt16TupleItem(ref e, 4, prompt);
            ReadUInt16TupleItem(ref f, 5, prompt);

            return Of(a, b, c, d, e, f);
        }

        /// <summary>
        /// Читает кортеж из семи значений типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort, ushort, ushort, ushort, ushort, ushort, ushort> ReadUInt16Tuple7(string prompt = EmptyStringHelper.Empty)
        {
            ushort a = default;
            ushort b = default;
            ushort c = default;
            ushort d = default;
            ushort e = default;
            ushort f = default;
            ushort g = default;

            ReadUInt16TupleItem(ref a, 0, prompt);
            ReadUInt16TupleItem(ref b, 1, prompt);
            ReadUInt16TupleItem(ref c, 2, prompt);
            ReadUInt16TupleItem(ref d, 3, prompt);
            ReadUInt16TupleItem(ref e, 4, prompt);
            ReadUInt16TupleItem(ref f, 5, prompt);
            ReadUInt16TupleItem(ref g, 6, prompt);

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

        private static void ReadSByteTupleItem(ref sbyte field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = Base.ReadSByte(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, index));
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

        private static void ReadSingleTupleItem(ref float field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = Base.ReadSingle(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, index));
                    return;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        private static void ReadInt32TupleItem(ref int field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = Base.ReadInt32(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, index));
                    return;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        private static void ReadUint32TupleItem(ref uint field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = Base.ReadUint32(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, index));
                    return;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        private static void ReadInt64TupleItem(ref long field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = Base.ReadInt64(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, index));
                    return;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        private static void ReadUInt64TupleItem(ref ulong field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = Base.ReadUInt64(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, index));
                    return;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        private static void ReadInt16TupleItem(ref short field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = Base.ReadInt16(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, index));
                    return;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.PrintLine();
                }
        }

        private static void ReadUInt16TupleItem(ref ushort field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = Base.ReadUInt16(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, index));
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
