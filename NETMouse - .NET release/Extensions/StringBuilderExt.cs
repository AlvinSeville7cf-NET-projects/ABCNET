using System;

namespace ABCNET.Extensions
{
    /// <summary>
    /// ������������� ���������� ��� ������ � StringBuilder.
    /// </summary>
    public static class StringBuilderExt
    {
        /// <summary>
        /// ������� �������� ���� StringBuilder.
        /// </summary>
        /// <param name="stringBuilder">StringBuilder.</param>
        /// <returns>��������.</returns>
        public static System.Text.StringBuilder Print(this System.Text.StringBuilder stringBuilder)
        {
            Console.Write(stringBuilder);
            return stringBuilder;
        }

        /// <summary>
        /// ������� �������� ���� StringBuilder � ��������� �� ����� ������.
        /// </summary>
        /// <param name="stringBuilder">StringBuilder.</param>
        /// <returns>��������.</returns>
        public static System.Text.StringBuilder Println(this System.Text.StringBuilder stringBuilder)
        {
            Console.WriteLine(stringBuilder);
            return stringBuilder;
        }
    }
}