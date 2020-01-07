using System;
using System.Collections.Generic;

namespace NETMouse.Extensions
{
    /// <summary>
    /// Provides standart extensions for tuples.
    /// </summary>
    public static class TuplesExtensions
    {
        /// <summary>
        /// Converts the tuple into the key-value pair.
        /// </summary>
        /// <param name="tuple">The tuple.</param>
        /// <typeparam name="T">The first type.</typeparam>
        /// <typeparam name="T1">The second type.</typeparam>
        /// <returns>The key-value pair.</returns>
        public static KeyValuePair<T, T1> ToKeyValuePair<T, T1>(this Tuple<T, T1> tuple)
        {
            return new KeyValuePair<T, T1>(tuple.Item1, tuple.Item2);
        }
        
        /// <summary>
        /// Adds the particular item to the tuple.
        /// </summary>
        /// <param name="tuple">The tuple.</param>
        /// <param name="item">The item.</param>
        /// <typeparam name="T">The first type.</typeparam>
        /// <typeparam name="T1">The second type.</typeparam>
        /// <typeparam name="T2">The third type.</typeparam>
        /// <returns>The new tuple that consists of the previous tuple elements and new one.</returns>
        public static Tuple<T, T1, T2> Add<T, T1, T2>(this Tuple<T, T1> tuple, T2 item)
        {
            return new Tuple<T, T1, T2>(tuple.Item1, tuple.Item2, item);
        }

        /// <summary>
        /// Adds the particular item to the tuple.
        /// </summary>
        /// <param name="tuple">The tuple.</param>
        /// <param name="item">The item.</param>
        /// <typeparam name="T">The first type.</typeparam>
        /// <typeparam name="T1">The second type.</typeparam>
        /// <typeparam name="T2">The third type.</typeparam>
        /// <returns>The new tuple that consists of the previous tuple elements and new one.</returns>
        public static Tuple<T2, T, T1> AddFirst<T, T1, T2>(this Tuple<T, T1> tuple, T2 item)
        {
            return new Tuple<T2, T, T1>(item, tuple.Item1, tuple.Item2);
        }
        
        /// <summary>
        /// Adds the particular item to the tuple.
        /// </summary>
        /// <param name="tuple">The tuple.</param>
        /// <param name="item">The item.</param>
        /// <typeparam name="T">The first type.</typeparam>
        /// <typeparam name="T1">The second type.</typeparam>
        /// <typeparam name="T2">The third type.</typeparam>
        /// <typeparam name="T3">The fourth type.</typeparam>
        /// <returns>The new tuple that consists of the previous tuple elements and new one.</returns>
        public static Tuple<T, T1, T2, T3> Add<T, T1, T2, T3>(this Tuple<T, T1, T2> tuple, T3 item)
        {
            return new Tuple<T, T1, T2, T3>(tuple.Item1, tuple.Item2, tuple.Item3, item);
        }
        
        /// <summary>
        /// Adds the particular item to the tuple.
        /// </summary>
        /// <param name="tuple">The tuple.</param>
        /// <param name="item">The item.</param>
        /// <typeparam name="T">The first type.</typeparam>
        /// <typeparam name="T1">The second type.</typeparam>
        /// <typeparam name="T2">The third type.</typeparam>
        /// <typeparam name="T3">The fourth type.</typeparam>
        /// <returns>The new tuple that consists of the previous tuple elements and new one.</returns>
        public static Tuple<T3, T, T1, T2> AddFirst<T, T1, T2, T3>(this Tuple<T, T1, T2> tuple, T3 item)
        {
            return new Tuple<T3, T, T1, T2>(item, tuple.Item1, tuple.Item2, tuple.Item3);
        }
        
        /// <summary>
        /// Adds the particular item to the tuple.
        /// </summary>
        /// <param name="tuple">The tuple.</param>
        /// <param name="item">The item.</param>
        /// <typeparam name="T">The first type.</typeparam>
        /// <typeparam name="T1">The second type.</typeparam>
        /// <typeparam name="T2">The third type.</typeparam>
        /// <typeparam name="T3">The fourth type.</typeparam>
        /// <typeparam name="T4">The fifth type.</typeparam>
        /// <returns>The new tuple that consists of the previous tuple elements and new one.</returns>
        public static Tuple<T, T1, T2, T3, T4> Add<T, T1, T2, T3, T4>(this Tuple<T, T1, T2, T3> tuple, T4 item)
        {
            return new Tuple<T, T1, T2, T3, T4>(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, item);
        }
        
        /// <summary>
        /// Adds the particular item to the tuple.
        /// </summary>
        /// <param name="tuple">The tuple.</param>
        /// <param name="item">The item.</param>
        /// <typeparam name="T">The first type.</typeparam>
        /// <typeparam name="T1">The second type.</typeparam>
        /// <typeparam name="T2">The third type.</typeparam>
        /// <typeparam name="T3">The fourth type.</typeparam>
        /// <typeparam name="T4">The fifth type.</typeparam>
        /// <returns>The new tuple that consists of the previous tuple elements and new one.</returns>
        public static Tuple<T4, T, T1, T2, T3> AddFirst<T, T1, T2, T3, T4>(this Tuple<T, T1, T2, T3> tuple, T4 item)
        {
            return new Tuple<T4, T, T1, T2, T3>(item, tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4);
        }
        
        /// <summary>
        /// Adds the particular item to the tuple.
        /// </summary>
        /// <param name="tuple">The tuple.</param>
        /// <param name="item">The item.</param>
        /// <typeparam name="T">The first type.</typeparam>
        /// <typeparam name="T1">The second type.</typeparam>
        /// <typeparam name="T2">The third type.</typeparam>
        /// <typeparam name="T3">The fourth type.</typeparam>
        /// <typeparam name="T4">The fifth type.</typeparam>
        /// <typeparam name="T5">The sixth type.</typeparam>
        /// <returns>The new tuple that consists of the previous tuple elements and new one.</returns>
        public static Tuple<T, T1, T2, T3, T4, T5> Add<T, T1, T2, T3, T4, T5>(this Tuple<T, T1, T2, T3, T4> tuple, T5 item)
        {
            return new Tuple<T, T1, T2, T3, T4, T5>(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, item);
        }
        
        /// <summary>
        /// Adds the particular item to the tuple.
        /// </summary>
        /// <param name="tuple">The tuple.</param>
        /// <param name="item">The item.</param>
        /// <typeparam name="T">The first type.</typeparam>
        /// <typeparam name="T1">The second type.</typeparam>
        /// <typeparam name="T2">The third type.</typeparam>
        /// <typeparam name="T3">The fourth type.</typeparam>
        /// <typeparam name="T4">The fifth type.</typeparam>
        /// <typeparam name="T5">The sixth type.</typeparam>
        /// <returns>The new tuple that consists of the previous tuple elements and new one.</returns>
        public static Tuple<T5, T, T1, T2, T3, T4> AddFirst<T, T1, T2, T3, T4, T5>(this Tuple<T, T1, T2, T3, T4> tuple, T5 item)
        {
            return new Tuple<T5, T, T1, T2, T3, T4>(item, tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5);
        }
        
        /// <summary>
        /// Adds the particular item to the tuple.
        /// </summary>
        /// <param name="tuple">The tuple.</param>
        /// <param name="item">The item.</param>
        /// <typeparam name="T">The first type.</typeparam>
        /// <typeparam name="T1">The second type.</typeparam>
        /// <typeparam name="T2">The third type.</typeparam>
        /// <typeparam name="T3">The fourth type.</typeparam>
        /// <typeparam name="T4">The fifth type.</typeparam>
        /// <typeparam name="T5">The sixth type.</typeparam>
        /// <typeparam name="T6">The seventh type.</typeparam>
        /// <returns>The new tuple that consists of the previous tuple elements and new one.</returns>
        public static Tuple<T, T1, T2, T3, T4, T5, T6> Add<T, T1, T2, T3, T4, T5, T6>(this Tuple<T, T1, T2, T3, T4, T5> tuple, T6 item)
        {
            return new Tuple<T, T1, T2, T3, T4, T5, T6>(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, item);
        }
        
        /// <summary>
        /// Adds the particular item to the tuple.
        /// </summary>
        /// <param name="tuple">The tuple.</param>
        /// <param name="item">The item.</param>
        /// <typeparam name="T">The first type.</typeparam>
        /// <typeparam name="T1">The second type.</typeparam>
        /// <typeparam name="T2">The third type.</typeparam>
        /// <typeparam name="T3">The fourth type.</typeparam>
        /// <typeparam name="T4">The fifth type.</typeparam>
        /// <typeparam name="T5">The sixth type.</typeparam>
        /// <typeparam name="T6">The seventh type.</typeparam>
        /// <returns>The new tuple that consists of the previous tuple elements and new one.</returns>
        public static Tuple<T6, T, T1, T2, T3, T4, T5> AddFirst<T, T1, T2, T3, T4, T5, T6>(this Tuple<T, T1, T2, T3, T4, T5> tuple, T6 item)
        {
            return new Tuple<T6, T, T1, T2, T3, T4, T5>(item, tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6);
        }

        /// <summary>
        /// Prints the tuple.
        /// </summary>
        /// <param name="tuple">The tuple.</param>
        /// <typeparam name="T">The first type.</typeparam>
        /// <typeparam name="T1">The second type.</typeparam>
        /// <returns>The current tuple.</returns>
        public static Tuple<T, T1> Print<T, T1>(this Tuple<T, T1> tuple)
        {
            Console.Write(tuple);
            return tuple;
        }
        
        /// <summary>
        /// Prints the tuple and jumps onto the new line.
        /// </summary>
        /// <param name="tuple">The tuple.</param>
        /// <typeparam name="T">The first type.</typeparam>
        /// <typeparam name="T1">The second type.</typeparam>
        /// <returns>The current tuple.</returns>
        public static Tuple<T, T1> PrintLine<T, T1>(this Tuple<T, T1> tuple)
        {
            Console.WriteLine(tuple);
            return tuple;
        }
        
        /// <summary>
        /// Prints the tuple.
        /// </summary>
        /// <param name="tuple">The tuple.</param>
        /// <typeparam name="T">The first type.</typeparam>
        /// <typeparam name="T1">The second type.</typeparam>
        /// <typeparam name="T2">The third type.</typeparam>
        /// <returns>The current tuple.</returns>
        public static Tuple<T, T1, T2> Print<T, T1, T2>(this Tuple<T, T1, T2> tuple)
        {
            Console.Write(tuple);
            return tuple;
        }
        
        /// <summary>
        /// Prints the tuple and jumps onto the new line.
        /// </summary>
        /// <param name="tuple">The tuple.</param>
        /// <typeparam name="T">The first type.</typeparam>
        /// <typeparam name="T1">The second type.</typeparam>
        /// <typeparam name="T2">The third type.</typeparam>
        /// <returns>The current tuple.</returns>
        public static Tuple<T, T1, T2> PrintLine<T, T1, T2>(this Tuple<T, T1, T2> tuple)
        {
            Console.WriteLine(tuple);
            return tuple;
        }
        
        /// <summary>
        /// Prints the tuple.
        /// </summary>
        /// <param name="tuple">The tuple.</param>
        /// <typeparam name="T">The first type.</typeparam>
        /// <typeparam name="T1">The second type.</typeparam>
        /// <typeparam name="T2">The third type.</typeparam>
        /// <typeparam name="T3">The fourth type.</typeparam>
        /// <returns>The current tuple.</returns>
        public static Tuple<T, T1, T2, T3> Print<T, T1, T2, T3>(this Tuple<T, T1, T2, T3> tuple)
        {
            Console.Write(tuple);
            return tuple;
        }
        
        /// <summary>
        /// Prints the tuple and jumps onto the new line.
        /// </summary>
        /// <param name="tuple">The tuple.</param>
        /// <typeparam name="T">The first type.</typeparam>
        /// <typeparam name="T1">The second type.</typeparam>
        /// <typeparam name="T2">The third type.</typeparam>
        /// <typeparam name="T3">The fourth type.</typeparam>
        /// <returns>The current tuple.</returns>
        public static Tuple<T, T1, T2, T3> PrintLine<T, T1, T2, T3>(this Tuple<T, T1, T2, T3> tuple)
        {
            Console.WriteLine(tuple);
            return tuple;
        }
        
        /// <summary>
        /// Prints the tuple.
        /// </summary>
        /// <param name="tuple">The tuple.</param>
        /// <typeparam name="T">The first type.</typeparam>
        /// <typeparam name="T1">The second type.</typeparam>
        /// <typeparam name="T2">The third type.</typeparam>
        /// <typeparam name="T3">The fourth type.</typeparam>
        /// <typeparam name="T4">The fifth type.</typeparam>
        /// <returns>The current tuple.</returns>
        public static Tuple<T, T1, T2, T3, T4> Print<T, T1, T2, T3, T4>(this Tuple<T, T1, T2, T3, T4> tuple)
        {
            Console.Write(tuple);
            return tuple;
        }
        
        /// <summary>
        /// Prints the tuple and jumps onto the new line.
        /// </summary>
        /// <param name="tuple">The tuple.</param>
        /// <typeparam name="T">The first type.</typeparam>
        /// <typeparam name="T1">The second type.</typeparam>
        /// <typeparam name="T2">The third type.</typeparam>
        /// <typeparam name="T3">The fourth type.</typeparam>
        /// <typeparam name="T4">The fifth type.</typeparam>
        /// <returns>The current tuple.</returns>
        public static Tuple<T, T1, T2, T3, T4> PrintLine<T, T1, T2, T3, T4>(this Tuple<T, T1, T2, T3, T4> tuple)
        {
            Console.WriteLine(tuple);
            return tuple;
        }
        
        /// <summary>
        /// Prints the tuple.
        /// </summary>
        /// <param name="tuple">The tuple.</param>
        /// <typeparam name="T">The first type.</typeparam>
        /// <typeparam name="T1">The second type.</typeparam>
        /// <typeparam name="T2">The third type.</typeparam>
        /// <typeparam name="T3">The fourth type.</typeparam>
        /// <typeparam name="T4">The fifth type.</typeparam>
        /// <typeparam name="T5">The sixth type.</typeparam>
        /// <returns>The current tuple.</returns>
        public static Tuple<T, T1, T2, T3, T4, T5> Print<T, T1, T2, T3, T4, T5>(this Tuple<T, T1, T2, T3, T4, T5> tuple)
        {
            Console.Write(tuple);
            return tuple;
        }
        
        /// <summary>
        /// Prints the tuple and jumps onto the new line.
        /// </summary>
        /// <param name="tuple">The tuple.</param>
        /// <typeparam name="T">The first type.</typeparam>
        /// <typeparam name="T1">The second type.</typeparam>
        /// <typeparam name="T2">The third type.</typeparam>
        /// <typeparam name="T3">The fourth type.</typeparam>
        /// <typeparam name="T4">The fifth type.</typeparam>
        /// <typeparam name="T5">The sixth type.</typeparam>
        /// <returns>The current tuple.</returns>
        public static Tuple<T, T1, T2, T3, T4, T5> PrintLine<T, T1, T2, T3, T4, T5>(this Tuple<T, T1, T2, T3, T4, T5> tuple)
        {
            Console.WriteLine(tuple);
            return tuple;
        }
        
        /// <summary>
        /// Prints the tuple.
        /// </summary>
        /// <param name="tuple">The tuple.</param>
        /// <typeparam name="T">The first type.</typeparam>
        /// <typeparam name="T1">The second type.</typeparam>
        /// <typeparam name="T2">The third type.</typeparam>
        /// <typeparam name="T3">The fourth type.</typeparam>
        /// <typeparam name="T4">The fifth type.</typeparam>
        /// <typeparam name="T5">The sixth type.</typeparam>
        /// <typeparam name="T6">The seventh type.</typeparam>
        /// <returns>The current tuple.</returns>
        public static Tuple<T, T1, T2, T3, T4, T5, T6> Print<T, T1, T2, T3, T4, T5, T6>(this Tuple<T, T1, T2, T3, T4, T5, T6> tuple)
        {
            Console.Write(tuple);
            return tuple;
        }
        
        /// <summary>
        /// Prints the tuple and jumps onto the new line.
        /// </summary>
        /// <param name="tuple">The tuple.</param>
        /// <typeparam name="T">The first type.</typeparam>
        /// <typeparam name="T1">The second type.</typeparam>
        /// <typeparam name="T2">The third type.</typeparam>
        /// <typeparam name="T3">The fourth type.</typeparam>
        /// <typeparam name="T4">The fifth type.</typeparam>
        /// <typeparam name="T5">The sixth type.</typeparam>
        /// <typeparam name="T6">The seventh type.</typeparam>
        /// <returns>The current tuple.</returns>
        public static Tuple<T, T1, T2, T3, T4, T5, T6> PrintLine<T, T1, T2, T3, T4, T5, T6>(this Tuple<T, T1, T2, T3, T4, T5, T6> tuple)
        {
            Console.WriteLine(tuple);
            return tuple;
        }
    }
}