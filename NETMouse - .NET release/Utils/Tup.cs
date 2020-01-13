using System;

namespace ABCNET.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы с ссылочными кортежами.
    /// </summary>
    public static class Tup
    {
        /// <summary>
        /// Создаёт кортеж из двух значений.
        /// </summary>
        /// <param name="arg0">Первое значение.</param>
        /// <param name="arg1">Второе значение.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1> New<T, T1>(T arg0, T1 arg1)
        {
            return Tuple.Create(arg0, arg1);
        }

        /// <summary>
        /// Создаёт кортеж из трёх значений.
        /// </summary>
        /// <param name="arg0">Первое значение.</param>
        /// <param name="arg1">Второе значение.</param>
        /// <param name="arg2">Третье значение.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2> New<T, T1, T2>(T arg0, T1 arg1, T2 arg2)
        {
            return Tuple.Create(arg0, arg1, arg2);
        }

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
        /// Читает кортеж из двух значений типа Boolean.
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
        /// Читает кортеж из трёх значений типа Boolean.
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
        /// Читает кортеж из двух значений типа Char.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<char, char> ReadChar2(string prompt = EmptyStringHelper.Empty)
        {
            return new Tuple<char, char>(Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 0)),
                Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Char.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<char, char, char> ReadChar3(string prompt = EmptyStringHelper.Empty)
        {
            return new Tuple<char, char, char>(Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 0)),
                Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 1)),
                Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из двух значений типа Real.
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
        /// Читает кортеж из трёх значений типа Real.
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
        /// Читает кортеж из двух значений типа Integer.
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
        /// Читает кортеж из трёх значений типа Integer.
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
        /// Читает кортеж из двух значений типа String.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<string, string> ReadString2(string prompt = EmptyStringHelper.Empty)
        {
            return new Tuple<string, string>(Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 0)),
                Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа String.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<string, string, string> ReadString3(string prompt = EmptyStringHelper.Empty)
        {
            return new Tuple<string, string, string>(Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 0)),
                Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 1)),
                Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, 2)));
        }

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
                    field = Base.ReadInteger(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, index));
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
                    field = Base.ReadReal(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, index));
                    return;
                }
                catch (Exception)
                {
                    Console.WriteLine(InputErrorHelper.Message);
                }
        }
    }
}