using ABCNET.Extensions;
using System;

namespace ABCNET.Utils
{
    /// <summary>
    /// ������������� ���������� ��� ������ � �������� ������.
    /// </summary>
    public static partial class Base
    {
        #region public
        /// <summary>
        /// ������ �������� ���� Boolean. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static bool ReadBoolean(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return bool.Parse(Console.ReadLine());
        }

        /// <summary>
        /// ������ �������� ���� Byte. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static byte ReadByte(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return byte.Parse(Console.ReadLine());
        }

        /// <summary>
        /// ������ �������� ���� SByte. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static sbyte ReadSByte(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return sbyte.Parse(Console.ReadLine());
        }

        /// <summary>
        /// ������ �������� ���� Char. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static char ReadChar(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return Console.ReadKey().KeyChar;
        }

        /// <summary>
        /// ������ �������� ���� Decimal. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static decimal ReadDecimal(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return decimal.Parse(Console.ReadLine());
        }

        /// <summary>
        /// ������ �������� ���� Double. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static double ReadDouble(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// ������ �������� ���� Single. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static float ReadSingle(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return float.Parse(Console.ReadLine());
        }

        /// <summary>
        /// ������ �������� ���� Int32. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static int ReadInt32(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// ������ �������� ���� UInt32. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static uint ReadUInt32(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return uint.Parse(Console.ReadLine());
        }

        /// <summary>
        /// ������ �������� ���� Int64. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static long ReadInt64(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return long.Parse(Console.ReadLine());
        }

        /// <summary>
        /// ������ �������� ���� UInt64. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static ulong ReadUInt64(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return ulong.Parse(Console.ReadLine());
        }

        /// <summary>
        /// ������ �������� ���� Int16. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static short ReadInt16(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return short.Parse(Console.ReadLine());
        }

        /// <summary>
        /// ������ �������� ���� UInt16. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static ushort ReadUInt16(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return ushort.Parse(Console.ReadLine());
        }

        /// <summary>
        /// ������ �������� ���� String. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static string ReadString(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return Console.ReadLine();
        }

        /// <summary> 
        /// ���������� ��������� ����� [0..1). 
        /// </summary> 
        /// <returns>�����.</returns> 
        public static double Rand()
        {
            return RandomHelper.Random.NextDouble();
        }

        /// <summary>
        /// ���������� ��������� ����� [low;high].
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>�����.</returns>
        public static int Rand(int low, int high)
        {
            if (high < low)
                Swap(ref low, ref high);

            return RandomHelper.Random.Next(low, high + 1);
        }

        /// <summary>
        /// ���������� ��������� ����� [low;high].
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>�����.</returns>
        public static double Rand(double low, double high)
        {
            if (high < low)
                Swap(ref low, ref high);

            return low + Rand() * (high - low);
        }
        #endregion public
    }
}