using System;

namespace ABCNET.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы с ссылочными кортежами.
    /// </summary>
    public static class Tup
    {

        #region Tup.New

        /// <summary>
        /// Создаёт кортеж из 2 значений.
        /// </summary>
        /// <param name="item1">Первое значение.</param>
        /// <param name="item2">Второе значение.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T2> New<T, T2>(T item1, T2 item2)
        {
            return Tuple.Create(item1, item2);
        }

        /// <summary>
        /// Создаёт кортеж из 3 значений.
        /// </summary>
        /// <param name="item1">Первое значение.</param>
        /// <param name="item2">Второе значение.</param>
        /// <param name="item3">Третье значение.</param>
        public static Tuple<T, T2, T3> New<T,T2, T3>(T item1, T2 item2, T3 item3)
        {
            return Tuple.Create(item1, item2, item3);
        }

        /// <summary>
        /// Создаёт кортеж из 4 значений.
        /// </summary>
        /// <param name="item1">Первое значение.</param>
        /// <param name="item2">Второе значение.</param>
        /// <param name="item3">Третье значение.</param>
        /// <param name="item4">Четвёртое значение.</param>
        public static Tuple<T, T2, T3, T4> New<T, T2, T3, T4>(T item1, T2 item2, T3 item3, T4 item4)
        {
            return Tuple.Create(item1, item2, item3, item4);
        }

        /// <summary>
        /// Создаёт кортеж из 5 значений.
        /// </summary>
        /// <param name="item1">Первое значение.</param>
        /// <param name="item2">Второе значение.</param>
        /// <param name="item3">Третье значение.</param>
        /// <param name="item4">Четвёртое значение.</param>
        /// <param name="item5">Пятое значение.</param>
        public static Tuple<T, T2, T3, T4, T5> New<T, T2, T3, T4, T5>(T item1, T2 item2, T3 item3, T4 item4, T5 item5)
        {
            return Tuple.Create(item1, item2, item3, item4, item5);
        }

        /// <summary>
        /// Создаёт кортеж из 6 значений.
        /// </summary>
        /// <param name="item1">Первое значение.</param>
        /// <param name="item2">Второе значение.</param>
        /// <param name="item3">Третье значение.</param>
        /// <param name="item4">Четвёртое значение.</param>
        /// <param name="item5">Пятое значение.</param>
        /// <param name="item6">Шестое значение.</param>
        public static Tuple<T, T2, T3, T4, T5, T6> New<T, T2, T3, T4, T5, T6>(T item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
        {
            return Tuple.Create(item1, item2, item3, item4, item5, item6);
        }

        /// <summary>
        /// Создаёт кортеж из 7 значений.
        /// </summary>
        /// <param name="item1">Первое значение.</param>
        /// <param name="item2">Второе значение.</param>
        /// <param name="item3">Третье значение.</param>
        /// <param name="item4">Четвёртое значение.</param>
        /// <param name="item5">Пятое значение.</param>
        /// <param name="item6">Шестое значение.</param>
        /// <param name="item7">Седьмое значение.</param>
        public static Tuple<T, T2, T3, T4, T5, T6, T7> New<T, T2, T3, T4, T5, T6, T7>(T item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
        {
            return Tuple.Create(item1, item2, item3, item4, item5, item6, item7);
        }

        #endregion

        /// <summary>
        /// Создаёт кортеж из двух случайных значений типа Integer.
        /// </summary>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int> Rand2(int low = IntegerBordersHelper.Low, int high = IntegerBordersHelper.High)
        {
            return new Tuple<int, int>(Base.Rand(low, high), Base.Rand(low, high));
        }

        /// <summary>
        /// Создаёт кортеж из трёх случайных значений типа Integer.
        /// </summary>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int, int> Rand3(int low = IntegerBordersHelper.Low, int high = IntegerBordersHelper.High)
        {
            return new Tuple<int, int, int>(Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high));
        }

        /// <summary>
        /// Создаёт кортеж из двух случайных значений типа Real.
        /// </summary>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double> Rand2(double low = RealBordersHelper.Low, double high = RealBordersHelper.High)
        {
            return new Tuple<double, double>(Base.Rand(low, high), Base.Rand(low, high));
        }

        /// <summary>
        /// Создаёт кортеж из трёх случайных значений типа Real.
        /// </summary>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double, double> Rand3(double low = RealBordersHelper.Low, double high = RealBordersHelper.High)
        {
            return new Tuple<double, double, double>(Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high));
        }

        /// <summary>
        /// Создаёт кортеж из двух элементов, заполненный указанным значением.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T> Fill2<T>(T value)
        {
            return new Tuple<T, T>(value, value);
        }

        /// <summary>
        /// Создаёт кортеж из двух элементов, заполненный указанным значением.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T> Fill3<T>(T value)
        {
            return new Tuple<T, T, T>(value, value, value);
        }

        /// <summary>
        /// Читает кортеж из двух значений типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool, bool> ReadBoolean2(string prompt = EmptyStringHelper.Empty)
        {
            bool a = default;
            bool b = default;

            ReadBooleanTupleItem(ref a, 0, prompt);
            ReadBooleanTupleItem(ref b, 1, prompt);

            return new Tuple<bool, bool>(a, b);
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool, bool, bool> ReadBoolean3(string prompt = EmptyStringHelper.Empty)
        {
            bool a = default;
            bool b = default;
            bool c = default;

            ReadBooleanTupleItem(ref a, 0, prompt);
            ReadBooleanTupleItem(ref b, 1, prompt);
            ReadBooleanTupleItem(ref c, 2, prompt);

            return new Tuple<bool, bool, bool>(a, b, c);
        }

        /// <summary>
        /// Читает кортеж из двух значений типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<char, char> ReadChar2(string prompt = EmptyStringHelper.Empty)
        {
            return new Tuple<char, char>(Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 0)),
                Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<char, char, char> ReadChar3(string prompt = EmptyStringHelper.Empty)
        {
            return new Tuple<char, char, char>(Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 0)),
                Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 1)),
                Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из двух значений типа Real. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double> ReadReal2(string prompt = EmptyStringHelper.Empty)
        {
            double a = default;
            double b = default;

            ReadRealTupleItem(ref a, 0, prompt);
            ReadRealTupleItem(ref b, 1, prompt);

            return new Tuple<double, double>(a, b);
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Real. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double, double> ReadReal3(string prompt = EmptyStringHelper.Empty)
        {
            double a = default;
            double b = default;
            double c = default;

            ReadRealTupleItem(ref a, 0, prompt);
            ReadRealTupleItem(ref b, 1, prompt);
            ReadRealTupleItem(ref c, 2, prompt);

            return new Tuple<double, double, double>(a, b, c);
        }

        /// <summary>
        /// Читает кортеж из двух значений типа Integer. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int> ReadInteger2(string prompt = EmptyStringHelper.Empty)
        {
            int a = default;
            int b = default;

            ReadIntegerTupleItem(ref a, 0, prompt);
            ReadIntegerTupleItem(ref b, 1, prompt);

            return new Tuple<int, int>(a, b);
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Integer. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int, int> ReadInteger3(string prompt = EmptyStringHelper.Empty)
        {
            int a = default;
            int b = default;
            int c = default;

            ReadIntegerTupleItem(ref a, 0, prompt);
            ReadIntegerTupleItem(ref b, 1, prompt);
            ReadIntegerTupleItem(ref c, 2, prompt);

            return new Tuple<int, int, int>(a, b, c);
        }

        /// <summary>
        /// Читает кортеж из двух значений типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<string, string> ReadString2(string prompt = EmptyStringHelper.Empty)
        {
            return new Tuple<string, string>(Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 0)),
                Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<string, string, string> ReadString3(string prompt = EmptyStringHelper.Empty)
        {
            return new Tuple<string, string, string>(Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 0)),
                Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 1)),
                Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 2)));
        }

        #region Private

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
                    Console.WriteLine(InputErrorHelper.Message);
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
                    Console.WriteLine(InputErrorHelper.Message);
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
                    Console.WriteLine(InputErrorHelper.Message);
                }
        }

        #endregion
    }
}