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
            bool result;
            while (!bool.TryParse(Console.ReadLine(), out result))
            {
                InputErrorHelper.Message.PrintLine();
                prompt.Print();
            }
            return result;
        }

        /// <summary>
        /// ������ �������� ���� Byte. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static byte ReadByte(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            byte result;
            while (!byte.TryParse(Console.ReadLine(), out result))
            {
                InputErrorHelper.Message.PrintLine();
                prompt.Print();
            }
            return result;
        }

        /// <summary>
        /// ������ �������� ���� SByte. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static sbyte ReadSByte(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            sbyte result;
            while (!sbyte.TryParse(Console.ReadLine(), out result))
            {
                InputErrorHelper.Message.PrintLine();
                prompt.Print();
            }
            return result;
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
            decimal result;
            while (!decimal.TryParse(Console.ReadLine(), out result))
            {
                InputErrorHelper.Message.PrintLine();
                prompt.Print();
            }
            return result;
        }

        /// <summary>
        /// ������ �������� ���� Double. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static double ReadDouble(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            double result;
            while (!double.TryParse(Console.ReadLine(), out result))
            {
                InputErrorHelper.Message.PrintLine();
                prompt.Print();
            }
            return result;
        }

        /// <summary>
        /// ������ �������� ���� Single. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static float ReadSingle(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            float result;
            while (!float.TryParse(Console.ReadLine(), out result))
            {
                InputErrorHelper.Message.PrintLine();
                prompt.Print();
            }
            return result;
        }

        /// <summary>
        /// ������ �������� ���� Int32. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static int ReadInt32(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                InputErrorHelper.Message.PrintLine();
                prompt.Print();
            }
            return result;
        }

        /// <summary>
        /// ������ �������� ���� UInt32. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static uint ReadUInt32(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            uint result;
            while (!uint.TryParse(Console.ReadLine(), out result))
            {
                InputErrorHelper.Message.PrintLine();
                prompt.Print();
            }
            return result;
        }

        /// <summary>
        /// ������ �������� ���� Int64. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static long ReadInt64(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            long result;
            while (!long.TryParse(Console.ReadLine(), out result))
            {
                InputErrorHelper.Message.PrintLine();
                prompt.Print();
            }
            return result;
        }

        /// <summary>
        /// ������ �������� ���� UInt64. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static ulong ReadUInt64(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            ulong result;
            while (!ulong.TryParse(Console.ReadLine(), out result))
            {
                InputErrorHelper.Message.PrintLine();
                prompt.Print();
            }
            return result;
        }

        /// <summary>
        /// ������ �������� ���� Int16. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static short ReadInt16(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            short result;
            while (!short.TryParse(Console.ReadLine(), out result))
            {
                InputErrorHelper.Message.PrintLine();
                prompt.Print();
            }
            return result;
        }

        /// <summary>
        /// ������ �������� ���� UInt16. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static ushort ReadUInt16(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            ushort result;
            while (!ushort.TryParse(Console.ReadLine(), out result))
            {
                InputErrorHelper.Message.PrintLine();
                prompt.Print();
            }
            return result;
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
        /// ������ �������� ���� BigInteger. [�� �������� ��� ������� �� ��� �������� � IDE PascalABC.NET.]
        /// </summary>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>��������.</returns>
        public static BigInteger ReadBigInteger(string prompt = EmptyStringHelper.Empty)
        {
            prompt.Print();
            BigInteger result;
            while (!BigInteger.TryParse(Console.ReadLine(), out result))
            {
                InputErrorHelper.Message.PrintLine();
                prompt.Print();
            }
            return result;
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