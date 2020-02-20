using System;

namespace ABCNET.Utils
{
    /// <summary>
    /// ������������� ���������� ��� ������ � ���������.
    /// </summary>
    public static class Arr
    {
        #region Read2

        /// <summary>
        /// ��������� 2 ������� ���������� ���� Bool. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">������ �������.</param>
        public static Tuple<bool[], bool[]> ReadBool2(int size)
        {
            return Tuple.Create(Arr.ReadBoolean(size), Arr.ReadBoolean(size));
        }

        /// <summary>
        /// ��������� 2 ������� ���������� ���� Char. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">������ �������.</param>
        public static Tuple<char[], char[]> ReadChar2(int size)
        {
            return Tuple.Create(Arr.ReadChar(size), Arr.ReadChar(size));
        }

        /// <summary>
        /// ��������� 2 ������� ���������� ���� Integer. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">������ �������.</param>
        public static Tuple<int[], int[]> ReadInteger2(int size)
        {
            return Tuple.Create(Arr.ReadInteger(size), Arr.ReadInteger(size));
        }

        /// <summary>
        /// ��������� 2 ������� ���������� ���� Real. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">������ �������.</param>
        public static Tuple<double[], double[]> ReadReal2(int size)
        {
            return Tuple.Create(Arr.ReadReal(size), Arr.ReadReal(size));
        }

        /// <summary>
        /// ��������� 2 ������� ���������� ���� String. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">������ �������.</param>
        public static Tuple<string[], string[]> ReadString2(int size)
        {
            return Tuple.Create(Arr.ReadString(size), Arr.ReadString(size));
        }

        #endregion

        #region Read3

        /// <summary>
        /// ��������� 3 ������� ���������� ���� Bool. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">������ �������.</param>
        public static Tuple<bool[], bool[], bool[]> ReadBool3(int size)
        {
            return Tuple.Create(Arr.ReadBoolean(size), Arr.ReadBoolean(size), Arr.ReadBoolean(size));
        }

        /// <summary>
        /// ��������� 3 ������� ���������� ���� Char. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">������ �������.</param>
        public static Tuple<char[], char[], char[]> ReadChar3(int size)
        {
            return Tuple.Create(Arr.ReadChar(size), Arr.ReadChar(size), Arr.ReadChar(size));
        }

        /// <summary>
        /// ��������� 3 ������� ���������� ���� Integer. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">������ �������.</param>
        public static Tuple<int[], int[], int[]> ReadInteger3(int size)
        {
            return Tuple.Create(Arr.ReadInteger(size), Arr.ReadInteger(size), Arr.ReadInteger(size));
        }

        /// <summary>
        /// ��������� 3 ������� ���������� ���� Real. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">������ �������.</param>
        public static Tuple<double[], double[], double[]> ReadReal3(int size)
        {
            return Tuple.Create(Arr.ReadReal(size), Arr.ReadReal(size), Arr.ReadReal(size));
        }

        /// <summary>
        /// ��������� 3 ������� ���������� ���� String. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">������ �������.</param>
        public static Tuple<string[], string[], string[]> ReadString3(int size)
        {
            return Tuple.Create(Arr.ReadString(size), Arr.ReadString(size), Arr.ReadString(size));
        }

        #endregion

        #region Read4

        /// <summary>
        /// ��������� 4 ������� ���������� ���� Bool. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">������ �������.</param>
        public static Tuple<bool[], bool[], bool[], bool[]> ReadBool4(int size)
        {
            return Tuple.Create(Arr.ReadBoolean(size), Arr.ReadBoolean(size), Arr.ReadBoolean(size), Arr.ReadBoolean(size));
        }

        /// <summary>
        /// ��������� 4 ������� ���������� ���� Char. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">������ �������.</param>
        public static Tuple<char[], char[], char[], char[]> ReadChar4(int size)
        {
            return Tuple.Create(Arr.ReadChar(size), Arr.ReadChar(size), Arr.ReadChar(size), Arr.ReadChar(size));
        }

        /// <summary>
        /// ��������� 4 ������� ���������� ���� Integer. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">������ �������.</param>
        public static Tuple<int[], int[], int[], int[]> ReadInteger4(int size)
        {
            return Tuple.Create(Arr.ReadInteger(size), Arr.ReadInteger(size), Arr.ReadInteger(size), Arr.ReadInteger(size));
        }

        /// <summary>
        /// ��������� 4 ������� ���������� ���� Real. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">������ �������.</param>
        public static Tuple<double[], double[], double[], double[]> ReadReal4(int size)
        {
            return Tuple.Create(Arr.ReadReal(size), Arr.ReadReal(size), Arr.ReadReal(size), Arr.ReadReal(size));
        }

        /// <summary>
        /// ��������� 4 ������� ���������� ���� String. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">������ �������.</param>
        public static Tuple<string[], string[], string[], string[]> ReadString4(int size)
        {
            return Tuple.Create(Arr.ReadString(size), Arr.ReadString(size), Arr.ReadString(size), Arr.ReadString(size));
        }

        #endregion

        #region Read5

        /// <summary>
        /// ��������� 5 ������� ���������� ���� Bool. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">������ �������.</param>
        public static Tuple<bool[], bool[], bool[], bool[], bool[]> ReadBool5(int size)
        {
            return Tuple.Create(Arr.ReadBoolean(size), Arr.ReadBoolean(size), Arr.ReadBoolean(size), Arr.ReadBoolean(size), Arr.ReadBoolean(size));
        }

        /// <summary>
        /// ��������� 5 ������� ���������� ���� Char. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">������ �������.</param>
        public static Tuple<char[], char[], char[], char[], char[]> ReadChar5(int size)
        {
            return Tuple.Create(Arr.ReadChar(size), Arr.ReadChar(size), Arr.ReadChar(size), Arr.ReadChar(size), Arr.ReadChar(size));
        }

        /// <summary>
        /// ��������� 5 ������� ���������� ���� Integer. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">������ �������.</param>
        public static Tuple<int[], int[], int[], int[], int[]> ReadInteger5(int size)
        {
            return Tuple.Create(Arr.ReadInteger(size), Arr.ReadInteger(size), Arr.ReadInteger(size), Arr.ReadInteger(size), Arr.ReadInteger(size));
        }

        /// <summary>
        /// ��������� 5 ������� ���������� ���� Real. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">������ �������.</param>
        public static Tuple<double[], double[], double[], double[], double[]> ReadReal5(int size)
        {
            return Tuple.Create(Arr.ReadReal(size), Arr.ReadReal(size), Arr.ReadReal(size), Arr.ReadReal(size), Arr.ReadReal(size));
        }

        /// <summary>
        /// ��������� 5 ������� ���������� ���� String. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">������ �������.</param>
        public static Tuple<string[], string[], string[], string[], string[]> ReadString5(int size)
        {
            return Tuple.Create(Arr.ReadString(size), Arr.ReadString(size), Arr.ReadString(size), Arr.ReadString(size), Arr.ReadString(size));
        }

        #endregion

        #region Read6

        /// <summary>
        /// ��������� 6 ������� ���������� ���� Bool. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">������ �������.</param>
        public static Tuple<bool[], bool[], bool[], bool[], bool[], bool[]> ReadBool6(int size)
        {
            return Tuple.Create(Arr.ReadBoolean(size), Arr.ReadBoolean(size), Arr.ReadBoolean(size), Arr.ReadBoolean(size), Arr.ReadBoolean(size), Arr.ReadBoolean(size));
        }

        /// <summary>
        /// ��������� 6 ������� ���������� ���� Char. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">������ �������.</param>
        public static Tuple<char[], char[], char[], char[], char[], char[]> ReadChar6(int size)
        {
            return Tuple.Create(Arr.ReadChar(size), Arr.ReadChar(size), Arr.ReadChar(size), Arr.ReadChar(size), Arr.ReadChar(size), Arr.ReadChar(size));
        }

        /// <summary>
        /// ��������� 6 ������� ���������� ���� Integer. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">������ �������.</param>
        public static Tuple<int[], int[], int[], int[], int[], int[]> ReadInteger6(int size)
        {
            return Tuple.Create(Arr.ReadInteger(size), Arr.ReadInteger(size), Arr.ReadInteger(size), Arr.ReadInteger(size), Arr.ReadInteger(size), Arr.ReadInteger(size));
        }

        /// <summary>
        /// ��������� 6 ������� ���������� ���� Real. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">������ �������.</param>
        public static Tuple<double[], double[], double[], double[], double[], double[]> ReadReal6(int size)
        {
            return Tuple.Create(Arr.ReadReal(size), Arr.ReadReal(size), Arr.ReadReal(size), Arr.ReadReal(size), Arr.ReadReal(size), Arr.ReadReal(size));
        }

        /// <summary>
        /// ��������� 6 ������� ���������� ���� String. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">������ �������.</param>
        public static Tuple<string[], string[], string[], string[], string[], string[]> ReadString6(int size)
        {
            return Tuple.Create(Arr.ReadString(size), Arr.ReadString(size), Arr.ReadString(size), Arr.ReadString(size), Arr.ReadString(size), Arr.ReadString(size));
        }

        #endregion

        #region Read7

        /// <summary>
        /// ��������� 7 ������� ���������� ���� Bool. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">������ �������.</param>
        public static Tuple<bool[], bool[], bool[], bool[], bool[], bool[], bool[]> ReadBool7(int size)
        {
            return Tuple.Create(Arr.ReadBoolean(size), Arr.ReadBoolean(size), Arr.ReadBoolean(size), Arr.ReadBoolean(size), Arr.ReadBoolean(size), Arr.ReadBoolean(size), Arr.ReadBoolean(size));
        }

        /// <summary>
        /// ��������� 7 ������� ���������� ���� Char. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">������ �������.</param>
        public static Tuple<char[], char[], char[], char[], char[], char[], char[]> ReadChar7(int size)
        {
            return Tuple.Create(Arr.ReadChar(size), Arr.ReadChar(size), Arr.ReadChar(size), Arr.ReadChar(size), Arr.ReadChar(size), Arr.ReadChar(size), Arr.ReadChar(size));
        }

        /// <summary>
        /// ��������� 7 ������� ���������� ���� Integer. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">������ �������.</param>
        public static Tuple<int[], int[], int[], int[], int[], int[], int[]> ReadInteger7(int size)
        {
            return Tuple.Create(Arr.ReadInteger(size), Arr.ReadInteger(size), Arr.ReadInteger(size), Arr.ReadInteger(size), Arr.ReadInteger(size), Arr.ReadInteger(size), Arr.ReadInteger(size));
        }

        /// <summary>
        /// ��������� 7 ������� ���������� ���� Real. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">������ �������.</param>
        public static Tuple<double[], double[], double[], double[], double[], double[], double[]> ReadReal7(int size)
        {
            return Tuple.Create(Arr.ReadReal(size), Arr.ReadReal(size), Arr.ReadReal(size), Arr.ReadReal(size), Arr.ReadReal(size), Arr.ReadReal(size), Arr.ReadReal(size));
        }

        /// <summary>
        /// ��������� 7 ������� ���������� ���� String. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="size">������ �������.</param>
        public static Tuple<string[], string[], string[], string[], string[], string[], string[]> ReadString7(int size)
        {
            return Tuple.Create(Arr.ReadString(size), Arr.ReadString(size), Arr.ReadString(size), Arr.ReadString(size), Arr.ReadString(size), Arr.ReadString(size), Arr.ReadString(size));
        }

        #endregion


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
        /// ������ ������ ��������� ����� ���� Integer.
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        public static int[] Rand(int count, int low = IntegerBordersHelper.Low, int high = IntegerBordersHelper.High)
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
        /// ������ ������ ��������� ����� ���� Real.
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        public static double[] Rand(int count, double low = RealBordersHelper.Low, double high = RealBordersHelper.High)
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
        /// ������ ������ �������� ���� Real. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>������.</returns>
        public static double[] ReadReal(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            double[] array = new double[count];
            int i = 0;
            while (i < count)
                try
                {
                    array[i] = Base.ReadReal(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    Console.WriteLine(InputErrorHelper.Message);
                }

            return array;
        }

        /// <summary>
        /// ������ ������ �������� ���� Integer. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>������.</returns>
        public static int[] ReadInteger(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            int[] array = new int[count];
            int i = 0;
            while (i < count)
                try
                {
                    array[i] = Base.ReadInteger(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
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
    }
}