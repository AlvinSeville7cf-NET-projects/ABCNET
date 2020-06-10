using System;
using System.Numerics;

namespace ABCNET.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы с матрицами.
    /// </summary>
    public static partial class MatrixU
    {

        #region public
        
        #region Read1

        /// <summary>
        /// Читает матрицу значений типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Матрица.</returns>
        public static bool[,] ReadBoolean(int rowsCount, int colsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));
            
            prompt = prompt ?? EmptyStringHelper.Empty;

            bool[,] source = new bool[rowsCount, colsCount];
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    source[i, j] = BaseU.ReadBoolean(string.Format(prompt, i, j));
                }
            }

            return source;
        }
 
        /// <summary>
        /// Читает матрицу значений типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Матрица.</returns>
        public static byte[,] ReadByte(int rowsCount, int colsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));
            
            prompt = prompt ?? EmptyStringHelper.Empty;

            byte[,] source = new byte[rowsCount, colsCount];
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    source[i, j] = BaseU.ReadByte(string.Format(prompt, i, j));
                }
            }

            return source;
        }
 
        /// <summary>
        /// Читает матрицу значений типа SByte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Матрица.</returns>
        public static sbyte[,] ReadSByte(int rowsCount, int colsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));
            
            prompt = prompt ?? EmptyStringHelper.Empty;

            sbyte[,] source = new sbyte[rowsCount, colsCount];
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    source[i, j] = BaseU.ReadSByte(string.Format(prompt, i, j));
                }
            }

            return source;
        }
 
        /// <summary>
        /// Читает матрицу значений типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Матрица.</returns>
        public static char[,] ReadChar(int rowsCount, int colsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));
            
            prompt = prompt ?? EmptyStringHelper.Empty;

            char[,] source = new char[rowsCount, colsCount];
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    source[i, j] = BaseU.ReadChar(string.Format(prompt, i, j));
                }
            }

            return source;
        }
 
        /// <summary>
        /// Читает матрицу значений типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Матрица.</returns>
        public static decimal[,] ReadDecimal(int rowsCount, int colsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));
            
            prompt = prompt ?? EmptyStringHelper.Empty;

            decimal[,] source = new decimal[rowsCount, colsCount];
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    source[i, j] = BaseU.ReadDecimal(string.Format(prompt, i, j));
                }
            }

            return source;
        }
 
        /// <summary>
        /// Читает матрицу значений типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Матрица.</returns>
        public static double[,] ReadDouble(int rowsCount, int colsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));
            
            prompt = prompt ?? EmptyStringHelper.Empty;

            double[,] source = new double[rowsCount, colsCount];
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    source[i, j] = BaseU.ReadDouble(string.Format(prompt, i, j));
                }
            }

            return source;
        }
 
        /// <summary>
        /// Читает матрицу значений типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Матрица.</returns>
        public static float[,] ReadSingle(int rowsCount, int colsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));
            
            prompt = prompt ?? EmptyStringHelper.Empty;

            float[,] source = new float[rowsCount, colsCount];
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    source[i, j] = BaseU.ReadSingle(string.Format(prompt, i, j));
                }
            }

            return source;
        }
 
        /// <summary>
        /// Читает матрицу значений типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Матрица.</returns>
        public static int[,] ReadInt32(int rowsCount, int colsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));
            
            prompt = prompt ?? EmptyStringHelper.Empty;

            int[,] source = new int[rowsCount, colsCount];
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    source[i, j] = BaseU.ReadInt32(string.Format(prompt, i, j));
                }
            }

            return source;
        }
 
        /// <summary>
        /// Читает матрицу значений типа UInt32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Матрица.</returns>
        public static uint[,] ReadUInt32(int rowsCount, int colsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));
            
            prompt = prompt ?? EmptyStringHelper.Empty;

            uint[,] source = new uint[rowsCount, colsCount];
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    source[i, j] = BaseU.ReadUInt32(string.Format(prompt, i, j));
                }
            }

            return source;
        }
 
        /// <summary>
        /// Читает матрицу значений типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Матрица.</returns>
        public static long[,] ReadInt64(int rowsCount, int colsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));
            
            prompt = prompt ?? EmptyStringHelper.Empty;

            long[,] source = new long[rowsCount, colsCount];
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    source[i, j] = BaseU.ReadInt64(string.Format(prompt, i, j));
                }
            }

            return source;
        }
 
        /// <summary>
        /// Читает матрицу значений типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Матрица.</returns>
        public static ulong[,] ReadUInt64(int rowsCount, int colsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));
            
            prompt = prompt ?? EmptyStringHelper.Empty;

            ulong[,] source = new ulong[rowsCount, colsCount];
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    source[i, j] = BaseU.ReadUInt64(string.Format(prompt, i, j));
                }
            }

            return source;
        }
 
        /// <summary>
        /// Читает матрицу значений типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Матрица.</returns>
        public static short[,] ReadInt16(int rowsCount, int colsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));
            
            prompt = prompt ?? EmptyStringHelper.Empty;

            short[,] source = new short[rowsCount, colsCount];
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    source[i, j] = BaseU.ReadInt16(string.Format(prompt, i, j));
                }
            }

            return source;
        }
 
        /// <summary>
        /// Читает матрицу значений типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Матрица.</returns>
        public static ushort[,] ReadUInt16(int rowsCount, int colsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));
            
            prompt = prompt ?? EmptyStringHelper.Empty;

            ushort[,] source = new ushort[rowsCount, colsCount];
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    source[i, j] = BaseU.ReadUInt16(string.Format(prompt, i, j));
                }
            }

            return source;
        }
 
        /// <summary>
        /// Читает матрицу значений типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Матрица.</returns>
        public static BigInteger[,] ReadBigInteger(int rowsCount, int colsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));
            
            prompt = prompt ?? EmptyStringHelper.Empty;

            BigInteger[,] source = new BigInteger[rowsCount, colsCount];
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    source[i, j] = BaseU.ReadBigInteger(string.Format(prompt, i, j));
                }
            }

            return source;
        }
 
        /// <summary>
        /// Читает матрицу значений типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <param name="prompt">Приглашение к вводу.</param>
        /// <returns>Матрица.</returns>
        public static string[,] ReadString(int rowsCount, int colsCount, string prompt = EmptyStringHelper.Empty)
        {
            if (rowsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(rowsCount));
            if (colsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(colsCount));
            
            prompt = prompt ?? EmptyStringHelper.Empty;

            string[,] source = new string[rowsCount, colsCount];
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    source[i, j] = BaseU.ReadString(string.Format(prompt, i, j));
                }
            }

            return source;
        }
        
        #endregion
        
        #region Read2
        
        /// <summary>
        /// Читает 2 матрицы типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool[,], bool[,]> ReadBooleanTuple2(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 2 матрицы типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte[,], byte[,]> ReadByteTuple2(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadByte(rowsCount, colsCount), ReadByte(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 2 матрицы типа SByte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte[,], sbyte[,]> ReadSByteTuple2(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadSByte(rowsCount, colsCount), ReadSByte(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 2 матрицы типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<char[,], char[,]> ReadCharTuple2(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 2 матрицы типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal[,], decimal[,]> ReadDecimalTuple2(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadDecimal(rowsCount, colsCount), ReadDecimal(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 2 матрицы типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double[,], double[,]> ReadDoubleTuple2(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 2 матрицы типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<float[,], float[,]> ReadSingleTuple2(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadSingle(rowsCount, colsCount), ReadSingle(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 2 матрицы типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[,], int[,]> ReadInt32Tuple2(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 2 матрицы типа UInt32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint[,], uint[,]> ReadUInt32Tuple2(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadUInt32(rowsCount, colsCount), ReadUInt32(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 2 матрицы типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<long[,], long[,]> ReadInt64Tuple2(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadInt64(rowsCount, colsCount), ReadInt64(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 2 матрицы типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong[,], ulong[,]> ReadUInt64Tuple2(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadUInt64(rowsCount, colsCount), ReadUInt64(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 2 матрицы типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<short[,], short[,]> ReadInt16Tuple2(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadInt16(rowsCount, colsCount), ReadInt16(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 2 матрицы типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort[,], ushort[,]> ReadUInt16Tuple2(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadUInt16(rowsCount, colsCount), ReadUInt16(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 2 матрицы типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger[,], BigInteger[,]> ReadBigIntegerTuple2(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadBigInteger(rowsCount, colsCount), ReadBigInteger(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 2 матрицы типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<string[,], string[,]> ReadStringTuple2(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount));
        }
        
        #endregion
        
        #region Read3
        
        /// <summary>
        /// Читает 3 матрицы типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool[,], bool[,], bool[,]> ReadBooleanTuple3(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 3 матрицы типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte[,], byte[,], byte[,]> ReadByteTuple3(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadByte(rowsCount, colsCount), ReadByte(rowsCount, colsCount), ReadByte(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 3 матрицы типа SByte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte[,], sbyte[,], sbyte[,]> ReadSByteTuple3(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadSByte(rowsCount, colsCount), ReadSByte(rowsCount, colsCount), ReadSByte(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 3 матрицы типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<char[,], char[,], char[,]> ReadCharTuple3(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 3 матрицы типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal[,], decimal[,], decimal[,]> ReadDecimalTuple3(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadDecimal(rowsCount, colsCount), ReadDecimal(rowsCount, colsCount), ReadDecimal(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 3 матрицы типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double[,], double[,], double[,]> ReadDoubleTuple3(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 3 матрицы типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<float[,], float[,], float[,]> ReadSingleTuple3(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadSingle(rowsCount, colsCount), ReadSingle(rowsCount, colsCount), ReadSingle(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 3 матрицы типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[,], int[,], int[,]> ReadInt32Tuple3(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 3 матрицы типа UInt32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint[,], uint[,], uint[,]> ReadUInt32Tuple3(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadUInt32(rowsCount, colsCount), ReadUInt32(rowsCount, colsCount), ReadUInt32(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 3 матрицы типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<long[,], long[,], long[,]> ReadInt64Tuple3(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadInt64(rowsCount, colsCount), ReadInt64(rowsCount, colsCount), ReadInt64(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 3 матрицы типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong[,], ulong[,], ulong[,]> ReadUInt64Tuple3(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadUInt64(rowsCount, colsCount), ReadUInt64(rowsCount, colsCount), ReadUInt64(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 3 матрицы типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<short[,], short[,], short[,]> ReadInt16Tuple3(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadInt16(rowsCount, colsCount), ReadInt16(rowsCount, colsCount), ReadInt16(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 3 матрицы типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort[,], ushort[,], ushort[,]> ReadUInt16Tuple3(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadUInt16(rowsCount, colsCount), ReadUInt16(rowsCount, colsCount), ReadUInt16(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 3 матрицы типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger[,], BigInteger[,], BigInteger[,]> ReadBigIntegerTuple3(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadBigInteger(rowsCount, colsCount), ReadBigInteger(rowsCount, colsCount), ReadBigInteger(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 3 матрицы типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<string[,], string[,], string[,]> ReadStringTuple3(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount));
        }
        
        #endregion
        
        #region Read4
        
        /// <summary>
        /// Читает 4 матрицы типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool[,], bool[,], bool[,], bool[,]> ReadBooleanTuple4(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 4 матрицы типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte[,], byte[,], byte[,], byte[,]> ReadByteTuple4(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadByte(rowsCount, colsCount), ReadByte(rowsCount, colsCount), ReadByte(rowsCount, colsCount), ReadByte(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 4 матрицы типа SByte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte[,], sbyte[,], sbyte[,], sbyte[,]> ReadSByteTuple4(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadSByte(rowsCount, colsCount), ReadSByte(rowsCount, colsCount), ReadSByte(rowsCount, colsCount), ReadSByte(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 4 матрицы типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<char[,], char[,], char[,], char[,]> ReadCharTuple4(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 4 матрицы типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal[,], decimal[,], decimal[,], decimal[,]> ReadDecimalTuple4(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadDecimal(rowsCount, colsCount), ReadDecimal(rowsCount, colsCount), ReadDecimal(rowsCount, colsCount), ReadDecimal(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 4 матрицы типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double[,], double[,], double[,], double[,]> ReadDoubleTuple4(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 4 матрицы типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<float[,], float[,], float[,], float[,]> ReadSingleTuple4(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadSingle(rowsCount, colsCount), ReadSingle(rowsCount, colsCount), ReadSingle(rowsCount, colsCount), ReadSingle(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 4 матрицы типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[,], int[,], int[,], int[,]> ReadInt32Tuple4(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 4 матрицы типа UInt32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint[,], uint[,], uint[,], uint[,]> ReadUInt32Tuple4(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadUInt32(rowsCount, colsCount), ReadUInt32(rowsCount, colsCount), ReadUInt32(rowsCount, colsCount), ReadUInt32(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 4 матрицы типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<long[,], long[,], long[,], long[,]> ReadInt64Tuple4(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadInt64(rowsCount, colsCount), ReadInt64(rowsCount, colsCount), ReadInt64(rowsCount, colsCount), ReadInt64(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 4 матрицы типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong[,], ulong[,], ulong[,], ulong[,]> ReadUInt64Tuple4(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadUInt64(rowsCount, colsCount), ReadUInt64(rowsCount, colsCount), ReadUInt64(rowsCount, colsCount), ReadUInt64(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 4 матрицы типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<short[,], short[,], short[,], short[,]> ReadInt16Tuple4(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadInt16(rowsCount, colsCount), ReadInt16(rowsCount, colsCount), ReadInt16(rowsCount, colsCount), ReadInt16(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 4 матрицы типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort[,], ushort[,], ushort[,], ushort[,]> ReadUInt16Tuple4(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadUInt16(rowsCount, colsCount), ReadUInt16(rowsCount, colsCount), ReadUInt16(rowsCount, colsCount), ReadUInt16(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 4 матрицы типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger[,], BigInteger[,], BigInteger[,], BigInteger[,]> ReadBigIntegerTuple4(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadBigInteger(rowsCount, colsCount), ReadBigInteger(rowsCount, colsCount), ReadBigInteger(rowsCount, colsCount), ReadBigInteger(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 4 матрицы типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<string[,], string[,], string[,], string[,]> ReadStringTuple4(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount));
        }
        
        #endregion
        
        #region Read5
        
        /// <summary>
        /// Читает 5 матриц типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool[,], bool[,], bool[,], bool[,], bool[,]> ReadBooleanTuple5(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 5 матриц типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte[,], byte[,], byte[,], byte[,], byte[,]> ReadByteTuple5(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadByte(rowsCount, colsCount), ReadByte(rowsCount, colsCount), ReadByte(rowsCount, colsCount), ReadByte(rowsCount, colsCount), ReadByte(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 5 матриц типа SByte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte[,], sbyte[,], sbyte[,], sbyte[,], sbyte[,]> ReadSByteTuple5(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadSByte(rowsCount, colsCount), ReadSByte(rowsCount, colsCount), ReadSByte(rowsCount, colsCount), ReadSByte(rowsCount, colsCount), ReadSByte(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 5 матриц типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<char[,], char[,], char[,], char[,], char[,]> ReadCharTuple5(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 5 матриц типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal[,], decimal[,], decimal[,], decimal[,], decimal[,]> ReadDecimalTuple5(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadDecimal(rowsCount, colsCount), ReadDecimal(rowsCount, colsCount), ReadDecimal(rowsCount, colsCount), ReadDecimal(rowsCount, colsCount), ReadDecimal(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 5 матриц типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double[,], double[,], double[,], double[,], double[,]> ReadDoubleTuple5(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 5 матриц типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<float[,], float[,], float[,], float[,], float[,]> ReadSingleTuple5(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadSingle(rowsCount, colsCount), ReadSingle(rowsCount, colsCount), ReadSingle(rowsCount, colsCount), ReadSingle(rowsCount, colsCount), ReadSingle(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 5 матриц типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[,], int[,], int[,], int[,], int[,]> ReadInt32Tuple5(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 5 матриц типа UInt32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint[,], uint[,], uint[,], uint[,], uint[,]> ReadUInt32Tuple5(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadUInt32(rowsCount, colsCount), ReadUInt32(rowsCount, colsCount), ReadUInt32(rowsCount, colsCount), ReadUInt32(rowsCount, colsCount), ReadUInt32(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 5 матриц типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<long[,], long[,], long[,], long[,], long[,]> ReadInt64Tuple5(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadInt64(rowsCount, colsCount), ReadInt64(rowsCount, colsCount), ReadInt64(rowsCount, colsCount), ReadInt64(rowsCount, colsCount), ReadInt64(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 5 матриц типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong[,], ulong[,], ulong[,], ulong[,], ulong[,]> ReadUInt64Tuple5(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadUInt64(rowsCount, colsCount), ReadUInt64(rowsCount, colsCount), ReadUInt64(rowsCount, colsCount), ReadUInt64(rowsCount, colsCount), ReadUInt64(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 5 матриц типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<short[,], short[,], short[,], short[,], short[,]> ReadInt16Tuple5(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadInt16(rowsCount, colsCount), ReadInt16(rowsCount, colsCount), ReadInt16(rowsCount, colsCount), ReadInt16(rowsCount, colsCount), ReadInt16(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 5 матриц типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort[,], ushort[,], ushort[,], ushort[,], ushort[,]> ReadUInt16Tuple5(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadUInt16(rowsCount, colsCount), ReadUInt16(rowsCount, colsCount), ReadUInt16(rowsCount, colsCount), ReadUInt16(rowsCount, colsCount), ReadUInt16(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 5 матриц типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger[,], BigInteger[,], BigInteger[,], BigInteger[,], BigInteger[,]> ReadBigIntegerTuple5(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadBigInteger(rowsCount, colsCount), ReadBigInteger(rowsCount, colsCount), ReadBigInteger(rowsCount, colsCount), ReadBigInteger(rowsCount, colsCount), ReadBigInteger(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 5 матриц типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<string[,], string[,], string[,], string[,], string[,]> ReadStringTuple5(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount));
        }
        
        #endregion
        
        #region Read6
        
        /// <summary>
        /// Читает 6 матриц типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool[,], bool[,], bool[,], bool[,], bool[,], bool[,]> ReadBooleanTuple6(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 6 матриц типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte[,], byte[,], byte[,], byte[,], byte[,], byte[,]> ReadByteTuple6(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadByte(rowsCount, colsCount), ReadByte(rowsCount, colsCount), ReadByte(rowsCount, colsCount), ReadByte(rowsCount, colsCount), ReadByte(rowsCount, colsCount), ReadByte(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 6 матриц типа SByte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte[,], sbyte[,], sbyte[,], sbyte[,], sbyte[,], sbyte[,]> ReadSByteTuple6(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadSByte(rowsCount, colsCount), ReadSByte(rowsCount, colsCount), ReadSByte(rowsCount, colsCount), ReadSByte(rowsCount, colsCount), ReadSByte(rowsCount, colsCount), ReadSByte(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 6 матриц типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<char[,], char[,], char[,], char[,], char[,], char[,]> ReadCharTuple6(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 6 матриц типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal[,], decimal[,], decimal[,], decimal[,], decimal[,], decimal[,]> ReadDecimalTuple6(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadDecimal(rowsCount, colsCount), ReadDecimal(rowsCount, colsCount), ReadDecimal(rowsCount, colsCount), ReadDecimal(rowsCount, colsCount), ReadDecimal(rowsCount, colsCount), ReadDecimal(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 6 матриц типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double[,], double[,], double[,], double[,], double[,], double[,]> ReadDoubleTuple6(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 6 матриц типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<float[,], float[,], float[,], float[,], float[,], float[,]> ReadSingleTuple6(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadSingle(rowsCount, colsCount), ReadSingle(rowsCount, colsCount), ReadSingle(rowsCount, colsCount), ReadSingle(rowsCount, colsCount), ReadSingle(rowsCount, colsCount), ReadSingle(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 6 матриц типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[,], int[,], int[,], int[,], int[,], int[,]> ReadInt32Tuple6(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 6 матриц типа UInt32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint[,], uint[,], uint[,], uint[,], uint[,], uint[,]> ReadUInt32Tuple6(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadUInt32(rowsCount, colsCount), ReadUInt32(rowsCount, colsCount), ReadUInt32(rowsCount, colsCount), ReadUInt32(rowsCount, colsCount), ReadUInt32(rowsCount, colsCount), ReadUInt32(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 6 матриц типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<long[,], long[,], long[,], long[,], long[,], long[,]> ReadInt64Tuple6(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadInt64(rowsCount, colsCount), ReadInt64(rowsCount, colsCount), ReadInt64(rowsCount, colsCount), ReadInt64(rowsCount, colsCount), ReadInt64(rowsCount, colsCount), ReadInt64(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 6 матриц типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong[,], ulong[,], ulong[,], ulong[,], ulong[,], ulong[,]> ReadUInt64Tuple6(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadUInt64(rowsCount, colsCount), ReadUInt64(rowsCount, colsCount), ReadUInt64(rowsCount, colsCount), ReadUInt64(rowsCount, colsCount), ReadUInt64(rowsCount, colsCount), ReadUInt64(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 6 матриц типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<short[,], short[,], short[,], short[,], short[,], short[,]> ReadInt16Tuple6(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadInt16(rowsCount, colsCount), ReadInt16(rowsCount, colsCount), ReadInt16(rowsCount, colsCount), ReadInt16(rowsCount, colsCount), ReadInt16(rowsCount, colsCount), ReadInt16(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 6 матриц типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort[,], ushort[,], ushort[,], ushort[,], ushort[,], ushort[,]> ReadUInt16Tuple6(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadUInt16(rowsCount, colsCount), ReadUInt16(rowsCount, colsCount), ReadUInt16(rowsCount, colsCount), ReadUInt16(rowsCount, colsCount), ReadUInt16(rowsCount, colsCount), ReadUInt16(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 6 матриц типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger[,], BigInteger[,], BigInteger[,], BigInteger[,], BigInteger[,], BigInteger[,]> ReadBigIntegerTuple6(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadBigInteger(rowsCount, colsCount), ReadBigInteger(rowsCount, colsCount), ReadBigInteger(rowsCount, colsCount), ReadBigInteger(rowsCount, colsCount), ReadBigInteger(rowsCount, colsCount), ReadBigInteger(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 6 матриц типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<string[,], string[,], string[,], string[,], string[,], string[,]> ReadStringTuple6(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount));
        }
        
        #endregion
        
        #region Read7
        
        /// <summary>
        /// Читает 7 матриц типа Boolean. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<bool[,], bool[,], bool[,], bool[,], bool[,], bool[,], bool[,]> ReadBooleanTuple7(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount), ReadBoolean(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 7 матриц типа Byte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<byte[,], byte[,], byte[,], byte[,], byte[,], byte[,], byte[,]> ReadByteTuple7(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadByte(rowsCount, colsCount), ReadByte(rowsCount, colsCount), ReadByte(rowsCount, colsCount), ReadByte(rowsCount, colsCount), ReadByte(rowsCount, colsCount), ReadByte(rowsCount, colsCount), ReadByte(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 7 матриц типа SByte. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<sbyte[,], sbyte[,], sbyte[,], sbyte[,], sbyte[,], sbyte[,], sbyte[,]> ReadSByteTuple7(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadSByte(rowsCount, colsCount), ReadSByte(rowsCount, colsCount), ReadSByte(rowsCount, colsCount), ReadSByte(rowsCount, colsCount), ReadSByte(rowsCount, colsCount), ReadSByte(rowsCount, colsCount), ReadSByte(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 7 матриц типа Char. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<char[,], char[,], char[,], char[,], char[,], char[,], char[,]> ReadCharTuple7(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount), ReadChar(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 7 матриц типа Decimal. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<decimal[,], decimal[,], decimal[,], decimal[,], decimal[,], decimal[,], decimal[,]> ReadDecimalTuple7(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadDecimal(rowsCount, colsCount), ReadDecimal(rowsCount, colsCount), ReadDecimal(rowsCount, colsCount), ReadDecimal(rowsCount, colsCount), ReadDecimal(rowsCount, colsCount), ReadDecimal(rowsCount, colsCount), ReadDecimal(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 7 матриц типа Double. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<double[,], double[,], double[,], double[,], double[,], double[,], double[,]> ReadDoubleTuple7(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount), ReadDouble(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 7 матриц типа Single. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<float[,], float[,], float[,], float[,], float[,], float[,], float[,]> ReadSingleTuple7(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadSingle(rowsCount, colsCount), ReadSingle(rowsCount, colsCount), ReadSingle(rowsCount, colsCount), ReadSingle(rowsCount, colsCount), ReadSingle(rowsCount, colsCount), ReadSingle(rowsCount, colsCount), ReadSingle(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 7 матриц типа Int32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<int[,], int[,], int[,], int[,], int[,], int[,], int[,]> ReadInt32Tuple7(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount), ReadInt32(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 7 матриц типа UInt32. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<uint[,], uint[,], uint[,], uint[,], uint[,], uint[,], uint[,]> ReadUInt32Tuple7(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadUInt32(rowsCount, colsCount), ReadUInt32(rowsCount, colsCount), ReadUInt32(rowsCount, colsCount), ReadUInt32(rowsCount, colsCount), ReadUInt32(rowsCount, colsCount), ReadUInt32(rowsCount, colsCount), ReadUInt32(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 7 матриц типа Int64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<long[,], long[,], long[,], long[,], long[,], long[,], long[,]> ReadInt64Tuple7(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadInt64(rowsCount, colsCount), ReadInt64(rowsCount, colsCount), ReadInt64(rowsCount, colsCount), ReadInt64(rowsCount, colsCount), ReadInt64(rowsCount, colsCount), ReadInt64(rowsCount, colsCount), ReadInt64(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 7 матриц типа UInt64. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ulong[,], ulong[,], ulong[,], ulong[,], ulong[,], ulong[,], ulong[,]> ReadUInt64Tuple7(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadUInt64(rowsCount, colsCount), ReadUInt64(rowsCount, colsCount), ReadUInt64(rowsCount, colsCount), ReadUInt64(rowsCount, colsCount), ReadUInt64(rowsCount, colsCount), ReadUInt64(rowsCount, colsCount), ReadUInt64(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 7 матриц типа Int16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<short[,], short[,], short[,], short[,], short[,], short[,], short[,]> ReadInt16Tuple7(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadInt16(rowsCount, colsCount), ReadInt16(rowsCount, colsCount), ReadInt16(rowsCount, colsCount), ReadInt16(rowsCount, colsCount), ReadInt16(rowsCount, colsCount), ReadInt16(rowsCount, colsCount), ReadInt16(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 7 матриц типа UInt16. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<ushort[,], ushort[,], ushort[,], ushort[,], ushort[,], ushort[,], ushort[,]> ReadUInt16Tuple7(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadUInt16(rowsCount, colsCount), ReadUInt16(rowsCount, colsCount), ReadUInt16(rowsCount, colsCount), ReadUInt16(rowsCount, colsCount), ReadUInt16(rowsCount, colsCount), ReadUInt16(rowsCount, colsCount), ReadUInt16(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 7 матриц типа BigInteger. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<BigInteger[,], BigInteger[,], BigInteger[,], BigInteger[,], BigInteger[,], BigInteger[,], BigInteger[,]> ReadBigIntegerTuple7(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadBigInteger(rowsCount, colsCount), ReadBigInteger(rowsCount, colsCount), ReadBigInteger(rowsCount, colsCount), ReadBigInteger(rowsCount, colsCount), ReadBigInteger(rowsCount, colsCount), ReadBigInteger(rowsCount, colsCount), ReadBigInteger(rowsCount, colsCount));
        }
 
        /// <summary>
        /// Читает 7 матриц типа String. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
        /// </summary>
        /// <param name="rowsCount">Количество строк.</param>
        /// <param name="colsCount">Количество столбцов.</param>
        /// <returns>Кортеж.</returns>
        public static Tuple<string[,], string[,], string[,], string[,], string[,], string[,], string[,]> ReadStringTuple7(int rowsCount, int colsCount)
        {
            return TupleU.Of(ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount), ReadString(rowsCount, colsCount));
        }
        
        #endregion
 
        #endregion public
    
    }
}
