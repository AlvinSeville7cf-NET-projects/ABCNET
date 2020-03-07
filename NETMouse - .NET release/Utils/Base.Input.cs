using ABCNET.Extensions;
using System;

namespace ABCNET.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы с базовыми типами.
    /// </summary>
    public static partial class Base
    {
        #region public
        /// <summary>
        /// Читает значение типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Значение.</returns>
        public static bool ReadBoolean(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return bool.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Читает значение типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Значение.</returns>
        public static byte ReadByte(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return byte.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Читает значение типа SByte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Значение.</returns>
        public static sbyte ReadSByte(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return sbyte.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Читает значение типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Значение.</returns>
        public static char ReadChar(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return Console.ReadKey().KeyChar;
        }

        /// <summary>
        /// Читает значение типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Значение.</returns>
        public static decimal ReadDecimal(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return decimal.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Читает значение типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Значение.</returns>
        public static double ReadDouble(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Читает значение типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Значение.</returns>
        public static float ReadSingle(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return float.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Читает значение типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Значение.</returns>
        public static int ReadInt32(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Читает значение типа UInt32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Значение.</returns>
        public static uint ReadUInt32(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return uint.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Читает значение типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Значение.</returns>
        public static long ReadInt64(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return long.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Читает значение типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Значение.</returns>
        public static ulong ReadUInt64(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return ulong.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Читает значение типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Значение.</returns>
        public static short ReadInt16(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return short.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Читает значение типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Значение.</returns>
        public static ushort ReadUInt16(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return ushort.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Читает значение типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Значение.</returns>
        public static string ReadString(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
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
        /// Генерирует случайное число [low;high].
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
        /// Генерирует случайное число [low;high].
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
        #endregion public
    }
}