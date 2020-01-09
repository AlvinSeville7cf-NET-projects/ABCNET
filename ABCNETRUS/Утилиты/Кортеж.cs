using System;

namespace ABCNETRUS.�������
{
    /// <summary>
    /// ������������� ���������� ��� ������ � ���������� ���������.
    /// </summary>
    public static class ������
    {
        /// <summary>
        /// ������ ������ �� ���� ��������.
        /// </summary>
        /// <param name="arg0">������ ��������.</param>
        /// <param name="arg1">������ ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<T, T1> �����<T, T1>(T arg0, T1 arg1)
        {
            return Tuple.Create(arg0, arg1);
        }

        /// <summary>
        /// ������ ������ �� ��� ��������.
        /// </summary>
        /// <param name="arg0">������ ��������.</param>
        /// <param name="arg1">������ ��������.</param>
        /// <param name="arg2">������ ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<T, T1, T2> �����<T, T1, T2>(T arg0, T1 arg1, T2 arg2)
        {
            return Tuple.Create(arg0, arg1, arg2);
        }

        /// <summary>
        /// ������ ������ �� ������ ��������.
        /// </summary>
        /// <param name="arg0">������ ��������.</param>
        /// <param name="arg1">������ ��������.</param>
        /// <param name="arg2">������ ��������.</param>
        /// <param name="arg3">�������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<T, T1, T2, T3> �����<T, T1, T2, T3>(T arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            return Tuple.Create(arg0, arg1, arg2, arg3);
        }

        /// <summary>
        /// ������ ������ �� ���� ��������.
        /// </summary>
        /// <param name="arg0">������ ��������.</param>
        /// <param name="arg1">������ ��������.</param>
        /// <param name="arg2">������ ��������.</param>
        /// <param name="arg3">�������� ��������.</param>
        /// <param name="arg4">����� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<T, T1, T2, T3, T4> �����<T, T1, T2, T3, T4>(T arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return Tuple.Create(arg0, arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// ������ ������ �� ����� ��������.
        /// </summary>
        /// <param name="arg0">������ ��������.</param>
        /// <param name="arg1">������ ��������.</param>
        /// <param name="arg2">������ ��������.</param>
        /// <param name="arg3">�������� ��������.</param>
        /// <param name="arg4">����� ��������.</param>
        /// <param name="arg5">������ ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<T, T1, T2, T3, T4, T5> �����<T, T1, T2, T3, T4, T5>(T arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return Tuple.Create(arg0, arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// ������ ������ �� ���� ��������.
        /// </summary>
        /// <param name="arg0">������ ��������.</param>
        /// <param name="arg1">������ ��������.</param>
        /// <param name="arg2">������ ��������.</param>
        /// <param name="arg3">�������� ��������.</param>
        /// <param name="arg4">����� ��������.</param>
        /// <param name="arg5">������ ��������.</param>
        /// <param name="arg6">������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<T, T1, T2, T3, T4, T5, T6> �����<T, T1, T2, T3, T4, T5, T6>(T arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            return Tuple.Create(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// ������ ������ �� ���� ��������� �������� ���� Integer.
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        public static Tuple<int, int> �����������������������(int low = ��������������������.������, int high = ��������������������.�������)
        {
            return new Tuple<int, int>(��������.���������(low, high), ��������.���������(low, high));
        }

        /// <summary>
        /// ������ ������ �� ��� ��������� �������� ���� Integer.
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        public static Tuple<int, int, int> ����������������������(int low = ��������������������.������, int high = ��������������������.�������)
        {
            return new Tuple<int, int, int>(��������.���������(low, high), ��������.���������(low, high), ��������.���������(low, high));
        }

        /// <summary>
        /// ������ ������ �� ���� ��������� �������� ���� Real.
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        public static Tuple<double, double> �����������������������(double low = �������������������.������, double high = �������������������.�������)
        {
            return new Tuple<double, double>(��������.���������(low, high), ��������.���������(low, high));
        }

        /// <summary>
        /// ������ ������ �� ��� ��������� �������� ���� Real.
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        public static Tuple<double, double, double> ����������������������(double low = �������������������.������, double high = �������������������.�������)
        {
            return new Tuple<double, double, double>(��������.���������(low, high), ��������.���������(low, high), ��������.���������(low, high));
        }

        /// <summary>
        /// ������ ������ �� ���� ���������, ����������� ��������� ���������.
        /// </summary>
        /// <param name="value">��������.</param>
        /// <returns>������.</returns>
        public static Tuple<T, T> Fill2<T>(T value)
        {
            return new Tuple<T, T>(value, value);
        }

        /// <summary>
        /// ������ ������ �� ���� ���������, ����������� ��������� ���������.
        /// </summary>
        /// <param name="value">��������.</param>
        /// <returns>������.</returns>
        public static Tuple<T, T, T> Fill3<T>(T value)
        {
            return new Tuple<T, T, T>(value, value, value);
        }

        /// <summary>
        /// ������ ������ �� ���� �������� ���� Boolean.
        /// </summary>
        /// <returns>������.</returns>
        public static Tuple<bool, bool> ReadBoolean2(string prompt = ������������.��������)
        {
            bool a = default;
            bool b = default;

            ReadBooleanTupleItem(ref a, 0, prompt);
            ReadBooleanTupleItem(ref b, 1, prompt);

            return new Tuple<bool, bool>(a, b);
        }

        /// <summary>
        /// ������ ������ �� ��� �������� ���� Boolean.
        /// </summary>
        /// <returns>������.</returns>
        public static Tuple<bool, bool, bool> ReadBoolean3(string prompt = ������������.��������)
        {
            bool a = default;
            bool b = default;
            bool c = default;

            ReadBooleanTupleItem(ref a, 0, prompt);
            ReadBooleanTupleItem(ref b, 1, prompt);
            ReadBooleanTupleItem(ref c, 2, prompt);

            return new Tuple<bool, bool, bool>(a, b, c);
        }

        /// <summary>
        /// ������ ������ �� ���� �������� ���� Char.
        /// </summary>
        /// <returns>������.</returns>
        public static Tuple<char, char> ReadChar2(string prompt = ������������.��������)
        {
            return new Tuple<char, char>(��������.������������(prompt is null ? ������������.�������� : string.Format(prompt, 0)),
                ��������.������������(prompt is null ? ������������.�������� : string.Format(prompt, 1)));
        }

        /// <summary>
        /// ������ ������ �� ��� �������� ���� Char.
        /// </summary>
        /// <returns>������.</returns>
        public static Tuple<char, char, char> ReadChar3(string prompt = ������������.��������)
        {
            return new Tuple<char, char, char>(��������.������������(prompt is null ? ������������.�������� : string.Format(prompt, 0)),
                ��������.������������(prompt is null ? ������������.�������� : string.Format(prompt, 1)),
                ��������.������������(prompt is null ? ������������.�������� : string.Format(prompt, 2)));
        }

        /// <summary>
        /// ������ ������ �� ���� �������� ���� Real.
        /// </summary>
        /// <returns>������.</returns>
        public static Tuple<double, double> ReadReal2(string prompt = ������������.��������)
        {
            double a = default;
            double b = default;

            ReadRealTupleItem(ref a, 0, prompt);
            ReadRealTupleItem(ref b, 1, prompt);

            return new Tuple<double, double>(a, b);
        }

        /// <summary>
        /// ������ ������ �� ��� �������� ���� Real.
        /// </summary>
        /// <returns>������.</returns>
        public static Tuple<double, double, double> ReadReal3(string prompt = ������������.��������)
        {
            double a = default;
            double b = default;
            double c = default;

            ReadRealTupleItem(ref a, 0, prompt);
            ReadRealTupleItem(ref b, 1, prompt);
            ReadRealTupleItem(ref c, 2, prompt);

            return new Tuple<double, double, double>(a, b, c);
        }

        /// <summary>
        /// ������ ������ �� ���� �������� ���� Integer.
        /// </summary>
        /// <returns>������.</returns>
        public static Tuple<int, int> ReadInteger2(string prompt = ������������.��������)
        {
            int a = default;
            int b = default;

            ReadIntegerTupleItem(ref a, 0, prompt);
            ReadIntegerTupleItem(ref b, 1, prompt);

            return new Tuple<int, int>(a, b);
        }

        /// <summary>
        /// ������ ������ �� ��� �������� ���� Integer.
        /// </summary>
        /// <returns>������.</returns>
        public static Tuple<int, int, int> ReadInteger3(string prompt = ������������.��������)
        {
            int a = default;
            int b = default;
            int c = default;

            ReadIntegerTupleItem(ref a, 0, prompt);
            ReadIntegerTupleItem(ref b, 1, prompt);
            ReadIntegerTupleItem(ref c, 2, prompt);

            return new Tuple<int, int, int>(a, b, c);
        }

        /// <summary>
        /// ������ ������ �� ���� �������� ���� String.
        /// </summary>
        /// <returns>������.</returns>
        public static Tuple<string, string> ReadString2(string prompt = ������������.��������)
        {
            return new Tuple<string, string>(��������.������������(prompt is null ? ������������.�������� : string.Format(prompt, 0)),
                ��������.������������(prompt is null ? ������������.�������� : string.Format(prompt, 1)));
        }

        /// <summary>
        /// ������ ������ �� ��� �������� ���� String.
        /// </summary>
        /// <returns>������.</returns>
        public static Tuple<string, string, string> ReadString3(string prompt = ������������.��������)
        {
            return new Tuple<string, string, string>(��������.������������(prompt is null ? ������������.�������� : string.Format(prompt, 0)),
                ��������.������������(prompt is null ? ������������.�������� : string.Format(prompt, 1)),
                ��������.������������(prompt is null ? ������������.�������� : string.Format(prompt, 2)));
        }

        private static void ReadBooleanTupleItem(ref bool field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = ��������.������������������������(prompt is null ? ������������.�������� : string.Format(prompt, index));
                    return;
                }
                catch (Exception)
                {
                    Console.WriteLine(�����������.��������);
                }
        }

        private static void ReadIntegerTupleItem(ref int field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = ��������.����������������(prompt is null ? ������������.�������� : string.Format(prompt, index));
                    return;
                }
                catch (Exception)
                {
                    Console.WriteLine(�����������.��������);
                }
        }

        private static void ReadRealTupleItem(ref double field, int index, string prompt)
        {
            while (true)
                try
                {
                    field = ��������.�����������������������(prompt is null ? ������������.�������� : string.Format(prompt, index));
                    return;
                }
                catch (Exception)
                {
                    Console.WriteLine(�����������.��������);
                }
        }
    }
}