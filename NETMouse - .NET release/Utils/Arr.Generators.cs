using System;

namespace ABCNET.Utils
{
    /// <summary>
    /// ������������� ���������� ��� ������ � ���������.
    /// </summary>
    public static partial class Arr
    {
        #region public
        /// <summary>
        /// ������ ������ �� ��������� ��������.
        /// </summary>
        /// <param name="values">��������.</param>
        /// <returns>������.</returns>
        public static T[] New<T>(params T[] values)
        {
            if (values == null)
                throw new ArgumentNullException(nameof(values));

            return values;
        }

        /// <summary>
        /// ������ ������ �� ������ ������� ���������.
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="selector">������� ��������.</param>
        /// <param name="firstIndex">��������� ������.</param>
        /// <returns>������.</returns>
        public static T[] Gen<T>(int count, Func<int, T> selector, int firstIndex = 0)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));
            
            T[] source = new T[count];
            for (int i = 0; i < source.Length; i++)
                source[i] = selector(i + firstIndex);

            return source;
        }

        /// <summary>
        /// ������ ������ �� ������ ������� ���������.
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="first">������ �������.</param>
        /// <param name="next">������� ��������� ���������� ��������.</param>
        /// <returns>������.</returns>
        public static T[] Gen<T>(int count, T first, Func<T, T> next)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (next == null)
                throw new ArgumentNullException(nameof(next));
            
            T[] source = new T[count];
            source[0] = first;
            for (int i = 1; i < source.Length; i++)
                source[i] = next(source[i - 1]);

            return source;
        }

        /// <summary>
        /// ������ ������ ��������� ����� ���� Int32.
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        public static int[] Rand(int count, int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (low > high)
                throw new ArgumentException(nameof(low));

            int[] source = new int[count];
            for (int i = 0; i < source.Length; i++)
                source[i] = Base.Rand(low, high);

            return source;
        }

        /// <summary>
        /// ������ ������ ��������� ����� ���� Double.
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        public static double[] Rand(int count, double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (low > high)
                throw new ArgumentException(nameof(low));

            double[] source = new double[count];
            for (int i = 0; i < source.Length; i++)
                source[i] = Base.Rand(low, high);

            return source;
        }

        /// <summary>
        /// ������ ������, ����������� ��������� ���������.
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="value">��������.</param>
        /// <returns>������.</returns>
        public static T[] Fill<T>(int count, T value)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            T[] source = new T[count];
            for (int i = 0; i < source.Length; i++)
                source[i] = value;

            return source;
        }
        #endregion public
    }
}