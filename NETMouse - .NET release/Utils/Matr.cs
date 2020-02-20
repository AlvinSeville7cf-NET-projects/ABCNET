using System;

namespace ABCNET.Utils
{
    /// <summary>
    /// ������������� ���������� ��� ������ � ���������.
    /// </summary>
    public static class Matr
    {

        #region Read2

        /// <summary>
        /// ��������� 2 ������� ���������� ���� Bool. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">���������� �����.</param>
        /// <param name="cols">���������� ��������.</param>
        public static Tuple<bool[,], bool[,]> ReadBool2(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols));
        }

        /// <summary>
        /// ��������� 2 ������� ���������� ���� Char. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">���������� �����.</param>
        /// <param name="cols">���������� ��������.</param>
        public static Tuple<char[,], char[,]> ReadChar2(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols));
        }

        /// <summary>
        /// ��������� 2 ������� ���������� ���� Integer. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">���������� �����.</param>
        /// <param name="cols">���������� ��������.</param>
        public static Tuple<int[,], int[,]> ReadInteger2(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols));
        }

        /// <summary>
        /// ��������� 2 ������� ���������� ���� Real. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">���������� �����.</param>
        /// <param name="cols">���������� ��������.</param>
        public static Tuple<double[,], double[,]> ReadReal2(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols));
        }

        /// <summary>
        /// ��������� 2 ������� ���������� ���� String. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">���������� �����.</param>
        /// <param name="cols">���������� ��������.</param>
        public static Tuple<string[,], string[,]> ReadString2(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadString(rows, cols), Matr.ReadString(rows, cols));
        }

        #endregion

        #region Read3

        /// <summary>
        /// ��������� 3 ������� ���������� ���� Bool. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">���������� �����.</param>
        /// <param name="cols">���������� ��������.</param>
        public static Tuple<bool[,], bool[,], bool[,]> ReadBool3(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols));
        }

        /// <summary>
        /// ��������� 3 ������� ���������� ���� Char. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">���������� �����.</param>
        /// <param name="cols">���������� ��������.</param>
        public static Tuple<char[,], char[,], char[,]> ReadChar3(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols));
        }

        /// <summary>
        /// ��������� 3 ������� ���������� ���� Integer. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">���������� �����.</param>
        /// <param name="cols">���������� ��������.</param>
        public static Tuple<int[,], int[,], int[,]> ReadInteger3(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols));
        }

        /// <summary>
        /// ��������� 3 ������� ���������� ���� Real. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">���������� �����.</param>
        /// <param name="cols">���������� ��������.</param>
        public static Tuple<double[,], double[,], double[,]> ReadReal3(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols));
        }

        /// <summary>
        /// ��������� 3 ������� ���������� ���� String. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">���������� �����.</param>
        /// <param name="cols">���������� ��������.</param>
        public static Tuple<string[,], string[,], string[,]> ReadString3(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadString(rows, cols), Matr.ReadString(rows, cols), Matr.ReadString(rows, cols));
        }

        #endregion

        #region Read4

        /// <summary>
        /// ��������� 4 ������� ���������� ���� Bool. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">���������� �����.</param>
        /// <param name="cols">���������� ��������.</param>
        public static Tuple<bool[,], bool[,], bool[,], bool[,]> ReadBool4(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols));
        }

        /// <summary>
        /// ��������� 4 ������� ���������� ���� Char. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">���������� �����.</param>
        /// <param name="cols">���������� ��������.</param>
        public static Tuple<char[,], char[,], char[,], char[,]> ReadChar4(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols));
        }

        /// <summary>
        /// ��������� 4 ������� ���������� ���� Integer. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">���������� �����.</param>
        /// <param name="cols">���������� ��������.</param>
        public static Tuple<int[,], int[,], int[,], int[,]> ReadInteger4(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols));
        }

        /// <summary>
        /// ��������� 4 ������� ���������� ���� Real. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">���������� �����.</param>
        /// <param name="cols">���������� ��������.</param>
        public static Tuple<double[,], double[,], double[,], double[,]> ReadReal4(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols));
        }

        /// <summary>
        /// ��������� 4 ������� ���������� ���� String. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">���������� �����.</param>
        /// <param name="cols">���������� ��������.</param>
        public static Tuple<string[,], string[,], string[,], string[,]> ReadString4(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadString(rows, cols), Matr.ReadString(rows, cols), Matr.ReadString(rows, cols), Matr.ReadString(rows, cols));
        }

        #endregion

        #region Read5

        /// <summary>
        /// ��������� 5 ������� ���������� ���� Bool. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">���������� �����.</param>
        /// <param name="cols">���������� ��������.</param>
        public static Tuple<bool[,], bool[,], bool[,], bool[,], bool[,]> ReadBool5(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols));
        }

        /// <summary>
        /// ��������� 5 ������� ���������� ���� Char. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">���������� �����.</param>
        /// <param name="cols">���������� ��������.</param>
        public static Tuple<char[,], char[,], char[,], char[,], char[,]> ReadChar5(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols));
        }

        /// <summary>
        /// ��������� 5 ������� ���������� ���� Integer. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">���������� �����.</param>
        /// <param name="cols">���������� ��������.</param>
        public static Tuple<int[,], int[,], int[,], int[,], int[,]> ReadInteger5(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols));
        }

        /// <summary>
        /// ��������� 5 ������� ���������� ���� Real. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">���������� �����.</param>
        /// <param name="cols">���������� ��������.</param>
        public static Tuple<double[,], double[,], double[,], double[,], double[,]> ReadReal5(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols));
        }

        /// <summary>
        /// ��������� 5 ������� ���������� ���� String. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">���������� �����.</param>
        /// <param name="cols">���������� ��������.</param>
        public static Tuple<string[,], string[,], string[,], string[,], string[,]> ReadString5(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadString(rows, cols), Matr.ReadString(rows, cols), Matr.ReadString(rows, cols), Matr.ReadString(rows, cols), Matr.ReadString(rows, cols));
        }

        #endregion

        #region Read6

        /// <summary>
        /// ��������� 6 ������� ���������� ���� Bool. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">���������� �����.</param>
        /// <param name="cols">���������� ��������.</param>
        public static Tuple<bool[,], bool[,], bool[,], bool[,], bool[,], bool[,]> ReadBool6(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols));
        }

        /// <summary>
        /// ��������� 6 ������� ���������� ���� Char. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">���������� �����.</param>
        /// <param name="cols">���������� ��������.</param>
        public static Tuple<char[,], char[,], char[,], char[,], char[,], char[,]> ReadChar6(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols));
        }

        /// <summary>
        /// ��������� 6 ������� ���������� ���� Integer. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">���������� �����.</param>
        /// <param name="cols">���������� ��������.</param>
        public static Tuple<int[,], int[,], int[,], int[,], int[,], int[,]> ReadInteger6(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols));
        }

        /// <summary>
        /// ��������� 6 ������� ���������� ���� Real. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">���������� �����.</param>
        /// <param name="cols">���������� ��������.</param>
        public static Tuple<double[,], double[,], double[,], double[,], double[,], double[,]> ReadReal6(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols));
        }

        /// <summary>
        /// ��������� 6 ������� ���������� ���� String. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">���������� �����.</param>
        /// <param name="cols">���������� ��������.</param>
        public static Tuple<string[,], string[,], string[,], string[,], string[,], string[,]> ReadString6(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadString(rows, cols), Matr.ReadString(rows, cols), Matr.ReadString(rows, cols), Matr.ReadString(rows, cols), Matr.ReadString(rows, cols), Matr.ReadString(rows, cols));
        }

        #endregion

        #region Read7

        /// <summary>
        /// ��������� 6 ������� ���������� ���� Bool. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">���������� �����.</param>
        /// <param name="cols">���������� ��������.</param>
        public static Tuple<bool[,], bool[,], bool[,], bool[,], bool[,], bool[,], bool[,]> ReadBool7(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols), Matr.ReadBoolean(rows, cols));
        }

        /// <summary>
        /// ��������� 7 ������� ���������� ���� Char. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">���������� �����.</param>
        /// <param name="cols">���������� ��������.</param>
        public static Tuple<char[,], char[,], char[,], char[,], char[,], char[,], char[,]> ReadChar7(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols), Matr.ReadChar(rows, cols));
        }

        /// <summary>
        /// ��������� 7 ������� ���������� ���� Integer. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">���������� �����.</param>
        /// <param name="cols">���������� ��������.</param>
        public static Tuple<int[,], int[,], int[,], int[,], int[,], int[,], int[,]> ReadInteger7(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols), Matr.ReadInteger(rows, cols));
        }

        /// <summary>
        /// ��������� 7 ������� ���������� ���� Real. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">���������� �����.</param>
        /// <param name="cols">���������� ��������.</param>
        public static Tuple<double[,], double[,], double[,], double[,], double[,], double[,], double[,]> ReadReal7(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols), Matr.ReadReal(rows, cols));
        }

        /// <summary>
        /// ��������� 2 ������� ���������� ���� String. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rows">���������� �����.</param>
        /// <param name="cols">���������� ��������.</param>
        public static Tuple<string[,], string[,], string[,], string[,], string[,], string[,], string[,]> ReadString7(int rows, int cols)
        {
            return Tuple.Create(Matr.ReadString(rows, cols), Matr.ReadString(rows, cols), Matr.ReadString(rows, cols), Matr.ReadString(rows, cols), Matr.ReadString(rows, cols), Matr.ReadString(rows, cols), Matr.ReadString(rows, cols));
        }

        #endregion

        /// <summary>
        /// ������ ������� �� ��������� ��������.
        /// </summary>
        ///  <param name="rowsCount">���������� �����.</param>
        /// <param name="columnsCount">���������� ��������.</param>
        /// <param name="values">��������.</param>
        /// <returns>�������.</returns>
        public static T[,] New<T>(int rowsCount, int columnsCount, params T[] values)
        {
            if (values == null)
                throw new ArgumentNullException(nameof(values));
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (columnsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(columnsCount));
            if (rowsCount * columnsCount != values.Length)
                throw new ArgumentNullException(nameof(values));

            T[,] source = new T[rowsCount, columnsCount];
            int k = 0;
            for (int i = 0; i < rowsCount; i++)
                for (int j = 0; j < columnsCount; j++)
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
        /// <param name="columnsCount">���������� ��������.</param>
        /// <param name="selector">������� ��������.</param>
        /// <param name="rowFirstIndex">��������� ������ ������.</param>
        /// <param name="columnFirstIndex">��������� ������ �������.</param>
        /// <returns>�������.</returns>
        public static T[,] Gen<T>(int rowsCount, int columnsCount, Func<int, int, T> selector, int rowFirstIndex = 0, int columnFirstIndex = 0)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (columnsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(columnsCount));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));
            
            T[,] source = new T[rowsCount, columnsCount];
            for (int i = 0; i < source.GetLength(0); i++)
                for (int j = 0; j < source.GetLength(1); j++)
                    source[i, j] = selector(i + rowFirstIndex, j + columnFirstIndex);

            return source;
        }

        /// <summary>
        /// ������ ������� ��������� ����� ���� Integer.
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="columnsCount">���������� ��������.</param>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>�������.</returns>
        public static int[,] Rand(int rowsCount, int columnsCount, int low = IntegerBordersHelper.Low, int high = IntegerBordersHelper.High)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (columnsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(columnsCount));
            if (low > high)
                throw new ArgumentException(nameof(low));

            int[,] source = new int[rowsCount, columnsCount];
            for (int i = 0; i < source.GetLength(0); i++)
                for (int j = 0; j < source.GetLength(1); j++)
                    source[i, j] = Base.Rand(low, high);

            return source;
        }

        /// <summary>
        /// ������ ������� ��������� ����� ���� Real.
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="columnsCount">���������� ��������.</param>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>�������.</returns>
        public static double[,] Rand(int rowsCount, int columnsCount, double low = RealBordersHelper.Low, double high = RealBordersHelper.High)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (columnsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(columnsCount));
            if (low > high)
                throw new ArgumentException(nameof(low));

            double[,] source = new double[rowsCount, columnsCount];
            for (int i = 0; i < source.GetLength(0); i++)
                for (int j = 0; j < source.GetLength(1); j++)
                    source[i, j] = Base.Rand(low, high);

            return source;
        }

        /// <summary>
        /// ������ �������, ����������� ��������� ���������.
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="columnsCount">���������� ��������.</param>
        /// <param name="value">��������.</param>
        /// <returns>������.</returns>
        public static T[,] Fill<T>(int rowsCount, int columnsCount, T value)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (columnsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(columnsCount));

            T[,] source = new T[rowsCount, columnsCount];
            for (int i = 0; i < source.GetLength(0); i++)
                for (int j = 0; j < source.GetLength(1); j++)
                    source[i, j] = value;

            return source;
        }

        /// <summary>
        /// ������ ������� �������� ���� Boolean. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET].
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="columnsCount">���������� ��������.</param>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>�������.</returns>
        public static bool[,] ReadBoolean(int rowsCount, int columnsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (columnsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(columnsCount));

            bool[,] source = new bool[rowsCount, columnsCount];
            int i = 0;
            int j = 0;

            while (i < rowsCount)
            {
                while (j < columnsCount)
                    try
                    {
                        source[i, j] = Base.ReadBoolean(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
                        j++;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(InputErrorHelper.Message);
                    }

                i++;
                j = 0;
            }

            return source;
        }

        /// <summary>
        /// ������ ������� �������� ���� Char. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET].
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="columnsCount">���������� ��������.</param>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>�������.</returns>
        public static char[,] ReadChar(int rowsCount, int columnsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (columnsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(columnsCount));

            char[,] source = new char[rowsCount, columnsCount];
            for (int i = 0; i < rowsCount; i++)
                for (int j = 0; j < columnsCount; j++)
                    source[i, j] = Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));

            return source;
        }

        /// <summary>
        /// ������ ������� �������� ���� Real. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET].
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="columnsCount">���������� ��������.</param>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>�������.</returns>
        public static double[,] ReadReal(int rowsCount, int columnsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (columnsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(columnsCount));

            double[,] source = new double[rowsCount, columnsCount];
            int i = 0;
            int j = 0;

            while (i < rowsCount)
            {
                while (j < columnsCount)
                    try
                    {
                        source[i, j] = Base.ReadReal(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
                        j++;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(InputErrorHelper.Message);
                    }

                i++;
                j = 0;
            }

            return source;
        }

        /// <summary>
        /// ������ ������� �������� ���� Integer. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET].
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="columnsCount">���������� ��������.</param>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>�������.</returns>
        public static int[,] ReadInteger(int rowsCount, int columnsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (columnsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(columnsCount));

            int[,] source = new int[rowsCount, columnsCount];
            int i = 0;
            int j = 0;

            while (i < rowsCount)
            {
                while (j < columnsCount)
                    try
                    {
                        source[i, j] = Base.ReadInteger(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
                        j++;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(InputErrorHelper.Message);
                    }

                i++;
                j = 0;
            }

            return source;
        }

        /// <summary>
        /// ������ ������� �������� ���� String. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET].
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="columnsCount">���������� ��������.</param>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>�������.</returns>
        public static string[,] ReadString(int rowsCount, int columnsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (columnsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(columnsCount));

            string[,] source = new string[rowsCount, columnsCount];
            for (int i = 0; i < rowsCount; i++)
                for (int j = 0; j < columnsCount; j++)
                    source[i, j] = Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));

            return source;
        }
    }
}