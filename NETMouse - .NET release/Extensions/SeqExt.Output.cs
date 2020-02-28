using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABCNET.Extensions
{
    public static partial class Seq
    {
        /// <summary>
        /// Выводит последовательность.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <param name="delimiter">Разделитель.</param>
        /// <param name="start">Первый выводимый символ строки.</param>
        /// <param name="end">Последний выводимый символ строки.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<T> Print<T>(this IEnumerable<T> collection, string delimiter = DefaultDelimiterHelper.Delimiter, string start = EmptyStringHelper.Empty, string end = EmptyStringHelper.Empty)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            IEnumerator<T> enumerator = collection.GetEnumerator();
            if (!enumerator.MoveNext())
                return collection;

            Console.Write(string.Format("{0}{1}", start, enumerator.Current));

            while (enumerator.MoveNext())
                Console.Write($"{delimiter}{enumerator.Current.NilOrString()}");

            Console.Write(end);

            return collection;
        }

        /// <summary>
        /// Выводит последовательность и переходит на новую строку.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <param name="delimiter">Разделитель.</param>
        /// <param name="start">Первый выводимый символ строки.</param>
        /// <param name="end">Последний выводимый символ строки.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<T> Println<T>(this IEnumerable<T> collection, string delimiter = DefaultDelimiterHelper.Delimiter, string start = EmptyStringHelper.Empty, string end = EmptyStringHelper.Empty)
        {
            Console.Write(start);
            collection.Print(delimiter);
            Console.WriteLine(end);
            return collection;
        }

        /// <summary>
        /// Выводит каждый элемент последовательности на отдельной строке.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<T> PrintLines<T>(this IEnumerable<T> collection)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            foreach (T item in collection)
                Console.WriteLine(item.NilOrString());
            return collection;
        }

        /// <summary>
        /// Выводит последовательность.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <param name="delimiter">Разделитель.</param>
        /// <param name="start">Первый выводимый символ строки.</param>
        /// <param name="end">Последний выводимый символ строки.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<T> PrintBy<T, TOutput>(this IEnumerable<T> collection, Func<T, TOutput> selector, string delimiter = DefaultDelimiterHelper.Delimiter, string start = EmptyStringHelper.Empty, string end = EmptyStringHelper.Empty)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            IEnumerator<T> enumerator = collection.GetEnumerator();
            if (!enumerator.MoveNext())
                return ArrayHelper<T>.Empty;

            Console.Write($"{start}{selector(enumerator.Current).NilOrString()}");

            while (enumerator.MoveNext())
                Console.Write($"{delimiter}{selector(enumerator.Current).NilOrString()}");

            Console.Write(end);

            return collection;
        }

        /// <summary>
        /// Выводит последовательность и переходит на новую строку.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <param name="delimiter">Разделитель.</param>
        /// <param name="start">Первый выводимый символ строки.</param>
        /// <param name="end">Последний выводимый символ строки.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<T> PrintlnBy<T, TOutput>(this IEnumerable<T> collection, Func<T, TOutput> selector, string delimiter = DefaultDelimiterHelper.Delimiter, string start = EmptyStringHelper.Empty, string end = EmptyStringHelper.Empty)
        {
            collection.PrintBy(selector, delimiter, start, end);
            Console.WriteLine();
            return collection;
        }

        /// <summary>
        /// Выводит каждый элемент последовательности на отдельной строке.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<T> PrintLinesBy<T, TOutput>(this IEnumerable<T> collection, Func<T, TOutput> selector)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            foreach (T item in collection)
                Console.WriteLine(selector(item).NilOrString());
            return collection;
        }
    }
}
