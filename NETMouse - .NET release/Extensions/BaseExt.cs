using System;
using System.Collections.Generic;

namespace ABCNET.Extensions
{
    /// <summary>
    /// ������������� ���������� ��� ������ � �������� ������.
    /// </summary>
    public static class BaseExt
    {
        /// <summary>
        /// ��������� ����� �� ����� ����� ������� �����.
        /// </summary>
        /// <param name="target">�����.</param>
        /// <param name="firstBorder">������ �������.</param>
        /// <param name="secondBorder">������ �������.</param>
        /// <returns>���������.</returns>
        public static bool IsBetween(this int target, int firstBorder, int secondBorder)
        {
            if (firstBorder > secondBorder)
                Utils.Base.Swap(ref firstBorder, ref secondBorder);
            return (target >= firstBorder) && (target <= secondBorder);
        }

        /// <summary>
        /// ������ ������������������ �� ���������� ����� �� ���������.
        /// </summary>
        /// <param name="from">��������� �����.</param>
        /// <param name="to">�������� �����.</param>
        /// <returns>������������������.</returns>
        public static IEnumerable<int> To(this int from, int to)
        {
            if (from >= to)
                for (int i = from; i >= to; i--)
                    yield return i;
            else
                for (int i = from; i <= to; i++)
                    yield return i;
        }

        /// <summary>
        /// ������ ������������������ �� 0 �� ��������� �����.
        /// </summary>
        /// <param name="to">�������� �����.</param>
        /// <returns>������������������.</returns>
        public static IEnumerable<int> Times(this int to)
        {
            if (to < 0)
                return 0.To(to);
            return 0.To(to);
        }

        /// <summary>
        /// ������ ����������� ������������������ �� ���������� �����.
        /// </summary>
        /// <param name="from">��������� �����.</param>
        /// <param name="step">���.</param>
        /// <returns>������������������.</returns>
        public static IEnumerable<int> Step(this int from, int step)
        {
            do
            {
                yield return from;
                from += step;
            } while (true);
        }

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