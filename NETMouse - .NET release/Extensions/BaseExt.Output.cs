using System;
using System.Collections.Generic;

namespace ABCNET.Extensions
{
    /// <summary>
    /// ������������� ���������� ��� ������ � �������� ������.
    /// </summary>
    public static partial class BaseExt
    {
        /// <summary>
        /// ������� �������� ���� Boolean.
        /// </summary>
        /// <param name="item">Boolean.</param>
        /// <returns>��������.</returns>
        public static bool Print(this bool item)
        {
            Console.Write(item.ToString());
            return item;
        }

        /// <summary>
        /// ������� �������� ���� Boolean � ��������� �� ����� ������.
        /// </summary>
        /// <param name="item">Boolean.</param>
        /// <returns>��������.</returns>
        public static bool Println(this bool item)
        {
            Console.WriteLine(item.ToString());
            return item;
        }

        /// <summary>
        /// ������� �������� ���� Char.
        /// </summary>
        /// <param name="item">Char.</param>
        /// <returns>��������.</returns>
        public static char Print(this char item)
        {
            Console.Write(item.ToString());
            return item;
        }

        /// <summary>
        /// ������� �������� ���� Char � ��������� �� ����� ������.
        /// </summary>
        /// <param name="item">Char.</param>
        /// <returns>��������.</returns>
        public static char Println(this char item)
        {
            Console.WriteLine(item.ToString());
            return item;
        }

        /// <summary>
        /// ������� �������� ���� Double.
        /// </summary>
        /// <param name="item">Double.</param>
        /// <returns>��������.</returns>
        public static double Print(this double item)
        {
            Console.Write(item.ToString());
            return item;
        }

        /// <summary>
        /// ������� �������� ���� Double � ��������� �� ����� ������.
        /// </summary>
        /// <param name="item">Double.</param>
        /// <returns>��������.</returns>
        public static double Println(this double item)
        {
            Console.WriteLine(item.ToString());
            return item;
        }

        /// <summary>
        /// ������� �������� ���� Int32.
        /// </summary>
        /// <param name="item">Int32.</param>
        /// <returns>��������.</returns>
        public static int Print(this int item)
        {
            Console.Write(item.ToString());
            return item;
        }

        /// <summary>
        /// ������� �������� ���� Int32 � ��������� �� ����� ������.
        /// </summary>
        /// <param name="item">Int32.</param>
        /// <returns>��������.</returns>
        public static int Println(this int item)
        {
            Console.WriteLine(item.ToString());
            return item;
        }

        /// <summary>
        /// ������� �������� ���� Boolean?.
        /// </summary>
        /// <param name="item">Boolean.</param>
        /// <returns>��������.</returns>
        public static bool? Print(this bool? item)
        {
            Console.Write(item.NilOrString());
            return item;
        }

        /// <summary>
        /// ������� �������� ���� Boolean? � ��������� �� ����� ������.
        /// </summary>
        /// <param name="item">Boolean.</param>
        /// <returns>��������.</returns>
        public static bool? Println(this bool? item)
        {
            Console.WriteLine(item.NilOrString());
            return item;
        }

        /// <summary>
        /// ������� �������� ���� Char?.
        /// </summary>
        /// <param name="item">Char.</param>
        /// <returns>��������.</returns>
        public static char? Print(this char? item)
        {
            Console.Write(item.NilOrString());
            return item;
        }

        /// <summary>
        /// ������� �������� ���� Char? � ��������� �� ����� ������.
        /// </summary>
        /// <param name="item">Char.</param>
        /// <returns>��������.</returns>
        public static char? Println(this char? item)
        {
            Console.WriteLine(item.NilOrString());
            return item;
        }

        /// <summary>
        /// ������� �������� ���� Double?.
        /// </summary>
        /// <param name="item">Double.</param>
        /// <returns>��������.</returns>
        public static double? Print(this double? item)
        {
            Console.Write(item.NilOrString());
            return item;
        }

        /// <summary>
        /// ������� �������� ���� Double? � ��������� �� ����� ������.
        /// </summary>
        /// <param name="item">Double.</param>
        /// <returns>��������.</returns>
        public static double? Println(this double? item)
        {
            Console.WriteLine(item.NilOrString());
            return item;
        }

        /// <summary>
        /// ������� �������� ���� Int32?.
        /// </summary>
        /// <param name="item">Int32.</param>
        /// <returns>��������.</returns>
        public static int? Print(this int? item)
        {
            Console.Write(item.NilOrString());
            return item;
        }

        /// <summary>
        /// ������� �������� ���� Int32? � ��������� �� ����� ������.
        /// </summary>
        /// <param name="item">Int32.</param>
        /// <returns>��������.</returns>
        public static int? Println(this int? item)
        {
            Console.WriteLine(item.NilOrString());
            return item;
        }
    }
}