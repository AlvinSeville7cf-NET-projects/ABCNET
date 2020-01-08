using System;
using System.Collections.Generic;

namespace ABCNET.Extensions
{
    /// <summary>
    /// Предоставляет функционал для работы с ссылочными кортежами.
    /// </summary>
    public static class TupExt
    {
        /// <summary>
        /// Преобразует кортеж в KeyValuePair.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>KeyValuePair.</returns>
        public static KeyValuePair<T, T1> ToKV<T, T1>(this Tuple<T, T1> tuple)
        {
            return new KeyValuePair<T, T1>(tuple.Item1, tuple.Item2);
        }
        
        /// <summary>
        /// Добавляет элемент к кортежу.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="item">Элемент.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2> Add<T, T1, T2>(this Tuple<T, T1> tuple, T2 item)
        {
            return new Tuple<T, T1, T2>(tuple.Item1, tuple.Item2, item);
        }

        /// <summary>
        /// Добавляет элемент к кортежу.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="item">Элемент.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T2, T, T1> AddFirst<T, T1, T2>(this Tuple<T, T1> tuple, T2 item)
        {
            return new Tuple<T2, T, T1>(item, tuple.Item1, tuple.Item2);
        }

        /// <summary>
        /// Добавляет элемент к кортежу.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="item">Элемент.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3> Add<T, T1, T2, T3>(this Tuple<T, T1, T2> tuple, T3 item)
        {
            return new Tuple<T, T1, T2, T3>(tuple.Item1, tuple.Item2, tuple.Item3, item);
        }

        /// <summary>
        /// Добавляет элемент к кортежу.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="item">Элемент.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T3, T, T1, T2> AddFirst<T, T1, T2, T3>(this Tuple<T, T1, T2> tuple, T3 item)
        {
            return new Tuple<T3, T, T1, T2>(item, tuple.Item1, tuple.Item2, tuple.Item3);
        }

        /// <summary>
        /// Добавляет элемент к кортежу.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="item">Элемент.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3, T4> Add<T, T1, T2, T3, T4>(this Tuple<T, T1, T2, T3> tuple, T4 item)
        {
            return new Tuple<T, T1, T2, T3, T4>(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, item);
        }

        /// <summary>
        /// Добавляет элемент к кортежу.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="item">Элемент.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T4, T, T1, T2, T3> AddFirst<T, T1, T2, T3, T4>(this Tuple<T, T1, T2, T3> tuple, T4 item)
        {
            return new Tuple<T4, T, T1, T2, T3>(item, tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4);
        }

        /// <summary>
        /// Добавляет элемент к кортежу.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="item">Элемент.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3, T4, T5> Add<T, T1, T2, T3, T4, T5>(this Tuple<T, T1, T2, T3, T4> tuple, T5 item)
        {
            return new Tuple<T, T1, T2, T3, T4, T5>(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, item);
        }

        /// <summary>
        /// Добавляет элемент к кортежу.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="item">Элемент.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T5, T, T1, T2, T3, T4> AddFirst<T, T1, T2, T3, T4, T5>(this Tuple<T, T1, T2, T3, T4> tuple, T5 item)
        {
            return new Tuple<T5, T, T1, T2, T3, T4>(item, tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5);
        }

        /// <summary>
        /// Добавляет элемент к кортежу.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="item">Элемент.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3, T4, T5, T6> Add<T, T1, T2, T3, T4, T5, T6>(this Tuple<T, T1, T2, T3, T4, T5> tuple, T6 item)
        {
            return new Tuple<T, T1, T2, T3, T4, T5, T6>(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, item);
        }

        /// <summary>
        /// Добавляет элемент к кортежу.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="item">Элемент.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T6, T, T1, T2, T3, T4, T5> AddFirst<T, T1, T2, T3, T4, T5, T6>(this Tuple<T, T1, T2, T3, T4, T5> tuple, T6 item)
        {
            return new Tuple<T6, T, T1, T2, T3, T4, T5>(item, tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6);
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1> Print<T, T1>(this Tuple<T, T1> tuple)
        {
            Console.Write(tuple);
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1> Println<T, T1>(this Tuple<T, T1> tuple)
        {
            Console.WriteLine(tuple);
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2> Print<T, T1, T2>(this Tuple<T, T1, T2> tuple)
        {
            Console.Write(tuple);
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2> Println<T, T1, T2>(this Tuple<T, T1, T2> tuple)
        {
            Console.WriteLine(tuple);
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3> Print<T, T1, T2, T3>(this Tuple<T, T1, T2, T3> tuple)
        {
            Console.Write(tuple);
            return tuple;
        }

        /// <summary>
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3> Println<T, T1, T2, T3>(this Tuple<T, T1, T2, T3> tuple)
        {
            Console.WriteLine(tuple);
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
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3, T4> Println<T, T1, T2, T3, T4>(this Tuple<T, T1, T2, T3, T4> tuple)
        {
            Console.WriteLine(tuple);
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
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3, T4, T5> Println<T, T1, T2, T3, T4, T5>(this Tuple<T, T1, T2, T3, T4, T5> tuple)
        {
            Console.WriteLine(tuple);
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
        /// Выводит кортеж и переходит на новую строку.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1, T2, T3, T4, T5, T6> Println<T, T1, T2, T3, T4, T5, T6>(this Tuple<T, T1, T2, T3, T4, T5, T6> tuple)
        {
            Console.WriteLine(tuple);
            return tuple;
        }
    }
}