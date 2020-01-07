using System;

namespace NETMouse.Extensions
{
    /// <summary>
    /// ������������� ���������� ��� ������ � StringBuilder.
    /// </summary>
    public static class StringBuilder
    {
        /// <summary>
        /// ������� StringBuilder.
        /// </summary>
        /// <param name="stringBuilder">StringBuilder.</param>
        /// <returns>StringBuilder.</returns>
        public static System.Text.StringBuilder Print(this System.Text.StringBuilder stringBuilder)
        {
            Console.Write(stringBuilder);
            return stringBuilder;
        }

        /// <summary>
        /// ������� StringBuilder � ��������� �� ����� ������.
        /// </summary>
        /// <param name="stringBuilder">StringBuilder.</param>
        /// <returns>StringBuilder.</returns>
        public static System.Text.StringBuilder Println(this System.Text.StringBuilder stringBuilder)
        {
            Console.WriteLine(stringBuilder);
            return stringBuilder;
        }
    }
}