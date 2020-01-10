using System;

namespace ABCNET.Extensions
{
    /// <summary>
    /// Предоставляет функционал для работы с ссылочными кортежами.
    /// </summary>
    public static class TupExt
    {
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
    }
}