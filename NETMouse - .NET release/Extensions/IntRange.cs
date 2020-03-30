using ABCNET.Utils;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ABCNET.Extensions
{
    /// <summary>
    /// Диапазон.
    /// </summary>
    public struct IntRange : IEnumerable<int>,
        IEquatable<IntRange>
    {
        /// <summary>
        /// Нижняя граница.
        /// </summary>
        public int Low { get; }

        /// <summary>
        /// Верхняя граница.
        /// </summary>
        public int High { get; }

        /// <summary>
        /// Конструктор для IntRange.
        /// </summary>
        /// <param name="low">Нижняя граница.</param>
        /// <param name="high">Верхняя граница.</param>
        public IntRange(int low, int high) : this()
        {
            if (low > high)
                Base.Swap(ref low, ref high);
            Low = low;
            High = high;
        }

        /// <summary>
        /// Сравниват два диапазона на равенство.
        /// </summary>
        /// <param name="other">Диапазон.</param>
        /// <returns>Результат сравнения.</returns>
        public bool Equals(IntRange other)
        {
            return (Low == other.Low) && (High == other.High);
        }

        /// <summary>
        /// Сравниват два диапазона на равенство.
        /// </summary>
        /// <param name="other">Диапазон.</param>
        /// <returns>Результат сравнения.</returns>
        public override bool Equals(object obj)
        {
            return obj is IntRange range && Equals(range);
        }

        /// <summary>
        /// Возвращает перечислитель диапазона.
        /// </summary>
        /// <returns>Перечислитель.</returns>
        public IEnumerator<int> GetEnumerator()
        {
            return Low.To(High).GetEnumerator();
        }

        /// <summary>
        /// Возвращает перечислитель диапазона.
        /// </summary>
        /// <returns>Перечислитель.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Возвращает хеш-код диапазона.
        /// </summary>
        /// <returns>Хеш-код.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 2082053542;
                hashCode = hashCode * -1521134295 + Low.GetHashCode();
                hashCode = hashCode * -1521134295 + High.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(IntRange left, IntRange right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(IntRange left, IntRange right)
        {
            return !(left == right);
        }
    }
}
