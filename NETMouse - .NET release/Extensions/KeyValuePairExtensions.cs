using System;
using System.Collections.Generic;

namespace NETMouse.Extensions
{
    /// <summary>
    /// Provides standart extensions for key-value pairs.
    /// </summary>
    public static class KeyValuePairExtensions
    {
        /// <summary>
        /// Converts the key-value pair into the tuple.
        /// </summary>
        /// <param name="pair">The key-value pair.</param>
        /// <typeparam name="T">The key type.</typeparam>
        /// <typeparam name="T1">The value type.</typeparam>
        /// <returns>The tuple.</returns>
        public static Tuple<T, T1> ToTuple<T, T1>(this KeyValuePair<T, T1> pair)
        {
            return new Tuple<T, T1>(pair.Key, pair.Value);
        }
        
        /// <summary>
        /// Prints the key-value pair.
        /// </summary>
        /// <param name="pair">The key-value pair.</param>
        /// <typeparam name="T">The first type.</typeparam>
        /// <typeparam name="T1">The second type.</typeparam>
        /// <returns>The current key-value pair.</returns>
        public static KeyValuePair<T, T1> Print<T, T1>(this KeyValuePair<T, T1> pair)
        {
            Console.Write(pair);
            return pair;
        }
        
        /// <summary>
        /// Prints the key-value pair and jumps onto the new line.
        /// </summary>
        /// <param name="pair">The key-value pair.</param>
        /// <typeparam name="T">The first type.</typeparam>
        /// <typeparam name="T1">The second type.</typeparam>
        /// <returns>The current key-value pair.</returns>
        public static KeyValuePair<T, T1> PrintLine<T, T1>(this KeyValuePair<T, T1> pair)
        {
            Console.WriteLine(pair);
            return pair;
        }
    }
}