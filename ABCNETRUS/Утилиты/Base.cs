using System;

namespace ABCNETRUS.�������
{
    /// <summary>
    /// ������������� ���������� ��� ������ � �������� ������.
    /// </summary>
    public static class ��������
    {
        /// <summary>
        /// ������ ������� �������� ���� ����������.
        /// </summary>
        /// <param name="x">������ ����������.</param>
        /// <param name="y">������ ����������.</param>
        public static void ����������������<T>(ref T x, ref T y)
        {
            T z = x;
            x = y;
            y = z;
        }

        /// <summary>
        /// ������ �������� ���� Boolean.
        /// </summary>
        /// <param name="�����������">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static bool ������������������������(string ����������� = ������������.��������)
        {
            Console.Write(�����������);
            return bool.Parse(Console.ReadLine());
        }

        /// <summary>
        /// ������ �������� ���� Char.
        /// </summary>
        /// <param name="�����������">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static char ������������(string ����������� = ������������.��������)
        {
            Console.Write(�����������);
            return Console.ReadKey().KeyChar;
        }

        /// <summary>
        /// ������ �������� ���� Real.
        /// </summary>
        /// <param name="�����������">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static double �����������������������(string ����������� = ������������.��������)
        {
            Console.Write(�����������);
            return double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// ������ �������� ���� Integer.
        /// </summary>
        /// <param name="�����������">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static int ����������������(string ����������� = ������������.��������)
        {
            Console.Write(�����������);
            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// ������ �������� ���� String.
        /// </summary>
        /// <param name="�����������">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static string ������������(string ����������� = ������������.��������)
        {
            Console.Write(�����������);
            return Console.ReadLine();
        }

        /// <summary>
        /// ���������� ��������� ����� [0..1).
        /// </summary>
        /// <returns>�����.</returns>
        public static int ���������()
        {
            return ��������������������������.��������.Next();
        }

        /// <summary>
        /// ���������� ��������� ����� [low..high].
        /// </summary>
        /// <param name="������">������ ������� ���������.</param>
        /// <param name="�������">������� ������� ���������.</param>
        /// <returns>�����.</returns>
        public static int ���������(int ������, int �������)
        {
            if (������� < ������)
                ����������������(ref ������, ref �������);
            return ��������������������������.��������.Next(������, ������� + 1);
        }

        /// <summary>
        /// ���������� ��������� ����� [low..high].
        /// </summary>
        /// <param name="������">������ ������� ���������.</param>
        /// <param name="�������">������� ������� ���������.</param>
        /// <returns>�����.</returns>
        public static double ���������(double ������, double �������)
        {
            if (������� < ������)
                ����������������(ref ������, ref �������);
            return ������ + ���������() * (������� - ������);
        }
    }
}