using System;

namespace NETMouse.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы с базовыми типами.
    /// </summary>
    public static class Base
    {
        /// <summary>
        /// Меняет местами значения двух переменных.
        /// </summary>
        /// <param name="x">Первая переменная.</param>
        /// <param name="y">Вторая переменная.</param>
        public static void Swap<T>(ref T x, ref T y)
        {
            T z = x;
            x = y;
            y = z;
        }

        /// <summary>
        /// Читает значение типа Boolean.
        /// </summary>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Значение.</returns>
        public static bool ReadBoolean(string prompt = EmptyStringHelper.Empty)
        {
            Console.Write(prompt);
            return bool.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Читает значение типа Char.
        /// </summary>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Значение.</returns>
        public static char ReadChar(string prompt = EmptyStringHelper.Empty)
        {
            Console.Write(prompt);
            return Console.ReadKey().KeyChar;
        }

        /// <summary>
        /// Читает значение типа Real.
        /// </summary>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Значение.</returns>
        public static double ReadReal(string prompt = EmptyStringHelper.Empty)
        {
            Console.Write(prompt);
            return double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Читает значение типа Integer.
        /// </summary>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Значение.</returns>
        public static int ReadInteger(string prompt = EmptyStringHelper.Empty)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Читает значение типа String.
        /// </summary>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Значение.</returns>
        public static string ReadString(string prompt = EmptyStringHelper.Empty)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}