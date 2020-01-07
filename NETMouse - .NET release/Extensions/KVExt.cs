using System;
using System.Collections.Generic;

namespace NETMouse.Extensions
{
    /// <summary>
    /// Предоставляет функционал для работы с KeyValuePair.
    /// </summary>
    public static class KVExt
    {
        /// <summary>
        /// Преобразует KeyValuePair в кортеж.
        /// </summary>
        /// <param name="pair">KeyValuePair.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<T, T1> ToTup<T, T1>(this KeyValuePair<T, T1> pair)
        {
            return new Tuple<T, T1>(pair.Key, pair.Value);
        }

        /// <summary>
        /// Выводит значение типа KeyValuePair.
        /// </summary>
        /// <param name="pair">KeyValuePair.</param>
        /// <returns>Значение.</returns>
        public static KeyValuePair<T, T1> Print<T, T1>(this KeyValuePair<T, T1> pair)
        {
            Console.Write(pair);
            return pair;
        }

        /// <summary>
        /// Выводит значение типа KeyValuePair и переходит на новую строку.
        /// </summary>
        /// <param name="pair">KeyValuePair.</param>
        /// <returns>Значение.</returns>
        public static KeyValuePair<T, T1> Println<T, T1>(this KeyValuePair<T, T1> pair)
        {
            Console.WriteLine(pair);
            return pair;
        }
    }
}