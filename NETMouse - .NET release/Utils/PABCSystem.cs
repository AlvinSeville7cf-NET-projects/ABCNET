using System;
using System.Collections.Generic;
using System.Linq;

namespace ABCNET.Utils
{
    /// <summary>
    /// Добавлен ради совместимости с PABCSystem.
    /// </summary>
    [Obsolete(ObsoleteMessageHelper.Message)]
    public static class PABCSystem
    {
        /// <summary>
        /// Возвращает словарь пар элементов (ключ, значение).
        /// </summary>
        [Obsolete(ObsoleteMessageHelper.Message)]
        public static Dictionary<TKey, TValue> Dict<TKey, TValue>(params KeyValuePair<TKey, TValue>[] pairs)
        {
            if (pairs == null)
                throw new ArgumentNullException("pairs");

            Dictionary<TKey, TValue> d = new Dictionary<TKey, TValue>();
            foreach (var item in pairs)
                d.Add(item.Key, item.Value);

            return d;
        }

        /// <summary>
        /// Возвращает словарь пар элементов (ключ, значение).
        /// </summary>
        [Obsolete(ObsoleteMessageHelper.Message)]
        public static Dictionary<TKey, TValue> Dict<TKey, TValue>(params Tuple<TKey, TValue>[] pairs)
        {
            if (pairs == null)
                throw new ArgumentNullException("pairs");

            Dictionary<TKey, TValue> d = new Dictionary<TKey, TValue>();
            foreach (var item in pairs)
                d.Add(item.Item1, item.Item2);

            return d;
        }

        /// <summary>
        ///  Возвращает множество на базе хеш таблицы, заполненное указанными значениями.
        /// </summary>
        [Obsolete(ObsoleteMessageHelper.Message)]
        public static HashSet<T> HSet<T>(params T[] values)
        {
            if (values == null)
                throw new ArgumentNullException("values");

            return new HashSet<T>(values);
        }

        /// <summary>
        /// Возвращает множество на базе хеш таблицы, заполненное значениями из последовательности.
        /// </summary>
        [Obsolete(ObsoleteMessageHelper.Message)]
        public static HashSet<T> HSet<T>(IEnumerable<T> values)
        {
            if (values == null)
                throw new ArgumentNullException("values");

            return new HashSet<T>(values);
        }

        /// <summary>
        /// Возвращает пару элементов (ключ, значение).
        /// </summary>
        [Obsolete(ObsoleteMessageHelper.Message)]
        public static KeyValuePair<TKey, TValue> KV<TKey, TValue>(TKey key, TValue value)
        {
            return new KeyValuePair<TKey, TValue>(key, value);
        }

        /// <summary>
        /// Возвращает двусвязный список, заполненный указанными значениями.
        /// </summary>
        [Obsolete(ObsoleteMessageHelper.Message)]
        public static LinkedList<T> LLst<T>(params T[] values)
        {
            if (values == null)
                throw new ArgumentNullException("values");

            return new LinkedList<T>(values);
        }

        /// <summary>
        /// Возвращает двусвязный список, заполненный значениями из последовательности.
        /// </summary>
        [Obsolete(ObsoleteMessageHelper.Message)]
        public static LinkedList<T> LLst<T>(IEnumerable<T> values)
        {
            if (values == null)
                throw new ArgumentNullException("values");

            return new LinkedList<T>(values);
        }

        /// <summary>
        /// Возвращает список, заполненный указанными значениями.
        /// </summary>
        [Obsolete(ObsoleteMessageHelper.Message)]
        public static List<T> Lst<T>(params T[] values)
        {
            if (values == null)
                throw new ArgumentNullException("values");

            return new List<T>(values);
        }

        /// <summary>
        /// Возвращает список, заполненный значениями из последовательности.
        /// </summary>
        [Obsolete(ObsoleteMessageHelper.Message)]
        public static List<T> Lst<T>(IEnumerable<T> values)
        {
            if (values == null)
                throw new ArgumentNullException("values");

            return new List<T>(values);
        }

        /// <summary>
        /// Возвращает множество на базе бинарного дерева поиска, заполненное указанными значениями.
        /// </summary>
        [Obsolete(ObsoleteMessageHelper.Message)]
        public static SortedSet<T> SSet<T>(params T[] values)
        {
            if (values == null)
                throw new ArgumentNullException("values");

            return new SortedSet<T>(values);
        }

        /// <summary>
        /// Возвращает множество на базе бинарного дерева поиска, заполненное значениями из последовательности.
        /// </summary>
        [Obsolete(ObsoleteMessageHelper.Message)]
        public static SortedSet<T> SSet<T>(IEnumerable<T> values)
        {
            if (values == null)
                throw new ArgumentNullException("values");

            return new SortedSet<T>(values);
        }
    }
}
