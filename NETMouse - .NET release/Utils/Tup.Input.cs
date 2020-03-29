using ABCNET.Extensions;
using System;

namespace ABCNET.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы с ссылочными кортежами.
    /// </summary>
    public static partial class Tup
    {
        #region public
        /// <summary>
        /// Читает кортеж из двух значений типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.ReadBooleanTuple2")]
        public static Tuple<bool, bool> ReadBooleanTup2(string prompt = EmptyStringHelper.Empty)
        {
            bool a = default;
            bool b = default;

            ReadBooleanTupleItem(ref a, 0, prompt);
            ReadBooleanTupleItem(ref b, 1, prompt);

            return New(a, b);
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.ReadBooleanTuple3")]
        public static Tuple<bool, bool, bool> ReadBooleanTup3(string prompt = EmptyStringHelper.Empty)
        {
            bool a = default;
            bool b = default;
            bool c = default;

            ReadBooleanTupleItem(ref a, 0, prompt);
            ReadBooleanTupleItem(ref b, 1, prompt);
            ReadBooleanTupleItem(ref c, 2, prompt);

            return New(a, b, c);
        }

        /// <summary>
        /// Читает кортеж из двух значений типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.ReadCharTuple2")]
        public static Tuple<char, char> ReadCharTup2(string prompt = EmptyStringHelper.Empty)
        {
            return New(Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 0)),
                Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.ReadCharTuple3")]
        public static Tuple<char, char, char> ReadCharTup3(string prompt = EmptyStringHelper.Empty)
        {
            return New(Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 0)),
                Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 1)),
                Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из двух значений типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.ReadDoubleTuple2")]
        public static Tuple<double, double> ReadDoubleTup2(string prompt = EmptyStringHelper.Empty)
        {
            double a = default;
            double b = default;

            ReadRealTupleItem(ref a, 0, prompt);
            ReadRealTupleItem(ref b, 1, prompt);

            return New(a, b);
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.ReadDoubleTuple3")]
        public static Tuple<double, double, double> ReadDoubleTup3(string prompt = EmptyStringHelper.Empty)
        {
            double a = default;
            double b = default;
            double c = default;

            ReadRealTupleItem(ref a, 0, prompt);
            ReadRealTupleItem(ref b, 1, prompt);
            ReadRealTupleItem(ref c, 2, prompt);

            return New(a, b, c);
        }

        /// <summary>
        /// Читает кортеж из двух значений типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.ReadInt32Tuple2")]
        public static Tuple<int, int> ReadInt32Tup2(string prompt = EmptyStringHelper.Empty)
        {
            int a = default;
            int b = default;

            ReadIntegerTupleItem(ref a, 0, prompt);
            ReadIntegerTupleItem(ref b, 1, prompt);

            return New(a, b);
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.ReadInt32Tuple3")]
        public static Tuple<int, int, int> ReadInt32Tup3(string prompt = EmptyStringHelper.Empty)
        {
            int a = default;
            int b = default;
            int c = default;

            ReadIntegerTupleItem(ref a, 0, prompt);
            ReadIntegerTupleItem(ref b, 1, prompt);
            ReadIntegerTupleItem(ref c, 2, prompt);

            return New(a, b, c);
        }

        /// <summary>
        /// Читает кортеж из двух значений типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.ReadStringTuple2")]
        public static Tuple<string, string> ReadStringTup2(string prompt = EmptyStringHelper.Empty)
        {
            return New(Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 0)),
                Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.ReadStringTuple3")]
        public static Tuple<string, string, string> ReadStringTup3(string prompt = EmptyStringHelper.Empty)
        {
            return New(Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 0)),
                Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 1)),
                Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 2)));
        }
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
                    InputErrorHelper.Message.Println();
                }
        }

        private static void ReadIntegerTupleItem(ref int field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = Base.ReadInt32(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, index));
                    return;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.Println();
                }
        }

        private static void ReadRealTupleItem(ref double field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = Base.ReadDouble(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, index));
                    return;
                }
                catch (Exception)
                {
                    InputErrorHelper.Message.Println();
                }
        }
        #endregion private
    }
}
