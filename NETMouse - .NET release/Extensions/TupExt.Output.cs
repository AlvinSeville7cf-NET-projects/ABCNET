﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABCNET.Extensions
{
    public static partial class Tup
    {

        #region Public

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T> Print<T>(this Tuple<T, T> tuple)
        {
            Console.Write(Tuple.Create(tuple.Item1.NilOrString(), tuple.Item2.NilOrString()));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T> Print<T>(this Tuple<T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Tuple<T, T> tupleRes = new Tuple<T, T>(func(tuple.Item1), func(tuple.Item2));

            Console.Write(Tuple.Create(tupleRes.Item1.NilOrString(), tupleRes.Item2.NilOrString()));
            return tupleRes;
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T> PrintBy<T>(this Tuple<T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Console.Write(Tuple.Create(func(tuple.Item1).NilOrString(), func(tuple.Item2).NilOrString()));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T> Println<T>(this Tuple<T, T> tuple)
        {
            Console.Write(Tuple.Create(tuple.Item1.NilOrString(), tuple.Item2.NilOrString()));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T> Println<T>(this Tuple<T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Tuple<T, T> tupleRes = new Tuple<T, T>(func(tuple.Item1), func(tuple.Item2));

            Console.WriteLine(Tuple.Create(tupleRes.Item1.NilOrString(), tupleRes.Item2.NilOrString()));
            return tupleRes;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T> PrintlnBy<T>(this Tuple<T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Console.WriteLine(Tuple.Create(func(tuple.Item1).NilOrString(), func(tuple.Item2).NilOrString()));
            return tuple;
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T> PrintLines<T>(this Tuple<T, T> tuple)
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
        public static Tuple<T, T> PrintLines<T>(this Tuple<T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Tuple<T, T> tupleRes = new Tuple<T, T>(func(tuple.Item1), func(tuple.Item2));

            Console.WriteLine(tupleRes.Item1);
            Console.WriteLine(tupleRes.Item2);
            return tupleRes;
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T> PrintLinesBy<T>(this Tuple<T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Console.WriteLine(func(tuple.Item1));
            Console.WriteLine(func(tuple.Item2));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T> Print<T>(this Tuple<T, T, T> tuple)
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
        public static Tuple<T, T, T> Print<T>(this Tuple<T, T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Tuple<T, T, T> tupleRes = new Tuple<T, T, T>(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3));

            Console.Write(tupleRes);
            return tupleRes;
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T> PrintBy<T>(this Tuple<T, T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Console.Write(Tuple.Create(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3)));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T> Println<T>(this Tuple<T, T, T> tuple)
        {
            Console.Write(Tuple.Create(tuple.Item1, tuple.Item2, tuple.Item3));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T> Println<T>(this Tuple<T, T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Tuple<T, T, T> tupleRes = new Tuple<T, T, T>(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3));

            Console.WriteLine(tupleRes);
            return tupleRes;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T> PrintlnBy<T>(this Tuple<T, T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Console.WriteLine(Tuple.Create(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3)));
            return tuple;
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T> PrintLines<T>(this Tuple<T, T, T> tuple)
        {
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            Console.WriteLine(tuple.Item3);
            return tuple;
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T> PrintLines<T>(this Tuple<T, T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Tuple<T, T, T> tupleRes = new Tuple<T, T, T>(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3));

            Console.WriteLine(tupleRes.Item1);
            Console.WriteLine(tupleRes.Item2);
            Console.WriteLine(tupleRes.Item3);
            return tupleRes;
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T> PrintLinesBy<T>(this Tuple<T, T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Console.WriteLine(func(tuple.Item1));
            Console.WriteLine(func(tuple.Item2));
            Console.WriteLine(func(tuple.Item3));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T> Print<T>(this Tuple<T, T, T, T> tuple)
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
        public static Tuple<T, T, T, T> Print<T>(this Tuple<T, T, T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Tuple<T, T, T, T> tupleRes = new Tuple<T, T, T, T>(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4));

            Console.Write(tupleRes);
            return tupleRes;
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T> PrintBy<T>(this Tuple<T, T, T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Console.Write(Tuple.Create(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4)));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T> Println<T>(this Tuple<T, T, T, T> tuple)
        {
            Console.Write(Tuple.Create(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T> Println<T>(this Tuple<T, T, T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Tuple<T, T, T, T> tupleRes = new Tuple<T, T, T, T>(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4));

            Console.WriteLine(tupleRes);
            return tupleRes;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T> PrintlnBy<T>(this Tuple<T, T, T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Console.WriteLine(Tuple.Create(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4)));
            return tuple;
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T> PrintLines<T>(this Tuple<T, T, T, T> tuple)
        {
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            Console.WriteLine(tuple.Item3);
            Console.WriteLine(tuple.Item4);
            return tuple;
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T> PrintLines<T>(this Tuple<T, T, T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Tuple<T, T, T, T> tupleRes = new Tuple<T, T, T, T>(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4));

            Console.WriteLine(tupleRes.Item1);
            Console.WriteLine(tupleRes.Item2);
            Console.WriteLine(tupleRes.Item3);
            Console.WriteLine(tupleRes.Item4);
            return tupleRes;
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T> PrintLinesBy<T>(this Tuple<T, T, T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Console.WriteLine(func(tuple.Item1));
            Console.WriteLine(func(tuple.Item2));
            Console.WriteLine(func(tuple.Item3));
            Console.WriteLine(func(tuple.Item4));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T> Print<T>(this Tuple<T, T, T, T, T> tuple)
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
        public static Tuple<T, T, T, T, T> Print<T>(this Tuple<T, T, T, T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Tuple<T, T, T, T, T> tupleRes = new Tuple<T, T, T, T, T>(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4), func(tuple.Item5));

            Console.Write(tupleRes);
            return tupleRes;
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T> PrintBy<T>(this Tuple<T, T, T, T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Console.Write(Tuple.Create(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4), func(tuple.Item5)));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T> Println<T>(this Tuple<T, T, T, T, T> tuple)
        {
            Console.Write(Tuple.Create(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T> Println<T>(this Tuple<T, T, T, T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Tuple<T, T, T, T, T> tupleRes = new Tuple<T, T, T, T, T>(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4), func(tuple.Item5));

            Console.WriteLine(tupleRes);
            return tupleRes;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T> PrintlnBy<T>(this Tuple<T, T, T, T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Console.WriteLine(Tuple.Create(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4), func(tuple.Item5)));
            return tuple;
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T> PrintLines<T>(this Tuple<T, T, T, T, T> tuple)
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
        public static Tuple<T, T, T, T, T> PrintLines<T>(this Tuple<T, T, T, T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Tuple<T, T, T, T, T> tupleRes = new Tuple<T, T, T, T, T>(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4), func(tuple.Item5));

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
        public static Tuple<T, T, T, T, T> PrintLinesBy<T>(this Tuple<T, T, T, T, T> tuple, Func<T, T> func)
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
        public static Tuple<T, T, T, T, T, T> Print<T>(this Tuple<T, T, T, T, T, T> tuple)
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
        public static Tuple<T, T, T, T, T, T> Print<T>(this Tuple<T, T, T, T, T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Tuple<T, T, T, T, T, T> tupleRes = new Tuple<T, T, T, T, T, T>(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4), func(tuple.Item5), func(tuple.Item6));

            Console.Write(tupleRes);
            return tupleRes;
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T, T> PrintBy<T>(this Tuple<T, T, T, T, T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Console.Write(Tuple.Create(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4), func(tuple.Item5), func(tuple.Item6)));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T, T> Println<T>(this Tuple<T, T, T, T, T, T> tuple)
        {
            Console.Write(Tuple.Create(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T, T> Println<T>(this Tuple<T, T, T, T, T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Tuple<T, T, T, T, T, T> tupleRes = new Tuple<T, T, T, T, T, T>(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4), func(tuple.Item5), func(tuple.Item6));

            Console.WriteLine(tupleRes);
            return tupleRes;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T, T> PrintlnBy<T>(this Tuple<T, T, T, T, T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Console.WriteLine(Tuple.Create(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4), func(tuple.Item5), func(tuple.Item6)));
            return tuple;
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T, T> PrintLines<T>(this Tuple<T, T, T, T, T, T> tuple)
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
        public static Tuple<T, T, T, T, T, T> PrintLines<T>(this Tuple<T, T, T, T, T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Tuple<T, T, T, T, T, T> tupleRes = new Tuple<T, T, T, T, T, T>(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4), func(tuple.Item5), func(tuple.Item6));

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
        public static Tuple<T, T, T, T, T, T> PrintLinesBy<T>(this Tuple<T, T, T, T, T, T> tuple, Func<T, T> func)
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
        public static Tuple<T, T, T, T, T, T, T> Print<T>(this Tuple<T, T, T, T, T, T, T> tuple)
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
        public static Tuple<T, T, T, T, T, T, T> Print<T>(this Tuple<T, T, T, T, T, T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Tuple<T, T, T, T, T, T, T> tupleRes = new Tuple<T, T, T, T, T, T, T>(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4), func(tuple.Item5), func(tuple.Item6), func(tuple.Item7));

            Console.Write(tupleRes);
            return tupleRes;
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T, T, T> PrintBy<T>(this Tuple<T, T, T, T, T, T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Console.Write(Tuple.Create(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4), func(tuple.Item5), func(tuple.Item6), func(tuple.Item7)));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T, T, T> Println<T>(this Tuple<T, T, T, T, T, T, T> tuple)
        {
            Console.Write(Tuple.Create(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7));
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T, T, T> Println<T>(this Tuple<T, T, T, T, T, T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Tuple<T, T, T, T, T, T, T> tupleRes = new Tuple<T, T, T, T, T, T, T>(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4), func(tuple.Item5), func(tuple.Item6), func(tuple.Item7));

            Console.WriteLine(tupleRes);
            return tupleRes;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="func">Функция-селктор.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T, T, T> PrintlnBy<T>(this Tuple<T, T, T, T, T, T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Console.WriteLine(Tuple.Create(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4), func(tuple.Item5), func(tuple.Item6), func(tuple.Item7)));
            return tuple;
        }

        /// <summary>
        /// Выводит каждый элемент на новой строке.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T, T, T> PrintLines<T>(this Tuple<T, T, T, T, T, T, T> tuple)
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
        public static Tuple<T, T, T, T, T, T, T> PrintLines<T>(this Tuple<T, T, T, T, T, T, T> tuple, Func<T, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            Tuple<T, T, T, T, T, T, T> tupleRes = new Tuple<T, T, T, T, T, T, T>(func(tuple.Item1), func(tuple.Item2), func(tuple.Item3), func(tuple.Item4), func(tuple.Item5), func(tuple.Item6), func(tuple.Item7));

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
        public static Tuple<T, T, T, T, T, T, T> PrintLinesBy<T>(this Tuple<T, T, T, T, T, T, T> tuple, Func<T, T> func)
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

        #endregion

    }
}
