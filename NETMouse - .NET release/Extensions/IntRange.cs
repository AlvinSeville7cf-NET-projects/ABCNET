using ABCNET.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public int Low
        {
            get => low;
            set
            {
                low = value;

                if (low > high)
                    Base.Swap(ref low, ref high);
            }
        }

        /// <summary>
        /// Верхняя граница.
        /// </summary>
        public int High
        {
            get => high;
            set
            {
                high = value;

                if (high < low)
                    Base.Swap(ref high, ref low);
            }
        }

        /// <summary>
        /// Конструктор для IntRange.
        /// </summary>
        /// <param name="low">Нижняя граница.</param>
        /// <param name="high">Верхняя граница.</param>
        public IntRange(int low, int high) : this()
        {
            this.low = low;
            High = high;
        }

        /// <summary>
        /// Сравниват два диапазона на равенство.
        /// </summary>
        /// <param name="other">Диапазон.</param>
        /// <returns>Результат сравнения.</returns>
        public bool Equals(IntRange other)
        {
            return (low == other.Low) && (high == other.High);
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
            return low.To(high).GetEnumerator();
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
                hashCode = hashCode * -1521134295 + low.GetHashCode();
                hashCode = hashCode * -1521134295 + high.GetHashCode();
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

        private int low;
        private int high;
    }
}
