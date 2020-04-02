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
        /// Создаёт кортеж из 2 значений.
        /// </summary>
        /// <param name="item1">Первое значение.</param>
        /// <param name="item2">Второе значение.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T2> Of<T, T2>(T item1, T2 item2)
        {
            return new Tuple<T, T2>(item1, item2);
        }

        /// <summary>
        /// Создаёт кортеж из 3 значений.
        /// </summary>
        /// <param name="item1">Первое значение.</param>
        /// <param name="item2">Второе значение.</param>
        /// <param name="item3">Третье значение.</param>
        public static Tuple<T, T2, T3> Of<T,T2, T3>(T item1, T2 item2, T3 item3)
        {
            return new Tuple<T, T2, T3>(item1, item2, item3);
        }

        /// <summary>
        /// Создаёт кортеж из 4 значений.
        /// </summary>
        /// <param name="item1">Первое значение.</param>
        /// <param name="item2">Второе значение.</param>
        /// <param name="item3">Третье значение.</param>
        /// <param name="item4">Четвёртое значение.</param>
        public static Tuple<T, T2, T3, T4> Of<T, T2, T3, T4>(T item1, T2 item2, T3 item3, T4 item4)
        {
            return new Tuple<T, T2, T3, T4>(item1, item2, item3, item4);
        }

        /// <summary>
        /// Создаёт кортеж из 5 значений.
        /// </summary>
        /// <param name="item1">Первое значение.</param>
        /// <param name="item2">Второе значение.</param>
        /// <param name="item3">Третье значение.</param>
        /// <param name="item4">Четвёртое значение.</param>
        /// <param name="item5">Пятое значение.</param>
        public static Tuple<T, T2, T3, T4, T5> Of<T, T2, T3, T4, T5>(T item1, T2 item2, T3 item3, T4 item4, T5 item5)
        {
            return new Tuple<T, T2, T3, T4, T5>(item1, item2, item3, item4, item5);
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
        public static Tuple<T, T2, T3, T4, T5, T6> Of<T, T2, T3, T4, T5, T6>(T item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
        {
            return new Tuple<T, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);
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
        public static Tuple<T, T2, T3, T4, T5, T6, T7> Of<T, T2, T3, T4, T5, T6, T7>(T item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
        {
            return new Tuple<T, T2, T3, T4, T5, T6, T7>(item1, item2, item3, item4, item5, item6, item7);
        }

        /// <summary>
        /// Создаёт кортеж из 2 значений на основе функции селектора.
        /// </summary>
        /// <param name="selector">Функция селектор.</param>
        /// <param name="firstIndex">Начальный индекс.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T> By2<T>(Func<int, T> selector, int firstIndex = 0)
        {
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Of(selector(firstIndex), selector(firstIndex + 1));
        }

        /// <summary>
        /// Создаёт кортеж из 3 значений на основе функции селектора.
        /// </summary>
        /// <param name="selector">Функция селектор.</param>
        /// <param name="firstIndex">Начальный индекс.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T> By3<T>(Func<int, T> selector, int firstIndex = 0)
        {
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Of(selector(firstIndex), selector(firstIndex + 1), selector(firstIndex + 2));
        }

        /// <summary>
        /// Создаёт кортеж из 4 значений на основе функции селектора.
        /// </summary>
        /// <param name="selector">Функция селектор.</param>
        /// <param name="firstIndex">Начальный индекс.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T> By4<T>(Func<int, T> selector, int firstIndex = 0)
        {
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Of(selector(firstIndex), selector(firstIndex + 1), selector(firstIndex + 2),
                selector(firstIndex + 3));
        }

        /// <summary>
        /// Создаёт кортеж из 5 значений на основе функции селектора.
        /// </summary>
        /// <param name="selector">Функция селектор.</param>
        /// <param name="firstIndex">Начальный индекс.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T> By5<T>(Func<int, T> selector, int firstIndex = 0)
        {
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Of(selector(firstIndex), selector(firstIndex + 1), selector(firstIndex + 2),
                selector(firstIndex + 3), selector(firstIndex + 4));
        }

        /// <summary>
        /// Создаёт кортеж из 6 значений на основе функции селектора.
        /// </summary>
        /// <param name="selector">Функция селектор.</param>
        /// <param name="firstIndex">Начальный индекс.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T, T> By6<T>(Func<int, T> selector, int firstIndex = 0)
        {
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Of(selector(firstIndex), selector(firstIndex + 1), selector(firstIndex + 2),
                selector(firstIndex + 3), selector(firstIndex + 4), selector(firstIndex + 5));
        }

        /// <summary>
        /// Создаёт кортеж из 7 значений на основе функции селектора.
        /// </summary>
        /// <param name="selector">Функция селектор.</param>
        /// <param name="firstIndex">Начальный индекс.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T, T, T> By7<T>(Func<int, T> selector, int firstIndex = 0)
        {
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Of(selector(firstIndex), selector(firstIndex + 1), selector(firstIndex + 2),
                selector(firstIndex + 3), selector(firstIndex + 4), selector(firstIndex + 5),
                selector(firstIndex + 6));
        }

        /// <summary>
        /// Создаёт кортеж из 2 значений на основе функции селектора.
        /// </summary>
        /// <param name="first">Первый элемент.</param>
        /// <param name="next">Функция получения следующего элемента.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T> By2<T>(T first, Func<T, T> next)
        {
            if (next == null)
                throw new ArgumentNullException(nameof(next));

            var a = first;
            var b = next(a);
            return Of(a, b);
        }

        /// <summary>
        /// Создаёт кортеж из 3 значений на основе функции селектора.
        /// </summary>
        /// <param name="first">Первый элемент.</param>
        /// <param name="next">Функция получения следующего элемента.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T> By3<T>(T first, Func<T, T> next)
        {
            if (next == null)
                throw new ArgumentNullException(nameof(next));

            var a = first;
            var b = next(a);
            var c = next(b);
            return Of(a, b, c);
        }

        /// <summary>
        /// Создаёт кортеж из 4 значений на основе функции селектора.
        /// </summary>
        /// <param name="first">Первый элемент.</param>
        /// <param name="next">Функция получения следующего элемента.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T> By4<T>(T first, Func<T, T> next)
        {
            if (next == null)
                throw new ArgumentNullException(nameof(next));

            var a = first;
            var b = next(a);
            var c = next(b);
            var d = next(c);
            return Of(a, b, c, d);
        }

        /// <summary>
        /// Создаёт кортеж из 5 значений на основе функции селектора.
        /// </summary>
        /// <param name="first">Первый элемент.</param>
        /// <param name="next">Функция получения следующего элемента.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T> By5<T>(T first, Func<T, T> next)
        {
            if (next == null)
                throw new ArgumentNullException(nameof(next));

            var a = first;
            var b = next(a);
            var c = next(b);
            var d = next(c);
            var e = next(d);
            return Of(a, b, c, d, e);
        }

        /// <summary>
        /// Создаёт кортеж из 6 значений на основе функции селектора.
        /// </summary>
        /// <param name="first">Первый элемент.</param>
        /// <param name="next">Функция получения следующего элемента.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T, T> By6<T>(T first, Func<T, T> next)
        {
            if (next == null)
                throw new ArgumentNullException(nameof(next));

            var a = first;
            var b = next(a);
            var c = next(b);
            var d = next(c);
            var e = next(d);
            var f = next(e);
            return Of(a, b, c, d, e, f);
        }

        /// <summary>
        /// Создаёт кортеж из 7 значений на основе функции селектора.
        /// </summary>
        /// <param name="first">Первый элемент.</param>
        /// <param name="next">Функция получения следующего элемента.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T, T, T> By7<T>(T first, Func<T, T> next)
        {
            if (next == null)
                throw new ArgumentNullException(nameof(next));

            var a = first;
            var b = next(a);
            var c = next(b);
            var d = next(c);
            var e = next(d);
            var f = next(e);
            var g = next(f);
            return Of(a, b, c, d, e, f, g);
        }

        /// <summary>
        /// Создаёт кортеж из двух случайных значений типа Int32.
        /// </summary>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int> Random2(int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            return Of(Base.Random(low, high), Base.Random(low, high));
        }

        /// <summary>
        /// Создаёт кортеж из трёх случайных значений типа Int32.
        /// </summary>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int, int> Random3(int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            return Of(Base.Random(low, high), Base.Random(low, high), Base.Random(low, high));
        }

        /// <summary>
        /// Создаёт кортеж из четырёх случайных значений типа Int32.
        /// </summary>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int, int, int> Random4(int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            return Of(Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high));
        }

        /// <summary>
        /// Создаёт кортеж из пяти случайных значений типа Int32.
        /// </summary>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int, int, int, int> Random5(int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            return Of(Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high));
        }

        /// <summary>
        /// Создаёт кортеж из шести случайных значений типа Int32.
        /// </summary>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int, int, int, int, int> Random6(int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            return Of(Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high));
        }

        /// <summary>
        /// Создаёт кортеж из семи случайных значений типа Int32.
        /// </summary>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int, int, int, int, int, int, int> Random7(int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            return Of(Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high));
        }

        /// <summary>
        /// Создаёт кортеж из двух случайных значений типа Double.
        /// </summary>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double> Random2(double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            return Of(Base.Random(low, high), Base.Random(low, high));
        }

        /// <summary>
        /// Создаёт кортеж из трёх случайных значений типа Double.
        /// </summary>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double, double> Random3(double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            return Of(Base.Random(low, high), Base.Random(low, high), Base.Random(low, high));
        }

        /// <summary>
        /// Создаёт кортеж из четырёх случайных значений типа Double.
        /// </summary>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double, double, double> Random4(double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            return Of(Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high));
        }

        /// <summary>
        /// Создаёт кортеж из пяти случайных значений типа Double.
        /// </summary>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double, double, double, double> Random5(double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            return Of(Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high));
        }

        /// <summary>
        /// Создаёт кортеж из шести случайных значений типа Double.
        /// </summary>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double, double, double, double, double> Random6(double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            return Of(Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high));
        }

        /// <summary>
        /// Создаёт кортеж из семи случайных значений типа Double.
        /// </summary>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double, double, double, double, double, double, double> Random7(double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            return Of(Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high));
        }

        /// <summary>
        /// Создаёт кортеж из двух элементов, заполненный указанным значением.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T> Fill2<T>(T value)
        {
            return Of(value, value);
        }

        /// <summary>
        /// Создаёт кортеж из трёх элементов, заполненный указанным значением.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T> Fill3<T>(T value)
        {
            return Of(value, value, value);
        }

        /// <summary>
        /// Создаёт кортеж из четырёх элементов, заполненный указанным значением.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T> Fill4<T>(T value)
        {
            return Of(value, value, value, value);
        }

        /// <summary>
        /// Создаёт кортеж из пяти элементов, заполненный указанным значением.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T> Fill5<T>(T value)
        {
            return Of(value, value, value, value, value);
        }

        /// <summary>
        /// Создаёт кортеж из шести элементов, заполненный указанным значением.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T, T> Fill6<T>(T value)
        {
            return Of(value, value, value, value, value, value);
        }

        /// <summary>
        /// Создаёт кортеж из семи элементов, заполненный указанным значением.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T, T, T> Fill7<T>(T value)
        {
            return Of(value, value, value, value, value, value, value);
        }
        #endregion public
    }
}