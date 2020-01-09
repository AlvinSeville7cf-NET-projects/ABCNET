using System;

namespace ABCNETRUS.Утилиты
{
    /// <summary>
    /// Предоставляет функционал для работы с ссылочными кортежами.
    /// </summary>
    public static class Кортеж
    {
        /// <summary>
        /// Создаёт кортеж из двух значений.
        /// </summary>
        /// <param name="arg0">Первое значение.</param>
        /// <param name="arg1">Второе значение.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1> Новый<T, T1>(T arg0, T1 arg1)
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
        public static Tuple<T, T1, T2> Новый<T, T1, T2>(T arg0, T1 arg1, T2 arg2)
        {
            return Tuple.Create(arg0, arg1, arg2);
        }

        /// <summary>
        /// Создаёт кортеж из четырёх значений.
        /// </summary>
        /// <param name="arg0">Первое значение.</param>
        /// <param name="arg1">Второе значение.</param>
        /// <param name="arg2">Третье значение.</param>
        /// <param name="arg3">Четвёртое значение.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3> Новый<T, T1, T2, T3>(T arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            return Tuple.Create(arg0, arg1, arg2, arg3);
        }

        /// <summary>
        /// Создаёт кортеж из пяти значений.
        /// </summary>
        /// <param name="arg0">Первое значение.</param>
        /// <param name="arg1">Второе значение.</param>
        /// <param name="arg2">Третье значение.</param>
        /// <param name="arg3">Четвёртое значение.</param>
        /// <param name="arg4">Пятое значение.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3, T4> Новый<T, T1, T2, T3, T4>(T arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return Tuple.Create(arg0, arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// Создаёт кортеж из шести значений.
        /// </summary>
        /// <param name="arg0">Первое значение.</param>
        /// <param name="arg1">Второе значение.</param>
        /// <param name="arg2">Третье значение.</param>
        /// <param name="arg3">Четвёртое значение.</param>
        /// <param name="arg4">Пятое значение.</param>
        /// <param name="arg5">Шестое значение.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3, T4, T5> Новый<T, T1, T2, T3, T4, T5>(T arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return Tuple.Create(arg0, arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// Создаёт кортеж из семи значений.
        /// </summary>
        /// <param name="arg0">Первое значение.</param>
        /// <param name="arg1">Второе значение.</param>
        /// <param name="arg2">Третье значение.</param>
        /// <param name="arg3">Четвёртое значение.</param>
        /// <param name="arg4">Пятое значение.</param>
        /// <param name="arg5">Шестое значение.</param>
        /// <param name="arg6">Седьмое значение.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3, T4, T5, T6> Новый<T, T1, T2, T3, T4, T5, T6>(T arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            return Tuple.Create(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// Создаёт кортеж из двух случайных значений типа Integer.
        /// </summary>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int> СлучайныйДвухэлементный(int low = ЦелочисленныеГраницы.Нижняя, int high = ЦелочисленныеГраницы.Верхняя)
        {
            return new Tuple<int, int>(Основное.Случайное(low, high), Основное.Случайное(low, high));
        }

        /// <summary>
        /// Создаёт кортеж из трёх случайных значений типа Integer.
        /// </summary>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int, int> СлучайныйТрёхэлементный(int low = ЦелочисленныеГраницы.Нижняя, int high = ЦелочисленныеГраницы.Верхняя)
        {
            return new Tuple<int, int, int>(Основное.Случайное(low, high), Основное.Случайное(low, high), Основное.Случайное(low, high));
        }

        /// <summary>
        /// Создаёт кортеж из двух случайных значений типа Real.
        /// </summary>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double> СлучайныйДвухэлементный(double low = ВещественныеГраницы.Нижняя, double high = ВещественныеГраницы.Верхняя)
        {
            return new Tuple<double, double>(Основное.Случайное(low, high), Основное.Случайное(low, high));
        }

        /// <summary>
        /// Создаёт кортеж из трёх случайных значений типа Real.
        /// </summary>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double, double> СлучайныйТрёхэлементный(double low = ВещественныеГраницы.Нижняя, double high = ВещественныеГраницы.Верхняя)
        {
            return new Tuple<double, double, double>(Основное.Случайное(low, high), Основное.Случайное(low, high), Основное.Случайное(low, high));
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
        public static Tuple<bool, bool> ReadBoolean2(string prompt = ПустаяСтрока.Значение)
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
        public static Tuple<bool, bool, bool> ReadBoolean3(string prompt = ПустаяСтрока.Значение)
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
        public static Tuple<char, char> ReadChar2(string prompt = ПустаяСтрока.Значение)
        {
            return new Tuple<char, char>(Основное.ЧитатьСимвол(prompt is null ? ПустаяСтрока.Значение : string.Format(prompt, 0)),
                Основное.ЧитатьСимвол(prompt is null ? ПустаяСтрока.Значение : string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа Char.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<char, char, char> ReadChar3(string prompt = ПустаяСтрока.Значение)
        {
            return new Tuple<char, char, char>(Основное.ЧитатьСимвол(prompt is null ? ПустаяСтрока.Значение : string.Format(prompt, 0)),
                Основное.ЧитатьСимвол(prompt is null ? ПустаяСтрока.Значение : string.Format(prompt, 1)),
                Основное.ЧитатьСимвол(prompt is null ? ПустаяСтрока.Значение : string.Format(prompt, 2)));
        }

        /// <summary>
        /// Читает кортеж из двух значений типа Real.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double> ReadReal2(string prompt = ПустаяСтрока.Значение)
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
        public static Tuple<double, double, double> ReadReal3(string prompt = ПустаяСтрока.Значение)
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
        public static Tuple<int, int> ReadInteger2(string prompt = ПустаяСтрока.Значение)
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
        public static Tuple<int, int, int> ReadInteger3(string prompt = ПустаяСтрока.Значение)
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
        public static Tuple<string, string> ReadString2(string prompt = ПустаяСтрока.Значение)
        {
            return new Tuple<string, string>(Основное.ЧитатьСтроку(prompt is null ? ПустаяСтрока.Значение : string.Format(prompt, 0)),
                Основное.ЧитатьСтроку(prompt is null ? ПустаяСтрока.Значение : string.Format(prompt, 1)));
        }

        /// <summary>
        /// Читает кортеж из трёх значений типа String.
        /// </summary>
        /// <returns>Кортеж.</returns>
        public static Tuple<string, string, string> ReadString3(string prompt = ПустаяСтрока.Значение)
        {
            return new Tuple<string, string, string>(Основное.ЧитатьСтроку(prompt is null ? ПустаяСтрока.Значение : string.Format(prompt, 0)),
                Основное.ЧитатьСтроку(prompt is null ? ПустаяСтрока.Значение : string.Format(prompt, 1)),
                Основное.ЧитатьСтроку(prompt is null ? ПустаяСтрока.Значение : string.Format(prompt, 2)));
        }

        private static void ReadBooleanTupleItem(ref bool field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = Основное.ЧитатьЛогическоеЗначение(prompt is null ? ПустаяСтрока.Значение : string.Format(prompt, index));
                    return;
                }
                catch (Exception)
                {
                    Console.WriteLine(ОшибкаВвода.Значение);
                }
        }

        private static void ReadIntegerTupleItem(ref int field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = Основное.ЧитатьЦелоеЧисло(prompt is null ? ПустаяСтрока.Значение : string.Format(prompt, index));
                    return;
                }
                catch (Exception)
                {
                    Console.WriteLine(ОшибкаВвода.Значение);
                }
        }

        private static void ReadRealTupleItem(ref double field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = Основное.ЧитатьВещественноеЧисло(prompt is null ? ПустаяСтрока.Значение : string.Format(prompt, index));
                    return;
                }
                catch (Exception)
                {
                    Console.WriteLine(ОшибкаВвода.Значение);
                }
        }
    }
}