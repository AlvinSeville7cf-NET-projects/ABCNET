using System;
using System.Collections.Generic;

namespace ABCNET.Utils
{
    /// <summary>
    /// ������������� ���������� ��� ������ � ��������������������.
    /// </summary>
    public static partial class Seq
    {
        #region public

        /// <summary>
        /// ������ ������������������ �� ������ ������� ���������.
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="selector">������� ��������.</param>
        /// <param name="firstIndex">��������� ������.</param>
        /// <returns>������������������.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Sequence.")]
        public static IEnumerable<T> Gen<T>(int count, Func<int, T> selector, int firstIndex = 0)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

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
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Sequence.")]
        public static IEnumerable<int> Rand(int count, int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (low > high)
                throw new ArgumentException(nameof(low));

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
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Sequence.")]
        public static IEnumerable<double> Rand(int count, double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (low > high)
                throw new ArgumentException(nameof(low));

            for (int i = 0; i < count; i++)
                yield return Base.Rand(low, high);
        }

        /// <summary>
        /// ������ ������������������, ����������� ��������� ���������.
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="value">��������.</param>
        /// <returns>������������������.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Sequence.")]
        public static IEnumerable<T> Fill<T>(int count, T value)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            for (int i = 0; i < count; i++)
                yield return value;
        }

        #endregion public
    }
}