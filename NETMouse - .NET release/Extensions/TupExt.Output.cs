using ABCNET.Utils;
using System;

namespace ABCNET.Extensions
{
    /// <summary>
    /// Предоставляет функционал для работы с кортежами.
    /// </summary>
    public static partial class TupExt
    {
        #region public
        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1> Print<T, T1>(this Tuple<T, T1> tuple)
        {
            Console.Write(Tup.New(tuple.Item1.NilOrString(), tuple.Item2.NilOrString()));
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

            Tuple<T1, T1> tupleRes = Tup.New(func(tuple.Item1), func(tuple.Item2));

            Console.Write(Tup.New(tupleRes.Item1.NilOrString(), tupleRes.Item2.NilOrString()));
            return tupleRes;
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

            Console.Write(Tup.New(func(tuple.Item1).NilOrString(), func(tuple.Item2).NilOrString()));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1> Println<T, T1>(this Tuple<T, T1> tuple)
        {
            Console.WriteLine(Tup.New(tuple.Item1.NilOrString(), tuple.Item2.NilOrString()));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T1, T1> Println<T, T1>(this Tuple<T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Tuple<T1, T1> tupleRes = Tup.New(func(tuple.Item1), func(tuple.Item2));

            Console.WriteLine(Tup.New(tupleRes.Item1.NilOrString(), tupleRes.Item2.NilOrString()));
            return tupleRes;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T> PrintlnBy<T, T1>(this Tuple<T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Console.WriteLine(Tup.New(func(tuple.Item1).NilOrString(), func(tuple.Item2).NilOrString()));
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

            Tuple<T1, T1> tupleRes = Tup.New(func(tuple.Item1), func(tuple.Item2));

            Console.WriteLine(tupleRes.Item1.NilOrString());
            Console.WriteLine(tupleRes.Item2.NilOrString());
            return tupleRes;
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

            Console.WriteLine(func(tuple.Item1).NilOrString());
            Console.WriteLine(func(tuple.Item2).NilOrString());
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2> Print<T, T1, T2>(this Tuple<T, T1, T2> tuple)
        {
            Console.Write(Tup.New(tuple.Item1.NilOrString(), tuple.Item2.NilOrString(), tuple.Item3.NilOrString()));
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

            Tuple<T1, T1, T1> tupleRes = Tup.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3));

            Console.Write(Tup.New(tupleRes.Item1.NilOrString(), tupleRes.Item2.NilOrString(), tupleRes.Item3.NilOrString()));
            return tupleRes;
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

            Console.Write(Tup.New(func(tuple.Item1).NilOrString(), func(tuple.Item2).NilOrString(), func(tuple.Item3).NilOrString()));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2> Println<T, T1, T2>(this Tuple<T, T1, T2> tuple)
        {
            Console.WriteLine(Tup.New(tuple.Item1.NilOrString(), tuple.Item2.NilOrString(), tuple.Item3.NilOrString()));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T1, T1, T1> Println<T, T1>(this Tuple<T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Tuple<T1, T1, T1> tupleRes = Tup.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3));

            Console.WriteLine(Tup.New(tupleRes.Item1.NilOrString(), tupleRes.Item2.NilOrString(), tupleRes.Item3.NilOrString()));
            return tupleRes;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T> PrintlnBy<T, T1>(this Tuple<T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Console.WriteLine(Tup.New(func(tuple.Item1).NilOrString(), func(tuple.Item2).NilOrString(), func(tuple.Item3).NilOrString()));
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

            Tuple<T1, T1, T1> tupleRes = Tup.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3));

            Console.WriteLine(tupleRes.Item1.NilOrString());
            Console.WriteLine(tupleRes.Item2.NilOrString());
            Console.WriteLine(tupleRes.Item3.NilOrString());
            return tupleRes;
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

            Console.WriteLine(func(tuple.Item1).NilOrString());
            Console.WriteLine(func(tuple.Item2).NilOrString());
            Console.WriteLine(func(tuple.Item3).NilOrString());
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3> Print<T, T1, T2, T3>(this Tuple<T, T1, T2, T3> tuple)
        {
            Console.Write(Tup.New(tuple.Item1.NilOrString(), tuple.Item2.NilOrString(), tuple.Item3.NilOrString(),
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

            Tuple<T1, T1, T1, T1> tupleRes = Tup.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3),
                func(tuple.Item4));

            Console.Write(Tup.New(tupleRes.Item1.NilOrString(), tupleRes.Item2.NilOrString(), tupleRes.Item3.NilOrString(),
                tupleRes.Item4.NilOrString()));
            return tupleRes;
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

            Console.Write(Tup.New(func(tuple.Item1).NilOrString(), func(tuple.Item2).NilOrString(), func(tuple.Item3).NilOrString(), func(tuple.Item4).NilOrString()));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3> Println<T, T1, T2, T3>(this Tuple<T, T1, T2, T3> tuple)
        {
            Console.WriteLine(Tup.New(tuple.Item1.NilOrString(), tuple.Item2.NilOrString(), tuple.Item3.NilOrString(),
                tuple.Item4.NilOrString()));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T1, T1, T1, T1> Println<T, T1>(this Tuple<T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Tuple<T1, T1, T1, T1> tupleRes = Tup.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4));

            Console.WriteLine(Tup.New(tupleRes.Item1.NilOrString(), tupleRes.Item2.NilOrString(), tupleRes.Item3.NilOrString(),
                tupleRes.Item4.NilOrString()));
            return tupleRes;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T> PrintlnBy<T, T1>(this Tuple<T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Console.WriteLine(Tup.New(func(tuple.Item1).NilOrString(), func(tuple.Item2).NilOrString(), func(tuple.Item3).NilOrString(),
                func(tuple.Item4).NilOrString()));
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

            Tuple<T1, T1, T1, T1> tupleRes = Tup.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4));

            Console.WriteLine(tupleRes.Item1.NilOrString());
            Console.WriteLine(tupleRes.Item2.NilOrString());
            Console.WriteLine(tupleRes.Item3.NilOrString());
            Console.WriteLine(tupleRes.Item4.NilOrString());
            return tupleRes;
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

            Console.WriteLine(func(tuple.Item1).NilOrString());
            Console.WriteLine(func(tuple.Item2).NilOrString());
            Console.WriteLine(func(tuple.Item3).NilOrString());
            Console.WriteLine(func(tuple.Item4).NilOrString());
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3, T4> Print<T, T1, T2, T3, T4>(this Tuple<T, T1, T2, T3, T4> tuple)
        {
            Console.Write(tuple);
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

            Tuple<T1, T1, T1, T1, T1> tupleRes = Tup.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4), func(tuple.Item5));

            Console.Write(tupleRes);
            return tupleRes;
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

            Console.Write(Tup.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4), func(tuple.Item5)));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3, T4> Println<T, T1, T2, T3, T4>(this Tuple<T, T1, T2, T3, T4> tuple)
        {
            Console.WriteLine(Tup.New(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T1, T1, T1, T1, T1> Println<T, T1>(this Tuple<T, T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Tuple<T1, T1, T1, T1, T1> tupleRes = Tup.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4), func(tuple.Item5));

            Console.WriteLine(tupleRes);
            return tupleRes;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T> PrintlnBy<T, T1>(this Tuple<T, T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Console.WriteLine(Tup.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4), func(tuple.Item5)));
            return tuple;
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3, T4> PrintLines<T, T1, T2, T3, T4>(this Tuple<T, T1, T2, T3, T4> tuple)
        {
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            Console.WriteLine(tuple.Item3);
            Console.WriteLine(tuple.Item4);
            Console.WriteLine(tuple.Item5);
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

            Tuple<T1, T1, T1, T1, T1> tupleRes = Tup.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4), func(tuple.Item5));

            Console.WriteLine(tupleRes.Item1);
            Console.WriteLine(tupleRes.Item2);
            Console.WriteLine(tupleRes.Item3);
            Console.WriteLine(tupleRes.Item4);
            Console.WriteLine(tupleRes.Item5);
            return tupleRes;
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

            Console.WriteLine(func(tuple.Item1));
            Console.WriteLine(func(tuple.Item2));
            Console.WriteLine(func(tuple.Item3));
            Console.WriteLine(func(tuple.Item4));
            Console.WriteLine(func(tuple.Item5));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3, T4, T5> Print<T, T1, T2, T3, T4, T5>(this Tuple<T, T1, T2, T3, T4, T5> tuple)
        {
            Console.Write(tuple);
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

            Tuple<T1, T1, T1, T1, T1, T1> tupleRes = Tup.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4), func(tuple.Item5), func(tuple.Item6));

            Console.Write(tupleRes);
            return tupleRes;
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

            Console.Write(Tup.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4), func(tuple.Item5), func(tuple.Item6)));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3, T4, T5> Println<T, T1, T2, T3, T4, T5>(this Tuple<T, T1, T2, T3, T4, T5> tuple)
        {
            Console.WriteLine(Tup.New(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T1, T1, T1, T1, T1, T1> Println<T, T1>(this Tuple<T, T, T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Tuple<T1, T1, T1, T1, T1, T1> tupleRes = Tup.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4), func(tuple.Item5), func(tuple.Item6));

            Console.WriteLine(tupleRes);
            return tupleRes;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T, T> PrintlnBy<T, T1>(this Tuple<T, T, T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Console.WriteLine(Tup.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4), func(tuple.Item5), func(tuple.Item6)));
            return tuple;
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3, T4, T5> PrintLines<T, T1, T2, T3, T4, T5>(this Tuple<T, T1, T2, T3, T4, T5> tuple)
        {
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            Console.WriteLine(tuple.Item3);
            Console.WriteLine(tuple.Item4);
            Console.WriteLine(tuple.Item5);
            Console.WriteLine(tuple.Item6);
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

            Tuple<T1, T1, T1, T1, T1, T1> tupleRes = Tup.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4), func(tuple.Item5), func(tuple.Item6));

            Console.WriteLine(tupleRes.Item1);
            Console.WriteLine(tupleRes.Item2);
            Console.WriteLine(tupleRes.Item3);
            Console.WriteLine(tupleRes.Item4);
            Console.WriteLine(tupleRes.Item5);
            Console.WriteLine(tupleRes.Item6);
            return tupleRes;
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

            Console.WriteLine(func(tuple.Item1));
            Console.WriteLine(func(tuple.Item2));
            Console.WriteLine(func(tuple.Item3));
            Console.WriteLine(func(tuple.Item4));
            Console.WriteLine(func(tuple.Item5));
            Console.WriteLine(func(tuple.Item6));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3, T4, T5, T6> Print<T, T1, T2, T3, T4, T5, T6>(this Tuple<T, T1, T2, T3, T4, T5, T6> tuple)
        {
            Console.Write(tuple);
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

            Tuple<T1, T1, T1, T1, T1, T1, T1> tupleRes = Tup.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4), func(tuple.Item5), func(tuple.Item6), func(tuple.Item7));

            Console.Write(tupleRes);
            return tupleRes;
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

            Console.Write(Tup.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4), func(tuple.Item5), func(tuple.Item6), func(tuple.Item7)));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3, T4, T5, T6> Println<T, T1, T2, T3, T4, T5, T6>(this Tuple<T, T1, T2, T3, T4, T5, T6> tuple)
        {
            Console.WriteLine(Tup.New(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T1, T1, T1, T1, T1, T1, T1> Println<T, T1>(this Tuple<T, T, T, T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Tuple<T1, T1, T1, T1, T1, T1, T1> tupleRes = Tup.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4), func(tuple.Item5), func(tuple.Item6), func(tuple.Item7));

            Console.WriteLine(tupleRes);
            return tupleRes;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T, T, T> PrintlnBy<T, T1>(this Tuple<T, T, T, T, T, T, T> tuple, Func<T, T1> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Console.WriteLine(Tup.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4), func(tuple.Item5), func(tuple.Item6), func(tuple.Item7)));
            return tuple;
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3, T4, T5, T6> PrintLines<T, T1, T2, T3, T4, T5, T6>(this Tuple<T, T1, T2, T3, T4, T5, T6> tuple)
        {
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            Console.WriteLine(tuple.Item3);
            Console.WriteLine(tuple.Item4);
            Console.WriteLine(tuple.Item5);
            Console.WriteLine(tuple.Item6);
            Console.WriteLine(tuple.Item7);
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

            Tuple<T1, T1, T1, T1, T1, T1, T1> tupleRes = Tup.New(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4), func(tuple.Item5), func(tuple.Item6), func(tuple.Item7));

            Console.WriteLine(tupleRes.Item1);
            Console.WriteLine(tupleRes.Item2);
            Console.WriteLine(tupleRes.Item3);
            Console.WriteLine(tupleRes.Item4);
            Console.WriteLine(tupleRes.Item5);
            Console.WriteLine(tupleRes.Item6);
            Console.WriteLine(tupleRes.Item7);
            return tupleRes;
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

            Console.WriteLine(func(tuple.Item1));
            Console.WriteLine(func(tuple.Item2));
            Console.WriteLine(func(tuple.Item3));
            Console.WriteLine(func(tuple.Item4));
            Console.WriteLine(func(tuple.Item5));
            Console.WriteLine(func(tuple.Item6));
            Console.WriteLine(func(tuple.Item7));
            return tuple;
        }
        #endregion public
    }
}
