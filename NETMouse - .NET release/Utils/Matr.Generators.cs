using System;

namespace ABCNET.Utils
{
    /// <summary>
    /// ������������� ���������� ��� ������ � ���������.
    /// </summary>
    public static partial class Matr
    {
        #region public

        /// <summary>
        /// ������ ������� �� ��������� ��������.
        /// </summary>
        ///  <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <param name="values">��������.</param>
        /// <returns>�������.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matr.")]
        public static T[,] New<T>(int rowsCount, int colsCount, params T[] values)
        {
            if (values == null)
                throw new ArgumentNullException(nameof(values));
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));
            if (rowsCount * colsCount != values.Length)
                throw new ArgumentNullException(nameof(values));

            T[,] source = new T[rowsCount, colsCount];
            int k = 0;
            for (int i = 0; i < rowsCount; i++)
                for (int j = 0; j < colsCount; j++)
                {
                    source[i, j] = values[k];
                    k++;
                }

            return source;
        }

        /// <summary>
        /// ������ ������� �� ������ ������� ���������.
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <param name="selector">������� ��������.</param>
        /// <param name="rowFirstIndex">��������� ������ ������.</param>
        /// <param name="columnFirstIndex">��������� ������ �������.</param>
        /// <returns>�������.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matr.")]
        public static T[,] Gen<T>(int rowsCount, int colsCount, Func<int, int, T> selector, int rowFirstIndex = 0, int columnFirstIndex = 0)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));
            
            T[,] source = new T[rowsCount, colsCount];
            for (int i = 0; i < source.GetLength(0); i++)
                for (int j = 0; j < source.GetLength(1); j++)
                    source[i, j] = selector(i + rowFirstIndex, j + columnFirstIndex);

            return source;
        }

        /// <summary>
        /// ������ ������� ��������� ����� ���� Int32.
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>�������.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matr.")]
        public static int[,] Rand(int rowsCount, int colsCount, int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));
            if (low > high)
                throw new ArgumentException(nameof(low));

            int[,] source = new int[rowsCount, colsCount];
            for (int i = 0; i < source.GetLength(0); i++)
                for (int j = 0; j < source.GetLength(1); j++)
                    source[i, j] = Base.Rand(low, high);

            return source;
        }

        /// <summary>
        /// ������ ������� ��������� ����� ���� Double.
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>�������.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matr.")]
        public static double[,] Rand(int rowsCount, int colsCount, double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));
            if (low > high)
                throw new ArgumentException(nameof(low));

            double[,] source = new double[rowsCount, colsCount];
            for (int i = 0; i < source.GetLength(0); i++)
                for (int j = 0; j < source.GetLength(1); j++)
                    source[i, j] = Base.Rand(low, high);

            return source;
        }

        /// <summary>
        /// ������ �������, ����������� ��������� ���������.
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <param name="value">��������.</param>
        /// <returns>������.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Matr.")]
        public static T[,] Fill<T>(int rowsCount, int colsCount, T value)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));

            T[,] source = new T[rowsCount, colsCount];
            for (int i = 0; i < source.GetLength(0); i++)
                for (int j = 0; j < source.GetLength(1); j++)
                    source[i, j] = value;

            return source;
        }

        #endregion public
    }
}