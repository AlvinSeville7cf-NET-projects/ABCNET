using System;
using System.Collections.Generic;
using System.Linq;

namespace NETMouse.Extensions
{
    /// <summary>
    /// Provides standart extensions for sequences.
    /// </summary>
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// The default delimiter.
        /// </summary>
        public const string DefaultDelimiter = " ";

        /// <summary>
        /// Numerates the collection.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <returns>The collection of tuples item-index.</returns>
        public static IEnumerable<Tuple<T, int>> Numerate<T>(this IEnumerable<T> collection)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");

            return collection.Select(delegate(T x, int i) { return new Tuple<T, int>(x, i); });
        }
        
        /// <summary>
        /// Numerates the collection.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <returns>The collection of tuples item-index or the empty collection if the input collection was null.</returns>
        public static IEnumerable<Tuple<T, int>> NumerateOrEmpty<T>(this IEnumerable<T> collection)
        {
            if (collection == null)
                return Enumerable.Empty<Tuple<T, int>>();

            return collection.Select(delegate(T x, int i) { return new Tuple<T, int>(x, i); });
        }
        
        /// <summary>
        /// Numerates the collection where every item is mapped with the selector method.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <param name="selector">The map method.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <typeparam name="TOutput">The output value type.</typeparam>
        /// <returns>The collection of tuples item-index.</returns>
        public static IEnumerable<Tuple<TOutput, int>> NumerateSelected<T, TOutput>(this IEnumerable<T> collection, Func<T, TOutput> selector)
        {
            if (selector == null)
                throw new ArgumentNullException("selector");
            if (collection == null)
                throw new ArgumentNullException("collection");

            return collection.Select(delegate(T x, int i) { return new Tuple<TOutput, int>(selector(x), i); });
        }
        
        /// <summary>
        /// Numerates the collection where every item is mapped with the selector method.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <param name="selector">The map method.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <typeparam name="TOutput">The output value type.</typeparam>
        /// <returns>The collection of tuples item-index or the empty collection if the input collection was null.</returns>
        public static IEnumerable<Tuple<TOutput, int>> NumerateSelectedOrEmpty<T, TOutput>(this IEnumerable<T> collection, Func<T, TOutput> selector)
        {
            if (selector == null)
                throw new ArgumentNullException("selector");
            if (collection == null)
                return Enumerable.Empty<Tuple<TOutput, int>>();

            return collection.Select(delegate(T x, int i) { return new Tuple<TOutput, int>(selector(x), i); });
        }
        
        /// <summary>
        /// Returns the sorted collection.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <param name="selector">The map method.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <typeparam name="TOutput">The map method output type.</typeparam>
        /// <returns>The sorted collection or the empty collection if the input collection was null.</returns>
        public static IOrderedEnumerable<T> OrderByOrEmpty<T, TOutput>(this IEnumerable<T> collection, Func<T, TOutput> selector)
        {
            if (selector == null)
                throw new ArgumentNullException("selector");
            if (collection == null)
                return Enumerable.Empty<T>().OrderBy(x => x);

            return collection.OrderBy(selector);
        }
        
        /// <summary>
        /// Returns the sorted collection that is sorted by keys descending.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <param name="selector">The map method.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <typeparam name="TOutput">The map method output type.</typeparam>
        /// <returns>The sorted collection that is sorted by keys descending or the empty collection if the input collection was null.</returns>
        public static IOrderedEnumerable<T> OrderByDescendingOrEmpty<T, TOutput>(this IEnumerable<T> collection, Func<T, TOutput> selector)
        {
            if (selector == null)
                throw new ArgumentNullException("selector");
            if (collection == null)
                return Enumerable.Empty<T>().OrderByDescending(x => x);

            return collection.OrderByDescending(selector);
        }
        
        /// <summary>
        /// Returns the sorted collection.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <returns>The sorted collection.</returns>
        public static IOrderedEnumerable<T> OrderBy<T>(this IEnumerable<T> collection)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");

            return collection.OrderBy(x => x);
        }

        /// <summary>
        /// Returns the sorted collection.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <returns>The sorted collection or the empty collection if the input collection was null.</returns>
        public static IOrderedEnumerable<T> OrderByOrEmpty<T>(this IEnumerable<T> collection)
        {
            if (collection == null)
                return Enumerable.Empty<T>().OrderBy(x => x);
            
            return collection.OrderBy(x => x);
        }
        
        /// <summary>
        /// Returns the collection that sorted by descending.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <returns>Returns the collection that sorted by descending.</returns>
        public static IOrderedEnumerable<T> OrderByDescending<T>(this IEnumerable<T> collection)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");
            
            return collection.OrderByDescending(x => x);
        }
        
        /// <summary>
        /// Returns the sorted collection that sorted by descending.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <returns>The sorted collection that sorted by descending or the empty collection if the input collection was null.</returns>
        public static IOrderedEnumerable<T> OrderByDescendingOrEmpty<T>(this IEnumerable<T> collection)
        {
            if (collection == null)
                return Enumerable.Empty<T>().OrderByDescending(x => x);
            
            return collection.OrderByDescending(x => x);
        }
        
        /// <summary>
        /// Retrieves the item with the minimum value.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <returns>The item with the minimum value or the default value if the input collection was null.</returns>
        public static T MinOrDefault<T>(this IEnumerable<T> collection)
            where T: IComparable
        {
            if (collection == null)
            	return default(T);
            
            return collection.Min();
        }
        
        /// <summary>
        /// Retrieves the item with the minimum key.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <param name="selector">The map method.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <typeparam name="TOutput">The output type.</typeparam>
        /// <returns>The item with the minimum key.</returns>
        public static T MinBy<T, TOutput>(this IEnumerable<T> collection, Func<T, TOutput> selector)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");
            
            IComparer<TOutput> comparer = Comparer<TOutput>.Default;
            return collection.Aggregate((a, b) => comparer.Compare(selector(a), selector(b)) < 0 ? a : b);
        }
        
        /// <summary>
        /// Retrieves the item with the minimum key.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <param name="selector">The map method.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <typeparam name="TOutput">The output type.</typeparam>
        /// <returns>The item with the minimum key.</returns>
        public static T MinByOrDefault<T, TOutput>(this IEnumerable<T> collection, Func<T, TOutput> selector)
        {
            if (collection == null)
            	return default(T);
            
            IComparer<TOutput> comparer = Comparer<TOutput>.Default;
            return collection.Aggregate((a, b) => comparer.Compare(selector(a), selector(b)) < 0 ? a : b);
        }
        
        /// <summary>
        /// Retrieves the item with the maximum value.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <returns>The item with the maximum value or the default value if the input collection was null.</returns>
        public static T MaxOrDefault<T>(this IEnumerable<T> collection)
            where T: IComparable
        {
            if (collection == null)
            	return default(T);
            
            return collection.Min();
        }
        
        /// <summary>
        /// Retrieves the item with the maximum key.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <param name="selector">The map method.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <typeparam name="TOutput">The output type.</typeparam>
        /// <returns>The item with the maximum key.</returns>
        public static T MaxBy<T, TOutput>(this IEnumerable<T> collection, Func<T, TOutput> selector)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");
            
            IComparer<TOutput> comparer = Comparer<TOutput>.Default;
            return collection.Aggregate((a, b) => comparer.Compare(selector(a), selector(b)) > 0 ? a : b);
        }
        
        /// <summary>
        /// Retrieves the item with the maximum key.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <param name="selector">The map method.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <typeparam name="TOutput">The output type.</typeparam>
        /// <returns>The item with the maximum key or the default value if the input collection was null.</returns>
        public static T MaxByOrDefault<T, TOutput>(this IEnumerable<T> collection, Func<T, TOutput> selector)
        {
            if (collection == null)
            	return default(T);
            
            IComparer<TOutput> comparer = Comparer<TOutput>.Default;
            return collection.Aggregate((a, b) => comparer.Compare(selector(a), selector(b)) > 0 ? a : b);
        }

        /// <summary>
        /// Returns the cartesian of two collections elements.
        /// </summary>
        /// <param name="collectionFirst">The first collection.</param>
        /// <param name="collectionSecond">The second collection.</param>
        /// <typeparam name="T">The first value type.</typeparam>
        /// <typeparam name="T1">The second value type.</typeparam>
        /// <returns>The cartesian of two collections elements.</returns>
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
        /// Shuffles the collection.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <returns>The shuffled collection.</returns>
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> collection)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");

            Random random = new Random();
            return collection.OrderBy(x => random.Next(int.MaxValue));
        }
        
        /// <summary>
        /// Shuffles the collection.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <returns>The shuffled collection or the empty collection if the input collection was null.</returns>
        public static IEnumerable<T> ShuffleOrEmpty<T>(this IEnumerable<T> collection)
        {
            if (collection == null)
                return Enumerable.Empty<T>();
            
            Random random = new Random();
            return collection.OrderBy(x => random.Next(int.MaxValue));
        }
        
        /// <summary>
        /// Shuffles the collection where every item is mapped with the selector method.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <param name="selector">The map method.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <typeparam name="TOutput">The output value type.</typeparam>
        /// <returns>The shuffled collection.</returns>
        public static IEnumerable<TOutput> ShuffleSelected<T, TOutput>(this IEnumerable<T> collection, Func<T, TOutput> selector)
        {
            if (selector == null)
                throw new ArgumentNullException("selector");
            if (collection == null)
                throw new ArgumentNullException("collection");

            Random random = new Random();
            return collection.Select(x => selector(x)).OrderBy(x => random.Next(int.MaxValue));
        }
        
        /// <summary>
        /// Shuffles the collection where every item is mapped with the selector method.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <param name="selector">The map method.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <typeparam name="TOutput">The output value type.</typeparam>
        /// <returns>The shuffled collection or the empty collection if the input collection was null.</returns>
        public static IEnumerable<TOutput> ShuffleSelectedOrEmpty<T, TOutput>(this IEnumerable<T> collection, Func<T, TOutput> selector)
        {
            if (selector == null)
                throw new ArgumentNullException("selector");
            if (collection == null)
                return Enumerable.Empty<TOutput>();

            Random random = new Random();
            return collection.Select(x => selector(x)).OrderBy(x => random.Next(int.MaxValue));
        }
        
        /// <summary>
        /// Prints the collection with the specified delimiter.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <param name="delimiter">The delimiter.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <returns>The collection.</returns>
        public static IEnumerable<T> Print<T>(this IEnumerable<T> collection, string delimiter = DefaultDelimiter)
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
        /// Prints the collection with the specified delimiter and jumps onto the new line.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <param name="delimiter">The delimiter.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <returns>The collection.</returns>
        public static IEnumerable<T> PrintLine<T>(this IEnumerable<T> collection, string delimiter = DefaultDelimiter)
        {
            collection.Print(delimiter);
            Console.WriteLine();
            return collection;
        }

        /// <summary>
        /// Prints the collection so that each item places on separate string.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <returns>The collection.</returns>
        public static IEnumerable<T> PrintLines<T>(this IEnumerable<T> collection)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");
            
            foreach (T item in collection)
                Console.WriteLine(item);
            return collection;
        }
        
        /// <summary>
        /// Prints the collection with the specified delimiter.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <param name="selector">The map method.</param>
        /// <param name="delimiter">The delimiter.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <typeparam name="TOutput">The output type.</typeparam>
        /// <returns>The collection.</returns>
        public static IEnumerable<T> PrintBy<T, TOutput>(this IEnumerable<T> collection, Func<T, TOutput> selector, string delimiter = DefaultDelimiter)
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
        /// Prints the collection with the specified delimiter and jumps onto the new line.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <param name="selector">The map method.</param>
        /// <param name="delimiter">The delimiter.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <typeparam name="TOutput">The output type.</typeparam>
        /// <returns>The collection.</returns>
        public static IEnumerable<T> PrintLineBy<T, TOutput>(this IEnumerable<T> collection, Func<T, TOutput> selector, string delimiter = DefaultDelimiter)
        {
            collection.PrintBy(selector, delimiter);
            Console.WriteLine();
            return collection;
        }

        /// <summary>
        /// Prints the collection so that each item places on separate string.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <param name="selector">The map method.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <typeparam name="TOutput">The output type.</typeparam>
        /// <returns>The collection.</returns>
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
    }
}