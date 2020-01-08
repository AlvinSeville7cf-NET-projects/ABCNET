using System;
using System.Collections.Generic;
using System.Linq;

namespace ABCNET.Extensions
{
    /// <summary>
    /// Предоставляет функционал для работы с последовательностями.
    /// </summary>
    public static class SeqExt
    {
        /// <summary>
        /// Ассоцирует элементы последовательности с их проекциями.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<AssociateRes<T, TOutput>> Associate<T, TOutput>(this IEnumerable<T> collection, Func<T, TOutput> selector)
        {
            if (selector == null)
                throw new ArgumentNullException("selector");
            if (collection == null)
                throw new ArgumentNullException("collection");

            return collection.Select(delegate (T x) { return new AssociateRes<T, TOutput>(x, selector(x)); });
        }

        /// <summary>
        /// Объединяет две последовательности в последовательность двухэлементных кортежей.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <param name="secondCollection">Вторая последовательность.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<Tuple<T, T1>> ZipTuple<T, T1>(this IEnumerable<T> collection, IEnumerable<T1> secondCollection)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");
            if (secondCollection == null)
                throw new ArgumentNullException("secondCollection");

            return collection.Zip(secondCollection, delegate (T x, T1 y) { return Tuple.Create(x, y); });
        }

        /// <summary>
        /// Разъединяет последовательность кортежей в две последовательности.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <returns>Пара последовательностей.</returns>
        public static Tuple<IEnumerable<T>, IEnumerable<T1>> UnzipTuple<T, T1>(this IEnumerable<Tuple<T, T1>> collection)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");

            return Tuple.Create(collection.Select(delegate (Tuple<T, T1> x) { return x.Item1; }),
                collection.Select(delegate (Tuple<T, T1> x) { return x.Item2; }));
        }

        /// <summary>
        /// Нумерует последовательность.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<NumerateRes<T>> Numerate<T>(this IEnumerable<T> collection)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");

            return collection.Select(delegate(T x, int i) { return new NumerateRes<T>(x, i); });
        }

        /// <summary>
        /// Нумерует последовательность.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<NumerateRes<TOutput>> Numerate<T, TOutput>(this IEnumerable<T> collection, Func<T, TOutput> selector)
        {
            if (selector == null)
                throw new ArgumentNullException("selector");
            if (collection == null)
                throw new ArgumentNullException("collection");

            return collection.Select(delegate(T x, int i) { return new NumerateRes<TOutput>(selector(x), i); });
        }

        /// <summary>
        /// Сортирует последовательность по возрастанию.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <returns>Последовательность.</returns>
        public static IOrderedEnumerable<T> Sort<T>(this IEnumerable<T> collection)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");

            return collection.OrderBy(x => x);
        }

        /// <summary>
        /// Сортирует последовательность по убыванию.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <returns>Последовательность.</returns>
        public static IOrderedEnumerable<T> SortDesc<T>(this IEnumerable<T> collection)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");
            
            return collection.OrderByDescending(x => x);
        }

        /// <summary>
        /// Находит минимум по ключу.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <returns>Минимум.</returns>
        public static T MinBy<T, TOutput>(this IEnumerable<T> collection, Func<T, TOutput> selector)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");
            
            IComparer<TOutput> comparer = Comparer<TOutput>.Default;
            return collection.Aggregate((a, b) => comparer.Compare(selector(a), selector(b)) < 0 ? a : b);
        }

        /// <summary>
        /// Находит максимум по ключу.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <returns>Максимум.</returns>
        public static T MaxBy<T, TOutput>(this IEnumerable<T> collection, Func<T, TOutput> selector)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");
            
            IComparer<TOutput> comparer = Comparer<TOutput>.Default;
            return collection.Aggregate((a, b) => comparer.Compare(selector(a), selector(b)) > 0 ? a : b);
        }

        /// <summary>
        /// Находит декартово произведене последовательностей.
        /// </summary>
        /// <param name="collectionFirst">Первая последовательность.</param>
        /// <param name="collectionSecond">Вторая последовательность.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<Tuple<T, T1>> Cartesian<T, T1>(this IEnumerable<T> collectionFirst, IEnumerable<T1> collectionSecond)
        {
            if (collectionFirst == null)
                throw new ArgumentNullException("collectionFirst");
            if (collectionSecond == null)
                throw new ArgumentNullException("collectionSecond");

            foreach (T itemA in collectionFirst)
                foreach (T1 itemB in collectionSecond)
                    yield return new Tuple<T, T1>(itemA, itemB);
        }

        /// <summary>
        /// Находит декартово произведене последовательностей.
        /// </summary>
        /// <param name="collectionFirst">Первая последовательность.</param>
        /// <param name="collectionSecond">Вторая последовательность.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<Tuple<TOutput, TOutput>> Cartesian<T, TOutput>(this IEnumerable<T> collectionFirst, IEnumerable<T> collectionSecond, Func<T, TOutput> selector)
        {
            if (selector == null)
                throw new ArgumentNullException("selector");
            if (collectionFirst == null)
                throw new ArgumentNullException("collectionFirst");
            if (collectionSecond == null)
                throw new ArgumentNullException("collectionSecond");

            foreach (T itemA in collectionFirst)
                foreach (T itemB in collectionSecond)
                    yield return new Tuple<TOutput, TOutput>(selector(itemA), selector(itemB));
        }

        /// <summary>
        /// Перемешивает последовательность.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> collection)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");

            Random random = new Random();
            return collection.OrderBy(x => random.Next(int.MaxValue));
        }

        /// <summary>
        /// Перемешивает последовательность.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<TOutput> Shuffle<T, TOutput>(this IEnumerable<T> collection, Func<T, TOutput> selector)
        {
            if (selector == null)
                throw new ArgumentNullException("selector");
            if (collection == null)
                throw new ArgumentNullException("collection");

            Random random = new Random();
            return collection.Select(x => selector(x)).OrderBy(x => random.Next(int.MaxValue));
        }

        /// <summary>
        /// Выводит последовательность.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <param name="delimiter">Разделитель.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<T> Print<T>(this IEnumerable<T> collection, string delimiter = DefaultDelimiterHelper.Delimiter)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");
            
            if (typeof(T) == typeof(char))
                delimiter = string.Empty;
            foreach (T item in collection)
                Console.Write(string.Format("{0}{1}", item, delimiter));
            return collection;
        }

        /// <summary>
        /// Выводит последовательность и переходит на новую строку.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <param name="delimiter">Разделитель.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<T> Println<T>(this IEnumerable<T> collection, string delimiter = DefaultDelimiterHelper.Delimiter)
        {
            collection.Print(delimiter);
            Console.WriteLine();
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
                throw new ArgumentNullException("collection");
            
            foreach (T item in collection)
                Console.WriteLine(item);
            return collection;
        }

        /// <summary>
        /// Выводит последовательность.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <param name="delimiter">Разделитель.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<T> PrintBy<T, TOutput>(this IEnumerable<T> collection, Func<T, TOutput> selector, string delimiter = DefaultDelimiterHelper.Delimiter)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");
            if (selector == null)
                throw new ArgumentNullException("selector");
            
            if (typeof(T) == typeof(char))
                delimiter = string.Empty;
            foreach (T item in collection)
            	Console.Write(string.Format("{0}{1}", selector(item), delimiter));
            return collection;
        }

        /// <summary>
        /// Выводит последовательность и переходит на новую строку.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <param name="delimiter">Разделитель.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<T> PrintlnBy<T, TOutput>(this IEnumerable<T> collection, Func<T, TOutput> selector, string delimiter = DefaultDelimiterHelper.Delimiter)
        {
            collection.PrintBy(selector, delimiter);
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
                throw new ArgumentNullException("collection");
            if (selector == null)
                throw new ArgumentNullException("selector");
            
            foreach (T item in collection)
                Console.WriteLine(selector(item));
            return collection;
        }

        /// <summary>
        /// Результат для Numerate.
        /// </summary>
        public class NumerateRes<T>
        {
            /// <summary>
            /// Элемент.
            /// </summary>
            public T Item { get; }

            /// <summary>
            /// Индекс.
            /// </summary>
            public int Index { get; }


            public NumerateRes(T item, int index)
            {
                Item = item;
                Index = index;
            }

            public void Deconstruct(out T item, out int index)
            {
                item = Item;
                index = Index;
            }

            public override string ToString()
            {
                return $"[{Item} - {Index}]";
            }
        }

        /// <summary>
        /// Результат для Associate.
        /// </summary>
        public class AssociateRes<T, TOutput>
        {
            /// <summary>
            /// Элемент.
            /// </summary>
            public T Item { get; }

            /// <summary>
            /// Проекция элемента.
            /// </summary>
            public TOutput Projection { get; }


            public AssociateRes(T item, TOutput projection)
            {
                Item = item;
                Projection = projection;
            }

            public void Deconstruct(out T item, out TOutput projection)
            {
                item = Item;
                projection = Projection;
            }

            public override string ToString()
            {
                return $"[{Item} - {Projection}]";
            }
        }
    }
}