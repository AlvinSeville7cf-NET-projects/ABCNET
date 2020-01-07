using NETMouse.Extensions;
using System;
using System.Collections.Generic;

namespace NETMouse.Utils
{
    /// <summary>
    /// ������������� ���������� ��� ������ � ��������������������.
    /// </summary>
    public static class Seq
    {
        /// <summary>
        /// ������ ������������������ �� ������ ������� ���������.
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="selector">������� ��������.</param>
        /// <param name="firstIndex">��������� ������.</param>
        /// <returns>������������������.</returns>
        public static IEnumerable<T> Gen<T>(int count, Func<int, T> selector, int firstIndex = 0)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if (selector == null)
                throw new ArgumentNullException("selector");

            for (int i = 0; i < count; i++)
                yield return selector(i + firstIndex);
        }

        /// <summary>
        /// ������ ������������������ ��������� ����� ���� Integer.
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������������������.</returns>
        public static IEnumerable<int> Rand(int count, int low = IntegerBordersHelper.Low, int high = IntegerBordersHelper.High)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if (low > high)
                throw new ArgumentException("low");

            for (int i = 0; i < count; i++)
                yield return Base.Rand(low, high);
        }

        /// <summary>
        /// ������ ������������������ ��������� ����� ���� Real.
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������������������.</returns>
        public static IEnumerable<double> Rand(int count, double low = RealBordersHelper.Low, double high = RealBordersHelper.High)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if (low > high)
                throw new ArgumentException("low");

            for (int i = 0; i < count; i++)
                yield return Base.Rand(low, high);
        }

        /// <summary>
        /// ������ ������������������, ����������� ��������� ���������.
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="value">��������.</param>
        /// <returns>������������������.</returns>
        public static IEnumerable<T> Fill<T>(int count, T value)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");

            for (int i = 0; i < count; i++)
                yield return value;
        }
    }
}