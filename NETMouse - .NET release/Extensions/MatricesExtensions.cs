using System;

namespace NETMouse.Extensions
{
    /// <summary>
    /// Provides standart extensions for matrices.
    /// </summary>
    public static class MatricesExtensions
    {
        /// <summary>
        /// The default delimiter.
        /// </summary>
        public const string DefaultDelimiter = " ";
        
        /// <summary>
        /// Retrieves the particular column from the matrix.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <param name="index">The column index.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <returns>The column of the current matrix.</returns>
        public static T[] GetColumn<T>(this T[,] matrix, int index)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            return matrix.InternalGetColumn(index);
        }
        
        /// <summary>
        /// Retrieves the particular column from the matrix.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <param name="index">The column index.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <returns>The column of the current matrix or the empty collection if matrix is null.</returns>
        public static T[] GetColumnOrEmpty<T>(this T[,] matrix, int index)
        {
            if (matrix == null)
                return ArrayHelper<T>.Empty;
            
            return matrix.InternalGetColumn(index);
        }

        /// <summary>
        /// Retrieves the particular column from the matrix and applies map method to it.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <param name="index">The column index.</param>
        /// <param name="selector">The map method.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <typeparam name="TOutput">The output value type.</typeparam>
        /// <returns>The column of the current matrix.</returns>
        public static TOutput[] GetColumnSelected<T, TOutput>(this T[,] matrix, int index, Func<T, TOutput> selector)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            return matrix.InternalGetColumnSelected(index, selector);
        }

        /// <summary>
        /// Retrieves the particular column from the matrix and applies map method to it.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <param name="index">The column index.</param>
        /// <param name="selector">The map method.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <typeparam name="TOutput">The output value type.</typeparam>
        /// <returns>The column of the current matrix or the empty collection if matrix is null.</returns>
        public static TOutput[] GetColumnSelectedOrEmpty<T, TOutput>(this T[,] matrix, int index, Func<T, TOutput> selector)
        {
            if (matrix == null)
                return ArrayHelper<TOutput>.Empty;

            return matrix.InternalGetColumnSelected(index, selector);
        }
        
        /// <summary>
        /// Retrieves the particular row from the matrix.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <param name="index">The row index.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <returns>The row of the current matrix.</returns>
        public static T[] GetRow<T>(this T[,] matrix, int index)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            return matrix.InternalGetRow(index);
        }
        
        /// <summary>
        /// Retrieves the particular row from the matrix.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <param name="index">The row index.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <returns>The row of the current matrix or the empty collection if matrix is null.</returns>
        public static T[] GetRowOrEmpty<T>(this T[,] matrix, int index)
        {
            if (matrix == null)
                return ArrayHelper<T>.Empty;
            
            return matrix.InternalGetRow(index);
        }
        
        /// <summary>
        /// Retrieves the particular row from the matrix and applies map method to it.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <param name="index">The row index.</param>
        /// <param name="selector">The map method.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <typeparam name="TOutput">The output value type.</typeparam>
        /// <returns>The row of the current matrix.</returns>
        public static TOutput[] GetRowSelected<T, TOutput>(this T[,] matrix, int index, Func<T, TOutput> selector)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            return matrix.InternalGetRowSelected(index, selector);
        }

        /// <summary>
        /// Retrieves the particular row from the matrix and applies map method to it.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <param name="index">The row index.</param>
        /// <param name="selector">The map method.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <typeparam name="TOutput">The output value type.</typeparam>
        /// <returns>The row of the current matrix or the empty collection if matrix is null.</returns>
        public static TOutput[] GetRowSelectedOrEmpty<T, TOutput>(this T[,] matrix, int index, Func<T, TOutput> selector)
        {
            if (matrix == null)
                return ArrayHelper<TOutput>.Empty;

            return matrix.InternalGetRowSelected(index, selector);
        }

        /// <summary>
        /// Prints the matrix with the specified delimiter.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <param name="delimiter">The delimiter.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <returns>The matrix.</returns>
        public static T[,] PrintAsMatrix<T>(this T[,] matrix, string delimiter = DefaultDelimiter)
        {
        	if (matrix == null)
        		throw new ArgumentNullException("matrix");
        	
        	return matrix.InternalPrintAsMatrix(delimiter);
        }
        
        /// <summary>
        /// Prints the matrix with the specified delimiter.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <param name="selector">The map method.</param>
        /// <param name="delimiter">The delimiter.</param>
        /// <typeparam name="T">The value type.</typeparam>
        /// <returns>The matrix.</returns>
        public static T[,] PrintByAsMatrix<T, TOutput>(this T[,] matrix, Func<T, TOutput> selector, string delimiter = DefaultDelimiter)
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
        
        private static T[,] InternalPrintAsMatrix<T>(this T[,] matrix, string delimiter = DefaultDelimiter)
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
        
        private static T[,] InternalPrintByAsMatrix<T, TOutput>(this T[,] matrix, Func<T, TOutput> selector, string delimiter = DefaultDelimiter)
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