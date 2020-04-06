using System;
using System.Collections.Generic;

namespace ABCNET.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы с отсортированными списками.
    /// </summary>
    public static class SortedList
    {
        #region public

        /// <summary>
        /// Создаёт отсортированный список из указанных значений.
        /// </summary>
        /// <param name="values">Значения.</param>
        /// <returns>Отсортированный список.</returns>
        public static SortedList<TKey, TValue> Of<TKey, TValue>(params KeyValuePair<TKey, TValue>[] values)
        {
            if (values is null)
                throw new ArgumentNullException(nameof(values));

            SortedList<TKey, TValue> result = new SortedList<TKey, TValue>();
            foreach (var item in values)
                result.Add(item.Key, item.Value);

            return result;
        }

        /// <summary>
        /// Создаёт отсортированный список на основе функции селектора.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <param name="firstIndex">Начальный индекс.</param>
        /// <returns>Отсортированный список.</returns>
        public static SortedList<TKey, TValue> By<TKey, TValue>(int count, Func<int, KeyValuePair<TKey, TValue>> selector, int firstIndex = 0)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (selector is null)
                throw new ArgumentNullException(nameof(selector));

            SortedList<TKey, TValue> result = new SortedList<TKey, TValue>();
            for (int i = 0; i < count; i++)
            {
                KeyValuePair<TKey, TValue> keyValuePair = selector(i + firstIndex);
                result.Add(keyValuePair.Key, keyValuePair.Value);
            }

            return result;
        }

        /// <summary>
        /// Создаёт отсортированный список на основе функции селектора.
        /// </summary>
        /// <param name="count">Количество элементов.</param>
        /// <param name="first">Первый элемент.</param>
        /// <param name="next">Функция получения следующего элемента.</param>
        /// <returns>Отсортированный список.</returns>
        public static SortedList<TKey, TValue> By<TKey, TValue>(int count, KeyValuePair<TKey, TValue> first, Func<KeyValuePair<TKey, TValue>, KeyValuePair<TKey, TValue>> next)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (next is null)
                throw new ArgumentNullException(nameof(next));

            SortedList<TKey, TValue> result = new SortedList<TKey, TValue>
            {
                { first.Key, first.Value }
            };

            KeyValuePair<TKey, TValue> previous = first;
            for (int i = 1; i < count; i++)
            {
                KeyValuePair<TKey, TValue> keyValuePair = next(previous);
                result.Add(keyValuePair.Key, keyValuePair.Value);
                previous = keyValuePair;
            }

            return result;
        }

        #endregion public
    }
}
