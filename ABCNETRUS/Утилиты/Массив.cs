using System;

namespace ABCNETRUS.�������
{
    /// <summary>
    /// ������������� ���������� ��� ������ � ���������.
    /// </summary>
    public static class ������
    {
        /// <summary>
        /// ������ ������ �� ��������� ��������.
        /// </summary>
        /// <param name="��������">��������.</param>
        /// <returns>������.</returns>
        public static T[] �����<T>(params T[] ��������)
        {
            if (�������� == null)
                throw new ����������������Null������(nameof(��������));

            return ��������;
        }

        /// <summary>
        /// ������ ������ �� ������ ������� ���������.
        /// </summary>
        /// <param name="�����">���������� ���������.</param>
        /// <param name="�����������">������� ��������.</param>
        /// <param name="������������">��������� ������.</param>
        /// <returns>������.</returns>
        public static T[] ������������<T>(int �����, Func<int, T> �����������, int ������������ = 0)
        {
            if (����� < 0)
                throw new �������������������������������������(nameof(�����));
            if (����������� == null)
                throw new ����������������Null������(nameof(�����������));
            
            T[] source = new T[�����];
            for (int i = 0; i < source.Length; i++)
                source[i] = �����������(i + ������������);

            return source;
        }

        /// <summary>
        /// ������ ������ �� ������ ������� ���������.
        /// </summary>
        /// <param name="�����">���������� ���������.</param>
        /// <param name="������">������ �������.</param>
        /// <param name="�����������">������� ��������� ���������� ��������.</param>
        /// <returns>������.</returns>
        public static T[] ������������<T>(int �����, T ������, Func<T, T> �����������)
        {
            if (����� < 0)
                throw new �������������������������������������(nameof(�����));
            if (����������� == null)
                throw new ����������������Null������(nameof(�����������));
            
            T[] source = new T[�����];
            source[0] = ������;
            for (int i = 1; i < source.Length; i++)
                source[i] = �����������(source[i - 1]);

            return source;
        }

        /// <summary>
        /// ������ ������ ��������� ����� ���� Integer.
        /// </summary>
        /// <param name="�����">���������� ���������.</param>
        /// <param name="������">������ ������� ���������.</param>
        /// <param name="�������">������� ������� ���������.</param>
        /// <returns>������.</returns>
        public static int[] ���������(int �����, int ������ = ��������������������.������, int ������� = ��������������������.�������)
        {
            if (����� < 0)
                throw new �������������������������������������(nameof(�����));
            if (������ > �������)
                throw new ����������������������(nameof(������));

            int[] source = new int[�����];
            for (int i = 0; i < source.Length; i++)
                source[i] = ��������.���������(������, �������);

            return source;
        }

        /// <summary>
        /// ������ ������ ��������� ����� ���� Real.
        /// </summary>
        /// <param name="�����">���������� ���������.</param>
        /// <param name="������">������ ������� ���������.</param>
        /// <param name="�������">������� ������� ���������.</param>
        /// <returns>������.</returns>
        public static double[] ���������(int �����, double ������ = �������������������.������, double ������� = �������������������.�������)
        {
            if (����� < 0)
                throw new �������������������������������������(nameof(�����));
            if (������ > �������)
                throw new ����������������������(nameof(������));

            double[] source = new double[�����];
            for (int i = 0; i < source.Length; i++)
                source[i] = ��������.���������(������, �������);

            return source;
        }

        /// <summary>
        /// ������ ������, ����������� ��������� ���������.
        /// </summary>
        /// <param name="�����">���������� ���������.</param>
        /// <param name="��������">��������.</param>
        /// <returns>������.</returns>
        public static T[] ���������<T>(int �����, T ��������)
        {
            if (����� < 0)
                throw new �������������������������������������(nameof(�����));

            T[] source = new T[�����];
            for (int i = 0; i < source.Length; i++)
                source[i] = ��������;

            return source;
        }

        /// <summary>
        /// ������ ������ �������� ���� Boolean.
        /// </summary>
        /// <param name="�����">���������� ���������.</param>
        /// <param name="�����������">����������� � �����.</param>
        /// <returns>������.</returns>
        public static bool[] ����������������(int �����, string ����������� = ������������.��������)
        {
            if (����� < 0)
                throw new �������������������������������������(nameof(�����));

            bool[] array = new bool[�����];
            int i = 0;
            while (i < �����)
                try
                {
                    array[i] = ��������.������������������������(����������� is null ? ������������.�������� : string.Format(�����������, i));
                    i++;
                }
                catch (Exception)
                {
                    Console.WriteLine(�����������.��������);
                }

            return array;
        }

        /// <summary>
        /// ������ ������ �������� ���� Char.
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="�����������">����������� � �����.</param>
        /// <returns>������.</returns>
        public static char[] ����������������(int count, string ����������� = ������������.��������)
        {
            if (count < 0)
                throw new �������������������������������������(nameof(count));

            char[] array = new char[count];
            for (int i = 0; i < count; i++)
                array[i] = ��������.������������(����������� is null ? ������������.�������� : string.Format(�����������, i));

            return array;
        }

        /// <summary>
        /// ������ ������ �������� ���� Real.
        /// </summary>
        /// <param name="�����">���������� ���������.</param>
        /// <param name="�����������">����������� � �����.</param>
        /// <returns>������.</returns>
        public static double[] ������������������(int �����, string ����������� = ������������.��������)
        {
            if (����� < 0)
                throw new �������������������������������������(nameof(�����));

            double[] array = new double[�����];
            int i = 0;
            while (i < �����)
                try
                {
                    array[i] = ��������.�����������������������(����������� is null ? ������������.�������� : string.Format(�����������, i));
                    i++;
                }
                catch (Exception)
                {
                    Console.WriteLine(�����������.��������);
                }

            return array;
        }

        /// <summary>
        /// ������ ������ �������� ���� Integer.
        /// </summary>
        /// <param name="�����">���������� ���������.</param>
        /// <param name="�����������">����������� � �����.</param>
        /// <returns>������.</returns>
        public static int[] �������������������(int �����, string ����������� = ������������.��������)
        {
            if (����� < 0)
                throw new �������������������������������������(nameof(�����));

            int[] array = new int[�����];
            int i = 0;
            while (i < �����)
                try
                {
                    array[i] = ��������.����������������(����������� is null ? ������������.�������� : string.Format(�����������, i));
                    i++;
                }
                catch (Exception)
                {
                    Console.WriteLine(�����������.��������);
                }

            return array;
        }

        /// <summary>
        /// ������ ������ �������� ���� String.
        /// </summary>
        /// <param name="�����">���������� ���������.</param>
        /// <param name="�����������">����������� � �����.</param>
        /// <returns>������.</returns>
        public static string[] ���������������(int �����, string ����������� = ������������.��������)
        {
            if (����� < 0)
                throw new �������������������������������������(nameof(�����));

            string[] array = new string[�����];
            for (int i = 0; i < �����; i++)
                array[i] = ��������.������������(����������� is null ? ������������.�������� : string.Format(�����������, i));
            return array;
        }
    }
}