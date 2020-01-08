using System;

namespace ABCNET.Extensions
{
    /// <summary>
    /// Предоставляет функционал для работы с StringBuilder.
    /// </summary>
    public static class StringBuilderExt
    {
        /// <summary>
        /// Выводит значение типа StringBuilder.
        /// </summary>
        /// <param name="stringBuilder">StringBuilder.</param>
        /// <returns>Значение.</returns>
        public static System.Text.StringBuilder Print(this System.Text.StringBuilder stringBuilder)
        {
            Console.Write(stringBuilder);
            return stringBuilder;
        }

        /// <summary>
        /// Выводит значение типа StringBuilder и переходит на новую строку.
        /// </summary>
        /// <param name="stringBuilder">StringBuilder.</param>
        /// <returns>Значение.</returns>
        public static System.Text.StringBuilder Println(this System.Text.StringBuilder stringBuilder)
        {
            Console.WriteLine(stringBuilder);
            return stringBuilder;
        }
    }
}