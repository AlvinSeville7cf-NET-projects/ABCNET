using System;

namespace ABCNET.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы с базовыми типами.
    /// </summary>
    public static partial class Base
    {
        /// <summary>
        /// Читает значение типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Значение.</returns>
        public static bool ReadBoolean(string prompt = EmptyStringHelper.Empty)
        {
            Console.Write(prompt);
            return bool.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Читает значение типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Значение.</returns>
        public static char ReadChar(string prompt = EmptyStringHelper.Empty)
        {
            Console.Write(prompt);
            return Console.ReadKey().KeyChar;
        }

        /// <summary>
        /// Читает значение типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Значение.</returns>
        public static double ReadDouble(string prompt = EmptyStringHelper.Empty)
        {
            Console.Write(prompt);
            return double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Читает значение типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Значение.</returns>
        public static int ReadInt32(string prompt = EmptyStringHelper.Empty)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Читает значение типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Значение.</returns>
        public static string ReadString(string prompt = EmptyStringHelper.Empty)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        /// <summary> 
        /// Генерирует случайное число [0..1). 
        /// </summary> 
        /// <returns>Число.</returns> 
        public static double Rand()
        {
            return RandomHelper.Random.NextDouble();
        }

        /// <summary>
        /// Генерирует случайное число [low..high].
        /// </summary>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Число.</returns>
        public static int Rand(int low, int high)
        {
            if (high < low)
                Swap(ref low, ref high);
            return RandomHelper.Random.Next(low, high + 1);
        }

        /// <summary>
        /// Генерирует случайное число [low..high].
        /// </summary>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        /// <returns>Число.</returns>
        public static double Rand(double low, double high)
        {
            if (high < low)
                Swap(ref low, ref high);
            return low + Rand() * (high - low);
        }
    }
}