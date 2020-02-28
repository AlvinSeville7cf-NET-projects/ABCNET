using System;
using System.Collections.Generic;

namespace ABCNET.Extensions
{
    /// <summary>
    /// Предоставляет функционал для работы с базовыми типами.
    /// </summary>
    public static partial class BaseExt
    {
        /// <summary>
        /// Выводит значение типа Boolean.
        /// </summary>
        /// <param name="item">Boolean.</param>
        /// <returns>Значение.</returns>
        public static bool Print(this bool item)
        {
            Console.Write(item.ToString());
            return item;
        }

        /// <summary>
        /// Выводит значение типа Boolean и переходит на новую строку.
        /// </summary>
        /// <param name="item">Boolean.</param>
        /// <returns>Значение.</returns>
        public static bool Println(this bool item)
        {
            Console.WriteLine(item.ToString());
            return item;
        }

        /// <summary>
        /// Выводит значение типа Char.
        /// </summary>
        /// <param name="item">Char.</param>
        /// <returns>Значение.</returns>
        public static char Print(this char item)
        {
            Console.Write(item.ToString());
            return item;
        }

        /// <summary>
        /// Выводит значение типа Char и переходит на новую строку.
        /// </summary>
        /// <param name="item">Char.</param>
        /// <returns>Значение.</returns>
        public static char Println(this char item)
        {
            Console.WriteLine(item.ToString());
            return item;
        }

        /// <summary>
        /// Выводит значение типа Double.
        /// </summary>
        /// <param name="item">Double.</param>
        /// <returns>Значение.</returns>
        public static double Print(this double item)
        {
            Console.Write(item.ToString());
            return item;
        }

        /// <summary>
        /// Выводит значение типа Double и переходит на новую строку.
        /// </summary>
        /// <param name="item">Double.</param>
        /// <returns>Значение.</returns>
        public static double Println(this double item)
        {
            Console.WriteLine(item.ToString());
            return item;
        }

        /// <summary>
        /// Выводит значение типа Int32.
        /// </summary>
        /// <param name="item">Int32.</param>
        /// <returns>Значение.</returns>
        public static int Print(this int item)
        {
            Console.Write(item.ToString());
            return item;
        }

        /// <summary>
        /// Выводит значение типа Int32 и переходит на новую строку.
        /// </summary>
        /// <param name="item">Int32.</param>
        /// <returns>Значение.</returns>
        public static int Println(this int item)
        {
            Console.WriteLine(item.ToString());
            return item;
        }

        /// <summary>
        /// Выводит значение типа Boolean?.
        /// </summary>
        /// <param name="item">Boolean.</param>
        /// <returns>Значение.</returns>
        public static bool? Print(this bool? item)
        {
            Console.Write(item.NilOrString());
            return item;
        }

        /// <summary>
        /// Выводит значение типа Boolean? и переходит на новую строку.
        /// </summary>
        /// <param name="item">Boolean.</param>
        /// <returns>Значение.</returns>
        public static bool? Println(this bool? item)
        {
            Console.WriteLine(item.NilOrString());
            return item;
        }

        /// <summary>
        /// Выводит значение типа Char?.
        /// </summary>
        /// <param name="item">Char.</param>
        /// <returns>Значение.</returns>
        public static char? Print(this char? item)
        {
            Console.Write(item.NilOrString());
            return item;
        }

        /// <summary>
        /// Выводит значение типа Char? и переходит на новую строку.
        /// </summary>
        /// <param name="item">Char.</param>
        /// <returns>Значение.</returns>
        public static char? Println(this char? item)
        {
            Console.WriteLine(item.NilOrString());
            return item;
        }

        /// <summary>
        /// Выводит значение типа Double?.
        /// </summary>
        /// <param name="item">Double.</param>
        /// <returns>Значение.</returns>
        public static double? Print(this double? item)
        {
            Console.Write(item.NilOrString());
            return item;
        }

        /// <summary>
        /// Выводит значение типа Double? и переходит на новую строку.
        /// </summary>
        /// <param name="item">Double.</param>
        /// <returns>Значение.</returns>
        public static double? Println(this double? item)
        {
            Console.WriteLine(item.NilOrString());
            return item;
        }

        /// <summary>
        /// Выводит значение типа Int32?.
        /// </summary>
        /// <param name="item">Int32.</param>
        /// <returns>Значение.</returns>
        public static int? Print(this int? item)
        {
            Console.Write(item.NilOrString());
            return item;
        }

        /// <summary>
        /// Выводит значение типа Int32? и переходит на новую строку.
        /// </summary>
        /// <param name="item">Int32.</param>
        /// <returns>Значение.</returns>
        public static int? Println(this int? item)
        {
            Console.WriteLine(item.NilOrString());
            return item;
        }
    }
}