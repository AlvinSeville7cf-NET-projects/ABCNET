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
        /// Преобразует последовательность в кортеж.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T> ToTup2<T>(this IEnumerable<T> collection)
        {
            T a = default;
            T b = default;

            IEnumerator<T> en = collection.GetEnumerator();
            if (en.MoveNext())
            {
                a = en.Current;
                if (en.MoveNext())
                {
                    b = en.Current;
                    if (en.MoveNext())
                        throw new ArgumentException(nameof(collection));
                    return Tuple.Create(a, b);
                }
                throw new ArgumentException(nameof(collection));
            }
            throw new ArgumentException(nameof(collection));
        }

        /// <summary>
        /// Преобразует последовательность в кортеж.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T, T> ToTup3<T>(this IEnumerable<T> collection)
        {
            T a = default;
            T b = default;
            T c = default;

            IEnumerator<T> en = collection.GetEnumerator();
            if (en.MoveNext())
            {
                a = en.Current;
                if (en.MoveNext())
                {
                    b = en.Current;
                    if (en.MoveNext())
                    {
                        c = en.Current;
                        if (en.MoveNext())
                            throw new ArgumentException(nameof(collection));
                        return Tuple.Create(a, b, c);
                    }
                }
                throw new ArgumentException(nameof(collection));
            }
            throw new ArgumentException(nameof(collection));
        }

        /// <summary>
        /// Разбивает последовательность на серии.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <param name="count">Длина серии.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<T[]> Batch<T>(this IEnumerable<T> collection, int count)
        {
            if (count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            int k = 0;
            List<T> part = new List<T>();

            foreach (var item in collection)
            {
                if (k < count)
                    k++;
                else
                {
                    yield return part.ToArray();
                    part.Clear();
                    k = 1;
                }
                part.Add(item);
            }
            if (part.Count != 0)
                yield return part.ToArray();
        }

        /// <summary>
        /// Разбивает последовательность на серии.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <param name="count">Длина серии.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<TOutput[]> Batch<T, TOutput>(this IEnumerable<T> collection, int count, Func<T, TOutput> selector)
        {
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));
            if (count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            int k = 0;
            List<TOutput> part = new List<TOutput>();

            foreach (var item in collection)
            {
                if (k < count)
                    k++;
                else
                {
                    yield return part.ToArray();
                    part.Clear();
                    k = 1;
                }
                part.Add(selector(item));
            }
            if (part.Count != 0)
                yield return part.ToArray();
        }

        /// <summary>
        /// Превращает последовательность в последовательность пар соседних элементов.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<Tuple<T, T>> Pairwise<T>(this IEnumerable<T> collection)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            IEnumerator<T> enumerator = collection.GetEnumerator();
            T previous = default;
            if (enumerator.MoveNext())
                previous = enumerator.Current;
            else
                yield break;

            while (enumerator.MoveNext())
            {
                yield return Tuple.Create(previous, enumerator.Current);
                previous = enumerator.Current;
            }
        }

        /// <summary>
        /// Превращает последовательность в последовательность пар соседних элементов.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<Tuple<TOutput, TOutput>> Pairwise<T, TOutput>(this IEnumerable<T> collection, Func<T, TOutput> selector)
        {
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            IEnumerator<T> enumerator = collection.GetEnumerator();
            TOutput previous = default;
            if (enumerator.MoveNext())
                previous = selector(enumerator.Current);
            else
                yield break;

            while (enumerator.MoveNext())
            {
                TOutput current = selector(enumerator.Current);
                yield return Tuple.Create(previous, current);
                previous = current;
            }
        }

        /// <summary>
        /// Превращает последовательность в последовательность пар соседних элементов и применяет функцию селектор к каждой паре.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<TOutput> Pairwise<T, TOutput>(this IEnumerable<T> collection, Func<T, T, TOutput> selector)
        {
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            IEnumerator<T> enumerator = collection.GetEnumerator();
            T previous = default;
            if (enumerator.MoveNext())
                previous = enumerator.Current;
            else
                yield break;

            while (enumerator.MoveNext())
            {
                yield return selector(previous, enumerator.Current);
                previous = enumerator.Current;
            }
        }

        /// <summary>
        /// Ассоцирует элементы последовательности с их проекциями.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<AssociateRes<T, TOutput>> Associate<T, TOutput>(this IEnumerable<T> collection, Func<T, TOutput> selector)
        {
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

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
                throw new ArgumentNullException(nameof(collection));
            if (secondCollection == null)
                throw new ArgumentNullException(nameof(secondCollection));

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
                throw new ArgumentNullException(nameof(collection));

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
                throw new ArgumentNullException(nameof(collection));

            return collection.Select(delegate (T x, int i) { return new NumerateRes<T>(x, i); });
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
                throw new ArgumentNullException(nameof(selector));
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            return collection.Select(delegate (T x, int i) { return new NumerateRes<TOutput>(selector(x), i); });
        }

        /// <summary>
        /// Сортирует последовательность по возрастанию.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <returns>Последовательность.</returns>
        public static IOrderedEnumerable<T> Sort<T>(this IEnumerable<T> collection)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

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
                throw new ArgumentNullException(nameof(collection));

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
                throw new ArgumentNullException(nameof(collection));

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
                throw new ArgumentNullException(nameof(collection));

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
                throw new ArgumentNullException(nameof(collectionFirst));
            if (collectionSecond == null)
                throw new ArgumentNullException(nameof(collectionSecond));

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
                throw new ArgumentNullException(nameof(selector));
            if (collectionFirst == null)
                throw new ArgumentNullException(nameof(collectionFirst));
            if (collectionSecond == null)
                throw new ArgumentNullException(nameof(collectionSecond));

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
                throw new ArgumentNullException(nameof(collection));

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
                throw new ArgumentNullException(nameof(selector));
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            Random random = new Random();
            return collection.Select(x => selector(x)).OrderBy(x => random.Next(int.MaxValue));
        }

        /// <summary>
        /// Чередует элементы двух последовательностей.
        /// </summary>
        /// <param name="collectionFirst">Первая последовательность.</param>
        /// <param name="collectionSecond">Вторая последовательность.</param>
        /// <param name="onlyPairs">Возвращать ли только пары элементов, или возвращать и оставшиеся элементы большей последовательности.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<T> Interleave<T>(this IEnumerable<T> collectionFirst, IEnumerable<T> collectionSecond, bool onlyPairs = true)
        {
            if (collectionFirst == null)
                throw new ArgumentNullException(nameof(collectionFirst));
            if (collectionSecond == null)
                throw new ArgumentNullException(nameof(collectionSecond));

            using (IEnumerator<T> e1 = collectionFirst.GetEnumerator())
            using (IEnumerator<T> e2 = collectionSecond.GetEnumerator())
            {
                bool firstCanMove = e1.MoveNext();
                bool secondCanMove = e2.MoveNext();
                while (firstCanMove && secondCanMove)
                {
                    yield return e1.Current;
                    yield return e2.Current;

                    firstCanMove = e1.MoveNext();
                    secondCanMove = e2.MoveNext();
                }
                if (!onlyPairs)
                    if (firstCanMove)
                        do
                        {
                            yield return e1.Current;
                        }
                        while (e1.MoveNext());
                if (secondCanMove)
                    do
                    {
                        yield return e2.Current;
                    }
                    while (e2.MoveNext());
            }
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
                throw new ArgumentNullException(nameof(collection));

            IEnumerator<T> enumerator = collection.GetEnumerator();
            if (!enumerator.MoveNext())
                return collection;

            Console.Write(enumerator.Current);

            while (enumerator.MoveNext())
                Console.Write($"{delimiter}{enumerator.Current}");

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
                throw new ArgumentNullException(nameof(collection));

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
                throw new ArgumentNullException(nameof(collection));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            IEnumerator<T> enumerator = collection.GetEnumerator();
            if (!enumerator.MoveNext())
                return ArrayHelper<T>.Empty;

            Console.Write(selector(enumerator.Current));

            while (enumerator.MoveNext())
                Console.Write($"{delimiter}{selector(enumerator.Current)}");

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
                throw new ArgumentNullException(nameof(collection));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

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

        /// <summary>
        /// Произведение элементов последовательности.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <returns>Произведение.</returns>
        public static int Prod(this IEnumerable<int> collection)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            int Res = 1;
            foreach (int item in collection)
                Res*=item;

            return Res;
        }

        /// <summary>
        /// Произведение элементов последовательности.
        /// </summary>
        /// <param name="collection">Последовательность.</param>
        /// <returns>Произведение.</returns>
        public static double Prod(this IEnumerable<double> collection)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            double Res = 1;
            foreach (double item in collection)
                Res *= item;

            return Res;
        }
    }
}