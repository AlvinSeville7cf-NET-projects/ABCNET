using ABCNET.Extensions;
using System;

namespace ABCNET.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы с ссылочными кортежами.
    /// </summary>
    public static partial class Tuple
    {
        #region public
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
        /// Читает кортеж из двух значений типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<char, char> ReadCharTuple2(string prompt = EmptyStringHelper.Empty)
        {
            return Of(Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 0)),
                Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<char, char, char> ReadCharTuple3(string prompt = EmptyStringHelper.Empty)
        {
            return Of(Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 0)),
                Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 1)),
                Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из двух значений типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double> ReadDoubleTuple2(string prompt = EmptyStringHelper.Empty)
        {
            double a = default;
            double b = default;

            ReadRealTupleItem(ref a, 0, prompt);
            ReadRealTupleItem(ref b, 1, prompt);

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

            ReadRealTupleItem(ref a, 0, prompt);
            ReadRealTupleItem(ref b, 1, prompt);
            ReadRealTupleItem(ref c, 2, prompt);

            return Of(a, b, c);
        }

        /// <summary>
        /// Читает кортеж из двух значений типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int> ReadInt32Tuple2(string prompt = EmptyStringHelper.Empty)
        {
            int a = default;
            int b = default;

            ReadIntegerTupleItem(ref a, 0, prompt);
            ReadIntegerTupleItem(ref b, 1, prompt);

            return Of(a, b);
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int, int> ReadInt32Tuple3(string prompt = EmptyStringHelper.Empty)
        {
            int a = default;
            int b = default;
            int c = default;

            ReadIntegerTupleItem(ref a, 0, prompt);
            ReadIntegerTupleItem(ref b, 1, prompt);
            ReadIntegerTupleItem(ref c, 2, prompt);

            return Of(a, b, c);
        }

        /// <summary>
        /// Читает кортеж из двух значений типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<string, string> ReadStringTuple2(string prompt = EmptyStringHelper.Empty)
        {
            return Of(Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 0)),
                Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<string, string, string> ReadStringTuple3(string prompt = EmptyStringHelper.Empty)
        {
            return Of(Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 0)),
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
                    InputErrorHelper.Message.PrintLine();
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
                    InputErrorHelper.Message.PrintLine();
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
                    InputErrorHelper.Message.PrintLine();
                }
        }
        #endregion private
    }
}
