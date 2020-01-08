using System;
using System.Collections.Generic;
using System.Linq;

namespace ABCNET.Extensions
{
    /// <summary>
    /// Предоставляет функционал для работы с базовыми типами.
    /// </summary>
    public static class BaseExt
    {
        /// <summary>
        /// Проверяет лежит ли число между другими двумя.
        /// </summary>
        /// <param name="target">Число.</param>
        /// <param name="firstBorder">Первая граница.</param>
        /// <param name="secondBorder">Вторая граница.</param>
        /// <returns>Результат.</returns>
        public static bool IsBetween(this int target, int firstBorder, int secondBorder)
        {
            if (firstBorder > secondBorder)
                Utils.Base.Swap(ref firstBorder, ref secondBorder);
            return (target >= firstBorder) && (target <= secondBorder);
        }

        /// <summary>
        /// Создаёт последовательность от начального числа до конечного.
        /// </summary>
        /// <param name="from">Начальное число.</param>
        /// <param name="to">Конечное число.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<int> To(this int from, int to)
        {
            if (from > to)
                return Enumerable.Empty<int>();
            return Enumerable.Range(from, to - from + 1);
        }

        /// <summary>
        /// Создаёт последовательность от начального числа до конечного.
        /// </summary>
        /// <param name="from">Начальное число.</param>
        /// <param name="to">Конечное число.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<int> DownTo(this int from, int to)
        {
            if (from < to)
            {
                foreach (var item in Enumerable.Empty<int>())
                    yield return item;
                yield break;
            }
            
            for (int i = from; i >= to; i--)
                yield return i;
        }

        /// <summary>
        /// Создаёт последовательность от 0 до конечного числа.
        /// </summary>
        /// <param name="to">Конечное число.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<int> Times(this int to)
        {
            if (to < 0)
                return 0.DownTo(to);
            return 0.To(to);
        }

        /// <summary>
        /// Создаёт бесконечную последовательность от начального числа.
        /// </summary>
        /// <param name="step">Шаг.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<int> Step(this int from, int step)
        {
            do
            {
                yield return from;
                from += step;
            } while (true);
        }

        /// <summary>
        /// Выводит значение типа Boolean.
        /// </summary>
        /// <param name="item">Boolean.</param>
        /// <returns>Значение.</returns>
        public static bool Print(this bool item)
        {
            Console.Write(item);
            return item;
        }

        /// <summary>
        /// Выводит значение типа Boolean и переходит на новую строку.
        /// </summary>
        /// <param name="item">Boolean.</param>
        /// <returns>Значение.</returns>
        public static bool Println(this bool item)
        {
            Console.WriteLine(item);
            return item;
        }

        /// <summary>
        /// Выводит значение типа Char.
        /// </summary>
        /// <param name="item">Char.</param>
        /// <returns>Значение.</returns>
        public static char Print(this char item)
        {
            Console.Write(item);
            return item;
        }

        /// <summary>
        /// Выводит значение типа Char и переходит на новую строку.
        /// </summary>
        /// <param name="item">Char.</param>
        /// <returns>Значение.</returns>
        public static char Println(this char item)
        {
            Console.WriteLine(item);
            return item;
        }

        /// <summary>
        /// Выводит значение типа Real.
        /// </summary>
        /// <param name="item">Real.</param>
        /// <returns>Значение.</returns>
        public static double Print(this double item)
        {
            Console.Write(item);
            return item;
        }

        /// <summary>
        /// Выводит значение типа Real и переходит на новую строку.
        /// </summary>
        /// <param name="item">Real.</param>
        /// <returns>Значение.</returns>
        public static double Println(this double item)
        {
            Console.WriteLine(item);
            return item;
        }

        /// <summary>
        /// Выводит значение типа Integer.
        /// </summary>
        /// <param name="item">Integer.</param>
        /// <returns>Значение.</returns>
        public static int Print(this int item)
        {
            Console.Write(item);
            return item;
        }

        /// <summary>
        /// Выводит значение типа Integer и переходит на новую строку.
        /// </summary>
        /// <param name="item">Integer.</param>
        /// <returns>Значение.</returns>
        public static int Println(this int item)
        {
            Console.WriteLine(item);
            return item;
        }
    }
}