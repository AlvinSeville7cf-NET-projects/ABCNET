using System;

namespace NETMouse.Extensions
{
    /// <summary>
    /// Предоставляет функционал для работы с StringBuilder.
    /// </summary>
    public static class StringBuilder
    {
        /// <summary>
        /// Выводит StringBuilder.
        /// </summary>
        /// <param name="stringBuilder">StringBuilder.</param>
        /// <returns>StringBuilder.</returns>
        public static System.Text.StringBuilder Print(this System.Text.StringBuilder stringBuilder)
        {
            Console.Write(stringBuilder);
            return stringBuilder;
        }

        /// <summary>
        /// Выводит StringBuilder и переходит на новую строку.
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