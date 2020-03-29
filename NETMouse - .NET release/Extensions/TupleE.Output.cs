using System;

namespace ABCNET.Extensions
{
    /// <summary>
    /// Предоставляет функционал для работы с кортежами.
    /// </summary>
    public static partial class TupleE
    {
        #region public
        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1> Print<T, T1>(this Tuple<T, T1> tuple)
        {
            Console.Write(Utils.Tuple.New(tuple.Item1.NilOrString(), tuple.Item2.NilOrString()));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T1, T1> Print<T, T1>(this Tuple<T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            return Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2)).Print();
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T> PrintBy<T, T1>(this Tuple<T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2)).Print();
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1> PrintLine<T, T1>(this Tuple<T, T1> tuple)
        {
            Console.WriteLine(Utils.Tuple.New(tuple.Item1.NilOrString(), tuple.Item2.NilOrString()));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T1, T1> PrintLine<T, T1>(this Tuple<T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            return Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2)).PrintLine();
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T> PrintLineBy<T, T1>(this Tuple<T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2)).PrintLine();
            return tuple;
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1> PrintLines<T, T1>(this Tuple<T, T1> tuple)
        {
            Console.WriteLine(tuple.Item1.NilOrString());
            Console.WriteLine(tuple.Item2.NilOrString());
            return tuple;
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T1, T1> PrintLines<T, T1>(this Tuple<T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            return Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2)).PrintLines();
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T> PrintLinesBy<T, T1>(this Tuple<T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2)).PrintLines();
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2> Print<T, T1, T2>(this Tuple<T, T1, T2> tuple)
        {
            Console.Write(Utils.Tuple.New(tuple.Item1.NilOrString(), tuple.Item2.NilOrString(), tuple.Item3.NilOrString()));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T1, T1, T1> Print<T, T1>(this Tuple<T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            return Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3)).Print();
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T> PrintBy<T, T1>(this Tuple<T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3)).Print();
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2> PrintLine<T, T1, T2>(this Tuple<T, T1, T2> tuple)
        {
            Console.WriteLine(Utils.Tuple.New(tuple.Item1.NilOrString(), tuple.Item2.NilOrString(), tuple.Item3.NilOrString()));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T1, T1, T1> PrintLine<T, T1>(this Tuple<T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            return Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3)).PrintLine();
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T> PrintLineBy<T, T1>(this Tuple<T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3)).PrintLine();
            return tuple;
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2> PrintLines<T, T1, T2>(this Tuple<T, T1, T2> tuple)
        {
            Console.WriteLine(tuple.Item1.NilOrString());
            Console.WriteLine(tuple.Item2.NilOrString());
            Console.WriteLine(tuple.Item3.NilOrString());
            return tuple;
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T1, T1, T1> PrintLines<T, T1>(this Tuple<T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            return Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3)).PrintLines();
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T> PrintLinesBy<T, T1>(this Tuple<T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3)).PrintLines();
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3> Print<T, T1, T2, T3>(this Tuple<T, T1, T2, T3> tuple)
        {
            Console.Write(Utils.Tuple.New(tuple.Item1.NilOrString(), tuple.Item2.NilOrString(), tuple.Item3.NilOrString(),
                tuple.Item4.NilOrString()));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T1, T1, T1, T1> Print<T, T1>(this Tuple<T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            return Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3),
                func(tuple.Item4)).Print();
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T> PrintBy<T, T1>(this Tuple<T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3),
                func(tuple.Item4)).Print();
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3> PrintLine<T, T1, T2, T3>(this Tuple<T, T1, T2, T3> tuple)
        {
            Console.WriteLine(Utils.Tuple.New(tuple.Item1.NilOrString(), tuple.Item2.NilOrString(), tuple.Item3.NilOrString(),
                tuple.Item4.NilOrString()));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T1, T1, T1, T1> PrintLine<T, T1>(this Tuple<T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            return Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3),
                func(tuple.Item4)).PrintLine();
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T> PrintLineBy<T, T1>(this Tuple<T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3),
                func(tuple.Item4)).PrintLine();
            return tuple;
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3> PrintLines<T, T1, T2, T3>(this Tuple<T, T1, T2, T3> tuple)
        {
            Console.WriteLine(tuple.Item1.NilOrString());
            Console.WriteLine(tuple.Item2.NilOrString());
            Console.WriteLine(tuple.Item3.NilOrString());
            Console.WriteLine(tuple.Item4.NilOrString());
            return tuple;
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T1, T1, T1, T1> PrintLines<T, T1>(this Tuple<T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            return Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4)).PrintLines();
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T> PrintLinesBy<T, T1>(this Tuple<T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4)).PrintLines();
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3, T4> Print<T, T1, T2, T3, T4>(this Tuple<T, T1, T2, T3, T4> tuple)
        {
            Console.Write(Utils.Tuple.New(tuple.Item1.NilOrString(), tuple.Item2.NilOrString(), tuple.Item3.NilOrString(),
                tuple.Item4.NilOrString(), tuple.Item5.NilOrString()));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T1, T1, T1, T1, T1> Print<T, T1>(this Tuple<T, T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            return Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3),
                func(tuple.Item4), func(tuple.Item5)).Print();
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T> PrintBy<T, T1>(this Tuple<T, T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3),
                func(tuple.Item4), func(tuple.Item5)).Print();
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3, T4> PrintLine<T, T1, T2, T3, T4>(this Tuple<T, T1, T2, T3, T4> tuple)
        {
            Console.WriteLine(Utils.Tuple.New(tuple.Item1.NilOrString(), tuple.Item2.NilOrString(), tuple.Item3.NilOrString(),
                tuple.Item4.NilOrString(), tuple.Item5.NilOrString()));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T1, T1, T1, T1, T1> PrintLine<T, T1>(this Tuple<T, T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            return Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3),
                func(tuple.Item4), func(tuple.Item5)).PrintLine();
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T> PrintLineBy<T, T1>(this Tuple<T, T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3),
                func(tuple.Item4), func(tuple.Item5)).PrintLine();
            return tuple;
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3, T4> PrintLines<T, T1, T2, T3, T4>(this Tuple<T, T1, T2, T3, T4> tuple)
        {
            Console.WriteLine(tuple.Item1.NilOrString());
            Console.WriteLine(tuple.Item2.NilOrString());
            Console.WriteLine(tuple.Item3.NilOrString());
            Console.WriteLine(tuple.Item4.NilOrString());
            Console.WriteLine(tuple.Item5.NilOrString());
            return tuple;
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T1, T1, T1, T1, T1> PrintLines<T, T1>(this Tuple<T, T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            return Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3),
                func(tuple.Item4), func(tuple.Item5)).PrintLines();
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T> PrintLinesBy<T, T1>(this Tuple<T, T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3),
                func(tuple.Item4), func(tuple.Item5)).PrintLines();
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3, T4, T5> Print<T, T1, T2, T3, T4, T5>(this Tuple<T, T1, T2, T3, T4, T5> tuple)
        {
            Console.Write(Utils.Tuple.New(tuple.Item1.NilOrString(), tuple.Item2.NilOrString(), tuple.Item3.NilOrString(),
                tuple.Item4.NilOrString(), tuple.Item5.NilOrString(), tuple.Item6.NilOrString()));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T1, T1, T1, T1, T1, T1> Print<T, T1>(this Tuple<T, T, T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            return Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3),
                func(tuple.Item4), func(tuple.Item5), func(tuple.Item6)).Print();
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T, T> PrintBy<T, T1>(this Tuple<T, T, T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3),
                func(tuple.Item4), func(tuple.Item5), func(tuple.Item6)).Print();
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3, T4, T5> PrintLine<T, T1, T2, T3, T4, T5>(this Tuple<T, T1, T2, T3, T4, T5> tuple)
        {
            Console.WriteLine(Utils.Tuple.New(tuple.Item1.NilOrString(), tuple.Item2.NilOrString(), tuple.Item3.NilOrString(),
                tuple.Item4.NilOrString(), tuple.Item5.NilOrString(), tuple.Item6.NilOrString()));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T1, T1, T1, T1, T1, T1> PrintLine<T, T1>(this Tuple<T, T, T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            return Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3),
                func(tuple.Item4), func(tuple.Item5), func(tuple.Item6)).PrintLine();
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T, T> PrintLineBy<T, T1>(this Tuple<T, T, T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3),
                func(tuple.Item4), func(tuple.Item5), func(tuple.Item6)).PrintLine();
            return tuple;
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3, T4, T5> PrintLines<T, T1, T2, T3, T4, T5>(this Tuple<T, T1, T2, T3, T4, T5> tuple)
        {
            Console.WriteLine(tuple.Item1.NilOrString());
            Console.WriteLine(tuple.Item2.NilOrString());
            Console.WriteLine(tuple.Item3.NilOrString());
            Console.WriteLine(tuple.Item4.NilOrString());
            Console.WriteLine(tuple.Item5.NilOrString());
            Console.WriteLine(tuple.Item6.NilOrString());
            return tuple;
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T1, T1, T1, T1, T1, T1> PrintLines<T, T1>(this Tuple<T, T, T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            return Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3),
                func(tuple.Item4), func(tuple.Item5), func(tuple.Item6)).PrintLines();
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T, T> PrintLinesBy<T, T1>(this Tuple<T, T, T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3),
                func(tuple.Item4), func(tuple.Item5), func(tuple.Item6)).PrintLines();
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3, T4, T5, T6> Print<T, T1, T2, T3, T4, T5, T6>(this Tuple<T, T1, T2, T3, T4, T5, T6> tuple)
        {
            Console.Write(Utils.Tuple.New(tuple.Item1.NilOrString(), tuple.Item2.NilOrString(), tuple.Item3.NilOrString(),
                tuple.Item4.NilOrString(), tuple.Item5.NilOrString(), tuple.Item6.NilOrString(),
                tuple.Item7.NilOrString()));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T1, T1, T1, T1, T1, T1, T1> Print<T, T1>(this Tuple<T, T, T, T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            return Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3),
                func(tuple.Item4), func(tuple.Item5), func(tuple.Item6),
                func(tuple.Item7)).Print();
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T, T, T> PrintBy<T, T1>(this Tuple<T, T, T, T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3),
                func(tuple.Item4), func(tuple.Item5), func(tuple.Item6),
                func(tuple.Item7)).Print();
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3, T4, T5, T6> PrintLine<T, T1, T2, T3, T4, T5, T6>(this Tuple<T, T1, T2, T3, T4, T5, T6> tuple)
        {
            Console.WriteLine(Utils.Tuple.New(tuple.Item1.NilOrString(), tuple.Item2.NilOrString(), tuple.Item3.NilOrString(),
                tuple.Item4.NilOrString(), tuple.Item5.NilOrString(), tuple.Item6.NilOrString(),
                tuple.Item7.NilOrString()));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T1, T1, T1, T1, T1, T1, T1> PrintLine<T, T1>(this Tuple<T, T, T, T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            return Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3),
                func(tuple.Item4), func(tuple.Item5), func(tuple.Item6),
                func(tuple.Item7)).PrintLine();
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T, T, T> PrintLineBy<T, T1>(this Tuple<T, T, T, T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3),
                func(tuple.Item4), func(tuple.Item5), func(tuple.Item6),
                func(tuple.Item7)).PrintLine();
            return tuple;
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3, T4, T5, T6> PrintLines<T, T1, T2, T3, T4, T5, T6>(this Tuple<T, T1, T2, T3, T4, T5, T6> tuple)
        {
            Console.WriteLine(tuple.Item1.NilOrString());
            Console.WriteLine(tuple.Item2.NilOrString());
            Console.WriteLine(tuple.Item3.NilOrString());
            Console.WriteLine(tuple.Item4.NilOrString());
            Console.WriteLine(tuple.Item5.NilOrString());
            Console.WriteLine(tuple.Item6.NilOrString());
            Console.WriteLine(tuple.Item7.NilOrString());
            return tuple;
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T1, T1, T1, T1, T1, T1, T1> PrintLines<T, T1>(this Tuple<T, T, T, T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            return Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3),
                func(tuple.Item4), func(tuple.Item5), func(tuple.Item6),
                func(tuple.Item7)).PrintLines();
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T, T, T> PrintLinesBy<T, T1>(this Tuple<T, T, T, T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Utils.Tuple.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3),
                func(tuple.Item4), func(tuple.Item5), func(tuple.Item6),
                func(tuple.Item7)).PrintLines();
            return tuple;
        }
        #endregion public
    }
}
