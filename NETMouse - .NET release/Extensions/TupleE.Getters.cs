using System;
using System.Collections.Generic;

namespace ABCNET.Extensions
{
    /// <summary>
    /// Предоставляет функционал для работы с кортежами.
    /// </summary>
    public static partial class TupleE
    {
        #region public

        /// <summary>
        /// Преобразует кортеж в последовательность.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<T> ToSequence<T>(this Tuple<T, T> tuple)
        {
            yield return tuple.Item1;
            yield return tuple.Item2;
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
        public static Tuple<T, T1, T2> Add<T, T1, T2>(this Tuple<T, T1> tuple, T2 item)
        {
            return new Tuple<T, T1, T2>(tuple.Item1, tuple.Item2, item);
        }



        /// <summary>
        /// Преобразует кортеж в последовательность.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<T> ToSequence<T>(this Tuple<T, T, T> tuple)
        {
            yield return tuple.Item1;
            yield return tuple.Item2;
            yield return tuple.Item3;
        }

        /// <summary>
        /// Добавляет элемент к кортежу.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="item">Элемент.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T> AddFirst<T>(this Tuple<T, T, T> tuple, T item)
        {
            return new Tuple<T, T, T, T>(item, tuple.Item1, tuple.Item2, tuple.Item3);
        }

        /// <summary>
        /// Добавляет элемент к кортежу.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="item">Элемент.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T> Add<T>(this Tuple<T, T, T> tuple, T item)
        {
            return new Tuple<T, T, T, T>(tuple.Item1, tuple.Item2, tuple.Item3, item);
        }



        /// <summary>
        /// Преобразует кортеж в последовательность.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<T> ToSequence<T>(this Tuple<T, T, T, T> tuple)
        {
            yield return tuple.Item1;
            yield return tuple.Item2;
            yield return tuple.Item3;
            yield return tuple.Item4;
        }

        /// <summary>
        /// Добавляет элемент к кортежу.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="item">Элемент.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T> AddFirst<T>(this Tuple<T, T, T, T> tuple, T item)
        {
            return new Tuple<T, T, T, T, T>(item, tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4);
        }

        /// <summary>
        /// Добавляет элемент к кортежу.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="item">Элемент.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T> Add<T>(this Tuple<T, T, T, T> tuple, T item)
        {
            return new Tuple<T, T, T, T, T>(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, item);
        }



        /// <summary>
        /// Преобразует кортеж в последовательность.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<T> ToSequence<T>(this Tuple<T, T, T, T, T> tuple)
        {
            yield return tuple.Item1;
            yield return tuple.Item2;
            yield return tuple.Item3;
            yield return tuple.Item4;
            yield return tuple.Item5;
        }

        /// <summary>
        /// Добавляет элемент к кортежу.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="item">Элемент.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T, T> AddFirst<T>(this Tuple<T, T, T, T, T> tuple, T item)
        {
            return new Tuple<T, T, T, T, T, T>(item, tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5);
        }

        /// <summary>
        /// Добавляет элемент к кортежу.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="item">Элемент.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T, T> Add<T>(this Tuple<T, T, T, T, T> tuple, T item)
        {
            return new Tuple<T, T, T, T, T, T>(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, item);
        }



        /// <summary>
        /// Преобразует кортеж в последовательность.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<T> ToSequence<T>(this Tuple<T, T, T, T, T, T> tuple)
        {
            yield return tuple.Item1;
            yield return tuple.Item2;
            yield return tuple.Item3;
            yield return tuple.Item4;
            yield return tuple.Item5;
            yield return tuple.Item6;
        }

        /// <summary>
        /// Добавляет элемент к кортежу.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="item">Элемент.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T, T, T> AddFirst<T>(this Tuple<T, T, T, T, T, T> tuple, T item)
        {
            return new Tuple<T, T, T, T, T, T, T>(item, tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6);
        }

        /// <summary>
        /// Добавляет элемент к кортежу.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <param name="item">Элемент.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T, T, T, T, T> Add<T>(this Tuple<T, T, T, T, T, T> tuple, T item)
        {
            return new Tuple<T, T, T, T, T, T, T>(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, item);
        }

        /// <summary>
        /// Преобразует кортеж в последовательность.
        /// </summary>
        /// <param name="tuple">Кортеж.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<T> ToSequence<T>(this Tuple<T, T, T, T, T, T, T> tuple)
        {
            yield return tuple.Item1;
            yield return tuple.Item2;
            yield return tuple.Item3;
            yield return tuple.Item4;
            yield return tuple.Item5;
            yield return tuple.Item6;
            yield return tuple.Item7;
        }

        #endregion public
    }
}
