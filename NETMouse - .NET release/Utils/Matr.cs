using System;

namespace ABCNET.Utils
{
    /// <summary>
    /// ������������� ���������� ��� ������ � ���������.
    /// </summary>
    public static class Matr
    {
        /// <summary>
        /// ������ ������� �� ��������� ��������.
        /// </summary>
        ///  <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <param name="values">��������.</param>
        /// <returns>�������.</returns>
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
        public static int[,] Rand(int rowsCount, int colsCount, int low = IntegerBordersHelper.Low, int high = IntegerBordersHelper.High)
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
        public static double[,] Rand(int rowsCount, int colsCount, double low = RealBordersHelper.Low, double high = RealBordersHelper.High)
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

        /// <summary>
        /// ������ ������� �������� ���� Boolean. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>�������.</returns>
        public static bool[,] ReadBoolean(int rowsCount, int colsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));

            bool[,] source = new bool[rowsCount, colsCount];
            int i = 0;
            int j = 0;

            while (i < rowsCount)
            {
                while (j < colsCount)
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
        /// ������ ������� �������� ���� Char. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>�������.</returns>
        public static char[,] ReadChar(int rowsCount, int colsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));

            char[,] source = new char[rowsCount, colsCount];
            for (int i = 0; i < rowsCount; i++)
                for (int j = 0; j < colsCount; j++)
                    source[i, j] = Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));

            return source;
        }

        /// <summary>
        /// ������ ������� �������� ���� Double. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>�������.</returns>
        public static double[,] ReadDouble(int rowsCount, int colsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));

            double[,] source = new double[rowsCount, colsCount];
            int i = 0;
            int j = 0;

            while (i < rowsCount)
            {
                while (j < colsCount)
                    try
                    {
                        source[i, j] = Base.ReadDouble(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
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
        /// ������ ������� �������� ���� Int32. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>�������.</returns>
        public static int[,] ReadInt32(int rowsCount, int colsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));

            int[,] source = new int[rowsCount, colsCount];
            int i = 0;
            int j = 0;

            while (i < rowsCount)
            {
                while (j < colsCount)
                    try
                    {
                        source[i, j] = Base.ReadInt32(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
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
        /// ������ ������� �������� ���� String. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>�������.</returns>
        public static string[,] ReadString(int rowsCount, int colsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));

            string[,] source = new string[rowsCount, colsCount];
            for (int i = 0; i < rowsCount; i++)
                for (int j = 0; j < colsCount; j++)
                    source[i, j] = Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));

            return source;
        }

        /// <summary>
        /// ��������� 2 ������� ���������� ���� Boolean. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<bool[,], bool[,]> ReadBooleanTup2(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount));
        }

        /// <summary>
        /// ��������� 2 ������� ���������� ���� Char. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<char[,], char[,]> ReadCharTup2(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount));
        }

        /// <summary>
        /// ��������� 2 ������� ���������� ���� Int32. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<int[,], int[,]> ReadInt32Tup2(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount));
        }

        /// <summary>
        /// ��������� 2 ������� ���������� ���� Double. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<double[,], double[,]> ReadDoubleTup2(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount));
        }

        /// <summary>
        /// ��������� 2 ������� ���������� ���� String. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<string[,], string[,]> ReadStringTup2(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount));
        }

        /// <summary>
        /// ��������� 3 ������� ���������� ���� Boolean. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<bool[,], bool[,], bool[,]> ReadBooleanTup3(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount));
        }

        /// <summary>
        /// ��������� 3 ������� ���������� ���� Char. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<char[,], char[,], char[,]> ReadCharTup3(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount));
        }

        /// <summary>
        /// ��������� 3 ������� ���������� ���� Int32. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<int[,], int[,], int[,]> ReadInt32Tup3(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount));
        }

        /// <summary>
        /// ��������� 3 ������� ���������� ���� Double. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<double[,], double[,], double[,]> ReadDoubleTup3(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount));
        }

        /// <summary>
        /// ��������� 3 ������� ���������� ���� String. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<string[,], string[,], string[,]> ReadStringTup3(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount));
        }

        /// <summary>
        /// ��������� 4 ������� ���������� ���� Boolean. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<bool[,], bool[,], bool[,], bool[,]> ReadBooleanTup4(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount));
        }

        /// <summary>
        /// ��������� 4 ������� ���������� ���� Char. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<char[,], char[,], char[,], char[,]> ReadCharTup4(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount));
        }

        /// <summary>
        /// ��������� 4 ������� ���������� ���� Int32. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<int[,], int[,], int[,], int[,]> ReadInt32Tup4(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount));
        }

        /// <summary>
        /// ��������� 4 ������� ���������� ���� Double. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<double[,], double[,], double[,], double[,]> ReadDoubleTup4(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount));
        }

        /// <summary>
        /// ��������� 4 ������� ���������� ���� String. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<string[,], string[,], string[,], string[,]> ReadStringTup4(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount));
        }

        /// <summary>
        /// ��������� 5 ������� ���������� ���� Boolean. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<bool[,], bool[,], bool[,], bool[,], bool[,]> ReadBooleanTup5(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount));
        }

        /// <summary>
        /// ��������� 5 ������� ���������� ���� Char. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<char[,], char[,], char[,], char[,], char[,]> ReadCharTup5(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount));
        }

        /// <summary>
        /// ��������� 5 ������� ���������� ���� Int32. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<int[,], int[,], int[,], int[,], int[,]> ReadInt32Tup5(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount));
        }

        /// <summary>
        /// ��������� 5 ������� ���������� ���� Double. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<double[,], double[,], double[,], double[,], double[,]> ReadDoubleTup5(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount));
        }

        /// <summary>
        /// ��������� 5 ������� ���������� ���� String. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<string[,], string[,], string[,], string[,], string[,]> ReadStringTup5(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount));
        }

        /// <summary>
        /// ��������� 6 ������� ���������� ���� Boolean. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<bool[,], bool[,], bool[,], bool[,], bool[,], bool[,]> ReadBooleanTup6(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount));
        }

        /// <summary>
        /// ��������� 6 ������� ���������� ���� Char. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<char[,], char[,], char[,], char[,], char[,], char[,]> ReadCharTup6(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount));
        }

        /// <summary>
        /// ��������� 6 ������� ���������� ���� Int32. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<int[,], int[,], int[,], int[,], int[,], int[,]> ReadInt32Tup6(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount));
        }

        /// <summary>
        /// ��������� 6 ������� ���������� ���� Double. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<double[,], double[,], double[,], double[,], double[,], double[,]> ReadDoubleTup6(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount));
        }

        /// <summary>
        /// ��������� 6 ������� ���������� ���� String. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<string[,], string[,], string[,], string[,], string[,], string[,]> ReadStringTup6(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount));
        }

        /// <summary>
        /// ��������� 6 ������� ���������� ���� Boolean. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<bool[,], bool[,], bool[,], bool[,], bool[,], bool[,], bool[,]> ReadBooleanTup7(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount));
        }

        /// <summary>
        /// ��������� 7 ������� ���������� ���� Char. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<char[,], char[,], char[,], char[,], char[,], char[,], char[,]> ReadCharTup7(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount));
        }

        /// <summary>
        /// ��������� 7 ������� ���������� ���� Int32. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<int[,], int[,], int[,], int[,], int[,], int[,], int[,]> ReadInt32Tup7(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount));
        }

        /// <summary>
        /// ��������� 7 ������� ���������� ���� Double. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<double[,], double[,], double[,], double[,], double[,], double[,], double[,]> ReadDoubleTup7(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount));
        }

        /// <summary>
        /// ��������� 2 ������� ���������� ���� String. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">���������� �����.</param>
        /// <param name="colsCount">���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<string[,], string[,], string[,], string[,], string[,], string[,], string[,]> ReadStringTup7(int rowsCount, int colsCount)
        {
            return Tuple.Create(ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount));
        }
    }
}