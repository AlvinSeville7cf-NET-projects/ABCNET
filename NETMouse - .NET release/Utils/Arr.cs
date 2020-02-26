using System;

namespace ABCNET.Utils
{
    /// <summary>
    /// ������������� ���������� ��� ������ � ���������.
    /// </summary>
    public static class Arr
    {
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

        /// <summary>
        /// ������ ������ �������� ���� Boolean. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>������.</returns>
        public static bool[] ReadBoolean(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            bool[] array = new bool[count];
            int i = 0;
            while (i < count)
                try
                {
                    array[i] = Base.ReadBoolean(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    Console.WriteLine(InputErrorHelper.Message);
                }

            return array;
        }

        /// <summary>
        /// ������ ������ �������� ���� Char. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>������.</returns>
        public static char[] ReadChar(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            char[] array = new char[count];
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));

            return array;
        }

        /// <summary>
        /// ������ ������ �������� ���� Double. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>������.</returns>
        public static double[] ReadDouble(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            double[] array = new double[count];
            int i = 0;
            while (i < count)
                try
                {
                    array[i] = Base.ReadDouble(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    Console.WriteLine(InputErrorHelper.Message);
                }

            return array;
        }

        /// <summary>
        /// ������ ������ �������� ���� Int32. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>������.</returns>
        public static int[] ReadInt32(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            int[] array = new int[count];
            int i = 0;
            while (i < count)
                try
                {
                    array[i] = Base.ReadInt32(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    Console.WriteLine(InputErrorHelper.Message);
                }

            return array;
        }

        /// <summary>
        /// ������ ������ �������� ���� String. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>������.</returns>
        public static string[] ReadString(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            string[] array = new string[count];
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
            return array;
        }

        /// <summary>
        /// ��������� 2 ������� ���������� ���� Boolean. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">������ �������.</param>
        /// <returns>������.</returns>
        public static Tuple<bool[], bool[]> ReadBooleanTup2(int count)
        {
            return Tuple.Create(ReadBoolean(count), ReadBoolean(count));
        }

        /// <summary>
        /// ��������� 2 ������� ���������� ���� Char. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">������ �������.</param>
        /// <returns>������.</returns>
        public static Tuple<char[], char[]> ReadCharTup2(int count)
        {
            return Tuple.Create(ReadChar(count), ReadChar(count));
        }

        /// <summary>
        /// ��������� 2 ������� ���������� ���� Int32. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">������ �������.</param>
        /// <returns>������.</returns>
        public static Tuple<int[], int[]> ReadInt32Tup2(int count)
        {
            return Tuple.Create(ReadInt32(count), ReadInt32(count));
        }

        /// <summary>
        /// ��������� 2 ������� ���������� ���� Double. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">������ �������.</param>
        /// <returns>������.</returns>
        public static Tuple<double[], double[]> ReadDoubleTup2(int count)
        {
            return Tuple.Create(ReadDouble(count), ReadDouble(count));
        }

        /// <summary>
        /// ��������� 2 ������� ���������� ���� String. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">������ �������.</param>
        /// <returns>������.</returns>
        public static Tuple<string[], string[]> ReadStringTup2(int count)
        {
            return Tuple.Create(ReadString(count), ReadString(count));
        }

        /// <summary>
        /// ��������� 3 ������� ���������� ���� Boolean. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">������ �������.</param>
        /// <returns>������.</returns>
        public static Tuple<bool[], bool[], bool[]> ReadBooleanTup3(int count)
        {
            return Tuple.Create(ReadBoolean(count), ReadBoolean(count), ReadBoolean(count));
        }

        /// <summary>
        /// ��������� 3 ������� ���������� ���� Char. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">������ �������.</param>
        /// <returns>������.</returns>
        public static Tuple<char[], char[], char[]> ReadCharTup3(int count)
        {
            return Tuple.Create(ReadChar(count), ReadChar(count), ReadChar(count));
        }

        /// <summary>
        /// ��������� 3 ������� ���������� ���� Int32. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">������ �������.</param>
        /// <returns>������.</returns>
        public static Tuple<int[], int[], int[]> ReadInt32Tup3(int count)
        {
            return Tuple.Create(ReadInt32(count), ReadInt32(count), ReadInt32(count));
        }

        /// <summary>
        /// ��������� 3 ������� ���������� ���� Double. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">������ �������.</param>
        /// <returns>������.</returns>
        public static Tuple<double[], double[], double[]> ReadDoubleTup3(int count)
        {
            return Tuple.Create(ReadDouble(count), ReadDouble(count), ReadDouble(count));
        }

        /// <summary>
        /// ��������� 3 ������� ���������� ���� String. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">������ �������.</param>
        /// <returns>������.</returns>
        public static Tuple<string[], string[], string[]> ReadStringTup3(int count)
        {
            return Tuple.Create(ReadString(count), ReadString(count), ReadString(count));
        }

        /// <summary>
        /// ��������� 4 ������� ���������� ���� Boolean. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">������ �������.</param>
        /// <returns>������.</returns>
        public static Tuple<bool[], bool[], bool[], bool[]> ReadBooleanTup4(int count)
        {
            return Tuple.Create(ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count));
        }

        /// <summary>
        /// ��������� 4 ������� ���������� ���� Char. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">������ �������.</param>
        /// <returns>������.</returns>
        public static Tuple<char[], char[], char[], char[]> ReadCharTup4(int count)
        {
            return Tuple.Create(ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count));
        }

        /// <summary>
        /// ��������� 4 ������� ���������� ���� Int32. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">������ �������.</param>
        /// <returns>������.</returns>
        public static Tuple<int[], int[], int[], int[]> ReadInt32Tup4(int count)
        {
            return Tuple.Create(ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count));
        }

        /// <summary>
        /// ��������� 4 ������� ���������� ���� Double. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">������ �������.</param>
        /// <returns>������.</returns>
        public static Tuple<double[], double[], double[], double[]> ReadDoubleTup4(int count)
        {
            return Tuple.Create(ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count));
        }

        /// <summary>
        /// ��������� 4 ������� ���������� ���� String. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">������ �������.</param>
        /// <returns>������.</returns>
        public static Tuple<string[], string[], string[], string[]> ReadStringTup4(int count)
        {
            return Tuple.Create(ReadString(count), ReadString(count), ReadString(count), ReadString(count));
        }

        /// <summary>
        /// ��������� 5 ������� ���������� ���� Boolean. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">������ �������.</param>
        /// <returns>������.</returns>
        public static Tuple<bool[], bool[], bool[], bool[], bool[]> ReadBooleanTup5(int count)
        {
            return Tuple.Create(ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count));
        }

        /// <summary>
        /// ��������� 5 ������� ���������� ���� Char. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">������ �������.</param>
        /// <returns>������.</returns>
        public static Tuple<char[], char[], char[], char[], char[]> ReadCharTup5(int count)
        {
            return Tuple.Create(ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count));
        }

        /// <summary>
        /// ��������� 5 ������� ���������� ���� Int32. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">������ �������.</param>
        /// <returns>������.</returns>
        public static Tuple<int[], int[], int[], int[], int[]> ReadInt32Tup5(int count)
        {
            return Tuple.Create(ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count));
        }

        /// <summary>
        /// ��������� 5 ������� ���������� ���� Double. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">������ �������.</param>
        /// <returns>������.</returns>
        public static Tuple<double[], double[], double[], double[], double[]> ReadDoubleTup5(int count)
        {
            return Tuple.Create(ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count));
        }

        /// <summary>
        /// ��������� 5 ������� ���������� ���� String. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">������ �������.</param>
        /// <returns>������.</returns>
        public static Tuple<string[], string[], string[], string[], string[]> ReadStringTup5(int count)
        {
            return Tuple.Create(ReadString(count), ReadString(count), ReadString(count), ReadString(count), ReadString(count));
        }

        /// <summary>
        /// ��������� 6 ������� ���������� ���� Boolean. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">������ �������.</param>
        /// <returns>������.</returns>
        public static Tuple<bool[], bool[], bool[], bool[], bool[], bool[]> ReadBooleanTup6(int count)
        {
            return Tuple.Create(ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count));
        }

        /// <summary>
        /// ��������� 6 ������� ���������� ���� Char. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">������ �������.</param>
        /// <returns>������.</returns>
        public static Tuple<char[], char[], char[], char[], char[], char[]> ReadCharTup6(int count)
        {
            return Tuple.Create(ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count));
        }

        /// <summary>
        /// ��������� 6 ������� ���������� ���� Int32. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">������ �������.</param>
        /// <returns>������.</returns>
        public static Tuple<int[], int[], int[], int[], int[], int[]> ReadInt32Tup6(int count)
        {
            return Tuple.Create(ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count));
        }

        /// <summary>
        /// ��������� 6 ������� ���������� ���� Double. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">������ �������.</param>
        /// <returns>������.</returns>
        public static Tuple<double[], double[], double[], double[], double[], double[]> ReadDoubleTup6(int count)
        {
            return Tuple.Create(ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count));
        }

        /// <summary>
        /// ��������� 6 ������� ���������� ���� String. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">������ �������.</param>
        /// <returns>������.</returns>
        public static Tuple<string[], string[], string[], string[], string[], string[]> ReadStringTup6(int count)
        {
            return Tuple.Create(ReadString(count), ReadString(count), ReadString(count), ReadString(count), ReadString(count), ReadString(count));
        }

        /// <summary>
        /// ��������� 7 ������� ���������� ���� Boolean. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">������ �������.</param>
        /// <returns>������.</returns>
        public static Tuple<bool[], bool[], bool[], bool[], bool[], bool[], bool[]> ReadBooleanTup7(int count)
        {
            return Tuple.Create(ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count), ReadBoolean(count));
        }

        /// <summary>
        /// ��������� 7 ������� ���������� ���� Char. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">������ �������.</param>
        /// <returns>������.</returns>
        public static Tuple<char[], char[], char[], char[], char[], char[], char[]> ReadCharTup7(int count)
        {
            return Tuple.Create(ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count), ReadChar(count));
        }

        /// <summary>
        /// ��������� 7 ������� ���������� ���� Int32. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">������ �������.</param>
        /// <returns>������.</returns>
        public static Tuple<int[], int[], int[], int[], int[], int[], int[]> ReadInt32Tup7(int count)
        {
            return Tuple.Create(ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count), ReadInt32(count));
        }

        /// <summary>
        /// ��������� 7 ������� ���������� ���� Double. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">������ �������.</param>
        /// <returns>������.</returns>
        public static Tuple<double[], double[], double[], double[], double[], double[], double[]> ReadDoubleTup7(int count)
        {
            return Tuple.Create(ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count), ReadDouble(count));
        }

        /// <summary>
        /// ��������� 7 ������� ���������� ���� String. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">������ �������.</param>
        /// <returns>������.</returns>
        public static Tuple<string[], string[], string[], string[], string[], string[], string[]> ReadStringTup7(int count)
        {
            return Tuple.Create(ReadString(count), ReadString(count), ReadString(count), ReadString(count), ReadString(count), ReadString(count), ReadString(count));
        }
    }
}