using System;
using System.Collections.Generic;

namespace NETMouse.Extensions
{
    /// <summary>
    /// ������������� ���������� ��� ������ � KeyValuePair.
    /// </summary>
    public static class KVExt
    {
        /// <summary>
        /// ����������� KeyValuePair � ������.
        /// </summary>
        /// <param name="pair">KeyValuePair.</param>
        /// <returns>������.</returns>
        public static Tuple<T, T1> ToTup<T, T1>(this KeyValuePair<T, T1> pair)
        {
            return new Tuple<T, T1>(pair.Key, pair.Value);
        }

        /// <summary>
        /// ������� �������� ���� KeyValuePair.
        /// </summary>
        /// <param name="pair">KeyValuePair.</param>
        /// <returns>��������.</returns>
        public static KeyValuePair<T, T1> Print<T, T1>(this KeyValuePair<T, T1> pair)
        {
            Console.Write(pair);
            return pair;
        }

        /// <summary>
        /// ������� �������� ���� KeyValuePair � ��������� �� ����� ������.
        /// </summary>
        /// <param name="pair">KeyValuePair.</param>
        /// <returns>��������.</returns>
        public static KeyValuePair<T, T1> Println<T, T1>(this KeyValuePair<T, T1> pair)
        {
            Console.WriteLine(pair);
            return pair;
        }
    }
}