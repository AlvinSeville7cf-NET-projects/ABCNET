using System;

namespace NETMouse.Extensions
{
    /// <summary>
    /// ������������� ���������� ��� ������ � ���������.
    /// </summary>
    public static class MatrExt
    {
        /// <summary>
        /// �������� ������� �������.
        /// </summary>
        /// <param name="matrix">�������.</param>
        /// <param name="index">������ �������.</param>
        /// <returns>�������.</returns>
        public static T[] Col<T>(this T[,] matrix, int index)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            return matrix.InternalGetColumn(index);
        }

        /// <summary>
        /// �������� ������� �������.
        /// </summary>
        /// <param name="matrix">�������.</param>
        /// <param name="index">������ �������.</param>
        /// <param name="selector">������� ��������.</param>
        /// <returns>�������.</returns>
        public static TOutput[] Col<T, TOutput>(this T[,] matrix, int index, Func<T, TOutput> selector)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            return matrix.InternalGetColumnSelected(index, selector);
        }

        /// <summary>
        /// �������� ������ �������.
        /// </summary>
        /// <param name="matrix">�������.</param>
        /// <param name="index">������ ������.</param>
        /// <returns>������.</returns>
        public static T[] Row<T>(this T[,] matrix, int index)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            return matrix.InternalGetRow(index);
        }

        /// <summary>
        /// �������� ������ �������.
        /// </summary>
        /// <param name="matrix">�������.</param>
        /// <param name="index">������ ������.</param>
        /// <param name="selector">������� ��������.</param>
        /// <returns>������.</returns>
        public static TOutput[] Row<T, TOutput>(this T[,] matrix, int index, Func<T, TOutput> selector)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            return matrix.InternalGetRowSelected(index, selector);
        }

        /// <summary>
        /// ������� ������� � ��������� �� ����� ������.
        /// </summary>
        /// <param name="matrix">�������.</param>
        /// <param name="delimiter">�����������.</param>
        /// <returns>�������.</returns>
        public static T[,] Print<T>(this T[,] matrix, string delimiter = DefaultDelimiterHelper.Delimiter)
        {
        	if (matrix == null)
        		throw new ArgumentNullException("matrix");
        	
        	return matrix.InternalPrintAsMatrix(delimiter);
        }

        /// <summary>
        /// ������� ������� � ��������� �� ����� ������.
        /// </summary>
        /// <param name="matrix">�������.</param>
        /// <param name="selector">������� ��������.</param>
        /// <param name="delimiter">�����������.</param>
        /// <returns>�������.</returns>
        public static T[,] PrintBy<T, TOutput>(this T[,] matrix, Func<T, TOutput> selector, string delimiter = DefaultDelimiterHelper.Delimiter)
        {
        	if (matrix == null)
        		throw new ArgumentNullException("matrix");
            if (selector == null)
                throw new ArgumentNullException("selector");
        	
        	return matrix.InternalPrintByAsMatrix(selector, delimiter);
        }
        
        private static T[] InternalGetColumn<T>(this T[,] matrix, int index)
        {
            int length = matrix.GetLength(0);
            if (!index.IsBetween(0, length - 1))
                throw new IndexOutOfRangeException("index");
            
            T[] column = new T[length];
            for (int i = 0; i < column.Length; i++)
                column[i] = matrix[i, index];

            return column;
        }
        
        private static TOutput[] InternalGetColumnSelected<T, TOutput>(this T[,] matrix, int index, Func<T, TOutput> selector)
        {
            if (selector == null)
                throw new ArgumentNullException("selector");

            int length = matrix.GetLength(0);
            if (!index.IsBetween(0, length - 1))
                throw new IndexOutOfRangeException("index");
            
            TOutput[] column = new TOutput[length];
            for (int i = 0; i < column.Length; i++)
                column[i] = selector(matrix[i, index]);

            return column;
        }
        
        private static T[] InternalGetRow<T>(this T[,] matrix, int index)
        {
            int length = matrix.GetLength(1);
            if (!index.IsBetween(0, length - 1))
                throw new IndexOutOfRangeException("index");
            
            T[] row = new T[length];
            for (int i = 0; i < row.Length; i++)
                row[i] = matrix[index, i];

            return row;
        }
        
        private static TOutput[] InternalGetRowSelected<T, TOutput>(this T[,] matrix, int index, Func<T, TOutput> selector)
        {
            if (selector == null)
                throw new ArgumentNullException("selector");

            int length = matrix.GetLength(1);
            if (!index.IsBetween(0, length - 1))
                throw new IndexOutOfRangeException("index");
            
            TOutput[] row = new TOutput[length];
            for (int i = 0; i < row.Length; i++)
                row[i] = selector(matrix[index, i]);

            return row;
        }
        
        private static T[,] InternalPrintAsMatrix<T>(this T[,] matrix, string delimiter = DefaultDelimiterHelper.Delimiter)
        {
        	int rowsCount = matrix.GetLength(0);
        	int columnsCount = matrix.GetLength(1);
        	int[] lengths = new int[columnsCount];
        	
			for (int j = 0; j < columnsCount; j++)
				for (int i = 0; i < rowsCount; i++)
				{
					int itemLength = matrix[i, j].ToString().Length;
					if (itemLength > lengths[j])
						lengths[j] = itemLength;
				}
			
			for (int i = 0; i < rowsCount; i++)
			{
				for (int j = 0; j < columnsCount; j++)
					Console.Write(string.Format("{0}{1}", matrix[i, j].ToString().PadLeft(lengths[j]), delimiter));
				Console.WriteLine();
			}
			
			return matrix;
        }
        
        private static T[,] InternalPrintByAsMatrix<T, TOutput>(this T[,] matrix, Func<T, TOutput> selector, string delimiter = DefaultDelimiterHelper.Delimiter)
        {
        	int rowsCount = matrix.GetLength(0);
        	int columnsCount = matrix.GetLength(1);
        	int[] lengths = new int[columnsCount];
        	
			for (int j = 0; j < columnsCount; j++)
				for (int i = 0; i < rowsCount; i++)
				{
					int itemLength = selector(matrix[i, j]).ToString().Length;
					if (itemLength > lengths[j])
						lengths[j] = itemLength;
				}
			
			for (int i = 0; i < rowsCount; i++)
			{
				for (int j = 0; j < columnsCount; j++)
					Console.Write(string.Format("{0}{1}", selector(matrix[i, j]).ToString().PadLeft(lengths[j]), delimiter));
				Console.WriteLine();
			}
			
			return matrix;
        }
    }
}