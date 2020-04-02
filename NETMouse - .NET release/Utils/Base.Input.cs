using ABCNET.Extensions;
using System;
using System.Numerics;

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
        /// ������ �������� ���� Sbyte. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static sbyte ReadSbyte(string prompt = EmptyStringHelper.Empty)
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
            return char.Parse(Console.ReadLine());
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
        /// ������ �������� ���� Float. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static float ReadFloat(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return float.Parse(Console.ReadLine());
        }

        /// <summary>
        /// ������ �������� ���� Int. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static int ReadInt(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// ������ �������� ���� Uint. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static uint ReadUint(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return uint.Parse(Console.ReadLine());
        }

        /// <summary>
        /// ������ �������� ���� Long. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static long ReadLong(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return long.Parse(Console.ReadLine());
        }

        /// <summary>
        /// ������ �������� ���� Ulong. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static ulong ReadUlong(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return ulong.Parse(Console.ReadLine());
        }

        /// <summary>
        /// ������ �������� ���� Short. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static short ReadShort(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return short.Parse(Console.ReadLine());
        }

        /// <summary>
        /// ������ �������� ���� Ushort. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static ushort ReadUshort(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return ushort.Parse(Console.ReadLine());
        }

        /// <summary>
        /// ������ �������� ���� BigInteger. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static BigInteger ReadBigInteger(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            return BigInteger.Parse(Console.ReadLine());
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
        /// ���������� ��������� ����� [0;1). 
        /// </summary> 
        /// <returns>�����.</returns>
        public static double Random()
        {
            return RandomHelper.Random.NextDouble();
        }

        /// <summary> 
        /// ���������� ��������� ����� [0;1). 
        /// </summary> 
        /// <returns>�����.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Base.Random.")]
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
        public static int Random(int low, int high)
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
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Base.Random.")]
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
        public static double Random(double low, double high)
        {
            if (high < low)
                Swap(ref low, ref high);

            return low + Random() * (high - low);
        }

        /// <summary>
        /// ���������� ��������� ����� [low;high].
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>�����.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Base.Random.")]
        public static double Rand(double low, double high)
        {
            if (high < low)
                Swap(ref low, ref high);

            return low + Rand() * (high - low);
        }
        #endregion public
    }
}