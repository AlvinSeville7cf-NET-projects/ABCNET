using System;

namespace ABCNETRUS.”тилиты
{
    /// <summary>
    /// ѕредоставл€ет функционал дл€ работы с базовыми типами.
    /// </summary>
    public static class ќсновное
    {
        /// <summary>
        /// ћен€ет местами значени€ двух переменных.
        /// </summary>
        /// <param name="x">ѕерва€ переменна€.</param>
        /// <param name="y">¬тора€ переменна€.</param>
        public static void ќбмен€ть«начени€<T>(ref T x, ref T y)
        {
            T z = x;
            x = y;
            y = z;
        }

        /// <summary>
        /// „итает значение типа Boolean.
        /// </summary>
        /// <param name="приглашение">ѕриглашение к вводу.</param>
        /// <returns>«начение.</returns>
        public static bool „итатьЋогическое«начение(string приглашение = ѕуста€—трока.«начение)
        {
            Console.Write(приглашение);
            return bool.Parse(Console.ReadLine());
        }

        /// <summary>
        /// „итает значение типа Char.
        /// </summary>
        /// <param name="приглашение">ѕриглашение к вводу.</param>
        /// <returns>«начение.</returns>
        public static char „итать—имвол(string приглашение = ѕуста€—трока.«начение)
        {
            Console.Write(приглашение);
            return Console.ReadKey().KeyChar;
        }

        /// <summary>
        /// „итает значение типа Real.
        /// </summary>
        /// <param name="приглашение">ѕриглашение к вводу.</param>
        /// <returns>«начение.</returns>
        public static double „итать¬ещественное„исло(string приглашение = ѕуста€—трока.«начение)
        {
            Console.Write(приглашение);
            return double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// „итает значение типа Integer.
        /// </summary>
        /// <param name="приглашение">ѕриглашение к вводу.</param>
        /// <returns>«начение.</returns>
        public static int „итать÷елое„исло(string приглашение = ѕуста€—трока.«начение)
        {
            Console.Write(приглашение);
            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// „итает значение типа String.
        /// </summary>
        /// <param name="приглашение">ѕриглашение к вводу.</param>
        /// <returns>«начение.</returns>
        public static string „итать—троку(string приглашение = ѕуста€—трока.«начение)
        {
            Console.Write(приглашение);
            return Console.ReadLine();
        }

        /// <summary>
        /// √енерирует случайное число [0..1).
        /// </summary>
        /// <returns>„исло.</returns>
        public static int —лучайное()
        {
            return ƒатчикѕсевдослучайных„исел.«начение.Next();
        }

        /// <summary>
        /// √енерирует случайное число [low..high].
        /// </summary>
        /// <param name="нижн€€">Ќижн€€ граница диапазона.</param>
        /// <param name="верхн€€">¬ерхн€€ граница диапазона.</param>
        /// <returns>„исло.</returns>
        public static int —лучайное(int нижн€€, int верхн€€)
        {
            if (верхн€€ < нижн€€)
                ќбмен€ть«начени€(ref нижн€€, ref верхн€€);
            return ƒатчикѕсевдослучайных„исел.«начение.Next(нижн€€, верхн€€ + 1);
        }

        /// <summary>
        /// √енерирует случайное число [low..high].
        /// </summary>
        /// <param name="нижн€€">Ќижн€€ граница диапазона.</param>
        /// <param name="верхн€€">¬ерхн€€ граница диапазона.</param>
        /// <returns>„исло.</returns>
        public static double —лучайное(double нижн€€, double верхн€€)
        {
            if (верхн€€ < нижн€€)
                ќбмен€ть«начени€(ref нижн€€, ref верхн€€);
            return нижн€€ + —лучайное() * (верхн€€ - нижн€€);
        }
    }
}