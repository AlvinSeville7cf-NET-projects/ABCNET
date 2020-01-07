using System;

namespace NETMouse.Utils
{
    /// <summary>
    /// ������������� ���������� ��� ������ � �������� ������.
    /// </summary>
    public static class Base
    {
        /// <summary>
        /// ������ ������� �������� ���� ����������.
        /// </summary>
        /// <param name="x">������ ����������.</param>
        /// <param name="y">������ ����������.</param>
        public static void Swap<T>(ref T x, ref T y)
        {
            T z = x;
            x = y;
            y = z;
        }

        /// <summary>
        /// ������ �������� ���� Boolean.
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static bool ReadBoolean(string prompt = EmptyStringHelper.Empty)
        {
            Console.Write(prompt);
            return bool.Parse(Console.ReadLine());
        }

        /// <summary>
        /// ������ �������� ���� Char.
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static char ReadChar(string prompt = EmptyStringHelper.Empty)
        {
            Console.Write(prompt);
            return Console.ReadKey().KeyChar;
        }

        /// <summary>
        /// ������ �������� ���� Real.
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static double ReadReal(string prompt = EmptyStringHelper.Empty)
        {
            Console.Write(prompt);
            return double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// ������ �������� ���� Integer.
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static int ReadInteger(string prompt = EmptyStringHelper.Empty)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// ������ �������� ���� String.
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static string ReadString(string prompt = EmptyStringHelper.Empty)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}